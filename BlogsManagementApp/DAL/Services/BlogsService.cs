using BlogsManagementApp.DAL.Interrfaces;
using BlogsManagementApp.DAL.Services.Repository;
using BlogsManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace BlogsManagementApp.DAL.Services
{
    public class BlogsService : IBlogsService
    {
        private readonly IBlogsRepository _repository;

        public BlogsService(IBlogsRepository repository)
        {
            _repository = repository;
        }

        public Task<Blogs> CreateBlogs(Blogs expense)
        {
            return _repository.CreateBlogs(expense);
        }

        public Task<bool> DeleteBlogsById(long id)
        {
            return _repository.DeleteBlogsById(id);
        }

        public List<Blogs> GetAllBlogss()
        {
            return _repository.GetAllBlogss();
        }

        public Task<Blogs> GetBlogsById(long id)
        {
            return _repository.GetBlogsById(id); ;
        }

        public Task<Blogs> UpdateBlogs(Blogs model)
        {
            return _repository.UpdateBlogs(model);
        }
    }
}