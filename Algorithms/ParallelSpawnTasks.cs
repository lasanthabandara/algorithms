using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class ParallelSpawnTasks
    {
        public static void ParallelForTest()
        {
            Parallel.For(0, 100000, (i) =>
            {
                WorkLoad(i.ToString());
            });
        }

        public static void TaskTest()
        {
            Task.Run(() => WorkLoad("A"));
            Task.Run(() => WorkLoad("B"));
            Task.Run(() => WorkLoad("C"));
            Task.Run(() => WorkLoad("D"));
        }

        public static void SpawnTest()
        {
            (new Thread(() => WorkLoad("A"))).Start();
            (new Thread(() => WorkLoad("B"))).Start();
            (new Thread(() => WorkLoad("C"))).Start();
            (new Thread(() => WorkLoad("D"))).Start();
        }

        private static void WorkLoad(string name)
        {
            while (true)
            {
                Console.WriteLine("run " + name + "\t\t:\t\t"
                    + Process.GetCurrentProcess().Threads.Count
                    + "\t\t:\t\t" + Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(1000);
            }
        }
    }
}
