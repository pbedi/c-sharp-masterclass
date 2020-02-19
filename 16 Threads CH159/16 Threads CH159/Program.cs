using System;
using System.Threading;
using System.Threading.Tasks;

namespace _16_Threads_CH159
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Thread started");

            Thread thread1 = new Thread(Thread1Function);
            Thread thread2 = new Thread(Thread2Function);
            thread1.Start();
            thread2.Start();

            /*thread1.Join();
            Console.WriteLine("Thread1Function joined");
            */
            if (thread1.Join(1000))
            {
                Console.WriteLine("Thread1Function done");
            }
            else
            {
                Console.WriteLine("Thread1Function wasn't done in 1 sec");
            }
            thread2.Join();
            Console.WriteLine("Thread2Function joined");

            for(int i=0; i < 10; i++)
            {
                if (thread1.IsAlive)
                {
                    Console.WriteLine("Thread1Function is still doing stuff: {0}", i);
                    Thread.Sleep(300);
                } else
                {
                    Console.WriteLine("Thread1Function completed");
                    break;
                }
            }
            
            Console.WriteLine("Main Thread ended");
        }

        public static void Thread1Function()
        {
            Console.WriteLine("Thread1Function started!");
            Thread.Sleep(3000);
            Console.WriteLine("Thread1Function coming back to caller");
        }

        public static void Thread2Function()
        {
            Console.WriteLine("Thread2Function started!");
        }
    }
}
