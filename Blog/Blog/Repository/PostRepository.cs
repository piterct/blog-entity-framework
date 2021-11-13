using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Blog.Repository
{
    public static class PostRepository
    {
        public static bool CreatePost(Post post)
        {
            int result = 0;

            using (var context = new BlogDataContext())
            {
                context.Posts.Add(post);
                result = context.SaveChanges();
            }

            return result == 0 ? false : true;
        }

        public static List<Post> GetPosts()
        {
            using (var context = new BlogDataContext())
            {
                return context.Posts
                     .AsNoTracking()
                     .Include(x => x.Author)
                     .OrderByDescending(x => x.LastUpdateDate)
                     .ToList();
            }
        }
    }
}
