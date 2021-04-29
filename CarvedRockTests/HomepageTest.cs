using NUnit.Framework;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace CarvedRockTests
{
    public class HomePageTest
    {
        public HttpClient HttpClient { get; set; }

        [SetUp]
        public void Setup()
        {
            this.HttpClient = new HttpClient();
        }

        [Test]
        public async Task Homepage_Ok_Response_Code()
        {
            var response = await this.HttpClient.GetAsync("http://ec2-18-133-221-163.eu-west-2.compute.amazonaws.com/");
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }
    }
}