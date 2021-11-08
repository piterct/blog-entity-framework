using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Blog.Repository
{
    public static class TagRepository
    {
        public static bool CreateTag(string name, string slug)
        {
            int result = 0;

            using (var context = new BlogDataContext())
            {
                var tag = new Tag { Name = name, Slug = slug };
                context.Tags.Add(tag);
                result = context.SaveChanges();
            }

            return result == 0 ? false : true;
        }

        public static bool RemoveTag(int id)
        {
            int result = 0;

            using (var context = new BlogDataContext())
            {
                var tag = context.Tags.FirstOrDefault(x => x.Id == id);
                context.Remove(tag);
                result = context.SaveChanges();

            }

            return result == 0 ? false : true;
        }

        public static Tag GetTag(int id)
        {

            using (var context = new BlogDataContext())
            {
                return context.Tags
                   .AsNoTracking()
                    .FirstOrDefault(x => x.Id == id);
            }

        }

        public static Tag UpdateTag(int id, string name, string slug)
        {
            using (var context = new BlogDataContext())
            {
                var tag = context.Tags.FirstOrDefault(x => x.Id == id);
                tag.Name = name;
                tag.Slug = slug;
                context.Update(tag);
                context.SaveChanges();
                return tag;
            }
        }

    }
}
