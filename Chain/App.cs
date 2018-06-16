using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain
{
    class App
    {
        List<IMiddleware> middlewares = new List<IMiddleware>();

        public void Use(IMiddleware middleware)
        {
            middlewares.Add(middleware);
        }

        public async void HandleRequest(Request request)
        {
            Response response = new Response();
            foreach (var middleware in middlewares)
            {
                if (await middleware.Handle(request, response))
                {
                    break;
                }
            }
        }
    }
}
