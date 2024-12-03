using BlogMVC.Data;
using BlogMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogMVC.Controllers
{
    public class HomeController : Controller
    {
        private BlogContext context = new BlogContext();
        // GET: Home
        public ActionResult Index()
        {
            var blogs = context.Blogs.Where(i => i.Confirmed == true && i.HomePage == true)
                .Select(i => new BlogModel()
            {
                Id = i.Id,
                Title = i.Title.Length> 100 ? i.Title.Substring(0,100) + ".." : i.Title,
                Description = i.Description,
                PostDate = i.PostDate,
                Confirmed = i.Confirmed,
                HomePage = i.HomePage,
                Image = i.Image
            });

            return View(blogs.ToList()); 
        }
    }
}