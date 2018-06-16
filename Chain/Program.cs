using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain
{
    class Program
    {
        static void Main(string[] args)
        {
            App app = new App();
            app.Use(new StaticFile());
            app.Use(new RestApi());

            app.HandleRequest(new Request()
            {
                Path = "the/path/of/the/static/file.jpg",
            });

            app.HandleRequest(new Request()
            {
                Path = "the/path/of/the/api",
            });

            Console.ReadKey();
        }
    }
}
