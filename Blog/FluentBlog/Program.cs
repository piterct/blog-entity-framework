using FluentBlog.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace FluentBlog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var context = new BlogDataContext();
            var posts = context.Posts.FirstOrDefault(x=> x.Id == 1);
            var posts2 = context.Posts.AsNoTracking();
        }
    }
}
