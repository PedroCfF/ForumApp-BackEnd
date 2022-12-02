using Microsoft.AspNetCore.Routing;
using Newtonsoft.Json;
using NUnit.Framework;
using System.Net;
using System.Text;
using ForumApp.Controllers;
using ForumApp.Models;

namespace ForumApp_BackEnd.Test.Controller
{
    [TestFixture]
    public class ControllerTest
    {
        private ApiController controller;

        [SetUp]
        public void SetUp()
        {
            controller = new ApiController();
        }

        [Test]
        public void checking()
        {
            int num = 1;
            Assert.AreEqual(1, num);
        }

        [Test]
        public void GetAllThreads_ShouldReturnOk()
        { 
            Assert.IsNotNull(controller.GetAllThreads()); 
            Assert.AreEqual(HttpStatusCode.OK, controller.GetAllThreads().Result);
            
        }

        [Test]
        public void GetAllPosts_ShouldReturnOk()
        { 
            Assert.IsNotNull(controller.GetAllPosts());
            Assert.AreEqual(HttpStatusCode.OK, controller.GetAllPosts().Result);
        }

        [Test]
        public void GetPostsInThread_ShouldReturnOk()
        {
            Assert.IsNotNull(controller.GetAllThreads());
            Assert.AreEqual(HttpStatusCode.OK, controller.GetAllThreads().Result);
        }

        [Test]
        public void CheckifPostExists_ShouldReturnTrue()
        {
            
            //Assert.IsTrue(controller.CheckifPostExists("post 1"));
        }

        [Test]
        public void SavePost_ShouldReturnNull()
        {
            ForumPost post = new ForumPost(25, "post 99", 1, "this is a post with the word palabraCensurada", 2);            

            var content = new StringContent(JsonConvert.SerializeObject(post), Encoding.UTF8, "application/json");

            var response = controller.SavePost(post);

            Assert.IsNull(response);
            Assert.AreEqual(HttpStatusCode.OK, controller.GetAllThreads().Result);
        }
    }
}
