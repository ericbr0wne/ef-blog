﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ef_blog.Models
{
    public class Post //Child
    {
        public int PostId { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public DateOnly Published_On { get; set; }

        public Blog? Blog {  get; set; }  
        public int BlogId { get; set; }
     
        public User? User {  get; set; }
        public int UserId { get; set; }
    }
}
