using Blog.Data;
using Blog.Models;

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
    }
}
