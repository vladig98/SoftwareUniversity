using Forum.App.Contracts.ViewModels;
using System;

namespace Forum.App.ViewModels
{
    public class CategoryInfoViewModel : ICategoryInfoViewModel
    {
        public int Id { get; }

        public string Name { get; }

        public int PostCount { get; }

        public CategoryInfoViewModel(int id, string name, int postCount)
        {
            Id = id;
            Name = name;
            PostCount = postCount;
        }
    }
}
