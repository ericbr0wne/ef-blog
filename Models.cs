﻿namespace ef_blog;
using Microsoft.EntityFrameworkCore;


public class User
{
    public int UserId { get; set; }
    public string? UserName { get; set; }
    public string? Password { get; set; }

    public int? PostId { get; set; }
}


public class Blog
{
    public int BlogId { get; set; }
    public string Url { get; set; }
    public string Title { get; set; }
    
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
