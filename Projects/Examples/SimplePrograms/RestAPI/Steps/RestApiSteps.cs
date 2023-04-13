using Newtonsoft.Json;
using NUnit.Framework;
using RestAPI.Context;
using RestSharp;
using TechTalk.SpecFlow;


namespace RestAPI
{
    [Binding]
    class RestApiSteps
    {
        private readonly RestApiContext _context;
         
        public RestApiSteps(RestApiContext context)
        {
            _context = context;
        }

        [Given (@"Get token")]
        public void GetToken() {
            _context.log.Info("Start VerifyLogin test");
            var client = new RestClient($"{_context.ApiUrl}/login");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddParameter("username", "Default");
            request.AddParameter("key", "OnWWxLrYKYGZ75Qjv3262n2ZBZFJM4PfKZr1n4lZ2WtLFWNisIy21uzBGoIQJ8sI6D5IkaEooAPCQkNhN130i0JMlz43KdsbXtP6kF2Nbl4wSDxjaPu3l0IolVCbUSyJQ26TPZ6RwF1hsgJvEo2dtUxdhTrxQbZ4RzVO1TnXMnt0impxJjJ4uALYjsHVaEat7dYSWUFOhmsNH0HHa1fRyL7wdVpOpIgzycQFpKySPt4aQCErhNeLLp55aXjq5RWB");
            IRestResponse response = client.Execute(request);

            string source = response.Content;
            dynamic data = JsonConvert.DeserializeObject(source);

            _context.JsonToken = data.api_token;
            _context.log.Info("api_token = " + data.api_token);
        }

        [When (@"Get Cart ""(.*)""")]
        public void GetCart(int cartId) {
            _context.log.Info("Start ReadCart test");
            var client = new RestClient($"{_context.ApiUrl}/cart/products&api_token=" + _context.JsonToken);
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Cookie", $"OCSESSID={_context.JsonToken}; currency=USD; language=en-gb");
            IRestResponse response = client.Execute(request);
            _context.response = response.Content;
        }

        [Then (@"Cart contains ""(.*)""")]
        public void IsCorrectCartText(string cartText) {
            Assert.True(_context.response.Contains(cartText));
        }

    }
}
