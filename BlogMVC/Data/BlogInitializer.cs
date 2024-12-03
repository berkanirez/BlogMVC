using BlogMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogMVC.Data
{
    public class BlogInitializer : DropCreateDatabaseIfModelChanges<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {
            List<Category> categories = new List<Category>()
            {
                new Category() {CategoryName="C#"},
                new Category() {CategoryName="Asp.net MVC"},
                new Category() {CategoryName="Asp.net WebForm"},
                new Category() {CategoryName="Windows Form"}
            };

            foreach (var category in categories) 
            {
                context.Categories.Add(category);
            };
            context.SaveChanges();

            List<Blog> blogs = new List<Blog>()
            {
                new Blog() {Title="C# Delegates C# DelegatesC# DelegatesC# DelegatesC# DelegatesC# DelegatesC# Delegates C# DelegatesC# DelegatesC# DelegatesC# DelegatesC# DelegatesC# Delegates C# DelegatesC# DelegatesC# DelegatesC# DelegatesC# Delegates",Description="About C# Delegates",PostDate=DateTime.Now.AddDays(-10),HomePage=true,Confirmed=true,Content="C# Delegates",Image="1.jpg", CategoryId=1 },
                new Blog() {Title="C# Delegates",Description="About C# Delegates",PostDate=DateTime.Now.AddDays(-10),HomePage=true,Confirmed=true,Content="C# Delegates",Image="1.jpg", CategoryId=1 },
                new Blog() {Title="C# Delegates",Description="About C# Delegates",PostDate=DateTime.Now.AddDays(-30),HomePage=false,Confirmed=false,Content="C# Delegates",Image="1.jpg", CategoryId=1 },
                new Blog() {Title="C# Delegates",Description="About C# Delegates",PostDate=DateTime.Now.AddDays(-20),HomePage=true,Confirmed=true,Content="C# Delegates",Image="2.jpg", CategoryId=2 },
                new Blog() {Title="C# Generic List",Description="About C# Delegates",PostDate=DateTime.Now.AddDays(-5),HomePage=true,Confirmed=false,Content="C# Delegates",Image="1.jpg", CategoryId=2 },
                new Blog() {Title="C# Delegates",Description="About C# Delegates",PostDate=DateTime.Now.AddDays(-10),HomePage=false,Confirmed=false,Content="C# Delegates",Image="2.jpg", CategoryId=2 },
                new Blog() {Title="C# Delegates",Description="About C# Delegates",PostDate=DateTime.Now.AddDays(-10),HomePage=true,Confirmed=true,Content="C# Delegates",Image="2.jpg", CategoryId=3 },
                new Blog() {Title="C# Delegates",Description="About C# Delegates",PostDate=DateTime.Now.AddDays(-10),HomePage=false,Confirmed=true,Content="C# Delegates",Image="2.jpg", CategoryId=3 },
                new Blog() {Title="C# Delegates",Description="About C# Delegates",PostDate=DateTime.Now.AddDays(-15),HomePage=true,Confirmed=true,Content="C# Delegates",Image="1.jpg", CategoryId=3 },
                new Blog() {Title="C# Delegates",Description="About C# Delegates",PostDate=DateTime.Now.AddDays(-17),HomePage=true,Confirmed=false,Content="C# Delegates",Image="2.jpg", CategoryId=4 },
                new Blog() {Title="C# Delegates",Description="About C# Delegates",PostDate=DateTime.Now.AddDays(-10),HomePage=true,Confirmed=true,Content="C# Delegates",Image="1.jpg", CategoryId=4 },
                new Blog() {Title="C# Delegates",Description="About C# Delegates",PostDate=DateTime.Now.AddDays(-10),HomePage=true,Confirmed=true,Content="C# Delegates",Image="1.jpg", CategoryId=4 },
                new Blog() {Title="C# Delegates",Description="About C# Delegates",PostDate=DateTime.Now.AddDays(-10),HomePage=true,Confirmed=true,Content="C# Delegates",Image="1.jpg", CategoryId=4 }

            };

            foreach (var blog in blogs)
            {
                context.Blogs.Add(blog);
            };
            context.SaveChanges();
            base.Seed(context);
        }
    }
}