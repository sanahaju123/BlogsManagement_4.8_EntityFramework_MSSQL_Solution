using BlogsManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace BlogsManagementApp.DAL.Services.Repository
{
    public class BlogsRepository : IBlogsRepository
    {
        private readonly DatabaseContext _dbContext;
        public BlogsRepository(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task<Blogs> CreateBlogs(Blogs expense)
        {
            try
            {
                var result =  _dbContext.Blogss.Add(expense);
                await _dbContext.SaveChangesAsync();
                return expense;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public async Task<bool> DeleteBlogsById(long id)
        {
            try
            {
                _dbContext.Blogss.Remove(_dbContext.Blogss.Single(a => a.BlogsId == id));
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public List<Blogs> GetAllBlogss()
        {
            try
            {
                var result = _dbContext.Blogss.ToList();
                return result;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public async Task<Blogs> GetBlogsById(long id)
        {
            try
            {
                return await _dbContext.Blogss.FindAsync(id);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

      
        

        public async Task<Blogs> UpdateBlogs(Blogs model)
        {
            var ex = await _dbContext.Blogss.FindAsync(model.BlogsId);
            try
            {
                await _dbContext.SaveChangesAsync();
                return ex;
            }
            catch (Exception exc)
            {
                throw (exc);
            }
        }
    }
}