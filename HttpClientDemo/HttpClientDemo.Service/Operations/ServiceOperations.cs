using System;
using System.Net;
using System.Net.Http;

namespace HttpClientDemo.Service.Operations
{
    public class ServiceOperations : IService
    {
        public string Host { get; set; }
        public HttpStatusCode HttpStatusCode { get; private set; }
        public string Token { get; set; }

        public string Get(string address)
        {
            
            string url = string.Format("{0}/{1}", Host, address);
            string result = string.Empty;
            using (HttpClient client = new HttpClient())
            {
                if (!string.IsNullOrEmpty(Token))
                {
                    client.DefaultRequestHeaders.Add("Authorization", Token);
                }
                client.DefaultRequestHeaders.Add("Accept", "application/json");

                var response = client.GetAsync(url).Result;
                HttpStatusCode = response.StatusCode;

                result = response.Content.ReadAsStringAsync().Result;
            }
            return result;
        }

        public string Post(string address)
        {
            throw new NotImplementedException();
        }

        public string Put(string address)
        {
            throw new NotImplementedException();
        }

        public string Delete(string address)
        {
            throw new NotImplementedException();
        }
    }
}
