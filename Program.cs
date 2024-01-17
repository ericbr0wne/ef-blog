using ef_blog.Models;
using ef_blog.Data;
using System.Runtime.ExceptionServices;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Reflection.Metadata;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;
using System;
using static System.Reflection.Metadata.BlobBuilder;
using Microsoft.EntityFrameworkCore.Storage;

using BloggingContext? db = new BloggingContext();

Console.WriteLine($"SQLite DB located at: {db.DbPath}");

db.SaveChanges();

string[] UserCSV = File.ReadAllLines("User.csv");
string[] BlogCSV = File.ReadAllLines("Blog.csv");
string[] PostCSV = File.ReadAllLines("Post.csv");

foreach (var line in UserCSV)
{
    var splitUser = line.Split(',');
    var userId = int.Parse(splitUser[0]);
    User? user = db.Users?.Find(userId);
    if (user != null) 
    {
        continue;
    }

    db.Users?.Add(new User
    {
        UserId = userId,
        UserName = splitUser[1],
        Password = splitUser[2]
    });
}
db.SaveChanges();


foreach (var line in BlogCSV)
{
    var splitBlog = line.Split(',');
    var blogId = int.Parse(splitBlog[0]);
    Blog? blog = db.Blogs?.Find(blogId);
    if (blog != null)
    {
        continue;
    }

    db.Blogs?.Add(new Blog
    {
        BlogId = blogId,
        Url = splitBlog[1],
        Name = splitBlog[2]
    });
}
    db.SaveChanges();


foreach (var line in PostCSV)
{ 
    var splitPost = line.Split(",");
    var postId = int.Parse(splitPost[0]);
    DateOnly.TryParse(splitPost[3], out DateOnly date);
    int.TryParse(splitPost[4], out int blogID_fk);
    int.TryParse(splitPost[5], out int userId_fk);
    Post? post = db.Posts?.Find(postId);
    if (post != null)
    {
        continue;
    }
    db.Add(new Post { 
        Title = splitPost[1], 
        Content = splitPost[2], 
        Published_On = date, 
        BlogId = blogID_fk, 
        UserId = userId_fk });
}
db.SaveChanges();

var blogs = db.Blogs
     .Include(p => p.Posts)
     .ThenInclude(u => u.User)
     .ToList();

foreach (var line in blogs)
{
    Console.WriteLine($"Blog: {line.Name}");

    foreach (var line2 in line.Posts)
    {
        Console.WriteLine($"   Post: {line2.Title}, {line2.Content}, {line2.Published_On}");
        Console.WriteLine($"      User: {line2.User.UserName}");
    }
        Console.WriteLine();
}

