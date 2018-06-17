using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain
{
    class Response
    {
        public void Send(string body)
        {
            Console.WriteLine(body);
        }
        public void Json(string body)
        {
            Console.WriteLine(body);
        }
    }
}
