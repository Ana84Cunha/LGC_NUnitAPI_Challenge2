using NUnit.Framework;
using RestSharp;

namespace APITestingChallenge
{
    public class DeletePostTests
    {
        private RestClient _client;

        [SetUp]
        public void Setup()
        {
            _client = new RestClient("https://jsonplaceholder.typicode.com");
        }

        [TearDown]
        public void TearDown()
        {
            _client?.Dispose();
        }

        [Test]
        public void DeletePost_ShouldReturnSuccess()
        {
            var request = new RestRequest("/posts/1", Method.Delete);

       
        // Check if the response status code is either 200 or 204
        Assert.That((int)response.StatusCode, Is.OneOf(200, 204))