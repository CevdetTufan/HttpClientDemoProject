using HttpClientDemo.Service.Operations;
using System;

namespace HttpClientDemo.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceOperations service = new ServiceOperations();
            service.Host = "host";

            string token = "token";
            service.Token = string.Format("bearer {0}", token);

            string result = service.Get("method_address");

            Console.WriteLine(service.HttpStatusCode);
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
