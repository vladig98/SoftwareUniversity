﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;

namespace MinionORM
{
    public abstract class DbContext
    {
        private readonly DatabaseConnection connection;
        private readonly Dictionary<Type, PropertyInfo> dbSetProperties;

        internal static readonly Type[] AllowedSqlTypes =
        {
            typeof(string),
            typeof(DateTime),
            typeof(int),
            typeof(uint),
            typeof(long), 
            typeof(ulong),
            typeof(decimal),
            typeof(bool)
        };

        protected DbContext(string connectionString)
        {
            connection = new DatabaseConnection(connectionString);
            dbSetProperties = DiscoverDbSets();

            using (new ConnectionManager(connection))
            {
                InitializeDbSets();
            }

            MapAllRelations();
        }

        public void SaveChanges()
        {
            var dbSets = dbSetProperties.Select(x => x.Value.GetValue(this)).ToArray();

            foreach (IEnumerable<object> dbSet in dbSets)
            {
                var invalidEntities = dbSet.Where(x => !IsObjectValid(x)).ToArray();

                if (invalidEntities.Any())
                {
                    throw new InvalidOperationException($"{invalidEntities.Length} Invalid Entities found in {dbSet.GetType().Name}!");
                }
            }

            using (new ConnectionManager(connection))
            {
                using (var transaction = connection.StartTransaction())
                {
                    foreach (IEnumerable<object> dbSet in dbSets)
                    {
                        var dbSetType = dbSet.GetType().GetGenericArguments().First();

                        var persistMethod = typeof(DbContext).GetMethod("Persist", BindingFlags.Instance | BindingFlags.NonPublic)
                            .MakeGenericMethod(dbSetType);

                        try
                        {
                            persistMethod.Invoke(this, new object[] { dbSet });
                        }
                        catch (TargetInvocationException tie)
                        {
                            throw tie.InnerException;
                        }
                        catch (InvalidOperationException) 
                        {
                            transaction.Rollback();
                            throw;
                        }
                        catch (SqlException)
                        {
                            transaction.Rollback();
                            throw;
                        }
                    }

                    transaction.Commit();
                }
            }
        }

        private void Persist<TEntity>(DbSet<TEntity> dbSet) where TEntity : class, new()
        {
            var tableName = GetTableName(typeof(TEntity));
            var columns = connection.FetchColumnNames(tableName).ToArray();

            if (dbSet.ChangeTracker.Added.Any())
            {
                connection.InsertEntities(dbSet.ChangeTracker.Added, tableName, columns);
            }

            var modifiedEntities = dbSet.ChangeTracker.GetModifiedEntities(dbSet).ToArray();

            if (modifiedEntities.Any())
            {
                connection.UpdateEntities(modifiedEntities, tableName, columns);
            }

            if (dbSet.ChangeTracker.Removed.Any())
            {
                connection.DeleteEntities(dbSet.ChangeTracker.Removed, tableName, columns);
            }
        }

        private void InitializeDbSets()
        {
            foreach (var dbSet in dbSetProperties)
            {
                var dbSetType = dbSet.Key;
                var dbSetProperty = dbSet.Value;

                var populateDbSetGeneric = typeof(DbContext).GetMethod("PopulateDbSet", BindingFlags.Instance | BindingFlags.NonPublic)
                    .MakeGenericMethod(dbSetType);

                populateDbSetGeneric.Invoke(this, new object[] { dbSetProperty });
            }
        }

        private void PopulateDbSet<TEntity>(PropertyInfo dbSet) where TEntity : class, new() 
        {
            var entities = LoadTableEntities<TEntity>();

            var dbSetInstance = new DbSet<TEntity>(entities);

            ReflectionHelper.ReplaceBackingField(this, dbSet.Name, dbSetInstance);
        }

        private void MapAllRelations()
        {
            foreach (var dbSetProperty in dbSetProperties)
            {
                var dbSetType = dbSetProperty.Key;

                var mapRelationsGeneric = typeof(DbContext).GetMethod("MapRelations", BindingFlags.Instance | BindingFlags.NonPublic)
                    .MakeGenericMethod(dbSetType);

                var dbSet = dbSetProperty.Value.GetValue(this);

                mapRelationsGeneric.Invoke(this, new object[] { dbSet });
            }
        }

