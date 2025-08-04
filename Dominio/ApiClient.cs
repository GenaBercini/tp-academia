using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public static class ApiClient
    {
        public static readonly HttpClient Instance = new HttpClient()
        {
            BaseAddress = new Uri("http://localhost:5170")
        };
    }
}
