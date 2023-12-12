


using BlogsManagementApp.DAL.Interrfaces;
using BlogsManagementApp.DAL.Services;
using BlogsManagementApp.DAL.Services.Repository;
using BlogsManagementApp.Models;
using Moq;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;
using Blogs = BlogsManagementApp.Models.Blogs;

namespace BlogsManagementApp.Tests.TestCases
{
    public class ExceptionalTests
    {
        private readonly ITestOutputHelper _output;
        private readonly IBlogsService _blogsService;
        public readonly Mock<IBlogsRepository> blogsservice = new Mock<IBlogsRepository>();

        private readonly Blogs _blogs;

        private static string type = "Exception";

        public ExceptionalTests(ITestOutputHelper output)
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
        public async Task<bool> Testfor_Validate_ifInvalidBlogsIdIsPassed()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                blogsservice.Setup(repo => repo.CreateBlogs(_blogs)).ReturnsAsync(_blogs);
                var result = await _blogsService.CreateBlogs(_blogs);
                if (result != null || result.BlogsId !=0)
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
        public async Task<bool> Testfor_Validate_ifInvalidNameIsPassed()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                blogsservice.Setup(repo => repo.CreateBlogs(_blogs)).ReturnsAsync(_blogs);
                var result = await _blogsService.CreateBlogs(_blogs);
                if (result != null || result.Name !=null)
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
        public async Task<bool> Testfor_Validate_ifInvalidDescriptionIsPassed()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                blogsservice.Setup(repo => repo.CreateBlogs(_blogs)).ReturnsAsync(_blogs);
                var result = await _blogsService.CreateBlogs(_blogs);
                if (result != null || result.Description !=null)
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
        public async Task<bool> Testfor_Validate_ifInvalidBlogsDateIsPassed()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                blogsservice.Setup(repo => repo.CreateBlogs(_blogs)).ReturnsAsync(_blogs);
                var result = await _blogsService.CreateBlogs(_blogs);
                if (result != null || result.DateCreated !=null)
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