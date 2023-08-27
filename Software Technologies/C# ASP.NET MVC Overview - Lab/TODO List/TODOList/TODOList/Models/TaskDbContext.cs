using System;
using System.Data.Entity;
using System.Linq;

namespace TODOList.Models
{
    public class TaskDbContext : DbContext
    {
        public TaskDbContext()
            : base("name=TaskDbContext")
        {
        }

        public virtual DbSet<Task> Tasks { get; set; }
    }
}