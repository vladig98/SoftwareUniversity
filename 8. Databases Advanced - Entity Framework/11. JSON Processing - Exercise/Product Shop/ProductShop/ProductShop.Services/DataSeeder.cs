using Microsoft.EntityFrameworkCore.Internal;
using Newtonsoft.Json;
using ProductShop.Data;
using ProductShop.Models;
using ProductShop.Services.Contracts;
using ProductShop.Services.Dtos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProductShop.Services
{
    public class DataSeeder : IDataSeeder
    {
        private readonly ProductShopContext context;
        private string pathToResources = Directory.GetCurrentDirectory() + @"..\..\..\..\..\Resources\";

        public DataSeeder(ProductShopContext context)
        {
            this.context = context;
        }

        public void Seed()
        {
            if (!context.Users.Any())
            {
                InsertUsers();
            }
            if (!context.Products.Any())
            {
                InsertProducts();
            }
            if (!context.Categories.Any())
            {
                InsertCategories();
            }
        }

        private void InsertCategories()
        {
            string categoriesJSON = File.ReadAllText(pathToResources + "categories.json");

            var deserializedCategories = JsonConvert.DeserializeObject<List<CategoryDto>>(categoriesJSON);

            foreach (var categoryDto in deserializedCategories)
            {
                context.Categories.Add(new Category
                {
                    Name = categoryDto.name
                });
            }

            context.SaveChanges();

            InsertCategoriesProducts();
        }

        private void InsertCategoriesProducts()
        {
            var products = context.Products.ToList();

            List<CategoryProduct> categoryProducts = new List<CategoryProduct>();

            Random rnd = new Random();

            foreach (var product in products)
            {
                int numberOfCategories = rnd.Next(1, context.Categories.Count());

                for (int i = 0; i < numberOfCategories; i++)
                {
                    int categoryIndex = rnd.Next(0, context.Categories.Count());

                    int categoryId = context.Categories.ToList().ElementAt(categoryIndex).Id;

                    while (categoryProducts.Any(x => x.ProductId == product.Id && x.CategoryId == categoryId))
                    {
                        categoryIndex = rnd.Next(0, context.Categories.Count());
                        categoryId = context.Categories.ToList().ElementAt(categoryIndex).Id;
                    }

                    categoryProducts.Add(new CategoryProduct
                    {
                        CategoryId = categoryId,
                        ProductId = product.Id
                    });
                }
            }

            context.CategoryProducts.AddRange(categoryProducts);

            context.SaveChanges();
        }

        private void InsertProducts()
        {
            string productsJSON = File.ReadAllText(pathToResources + "products.json");

            var deserializedProducts = JsonConvert.DeserializeObject<List<ProductDto>>(productsJSON);

            Random rnd = new Random();

            foreach (var product in deserializedProducts)
            {
                int buyerIndex = rnd.Next(0, context.Users.Count());
                int? buyerId = context.Users.ToList().ElementAt(buyerIndex).Id;

                int sellerIndex = rnd.Next(0, context.Users.Count());
                int sellerId = context.Users.ToList().ElementAt(sellerIndex).Id;

                while (buyerId == sellerId)
                {
                    sellerIndex = rnd.Next(0, context.Users.Count());
                    sellerId = context.Users.ToList().ElementAt(sellerIndex).Id;
                }

                int FiftyPercentChance = rnd.Next(0, 2);

                if (FiftyPercentChance > 0)
                {
                    buyerId = null;
                }

                context.Products.Add(new Product
                {
                    BuyerId = buyerId,
                    Name = product.name,
                    Price = product.price,
                    SellerId = sellerId
                });
            }

            context.SaveChanges();
        }

        private void InsertUsers()
        {
            string usersJSON = File.ReadAllText(pathToResources + "users.json");

            var deserializedUsers = JsonConvert.DeserializeObject<List<UserDto>>(usersJSON);

            foreach (var user in deserializedUsers)
            {
                context.Users.Add(new User
                {
                    Age = user.age,
                    FirstName = user.firstName,
                    LastName = user.lastName
                });
            }

            context.SaveChanges();
        }
    }
}
