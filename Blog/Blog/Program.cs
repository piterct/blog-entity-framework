﻿using Blog.Data;
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
              
                //var tag = context.Tags.FirstOrDefault(x => x.Id == 1);
                //tag.Name = ".NET";
                //tag.Slug = "dotnet";
                //context.Update(tag);
                //context.SaveChanges();

               
            }
        }
    }
}
