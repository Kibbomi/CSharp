using System;
using System.Threading;

namespace CSharp
{
    class Thread_
    {
        public static void Func()
        {
            try
            {
                for (int i = 1; i <= 50; ++i)
                {
                    Console.WriteLine($"Thread : {i}");
                    if (i % 5 == 0)
                        Thread.Sleep(10);
                }
            }
            catch (ThreadInterruptedException e)
            {
                Console.WriteLine(e.Message);
            }
           
        }

        static void Main(string[] args)
        {

            #region Thread1,, original

            Thread t1 = new Thread(new ThreadStart(Func));
            t1.Start();

            for (int i = 1; i <= 50; ++i)
                Console.WriteLine($"Main : {i}");

            t1.Join();

            #endregion



            #region Interrupt Thread

            Thread t2 = new Thread(new ThreadStart(Func));
            t2.Start();
            t2.Interrupt(); //it make thread stop when thread is sleeping.
            t2.Join();


            #endregion

        }
    }
}
