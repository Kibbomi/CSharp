using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace CSharp
{
    class AsyncAwait_Simple
    {
        //like task.. Task.Run( THIS FUNCTION )
        public static async Task<int> DoSomethingAsync(int v)
        {
            await Task.Delay(3000);

            v *= 10;

            await Task.Delay(3000);

            return v * 10;
        }

        
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            Task<int> t = DoSomethingAsync(1);
            t.Wait();

            Console.WriteLine(t.Result);
            sw.Stop();
            Console.WriteLine("Time : " + sw.ElapsedMilliseconds + " ms");

        }
    }
}
 