using ef_blog.Models;
using ef_blog.Data;

using BloggingContext? db = new BloggingContext();

Console.WriteLine($"SQLite DB located at: {db.DbPath}");

db.SaveChanges();


string[] userCSV = File.ReadAllLines("../../../CSV/User.csv");
string[] BlogCSV = File.ReadAllLines("../../../CSV/Blog.csv");
string[] PostCSV = File.ReadAllLines("../../../CSV/Post.csv");


//köra en array istället?
//int[] UserId = new int[];
List<int> UserId = new List<int>();
List<string> userName = new List<string>();
List<string> password = new List<string>();
List<int> PostId = new List<int>();

for (int i = 0; i < userCSV.Length; i++)
{
    string[] userLines = userCSV[i].Split(',');

    int.TryParse(userLines[0], out int id);
    UserId.Add(id);
 
    userName.Add(userLines[1]);
    password.Add(userLines[2]);

    int.TryParse(userLines[3], out int fk);
    PostId.Add(fk);

}

foreach (int id in UserId)
{ 

    //db.Add(id);
    db.AddRange(id);
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