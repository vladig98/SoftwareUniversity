using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using ProductShop.Data;
using ProductShop.Services.Contracts;
using ProductShop.Services.Dtos;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProductShop.Services
{
    public class DataExporter : IDataExporter
    {
        private readonly ProductShopContext context;
        private string pathToResources = Directory.GetCurrentDirectory() + @"..\..\..\..\..\Resources\Exports\";

        public DataExporter(ProductShopContext context)
        {
            this.context = context;
        }

        public void ExportCategoriesByProductsCount()
        {
            StreamWriter filePath = File.CreateText(pathToResources + "categories-by-products.json");

            JsonSerializer serializer = new JsonSerializer();
            serializer.Formatting = Formatting.Indented;

            var categories = context.Categories.Include(x => x.CategoryProducts).ThenInclude(x => x.Product)
                .ToList().OrderBy(x => x.CategoryProducts.Count).ToList();

            List<CategoryExportDto> categoriesDtos = new List<CategoryExportDto>();

            foreach (var category in categories)
            {
                categoriesDtos.Add(new CategoryExportDto
                {
                    category = category.Name,
                    productsCount = category.CategoryProducts.Count,
                    averagePrice = category.CategoryProducts.Average(x => x.Product.Price),
                    totalRevenue = category.CategoryProducts.Sum(x => x.Product.Price),
                });
            }

            using (filePath)
            {
                serializer.Serialize(filePath, categoriesDtos);
            }
        }

        public void ExportProductsInRange()
        {
            StreamWriter filePath = File.CreateText(pathToResources + "products-in-range.json");

            JsonSerializer serializer = new JsonSerializer();
            serializer.Formatting = Formatting.Indented;

            var products = context.Products.Include(x => x.Seller).ToList()
                .Where(x => x.Price >= 500 && x.Price <= 1000).OrderBy(x => x.Price);

            List<ProductExportDto> productDtos = new List<ProductExportDto>();

            foreach (var product in products)
            {
                productDtos.Add(new ProductExportDto
                {
                    name = product.Name,
                    price = product.Price,
                    seller = product.Seller.FirstName + " " + product.Seller.LastName
                });
            }

            using (filePath)
            {
                serializer.Serialize(filePath, productDtos);
            }
        }

        public void ExportSuccessfullySoldProducts()
        {
            StreamWriter filePath = File.CreateText(pathToResources + "users-sold-products.json");

            JsonSerializer serializer = new JsonSerializer();
            serializer.Formatting = Formatting.Indented;

            var users = context.Users.Include(x => x.ProductsSold).ThenInclude(x => x.Buyer).ToList().Where(x => x.ProductsSold.Count > 0)
                .Where(x => x.ProductsSold.Where(y => y.BuyerId != null).Count() > 0).OrderBy(x => x.LastName).ThenBy(x => x.FirstName);

            List<UsersExportDto> usersDtos = new List<UsersExportDto>();

            foreach (var user in users)
            {
                List<UPProductExportDto> productsDtos = new List<UPProductExportDto>();

                foreach (var product in user.ProductsSold)
                {
                    if (product.BuyerId != null)
                    {
                        productsDtos.Add(new UPProductExportDto
                        {
                            name = product.Name,
                            price = product.Price,
                            buyerFirstName = product.Buyer.FirstName,
                            buyerLastName = product.Buyer.LastName
                        });
                    }
                }

                usersDtos.Add(new UsersExportDto
                {
                    firstName = user.FirstName,
                    lastName = user.LastName,
                    soldProducts = productsDtos
                });
            }

            using (filePath)
            {
                serializer.Serialize(filePath, usersDtos);
            }
        }

        public void ExportUsersAndProducts()
        {
            StreamWriter filePath = File.CreateText(pathToResources + "users-and-products.json");

            JsonSerializer serializer = new JsonSerializer();
            serializer.Formatting = Formatting.Indented;

            var users = context.Users.Include(x => x.ProductsSold).ToList().Where(x => x.ProductsSold.Count > 0)
                .OrderByDescending(x => x.ProductsSold.Count).ThenBy(x => x.LastName).ToList();

            List<UPUsersDto> usersDtos = new List<UPUsersDto>();

            foreach (var user in users)
            {
                List<ProductDto> productDtos = new List<ProductDto>();

                foreach(var product in user.ProductsSold)
                {
                    productDtos.Add(new ProductDto
                    {
                        name = product.Name,
                        price = product.Price,
                    });
                }

                SoldProductsDto soldProductsDto = new SoldProductsDto()
                {
                    count = user.ProductsSold.Count,
                    products = productDtos
                };

                usersDtos.Add(new UPUsersDto
                {
                    age = user.Age,
                    firstName = user.FirstName,
                    lastName = user.LastName,
                    soldProducts = soldProductsDto
                });
            }

            UsersDto usersDto = new UsersDto()
            {
                usersCount = users.Count,
                users = usersDtos
            };

            using (filePath)
            {
                serializer.Serialize(filePath, usersDto);
            }
        }
    }
}
