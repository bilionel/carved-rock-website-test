using NUnit.Framework;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace CarvedRockTests
{
    public class PageLoadTest
    {
        public HttpClient HttpClient { get; set; }

        [SetUp]
        public void Setup()
        {
            this.HttpClient = new HttpClient();
        }

        [TestCase("")]
        [TestCase("contact")]
        [TestCase("post/carabiners/")] 
        public async Task Homepage_Ok_Response_Code(string relativePath)
        {
            var response = await this.HttpClient.GetAsync($"http://ec2-18-133-221-163.eu-west-2.compute.amazonaws.com/{relativePath}");
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }
    }
}