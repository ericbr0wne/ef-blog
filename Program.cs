using ef_blog;


using BloggingContext? db = new();

Console.WriteLine($"SQLite DB located at: {db.DbPath}");

db.Add(new Blog { Url = "First Blog" });
db.Add(new Blog { Url = "Second Blog" });

db.SaveChanges();

string list = File.ReadAllText("User.csv");

try
{
	int.TryParse(list, out int sd);

	Add.

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