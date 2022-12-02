using Microsoft.AspNetCore.Routing;
using Newtonsoft.Json;
using NUnit.Framework;
using System.Net;
using System.Text;

namespace ForumApp_BackEnd.Test.Controller
{
    [TestFixture]
    public class ControllerTest
    {
        private HttpClient _client;

        [SetUp]
        public void SetUp()
        {
            // Create an instance of the HttpClient class
            _client = new HttpClient();
        }

        [Test]
        public void DoSomething_ShouldReturnOk()
        {
            // Arrange
            var requestBody = new
            {
                SomeProperty = "some value"
            };
            var content = new StringContent(
                JsonConvert.SerializeObject(requestBody),
                Encoding.UTF8,
                "application/json");

            // Act
            var response = _client.PostAsync("/api/do-something", content).Result;

            // Assert
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
