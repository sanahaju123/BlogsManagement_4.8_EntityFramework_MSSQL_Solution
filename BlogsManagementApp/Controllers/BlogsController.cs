using BlogsManagement.Models;
using BlogsManagementApp.DAL.Interrfaces;
using BlogsManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace BlogsManagementApp.Controllers
{
    public class BlogsController : ApiController
    {
        private readonly IBlogsService _service;
        public BlogsController(IBlogsService service)
        {
            _service = service;
        }
        public BlogsController()
        {
            // Constructor logic, if needed
        }
        [HttpPost]
        [Route("api/Blogs/CreateBlogs")]
        [AllowAnonymous]
        public async Task<IHttpActionResult> CreateBlogs([FromBody] Blogs model)
        {
            var leaveExists = await _service.GetBlogsById(model.BlogsId);
            var result = await _service.CreateBlogs(model);
            return Ok(new Response { Status = "Success", Message = "Blogs created successfully!" });
        }


        [HttpPut]
        [Route("api/Blogs/UpdateBlogs")]
        public async Task<IHttpActionResult> UpdateBlogs([FromBody] Blogs model)
        {
            var result = await _service.UpdateBlogs(model);
            return Ok(new Response { Status = "Success", Message = "Blogs updated successfully!" });
        }


        [HttpDelete]
        [Route("api/Blogs/DeleteBlogs")]
        public async Task<IHttpActionResult> DeleteBlogs(long id)
        {
            var result = await _service.DeleteBlogsById(id);
            return Ok(new Response { Status = "Success", Message = "Blogs deleted successfully!" });
        }


        [HttpGet]
        [Route("api/Blogs/GetBlogsById")]
        public async Task<IHttpActionResult> GetBlogsById(long id)
        {
            var expense = await _service.GetBlogsById(id);
            return Ok(expense);
        }


        [HttpGet]
        [Route("api/Blogs/GetAllBlogss")]
        public async Task<IEnumerable<Blogs>> GetAllBlogss()
        {
            return _service.GetAllBlogss();
        }
    }
}
