using Blog.Data;
using Blog.Models;
using Blog.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Blog
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using var context = new BlogDataContext();

                //var user = new User
                //{
                //    Name = "Michael Peter",
                //    Slug = "michaelpeter",
                //    Email = "michael.peter@developer.com",
                //    Bio = ".NET Developer ",
                //    Image = "https://imagem.com",
                //    PasswordHash = "123098457"
                //};

                //var category = new Category
                //{
                //    Name = "Backend",
                //    Slug = "backend"
                //};

                //var post = new Post
                //{
                //    Author = user,
                //    Category = category,
                //    Body = "<p>Hello world</p>",
                //    Slug = "Ef-Core",
                //    Summary = "In this post you will learn Ef core",
                //    Title = "Beginning  Ef Core",
                //    CreateDate = DateTime.Now,
                //    LastUpdateDate = DateTime.Now
                //};

                //PostRepository.CreatePost(post);

                var posts = PostRepository.GetPosts();

                foreach (var post in posts)
                {
                    Console.WriteLine($"{post.Title}  writed by {post.Author?.Name}");
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }
    }
}
