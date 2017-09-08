using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpClientDemo.Service.Operations
{
    public interface IServiceAsync
    {
        Task<string> GetAsync(string address);
    }
}
