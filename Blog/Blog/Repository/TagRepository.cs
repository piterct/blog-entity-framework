using Blog.Data;
using Blog.Models;

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

    }
}
