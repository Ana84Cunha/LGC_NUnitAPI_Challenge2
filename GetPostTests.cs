using NUnit.Framework;
using RestSharp;

namespace APITestingChallenge  
{
    public class APITestingChallengeTests // Class definition
    {
        private RestClient _client;

        [SetUp]
        public void Setup()
        {
            // _client is a private field of type RestClient, which will be used to send HTTP requests in each test.
            // In this Setup method, we are initializing the _client with the base URL of the API we are testing.
            // This is the REST API base URL (https://jsonplaceholder.typicode.com), and _client will be responsible for sending HTTP requests to this API.
            _client = new RestClient("https://jsonplaceholder.typicode.com");
            
        }

        [Test]
        public void GetPost_ShouldReturnPostWithExpectedFields()
        {
            
            // 1. Create a GET request for post ID 1
            var request = new RestRequest("/posts/1", Method.Get);

            // 2. Execute the request and store the response
            var response = _client.Execute(request);

            // 3. Assert the status code is 200
            Assert.AreEqual(200, (int)response.StatusCode);

            // 4. Check the response contains expected data
            Assert.IsTrue(response.Content.Contains("\"userId\": 1"));
            Assert.IsTrue(response.Content.Contains("\"id\": 1"));
        }
    }
}
