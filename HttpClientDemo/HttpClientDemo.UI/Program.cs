using HttpClientDemo.Service.Operations;
using System;
using System.Threading.Tasks;

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


            Download(service);


            Console.ReadLine();
        }
        static async void Download(ServiceOperations service)
        {
            var s = await Task.Run(() =>
            {
                return service.GetAsync("OnlinePrice/GetPriceChange");

            });
            Console.WriteLine(s);
        }
    }
}