        private void MapRelations<TEntity>(DbSet<TEntity> dbSet) where TEntity : class, new()
        {
            var entityType = typeof(TEntity);

            MapNavigationProperties(dbSet);

            var collections = entityType.GetProperties().Where(x => x.PropertyType.IsGenericType
            && x.PropertyType.GetGenericTypeDefinition() == typeof(ICollection<>)).ToArray();

            foreach (var collection in collections)
            {
                var collectionType = collection.PropertyType.GenericTypeArguments.First();

                var mapCollectionMethod = typeof(DbContext).GetMethod("MapCollection", BindingFlags.Instance | BindingFlags.NonPublic)
                    .MakeGenericMethod(entityType, collectionType);

                mapCollectionMethod.Invoke(this, new object[] { dbSet, collection });
            }
        }

        private void MapCollection<TDbSet, TCollection>(DbSet<TDbSet> dbSet, PropertyInfo collectionProperty) 
            where TDbSet : class, new() where TCollection : class, new()
        {
            var entityType = typeof(TDbSet);
            var collectionType = typeof(TCollection);

            var primaryKeys = collectionType.GetProperties().Where(x => x.HasAttribute<KeyAttribute>()).ToArray();
            var primaryKey = primaryKeys.First();

            var foreignKey = entityType.GetProperties().First(x => x.HasAttribute<KeyAttribute>());

            var isManyToMany = primaryKeys.Length >= 2;

            if (isManyToMany)
            {
                primaryKey = collectionType.GetProperties().First(x =>
                collectionType.GetProperty(x.GetCustomAttribute<ForeignKeyAttribute>().Name).PropertyType == entityType);
            }

            var navigationDbSet = (DbSet<TCollection>)dbSetProperties[collectionType].GetValue(this);

            foreach (var entity in dbSet)
            {
                var primaryKeyValue = foreignKey.GetValue(entity);

                var navigationEntities = navigationDbSet.Where(x => primaryKey.GetValue(x).Equals(primaryKeyValue)).ToArray();

                ReflectionHelper.ReplaceBackingField(entity, collectionProperty.Name, navigationEntities);
            }
        }

        private void MapNavigationProperties<TEntity>(DbSet<TEntity> dbSet) where TEntity : class, new()
        {
            var entityType = typeof(TEntity);

            var foreignKeys = entityType.GetProperties().Where(x => x.HasAttribute<ForeignKeyAttribute>()).ToArray();

            foreach (var foreignKey in foreignKeys)
            {
                var navigationPropertyName = foreignKey.GetCustomAttribute<ForeignKeyAttribute>().Name;
                var navigationProperty = entityType.GetProperty(navigationPropertyName);

                var navigationDbSet = dbSetProperties[navigationProperty.PropertyType].GetValue(this);

                var navigationPropertyKey = navigationProperty.PropertyType.GetProperties().First(x => x.HasAttribute<KeyAttribute>());

                foreach (var entity in dbSet)
                {
                    var foreignKeyValue = foreignKey.GetValue(entity);

                    var navigationPropertyValue = ((IEnumerable<object>)navigationDbSet)
                        .First(x => navigationPropertyKey.GetValue(x).Equals(foreignKeyValue));

                    navigationProperty.SetValue(entity, navigationPropertyValue);
                }
            }
        }

        private static bool IsObjectValid(object e)
        {
            var validationContext = new ValidationContext(e);
            var validationErrors = new List<ValidationResult>();

            var validationResult = Validator.TryValidateObject(e, validationContext, validationErrors, validateAllProperties: true);

            return validationResult;
        }

        private IEnumerable<TEntity> LoadTableEntities<TEntity>() where TEntity : class
        {
            var table = typeof(TEntity);
            var columns = GetEntityColumnNames(table);
            var tableName = GetTableName(table);
            var fetchedRows = connection.FetchResultSet<TEntity>(tableName, columns).ToArray();

            return fetchedRows;
        }

        private string GetTableName(Type tableType)
        {
            var tableName = ((TableAttribute)Attribute.GetCustomAttribute(tableType, typeof(TableAttribute)))?.Name;

            if (tableName == null)
            {
                tableName = dbSetProperties[tableType].Name;
            }

            return tableName;
        }

        private Dictionary<Type, PropertyInfo> DiscoverDbSets()
        {
            var dbSets = GetType().GetProperties().Where(x => x.PropertyType.GetGenericTypeDefinition() == typeof(DbSet<>))
                .ToDictionary(x => x.PropertyType.GetGenericArguments().First(), x => x);

            return dbSets;
        }

        private string[] GetEntityColumnNames(Type table)
        {
            var tableName = GetTableName(table);
            var dbColumns = connection.FetchColumnNames(tableName);

            var columns = table.GetProperties().Where(x => dbColumns.Contains(x.Name) && !x.HasAttribute<NotMappedAttribute>()
            && AllowedSqlTypes.Contains(x.PropertyType)).Select(x => x.Name).ToArray();

            return columns;
        }
    }
}
