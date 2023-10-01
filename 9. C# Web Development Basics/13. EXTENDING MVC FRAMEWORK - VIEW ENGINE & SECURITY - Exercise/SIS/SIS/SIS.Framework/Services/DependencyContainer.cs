using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace SIS.Framework.Services
{
    public class DependencyContainer : IDependencyContainer
    {
        private readonly IDictionary<Type, Type> dependencyDictionary;

        public DependencyContainer()
        {
            dependencyDictionary = new Dictionary<Type, Type>();
        }

        private Type this[Type key]
        {
            get
            {
                if (key == null)
                {
                    return null;
                }

                return dependencyDictionary.ContainsKey(key) ? dependencyDictionary[key] : null;
            }
        }

        public T CreateInstance<T>()
            => (T)CreateInstance(typeof(T));

        public object CreateInstance(Type type)
        {
            Type instanceType = this[type] ?? type;

            if (instanceType.IsInterface || instanceType.IsAbstract)
            {
                throw new InvalidOperationException($"Type {instanceType.FullName} cannot be instantiated.");
            }

            ConstructorInfo constructor = instanceType.GetConstructors().OrderBy(x => x.GetParameters().Length).First();
            ParameterInfo[] constructorParameters = constructor.GetParameters();
            object[] constructorParametersObjects = new object[constructorParameters.Length];

            for (int i = 0; i < constructorParameters.Length; i++)
            {
                constructorParametersObjects[i] = CreateInstance(constructorParameters[i].ParameterType);
            }

            return constructor.Invoke(constructorParametersObjects);
        }

        public void RegisterDependency<TSource, TDestination>()
        {
            dependencyDictionary[typeof(TSource)] = typeof(TDestination);
        }
    }
}
