using System;
using System.Collections.Generic;
using System.Text;

namespace CustomClassAttribute
{
    [AttributeUsage(AttributeTargets.Class)]
    public class CustomClassAttribute : Attribute
    {
        private string[] reviewers;

        public string Author { get; set; }
        public int Revision { get; set; }
        public string Description { get; set; }
        public string[] Reviewers { get; set; }

        //public CustomClassAttribute(string Author, int Revision, string Description, string[] Reviewers)
        //{
        //    this.Author = Author;
        //    this.Revision = Revision;
        //    this.Description = Description;
        //    reviewers = Reviewers;
        //}
    }
}
