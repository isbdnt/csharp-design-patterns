using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain
{
    class StaticFile : IMiddleware
    {
        public async Task<bool> Handle(Request request, Response response)
        {
            if (request.Path.IndexOf('.') != -1)
            {
                string data = await ReadFile(request.Path);
                response.Json($"{{ \"data\" : \"{data}\" }}");
                return true;
            }
            return false;
        }

        async Task<string> ReadFile(string path)
        {
            Console.WriteLine("reading file");
            await Task.Delay(100);
            return "the data of the file";
        }
    }
}
