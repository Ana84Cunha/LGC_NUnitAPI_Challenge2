using NUnit.Framework;
using RestSharp;

namespace APITestingChallenge
{
    public class CreatePostTests
    {
        private RestClient _client;

        [SetUp]
        public void Setup()
        {
            _client = new RestClient("https://jsonplaceholder.typicode.com");
        }
        [Test]
        public void CreatePost_ShouldReturnNewPost()
        {
            var request = new RestRequest("/posts", Method.Post);
            request.AddJsonBody(new 
            { 
                userId = 2, 
                title = "This is a New Post Title",
                body = "New post content"
            });

            var response = _client.Execute(request);

            Assert.That((int)response.StatusCode, Is.EqualTo(201));
            Assert.That(response.Content.Contains("\"userId\": 1"));
            Assert.That(response.Content.Contains("\"title\": \"This is a New Post Title\""));
            Assert.That(response.Content.Contains("\"body\": \"New post content\""));
        }
    }
}
