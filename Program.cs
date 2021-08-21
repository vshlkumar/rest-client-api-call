using RestSharp;
using System;

namespace RestClientUseApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start RestClient call request.");
            var response = GetCall("http://dummy.restapiexample.com/api/v1/employees");
            var content = response.Content;
            Console.WriteLine(content);
            Console.ReadLine();
        }

        public static IRestResponse GetCall(string url)
        {
            RestClient restClient = new RestClient(url);
            return restClient.Execute(new RestRequest(Method.GET));
        }

        public static IRestResponse GetAPICall()
        {
            RestClient restClient = new RestClient("Endpoint URL");
            var request = new RestRequest(Method.GET);
            request.AddHeader("Cache-Control", "no-cache");
            request.AddHeader("X-Auth-Token", "tokenASDJWIUEASHDUQWYEIQASJDASD"); //add the token if service needs any authentication
            request.AddParameter("Id", "1234");

            return restClient.Execute(request);
        }

        public static IRestResponse PostAPICall()
        {
            RestClient restClient = new RestClient("Endpoint URL");
            var request = new RestRequest(Method.POST);
            request.AddHeader("Cache-Control", "no-cache");
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("X-Auth-Token", "tokenASDJWIUEASHDUQWYEIQASJDASD"); //add the token if service needs any authentication
            request.AddParameter("student", new { Name = "Vishal" }, ParameterType.RequestBody);

            return restClient.Execute(request);
        }
    }
}
