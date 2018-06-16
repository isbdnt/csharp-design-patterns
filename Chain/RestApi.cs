using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain
{
    class RestApi : IMiddleware
    {
        public Task<bool> Handle(Request request, Response response)
        {
            response.Json($"{{ \"data\" : \"the data of the api\" }}");
            return Task.FromResult(true);
        }
    }
}
