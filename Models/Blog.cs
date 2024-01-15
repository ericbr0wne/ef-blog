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
        [Key]
        public int BlogId { get; set; }

        public string? Url { get; set; }
        public string? Name { get; set; }

        //public Post? Post { get; set; } 
        //public int? PostId { get; set;}
    }
}
