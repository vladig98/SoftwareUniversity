using Microsoft.EntityFrameworkCore.Internal;
using ProductShop.Data;
using ProductShop.Models;
using ProductShop.Services.Contracts;
using ProductShop.Services.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace ProductShop.Services
{
    public class DatabaseDataSeeder : IDatabaseDataSeeder
    {
        private readonly ProductShopDbContext context;
        private string pathToResources = Directory.GetCurrentDirectory() + @"..\..\..\..\..\Resources\";

        public DatabaseDataSeeder(ProductShopDbContext context)
        {
            this.context = context;
        }

        public void Seed()
        {
            if (!context.Users.Any())
            {
                ImportUsers();
            }
            if (!context.Products.Any())
            {
                ImportProducts();
            }
            if (!context.Categories.Any())
            {
                InsertCategories();
            }
        }

        private void InsertCategories()
        {
            string categoriesXML = File.ReadAllText(pathToResources + "categories.xml");

            var serializer = new XmlSerializer(typeof(CategoryDto[]), new XmlRootAttribute("categories"));
            var deserializedCategories = (CategoryDto[])serializer.Deserialize(new StringReader(categoriesXML));

            foreach (var category in deserializedCategories)
            {
                if (IsValid(category))
                {
                    context.Categories.Add(new Category
                    {
                        Name = category.Name
                    });
                }
            }

            context.SaveChanges();
            GenerateCategoriesForProducts();
        }

        private void GenerateCategoriesForProducts()
        {
            var categories = context.Categories.ToList();
            var products = context.Products.ToList();
            Random rnd = new Random();

            int numberOfCategoriesToTake = rnd.Next(1, categories.Count());

            foreach (var product in  products)
            {
                List<CategoryProduct> categoryProducts = new List<CategoryProduct>();

                for (int i = 0; i < numberOfCategoriesToTake; i++)
                {
                    int categoryIndex = rnd.Next(0, categories.Count());
                    int categoryId = context.Categories.ToList().ElementAt(categoryIndex).Id;

                    while (categoryProducts.Where(x => x.ProductId == product.Id).Any(x => x.CategoryId == categoryId))
                    {
                        categoryIndex = rnd.Next(0, categories.Count());
                        categoryId = context.Categories.ToList().ElementAt(categoryIndex).Id;
                    }

                    categoryProducts.Add(new CategoryProduct
                    {
                        ProductId = product.Id,
                        CategoryId = categoryId
                    });
                }

                context.CategoryProducts.AddRange(categoryProducts);

                numberOfCategoriesToTake = rnd.Next(1, categories.Count());

                context.SaveChanges();
            }

            context.SaveChanges();
        }

        private void ImportProducts()
        {
            string productsXML = File.ReadAllText(pathToResources + "products.xml");

            var serializer = new XmlSerializer(typeof(ProductDto[]), new XmlRootAttribute("products"));
            var deserializedProducts = (ProductDto[])serializer.Deserialize(new StringReader(productsXML));

            foreach (var product in deserializedProducts)
            {
                if (IsValid(product))
                {
                    Random rnd = new Random();
                    int buyerIndex = rnd.Next(0, context.Users.Count());
                    int sellerIndex = rnd.Next(0, context.Users.Count());

                    while (buyerIndex == sellerIndex)
                    {
                        sellerIndex = rnd.Next(0, context.Users.Count());
                    }

                    int? buyerId = context.Users.ToList().ElementAt(buyerIndex).Id;
                    int sellerId = context.Users.ToList().ElementAt(sellerIndex).Id;

                    if (rnd.Next(0, 2) == 1)
                    {
                        buyerId = null;
                    }

                    context.Products.Add(new Product
                    {
                        Name = product.Name,
                        Price = product.Price,
                        BuyerId = buyerId,
                        SellerId = sellerId,
                    });
                }
            }

            context.SaveChanges();
        }

        private void ImportUsers()
        {
            string usersXML = File.ReadAllText(pathToResources + "users.xml");
            
            var serializer = new XmlSerializer(typeof(UserDto[]), new XmlRootAttribute("users"));
            var deserializedUsers = (UserDto[])serializer.Deserialize(new StringReader(usersXML));

            foreach (var user in deserializedUsers)
            {
                if (IsValid(user))
                {
                    context.Users.Add(new User
                    {
                        Age = user.age,
                        FirstName = user.FirstName,
                        LastName = user.LastName
                    });
                }
            }

            context.SaveChanges();
        }

        private bool IsValid(object obj)
        {
            var validationContext = new ValidationContext(obj);
            var result = new List<ValidationResult>();

            return Validator.TryValidateObject(obj, validationContext, result, true);
        }
    }
}
