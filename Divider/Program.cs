using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Divider
{
    class Program
    {
        static int[] divider(int a)
        {
            List<int> b = new List<int>();
            for (int i = 1; i < ((int)Math.Sqrt(a))+1; i++)
            {
                if (a % i == 0)
                {
                    b.Add(i);
                    if (!b.Contains(a/i))
                    {
                        b.Add(a / i);
                    }
                }
            }
            b.Sort();
            return b.ToArray();
        }

        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            string a = "0";
            //a = Console.ReadLine();
            int b = int.MaxValue;//Int32.Parse(a);
            int[] c = divider(100);
            foreach(int k in c)
            {
                Console.WriteLine(k.ToString());
            }
            sw.Stop();
            TimeSpan e = sw.Elapsed;
            Console.WriteLine(e);
            Console.Read();
        }
    }
}
