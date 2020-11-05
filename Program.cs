using System;
using System.Diagnostics;

namespace busyloader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting calculations");
            double result=0,baseNumber=24;   

            var sw = new Stopwatch();
            while(true) {
              sw=Stopwatch.StartNew();
              for (var i = Math.Pow(baseNumber, 6); i >= 0; i--) {    
                result += Math.Atan(i) * Math.Tan(i);
              };            
              sw.Stop();
              Console.WriteLine("Time Taken-->{0}ms",sw.ElapsedMilliseconds);
            }
        }
    }
}
