﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Url url = new UrlBuilder()
                .Protocol("http")
                .Domain("www.test.com")
                .Path("the/path")
                .Parameter("p1", "csharp")
                .Parameter("p2", "cpp")
                .Build();

            Console.WriteLine(url.Value);

            url = new UrlBuilder()
               .Protocol("https")
               .Domain("www.test2.com")
               .Path("the/path2")
               .Build();

            Console.WriteLine(url.Value);
        }
    }
}
