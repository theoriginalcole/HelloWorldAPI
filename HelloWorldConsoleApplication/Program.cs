using RestSharp;
using HelloWorldConsoleApplication.Services;
using System;

namespace HelloWorldConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloWorldWebService webService = new HelloWorldWebService(new RestClient(), new RestRequest());
            var data = webService.getHelloWorld();
            Console.Write(data);

        }
    }
}
