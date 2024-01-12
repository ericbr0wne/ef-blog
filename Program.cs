using ef_blog;

using BloggingContext? db = new();

Console.WriteLine($"SQLite DB located at: {db.DbPath}");

db.Add(new Blog { Url = "First Blog" });
db.Add(new Blog { Url = "Second Blog" });

db.SaveChanges();

