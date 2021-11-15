using FluentBlog.Data;
using FluentBlog.Models;
using FluentBlog.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentBlog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var context = new BlogDataContext();

            //var post = await context.Posts.ToListAsync();
            //var tausersgs = await context.Users.ToListAsync();

            //var posts = await GetPosts(context);

           // var posts = PostRepository.GetPosts(context, 0, 25);

            var postsWithRole = PostRepository.GetPostWithRole(context, 7);

            Console.WriteLine("Test");
        }

       
    }
}
