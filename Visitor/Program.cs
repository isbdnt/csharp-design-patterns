using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            // emulate 1+2+3
            var e = new Addition(
              new Addition(
                new Literal(1),
                new Literal(2)
              ),
              new Literal(3)
            );
            var sb = new StringBuilder();
            var expressionPrinter = new ExpressionPrinter(sb);
            e.Accept(expressionPrinter);
            Console.WriteLine(sb);
        }
    }
}
