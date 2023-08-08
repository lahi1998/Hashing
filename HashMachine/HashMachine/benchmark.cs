using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashMachine
{
    internal class benchmark
    {
        private static void RunBenchmark(Action benchmarkMethod, string methodName)
        {
            long startTime = DateTime.Now.Ticks;
            benchmarkMethod();
            long endTime = DateTime.Now.Ticks;
            long elapsedTime = endTime - startTime;
            Console.WriteLine($"{methodName} tid (ticks): {elapsedTime}");
        }
    }
}
