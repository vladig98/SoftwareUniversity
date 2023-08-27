using Forum.App.Contracts.Services;
using Forum.App.Contracts.ViewModels;
using Forum.App.ViewModels;
using Forum.Data;
using Forum.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Forum.App.Services
{
    public class PostService : IPostService
    {
        private ForumData forumData;
        private IUserService userService;

        public PostService(ForumData forumData, IUserService userService)
        {
            this.forumData = forumData;
            this.userService = userService;
        }

        public int AddPost(int userId, string postTitle, string postCategory, string postContent)
        {
            bool emptyCategory = string.IsNullOrWhiteSpace(postCategory);
            bool emptyTitle = string.IsNullOrWhiteSpace(postTitle);
            bool emptyContent = string.IsNullOrWhiteSpace(postContent);

            if (emptyCategory || emptyTitle || emptyContent)
            {
                throw new ArgumentException("All fields must be filled!");
            }

            Category category = EnsureCategory(postCategory);

            int postId = forumData.Posts.Any() ? forumData.Posts.Last().Id + 1 : 1;

            User author = userService.GetUserById(userId);

            Post post =  new Post(postId, postTitle, postContent, category.Id, userId, new List<int>());

            forumData.Posts.Add(post);
            author.Posts.Add(post.Id);
            category.Posts.Add(post.Id);
            forumData.SaveChanges();

            return post.Id;
        }

        private Category EnsureCategory(string postCategory)
        {
            var category = forumData.Categories.Where(x => x.Name == postCategory).FirstOrDefault();

            if (category == null)
            {
                int categoryId = forumData.Categories.Any() ? forumData.Categories.Last().Id + 1 : 1;
                category = new Category(categoryId, postCategory, new List<int>());
                forumData.Categories.Add(category);
                forumData.SaveChanges();
            }

            return category;
        }

        public void AddReplyToPost(int postId, string replyContents, int userId)
        {
            Post post = forumData.Posts.Where(x => x.Id == postId).FirstOrDefault();
            bool verifyReplyContent = string.IsNullOrWhiteSpace(replyContents);
            User user = forumData.Users.Where(x => x.Id == userId).FirstOrDefault();

            if (post == null || !verifyReplyContent || user == null)
            {
                throw new ArgumentException("Invalid arguments!");
            }

            int replyId = forumData.Replies.Any() ? forumData.Replies.Last().Id + 1 : 1;

            forumData.Replies.Add(new Reply(replyId, replyContents, userId, postId));
            post.Replies.Add(replyId);
            forumData.SaveChanges();
        }

        public IEnumerable<ICategoryInfoViewModel> GetAllCategories()
        {
            IEnumerable<ICategoryInfoViewModel> categories = forumData.Categories
                .Select(x => new CategoryInfoViewModel(x.Id, x.Name, x.Posts.Count));

            return categories;
        }

        public string GetCategoryName(int categoryId)
        {
            string categoryName = forumData.Categories.Find(x => x.Id == categoryId)?.Name;

            if (categoryName == null)
            {
                throw new ArgumentException($"Category with id {categoryId} not found!");
            }

            return categoryName;
        }

        public IEnumerable<IPostInfoViewModel> GetCategoryPostsInfo(int categoryId)
        {
            IEnumerable<IPostInfoViewModel> posts = forumData.Posts.Where(x => x.CategoryId == categoryId)
                .Select(x => new PostInfoViewModel(x.Id, x.Title, x.Replies.Count));

            return posts;
        }

        public IPostViewModel GetPostViewModel(int postId)
        {
            var post = forumData.Posts.FirstOrDefault(x => x.Id == postId);
            IPostViewModel postView = new PostViewModel(post.Title, 
                userService.GetUserName(post.AuthorId), post.Content, GetPostReplies(postId));

            return postView;
        }

        private IEnumerable<IReplyViewModel> GetPostReplies(int postId)
        {
            IEnumerable<IReplyViewModel> replies = forumData.Replies.Where(x => x.PostId == postId)
                .Select(x => new ReplyViewModel(userService.GetUserName(x.AuthorId), x.Content));

            return replies;
        }
    }
}
