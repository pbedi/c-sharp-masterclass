using System;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;

namespace _16_Threads_CH158
{
    class Program
    {
        static void Main(string[] args)
        {
            //set thread in background
            new Thread(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Background thread");
            })
            { IsBackground = true }.Start();
            Enumerable.Range(0, 10).ToList().ForEach(f =>
            {
                ThreadPool.QueueUserWorkItem(o =>
                {
                    Console.WriteLine($"Thread number: {Thread.CurrentThread.ManagedThreadId} started");

                    Thread.Sleep(3000);

                    Console.WriteLine($"Thread number: {Thread.CurrentThread.ManagedThreadId} ended");
                });
            });

            Console.ReadLine();
        }
    }
}
