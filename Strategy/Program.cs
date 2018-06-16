using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            StrategyExecutor executor = new StrategyExecutor(new Strategy1());

            executor.Execute();
            executor.ChangeStrategy(new Strategy2());
            executor.Execute();
            executor.ChangeStrategy(new Strategy1());
            executor.Execute();
        }
    }
}
