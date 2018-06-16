using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain
{
    interface IMiddleware
    {
        Task<bool> Handle(Request request, Response response);
    }
}
