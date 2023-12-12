using BlogsManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogsManagementApp.DAL.Interrfaces
{
    public interface IBlogsService
    {
        List<Blogs> GetAllBlogss();
        Task<Blogs> CreateBlogs(Blogs expense);
        Task<Blogs> GetBlogsById(long id);
        Task<bool> DeleteBlogsById(long id);
        Task<Blogs> UpdateBlogs(Blogs model);
    }
}
