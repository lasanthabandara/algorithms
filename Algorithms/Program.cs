using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //ParallelForTest();
            TaskTest();
            //SpawnTest();
            Console.ReadKey();
        }

        static void ParallelForTest()
        {
            Parallel.For(0, 100000, (i) =>
            {
                var a = i + 1;
                Console.WriteLine("run " + Process.GetCurrentProcess().Threads.Count);
            });
        }

        static void TaskTest()
        {
            Task.Run(() => WorkLoad("A"));
            Task.Run(() => WorkLoad("B"));
            Task.Run(() => WorkLoad("C"));
            Task.Run(() => WorkLoad("D"));
        }

        static void SpawnTest()
        {
            (new Thread(() => WorkLoad("A"))).Start();
            (new Thread(() => WorkLoad("B"))).Start();
            (new Thread(() => WorkLoad("C"))).Start();
            (new Thread(() => WorkLoad("D"))).Start();
        }

        static void WorkLoad(string name)
        {
            while (true)
            {
                var a = 1 + 1;
                Console.WriteLine("run " + Process.GetCurrentProcess().Threads.Count + " " + Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(1000);
            }
        }
    }
}
