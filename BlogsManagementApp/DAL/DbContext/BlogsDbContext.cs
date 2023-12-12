
using BlogsManagementApp.Models;
using System.Data.Entity;


namespace BlogsManagementApp.DAL
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("DefaultConnection") { }

        public DbSet<Blogs> Blogss { get; set; }
    }
}