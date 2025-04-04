﻿using Forum.App.UserInterface.ViewModels;
using Forum.Data;
using Forum.Models;
using System.Collections.Generic;
using System.Linq;

namespace Forum.App.Services
{
    public static class PostService
    {
        internal static Category GetCategory(int categoryId)
        {
            ForumData forumData = new ForumData();
            Category category = forumData.Categories.Find(c => c.Id == categoryId);

            return category;
        }

        internal static IList<ReplyViewModel> GetPostReplies(int postId)
        {
            ForumData forumData = new ForumData();
            Post post = forumData.Posts.Find(c => c.Id == postId);

            IList<ReplyViewModel> replyList = new List<ReplyViewModel>();

            foreach (var replyId in post.ReplyIds)
            {
                var reply = forumData.Replies.Find(r => r.Id == replyId);
                replyList.Add(new ReplyViewModel(reply));
            }

            return replyList;
        }

        internal static string[] GetAllCategoriesNames()
        {
            ForumData forumData = new ForumData();

            var allCategories = forumData.Categories.Select(x => x.Name).ToArray();

            return allCategories;
        }

        public static IEnumerable<Post> GetPostsByCategory(int categoryId)
        {
            ForumData forumData = new ForumData();

            var postIds = forumData.Categories.First(c => c.Id == categoryId).PostIds;

            IEnumerable<Post> posts = forumData.Posts.Where(p => postIds.Contains(p.Id));

            return posts;
        }

        public static PostViewModel GetPostViewModel(int postId)
        {
            ForumData forumData = new ForumData();
            Post post = forumData.Posts.Find(c => c.Id == postId);

            PostViewModel postViewModel = new PostViewModel(post);
            return postViewModel;
        }

        private static Category EnsureCategory(PostViewModel postView, ForumData forumData)
        {
            var categoryName = postView.Category;
            Category category = forumData.Categories.FirstOrDefault(x => x.Name == categoryName);

            if (category == null)
            {
                var categories = forumData.Categories;
                int categoryId = categories.Any() ? categories.Last().Id + 1 : 1;
                category = new Category(categoryId, categoryName, new List<int>());
                forumData.Categories.Add(category);
            }

            return category;
        }

        public static bool TrySavePost(PostViewModel postView)
        {
            bool emptyCategory = string.IsNullOrWhiteSpace(postView.Category);
            bool emptyTitle = string.IsNullOrWhiteSpace(postView.Title);
            bool emptyContent = !postView.Content.Any();

            if (emptyCategory || emptyContent || emptyTitle)
            {
                return false;
            }

            ForumData forumData = new ForumData();
            Category category = EnsureCategory(postView, forumData);
            int postId = forumData.Posts.Any() ? forumData.Posts.Last().Id + 1 : 1;
            //User author = UserService.GetUser(postView.Author);
            User author = forumData.Users.Single(u => u.Username == postView.Author);

            int authorId = author.Id;
            string content = string.Join("", postView.Content);

            Post post = new Post(postId, postView.Title, content, category.Id, authorId);//, new List<int>());

            forumData.Posts.Add(post);
            author.PostIds.Add(post.Id);
            category.PostIds.Add(post.Id);
            forumData.SaveChanges();

            postView.PostId = postId;

            return true;
        }

        public static bool TrySaveReply(ReplyViewModel rvm, int postId)
        {
            if (!rvm.Content.Any())
            {
                return false;
            }

            ForumData forumData = new ForumData();
            User author = UserService.GetUser(rvm.Author);
            int authorId = author.Id;
            Post post = forumData.Posts.Single(p => p.Id == postId);
            int replyId = forumData.Replies.LastOrDefault()?.Id + 1 ?? 1;
            string content = string.Join("", rvm.Content);

            Reply reply = new Reply(replyId, content, authorId, postId);

            forumData.Replies.Add(reply);
            post.ReplyIds.Add(replyId);
            forumData.SaveChanges();
            return true;
        }
    }
}
