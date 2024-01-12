namespace ef_blog;
using Microsoft.EntityFrameworkCore;

public class User
{
    public int Userid { get; set; }
    public string? UserName { get; set; }
    public string? Password { get; set; }

    public int? PostId { get; set; }
}

public class Blog
{
    public int BlogId { get; set; }
    public string Url { get; set; }
    public string Name { get; set; }

    public int PostId { get; set; }

}

public class Post
{
    public int PostID { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public string Published_On { get; set; }

    public int BlogId { get; set; }
    public int UserId { get; set; }
}


public class BloggingContext : DbContext
{

    public DbSet<User> Users { get; set; } //skapar tables 
    public DbSet<Blog> Blogs { get; set; }
    public DbSet<Post> Posts { get; set; }

    public string DbPath { get; }

    public BloggingContext()
    {
        string folder = Environment.CurrentDirectory;
        DbPath = System.IO.Path.Join(folder, "blogging.db");
    }
    protected override void OnConfiguring(DbContextOptionsBuilder options) =>
        options.UseSqlite($"Data Source={DbPath}");
}
