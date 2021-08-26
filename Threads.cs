using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Collection
{
    class Threads
    {
        static void Thread()
        {

            // Creating and initializing thread
            Thread thr = new Thread(Mythread);
            thr.Start();
            Console.WriteLine("Main Thread Ends!!");
        }

        // Static method
        static void Mythread()
        {
            for (int c = 0; c <= 3; c++)
            {

                Console.WriteLine("mythread is in progress!!");
                 Threads.Sleep(1000);
            }
            Console.WriteLine("Mythread ends!!");
        }

        private static void Sleep(int v)
        {
            throw new NotImplementedException();
        }
    }
}
