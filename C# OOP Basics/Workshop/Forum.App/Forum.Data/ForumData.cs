﻿using System.Collections.Generic;
using Forum.Models;

namespace Forum.Data
{
    public class ForumData
    {
        public List<Category> Categories { get; set; }
        public List<User> Users { get; set; }
        public List<Post> Posts { get; set; }
        public List<Reply> Replies { get; set; }

        public ForumData()
        {
            Users = DataMapper.LoadUsers();
            Posts = DataMapper.LoadPosts();
            Replies = DataMapper.LoadReplies();
            Categories = DataMapper.LoadCategories();
        }

        public void SaveChanges()
        {
            DataMapper.SaveUsers(Users);
            DataMapper.SavePosts(Posts);
            DataMapper.SaveReplies(Replies);
            DataMapper.SaveCategories(Categories);
        }
    }
}
