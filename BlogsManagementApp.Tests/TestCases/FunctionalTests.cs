

using BlogsManagementApp.DAL.Interrfaces;
using BlogsManagementApp.DAL.Services;
using BlogsManagementApp.DAL.Services.Repository;
using BlogsManagementApp.Models;
using BlogsManagementApp.Tests.TestCases;
using Moq;
using System;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;
using Blogs = BlogsManagementApp.Models.Blogs;

namespace BlogsManagementApp.Tests.TestCases
{
    public class FunctionalTests
    {
        private readonly ITestOutputHelper _output;
        private readonly IBlogsService _blogsService;
        public readonly Mock<IBlogsRepository> blogsservice = new Mock<IBlogsRepository>();

        private readonly Blogs _blogs;

        private static string type = "Functional";

        public FunctionalTests(ITestOutputHelper output)
        {
            _blogsService = new BlogsService(blogsservice.Object);

            _output = output;

            _blogs = new Blogs
            {
                BlogsId = 1,
                Name = "Sample Blogs",
                DateCreated = DateTime.Now,
                Description = "This is a sample blogs."
            };
        }


        [Fact]
        public async Task<bool> Testfor_Create_Blogs()
        {
            //Arrange
            var res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                blogsservice.Setup(repos => repos.CreateBlogs(_blogs)).ReturnsAsync(_blogs);
                var result = await _blogsService.CreateBlogs(_blogs);
                //Assertion
                if (result != null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }


        [Fact]
        public async Task<bool> Testfor_Update_Blogs()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                blogsservice.Setup(repos => repos.UpdateBlogs(_blogs)).ReturnsAsync(_blogs);
                var result = await _blogsService.UpdateBlogs(_blogs);
                if (result != null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");

            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

        [Fact]
        public async Task<bool> Testfor_GetBlogsById()
        {
            //Arrange
            var res = false;
            int id = 1;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                blogsservice.Setup(repos => repos.GetBlogsById(id)).ReturnsAsync(_blogs);
                var result = await _blogsService.GetBlogsById(id);
                //Assertion
                if (result != null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

        [Fact]
        public async Task<bool> Testfor_DeleteBlogsById()
        {
            //Arrange
            var res = false;
            int id = 1;
            bool response = true;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                blogsservice.Setup(repos => repos.DeleteBlogsById(id)).ReturnsAsync(response);
                var result = await _blogsService.DeleteBlogsById(id);
                //Assertion
                if (result != null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

    }
}