using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntegrationTests
{
    public class User
    {
        public string Name {  get; set; }
        private List<Category> Categories { get; set; }

        public User(string name)
        {
            Name = name;
            Categories = new List<Category>();
        }

        public void AddCategory(Category category)
        {
            Categories.Add(category);
        }

        public List<Category> GetCategories() 
        { 
            return Categories.ToList(); 
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Name: {Name}");
            sb.AppendLine("Categories:");
            foreach (var category in Categories)
            {
                sb.AppendLine($"---{category.Name}");
            }

            return sb.ToString();
        }
    }
}
