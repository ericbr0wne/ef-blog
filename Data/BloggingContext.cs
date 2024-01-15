using ef_blog.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ef_blog.Data
{
    public class BloggingContext : DbContext
    {

        public DbSet<User> Users { get; set; }  
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

        public string DbPath { get; }

        public BloggingContext()
        {
            string folder = Environment.CurrentDirectory;
            DbPath = System.IO.Path.Join(folder, "EricBrowne.db");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options) =>
            options.UseSqlite($"Data Source={DbPath}");
    }
}
