using Blog.Data;
using Blog.Models;

namespace Blog
{
    class Program
    {
        static void Main(string[] args)
        {
           using(var context = new BlogDataContext())
            {
                var tag = new Tag { Name = "ASP.NET", Slug = "aspnet2" };
                context.Tags.Add(tag);
                context.SaveChanges();
            }
        }
    }
}
