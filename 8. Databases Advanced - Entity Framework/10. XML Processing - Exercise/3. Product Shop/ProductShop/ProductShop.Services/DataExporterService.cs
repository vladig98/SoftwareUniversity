using Microsoft.EntityFrameworkCore;
using ProductShop.Data;
using ProductShop.Services.Contracts;
using ProductShop.Services.Dtos;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace ProductShop.Services
{
    public class DataExporterService : IDataExporterService
    {
        private readonly ProductShopDbContext context;
        private string pathToResources = Directory.GetCurrentDirectory() + @"..\..\..\..\..\Resources\Exports\";

        public DataExporterService(ProductShopDbContext context)
        {
            this.context = context;
        }

        public void ExportCategoriesByProductsCount()
        {
            string fileName = pathToResources + "categories-by-products.xml";

            var serializer = new XmlSerializer(typeof(List<CategoryExportDto>), new XmlRootAttribute("categories"));
            var writer = new StreamWriter(fileName);

            var categories = context.Categories.Include(x => x.Products).ThenInclude(x => x.Product).ToList()
                .OrderBy(x => x.Products.Count).ToList();

            List<CategoryExportDto> categoriesDtos = new List<CategoryExportDto>();

            foreach (var category in categories)
            {
                categoriesDtos.Add(new CategoryExportDto
                {
                    Name = category.Name,
                    NumberOfProducts = category.Products.Count,
                    AverageProductsPrice = category.Products.Average(x => x.Product.Price),
                    TotalRevenue = category.Products.Sum(x => x.Product.Price)
                });
            }

            serializer.Serialize(writer, categoriesDtos);
        }

        public void ExportProductsInRange()
        {
            string fileName = pathToResources + "products-in-range.xml";

            var serializer = new XmlSerializer(typeof(List<ProductExportDto>), new XmlRootAttribute("products"));
            var writer = new StreamWriter(fileName);

            var products = context.Products.Include(x => x.Buyer).ToList().Where(x => x.Price >= 1000 && x.Price <= 2000 && x.BuyerId.HasValue)
                .OrderBy(x => x.Price).ToList();

            List<ProductExportDto> productsDtos = new List<ProductExportDto>();

            foreach (var product in products)
            {
                productsDtos.Add(new ProductExportDto
                {
                    Name = product.Name,
                    Price = product.Price,
                    BuyerName = product.Buyer.FirstName + " " + product.Buyer.LastName
                });
            }

            serializer.Serialize(writer, productsDtos);
        }

        public void ExportSoldProducts()
        {
            string fileName = pathToResources + "users-sold-products.xml";

            var serializer = new XmlSerializer(typeof(List<UserExportDto>), new XmlRootAttribute("users"));
            var writer = new StreamWriter(fileName);

            var users = context.Users.Include(x => x.ProductsSold).ToList().Where(x => x.ProductsSold.Any())
                .OrderBy(x => x.LastName).ThenBy(x => x.FirstName).ToList();

            List<UserExportDto> usersDtos = new List<UserExportDto>();

            foreach (var user in users)
            {
                HashSet<ProductDto> products = new HashSet<ProductDto>();

                foreach (var product in user.ProductsSold)
                {
                    products.Add(new ProductDto
                    {
                        Name= product.Name,
                        Price = product.Price
                    });
                }

                usersDtos.Add(new UserExportDto
                {
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Products = products
                });
            }

            serializer.Serialize(writer, usersDtos);
        }

        public void ExportUsersAndProducts()
        {
            string fileName = pathToResources + "users-and-products.xml";

            var serializer = new XmlSerializer(typeof(UPUsersExportDto));
            var writer = new StreamWriter(fileName);

            var users = context.Users.Include(x => x.ProductsSold).ToList().Where(x => x.ProductsSold.Any())
                .OrderByDescending(x => x.ProductsSold.Count).ThenBy(x => x.LastName).ToList();

            List<UPUserExportDto> usersDDtos = new List<UPUserExportDto>();


            foreach (var user in users)
            {
                List<UPProductExportDto> productDtos = new List<UPProductExportDto>();

                foreach (var product in user.ProductsSold)
                {
                    productDtos.Add(new UPProductExportDto
                    {
                        Name = product.Name,
                        Price = product.Price
                    });
                }

                var productsDto = new UPProductsExportDto
                {
                    Count = productDtos.Count,
                    Products = productDtos.ToArray()
                };

                usersDDtos.Add(new UPUserExportDto
                {
                    Age = user.Age.HasValue ? user.Age.Value.ToString() : null,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    SoldProducts = new UPProductsExportDto[] { productsDto }
                });
            }

            var usersDto = new UPUsersExportDto
            {
                Count = usersDDtos.Count,
                users = usersDDtos.ToArray()
            };

            serializer.Serialize(writer, usersDto);
        }
    }
}
