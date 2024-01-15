using ef_blog.Models;
using ef_blog.Data;
using System.Runtime.ExceptionServices;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Reflection.Metadata;

using BloggingContext? db = new BloggingContext();

Console.WriteLine($"SQLite DB located at: {db.DbPath}");

db.SaveChanges();

string[] userCSV = File.ReadAllLines("User.csv");
string[] BlogCSV = File.ReadAllLines("Blog.csv");
string[] PostCSV = File.ReadAllLines("Post.csv");


for (int i = 0; i < userCSV.Length; i++)
{
    string[] userSplit = userCSV[i].Split(',');

    db.Add(new User { UserName = userSplit[1], Password = userSplit[2] });

}
for (int i = 0; i < BlogCSV.Length; i++)
{
    string[] blogSplit = BlogCSV[i].Split(',');

    db.Add(new Blog { Url = blogSplit[1], Name = blogSplit[2] });

}


for (int i = 0; i < PostCSV.Length; i++)
{
    string[] postSplit = PostCSV[i].Split(",");

    DateOnly.TryParse(postSplit[3], out DateOnly date);
    int.TryParse(postSplit[4], out int blogID_fk);
    int.TryParse(postSplit[5], out int userId_fk);

    db.Add(new Post { Title = postSplit[1], Content = postSplit[2], Published_On = date, BlogId = blogID_fk, UserId = userId_fk });
}

db.SaveChanges();





//Console.WriteLine("Delete the blog"); db.Remove(); db.SaveChanges();






/*
User user = new User();
{
    foreach (int id in UserId)
    {
        Console.WriteLine(id);
    }
}
db.Users.Add(user);
db.SaveChanges();

foreach (int id in UserId)
{ 

    //db.Add(id);
    db.Users.Add(user);
}
db.SaveChanges();

/*

Console.WriteLine("UserNames: ");
for (int i = 0;i < userName.Count; i++)
{
    Console.WriteLine(userName[i]);
}


List<string> list2 = new List<string>();    

ICollection<string> users = (ICollection<string>)list2;


foreach (string line in users)
{

}

try
{
	int.TryParse(list2, out int sd);



            List<Person> persons = new List<Person>();
    persons.Add(new Person("John", 30));
    persons.Add(new Person("Jack", 27));

    ICollection<Person> personCollection = persons;
    IEnumerable<Person> personEnumeration = persons;


    foreach (string line in sd)
{

}


}
catch (Exception)
{

	throw;
}
//filhantering
//göra om csv filer
//try parse




/*
 * // Create
Console.WriteLine("Inserting a new blog");
db.Add(new Blog { Url = "http://blogs.msdn.com/adonet" });
db.SaveChanges();

// Read
Console.WriteLine("Querying for a blog");
var blog = db.Blogs
.OrderBy(b => b.BlogId)
.First();
 */