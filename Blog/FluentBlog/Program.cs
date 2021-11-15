using FluentBlog.Data;
using FluentBlog.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentBlog
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            using var context = new BlogDataContext();

            var post = await context.Posts.ToListAsync();
            var tausersgs = await context.Users.ToListAsync();

            var posts = await GetPosts(context);

            Console.WriteLine("Teste");
        }

        public static async Task<IEnumerable<Post>> GetPosts(BlogDataContext context)
        {
           return await context.Posts.ToListAsync();
        }
    }
}
