using FluentBlog.Data;
using FluentBlog.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentBlog.Repository
{
    public static  class PostRepository
    {
        public static async Task<IEnumerable<Post>> GetPosts(BlogDataContext context)
        {
            return await context.Posts.ToListAsync();
        }

        public static List<Post> GetPostComplete(BlogDataContext context, int authorId, int categoryId)
        {
            return context.Posts.AsNoTracking().Include(x => x.Author).Include(x => x.Category).Where(x=> x.Author.Id == authorId && x.Category.Id == categoryId).ToList();
        }
    }
}
