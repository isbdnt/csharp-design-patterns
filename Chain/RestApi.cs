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
            if (request.Path == "the/path/of/the/api")
            {
                response.Json($"{{ \"data\" : \"the data of the api\" }}");
                return Task.FromResult(true);
            }
            else
            {
                return Task.FromResult(false);
            }
        }
    }
}
