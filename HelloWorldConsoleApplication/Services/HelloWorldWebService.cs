using System;
using System.Configuration;
using RestSharp;

namespace HelloWorldConsoleApplication.Services
{
    class HelloWorldWebService
    {

        /// <summary>
        ///     The Rest client
        /// </summary>
        private readonly IRestClient restClient;

        /// <summary>
        ///     The Rest request
        /// </summary>
        private readonly IRestRequest restRequest;

        public HelloWorldWebService(
           IRestClient restClient,
           IRestRequest restRequest)
        {
            this.restClient = restClient;
            this.restRequest = restRequest;
        }

        public string getHelloWorld()
        {
            this.restClient.BaseUrl = new Uri(ConfigurationManager.AppSettings.Get("HelloWorldAPIURL"));

            this.restRequest.Resource = "HelloWorld";
            this.restRequest.Method = Method.GET;
            this.restRequest.Parameters.Clear();

            string responseResult;

            var response = this.restClient.Execute(this.restRequest);

            if(response != null)
            {
                if(response.ErrorMessage != null)
                {
                    responseResult = response.ErrorMessage;
                }
                else
                {
                    responseResult = response.Content;
                }
            }
            else
            {
                responseResult = "No data was returned from web service";
            }

            return responseResult;
        }
    }
}
