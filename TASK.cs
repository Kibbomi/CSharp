using System;
using System.Threading.Tasks;

namespace CSharp
{
    class TASK
    {
        public static int cnt = 0;
        private static readonly object myLock = new object();
        

        static void Main(string[] args)
        {

            
            //The Action delegate have not to has any parameters!!
            //when the parameters exist, first, declare Action delegate which has no parameters,
            //and Call method(Function) in that Action delegate(Anonymous method)
            /*
            * Task t = Task.Run(
            ()=>{doSomething(arg1, arg2, arg3...);}
            );
            *
            */
            #region No return value, --> use Action delegate
            //Task t1 = new Task( Action (anonymous function) ),,,,, t1.start() OK;    
            Task t1 = Task.Run(() =>
            {
                for (int i = 1; i <= 500000; ++i)
                {
                    lock(myLock)
                        ++cnt;
                }
            });
            Task t2 = Task.Run(() =>
            {
                for (int i = 1; i <= 500000; ++i)
                {
                    lock (myLock)
                        ++cnt;
                }
            });

            t1.Wait();
            t2.Wait();

            Console.WriteLine(cnt);
            #endregion


            #region Task which has return value
            Task<int> t3 = Task<int>.Run(()=>
            {
                int val = 0;
                for (int i = 1; i <= 500000; ++i)
                    ++val;

                return val;
            });
            t3.Wait();
            Console.WriteLine(t3.Result);
            #endregion
        }
    }
}
