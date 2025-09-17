using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintSequence(5,"*");
        }
        public static void PrintSequence(int n,String symbol)
        {
            if (n <= 0)
            {
                return;
            }
            else
            {
                Console.WriteLine(symbol);
                PrintSequence(n-1, symbol);
            }
        }
    }
}
