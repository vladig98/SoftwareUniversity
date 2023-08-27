using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntegrationTests
{
    public class Category
    {
        public string Name { get; set; }
        private List<User> Users { get; set; }
        private List<Category> Children { get; set; }

        public Category(string name)
        {
            Name = name;
            Users = new List<User>();
            Children = new List<Category>();
        }

        public void AssignChild(Category child)
        {
            Children.Add(child);
        }

        public void AddUser(User user)
        {
            Users.Add(user);
        }

        public void RemoveChild(Category child)
        {
            Children.Remove(child);
        }

        public bool HasUsers()
        {
            return Users.Count > 0;
        }

        public bool HasChildren()
        {
            return Children.Count > 0;
        }

        public void AssignUsersToChild()
        {
            var child = Children[0];

            foreach (var user in Users)
            {
                child.AddUser(user);
            }
        }

        public List<Category> GetChildren()
        {
            return Children.ToList();
        }

        public List<User> GetUsers()
        {
            return Users.ToList();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Name: {Name}");
            sb.AppendLine($"Children:");
            foreach (var child in Children)
            {
                sb.AppendLine($"---{child.Name}");
            }
            sb.AppendLine($"Users:");
            foreach(var user in Users)
            {
                sb.AppendLine($"---{user.Name}");
            }

            return sb.ToString();
        }
    }
}
