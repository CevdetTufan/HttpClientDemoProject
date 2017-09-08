
namespace HttpClientDemo.Service.Operations
{
    public interface IService
    {
        string Get(string address);
        string Post(string address);
        string Put(string address);
        string Delete(string address);
    }
}
