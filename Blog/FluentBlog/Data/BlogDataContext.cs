using Microsoft.EntityFrameworkCore;

namespace FluentBlog.Data
{
    public class BlogDataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=.\\MSSQLSERVER2019;Database=Blog;User ID=local;Password=147258;");
        }
    }
}
