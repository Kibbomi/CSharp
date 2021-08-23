using System;
using System.Threading;

namespace CSharp
{
    class ThreadLock
    {
        public static int cnt = 0;
        private static readonly object thisLock = new object();

        public static void Func()
        {
            try
            {
                for (int i = 1; i <= 500000; ++i)
                {
                    lock (thisLock)
                    {
                        ++cnt;
                    }

                    //Monitor.Enter(thisLock), Monitor.Exit(thisLock)도 있음. 
                }
            }
            catch (ThreadInterruptedException e)
            {
                Console.WriteLine(e.Message);
            }
           
        }

        static void Main(string[] args)
        {

            Thread t1 = new Thread(new ThreadStart(Func));
            Thread t2 = new Thread(new ThreadStart(Func));
            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();

            Console.WriteLine(cnt);

            
        }
    }
}
