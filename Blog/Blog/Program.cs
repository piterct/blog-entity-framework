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

            using (var context = new BlogDataContext())
            {
                //var tag = new Tag { Name = "ASP.NET6", Slug = ".NET6" };
                //context.Tags.Add(tag);
                //context.SaveChanges();


                //var tag = context.Tags.FirstOrDefault(x => x.Id == 1);
                //tag.Name = ".NET";
                //tag.Slug = "dotnet";
                //context.Update(tag);
                //context.SaveChanges();


                //var tag = context.Tags.FirstOrDefault(x => x.Id == 5);
                //context.Remove(tag);
                //context.SaveChanges();


                //var tags = context.Tags
                //    .AsNoTracking()
                //    .ToList();

                //foreach (var tag in tags)
                //{
                //    Console.WriteLine(tag.Name);
                //}

                //var tag = context.Tags
                //    .AsNoTracking()
                //    .FirstOrDefault(x => x.Id == 6);
                //Console.WriteLine(tag?.Name);
            }
        }
    }
}
