using FluentBlog.Data;
using FluentBlog.Models;
using System;
using System.Linq;

namespace FluentBlog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var context = new BlogDataContext();

            //context.Users.Add(new User
            //{
            //    Name = "Michael P.",
            //    Email = "michael.p@developer.com",
            //    Bio = "Software Developer",
            //    Image = "https://developer.com",
            //    Slug = "michael-p",
            //    PasswordHash = "1234"
            //});

            //context.SaveChanges();

            var user = context.Users.FirstOrDefault();

            var post = new Post
            {
                Author = user,
                Body = "My Article",
                Category = new Category { Name = "Backend", Slug = "backend-ef-core" },
                CreateDate = DateTime.Now,
                Slug = "my-article",
                Summary = "Beginning backend",
                Title = "Ef Core"
            };

            context.Posts.Add(post);
            context.SaveChanges();
        }
    }
}
