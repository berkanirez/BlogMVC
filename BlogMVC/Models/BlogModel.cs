using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BlogMVC.Models
{
    public class BlogModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime PostDate { get; set; }
        public bool Confirmed { get; set; }
        public bool HomePage { get; set; }
        public string Image { get; set; }
        public int CategoryId { get; set; }
    }
}