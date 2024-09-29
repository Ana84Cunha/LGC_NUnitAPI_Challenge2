using NUnit.Framework;
using RestSharp;

namespace APITestingChallenge
{
    public class UpdatePostTests
    {
        private RestClient _client;

        [SetUp]
        public void Setup()
        {
            _client = new RestClient("https://jsonplaceholder.typicode.com");
        }
        [Test]
        public void UpdatePost_ShouldReturnUpdatedPostDetails()
        {
            var request = new RestRequest("/posts/1", Method.Put);

            request.AddJsonBody(new 
            { 
                userId = 1, 
                title = "Updated Title", 
                body = "Updated content" 
            });

            var response = _client.Execute(request);

            Assert.That((int)response.StatusCode, Is.EqualTo(200));

            // Check if the response contains the updated fields
            Assert.That(response.Content.Contains("\"userId\": 1"));
            Assert.That(response.Content.Contains("\"title\": \"Updated Title\""));
            Assert.That(response.Content.Contains("\"body\": \"Updated content\""));
        }
    }
}