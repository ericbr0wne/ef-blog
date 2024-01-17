using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ef_blog.Models
{
    public class User 
    {
        public int UserId { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; } 

        public List<Post> Posts { get; } = new();
    }
}
