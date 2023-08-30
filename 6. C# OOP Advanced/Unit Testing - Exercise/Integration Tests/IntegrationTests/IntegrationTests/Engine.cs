using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace IntegrationTests
{
    public class Engine
    {
        public List<Category> Categories;
        public List<User> Users;

        public Engine()
        {
            Categories = new List<Category>();
            Users = new List<User>();
        }

        public void AddCategory(string name)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("The category's name cannot be empty.");
            }

            if (Categories.Any(x => x.Name == name))
            {
                throw new InvalidOperationException("The category already exists.");
            }

            Categories.Add(new Category(name));
        }

        public void AddUser(string name)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("The user's name cannot be empty.");
            }

            if (Users.Any(x => x.Name == name))
            {
                throw new InvalidOperationException("The user already exists.");
            }

            Users.Add(new User(name));
        }

        public void RemoveCategory(string name)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("The category's name cannot be empty.");
            }

            Category category = Categories.Where(x => x.Name == name).FirstOrDefault();

            if (category != null)
            {
                if (category.HasUsers())
                {
                    if (category.HasChildren())
                    {
                        category.AssignUsersToChild();
                    }

                    Categories.AddRange(category.GetChildren());
                }

                Categories.Remove(category);
            }
            else
            {
                throw new InvalidOperationException("Category does not exist");
            }
        }

        public void RemoveCategories(List<string> names)
        {
            if (names.Count == 0)
            {
                throw new ArgumentNullException("You need to provide at least one category name to remove.");
            }

            if (Categories.Count == 0)
            {
                throw new InvalidOperationException("Category does not exist");
            }

            foreach (string name in names)
            {
                if (!Categories.Any(x => x.Name == name))
                {
                    throw new ArgumentException("Some of the categories do not exist");
                }
            }

            foreach (var category in names)
            {
                RemoveCategory(category);
            }
        }

        public void AssignChildCategory(string categoryName, string childName)
        {
            if (string.IsNullOrEmpty(categoryName) || string.IsNullOrWhiteSpace(categoryName))
            {
                throw new ArgumentNullException("The parent category name cannot be empty.");
            }

            if (string.IsNullOrEmpty(childName) || string.IsNullOrWhiteSpace(childName))
            {
                throw new ArgumentNullException("The child category name cannot be empty.");
            }

            Category category = Categories.Where(x => x.Name ==  categoryName).FirstOrDefault();
            Category child = Categories.Where(x => x.Name ==  childName).FirstOrDefault();

            if (category == null || child == null || category == child)
            {
                throw new ArgumentException("Not found");
            }

            foreach (var cat in Categories)
            {
                if (cat.GetChildren().Any(x => x.Name == child.Name))
                {
                    throw new InvalidOperationException("Already assigned");
                }
            }

            if (!category.GetChildren().Any(x => x == child))
            {
                category.AssignChild(child);
            }
        }

        public void AssignUserCategory(string categoryName, string userName)
        {
            if (string.IsNullOrEmpty(categoryName) || string.IsNullOrWhiteSpace(categoryName))
            {
                throw new ArgumentNullException("The category's name cannot be empty.");
            }

            if (string.IsNullOrEmpty(userName) || string.IsNullOrWhiteSpace(userName))
            {
                throw new ArgumentNullException("The user's name cannot be empty.");
            }

            Category category = Categories.Where(x => x.Name == categoryName).FirstOrDefault();
            User user = Users.Where(x => x.Name == userName).FirstOrDefault();

            if (category == null || user == null)
            {
                throw new ArgumentException("Not found");
            }

            foreach (var u in Users)
            {
                if (u.GetCategories().Any(x => x.Name == category.Name))
                {
                    throw new InvalidOperationException("Already assigned");
                }
            }

            foreach(var c in Categories)
            {
                if (c.GetUsers().Any(x => x.Name == user.Name))
                {
                    throw new InvalidOperationException("AlreadyAssigned");
                }
            }

            if (!category.GetUsers().Any(x => x == user) && !user.GetCategories().Any(x => x == category))
            {
                category.AddUser(user);
                user.AddCategory(category);
            }
        }

        public void RemoveChild(string categoryName, string childName)
        {
            if (string.IsNullOrEmpty(categoryName) || string.IsNullOrWhiteSpace(categoryName))
            {
                throw new ArgumentNullException("The parent category name cannot be empty.");
            }

            if (string.IsNullOrEmpty(childName) || string.IsNullOrWhiteSpace(childName))
            {
                throw new ArgumentNullException("The child category name cannot be empty.");
            }

            Category category = Categories.Where(x => x.Name == categoryName).FirstOrDefault();
            Category child = Categories.Where(x => x.Name == childName).FirstOrDefault();

            if (category == null || child == null || category == child)
            {
                throw new ArgumentException("Not found");
            }

            if (category.GetChildren().Any(x => x == child))
            {
                category.RemoveChild(child);
            }
            else
            {
                throw new InvalidOperationException("Not found");
            }
        }

        public void RemoveChildren(string categoryName, List<string> children)
        {
            if (string.IsNullOrEmpty(categoryName) || string.IsNullOrWhiteSpace(categoryName))
            {
                throw new ArgumentNullException("The parent category name cannot be empty.");
            }

            if (children.Count == 0)
            {
                throw new ArgumentNullException("You need to provide at least one child category name to remove.");
            }

            if (children.Any(x => string.IsNullOrEmpty(x) || string.IsNullOrWhiteSpace(x)))
            {
                throw new ArgumentNullException("Invalid names");
            }

            Category category = Categories.Where(x => x.Name == categoryName).FirstOrDefault();
            List<Category> childrenCats = Categories.Where(x => children.Contains(x.Name)).ToList();

            if (category == null)
            {
                throw new ArgumentNullException("Invalid names");
            }

            foreach (var c in childrenCats)
            {
                if (!category.GetChildren().Contains(c))
                {
                    throw new InvalidOperationException();
                }
            }

            foreach (var child in childrenCats)
            {
                category.RemoveChild(child);
            }
        }

        public void Print()
        {
            foreach (var category in Categories)
            {
                Console.WriteLine(category);
            }

            foreach (var user in Users)
            {
                Console.WriteLine(user);
            }
        }

        public void Reset()
        {
            Users = new List<User>();
            Categories = new List<Category>();
        }
    }
}
