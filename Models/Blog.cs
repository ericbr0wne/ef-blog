using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ef_blog.Models
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string? Url { get; set; }
        public string? Name { get; set; }

        public List<Post> Posts { get; } = new();
    }
}
