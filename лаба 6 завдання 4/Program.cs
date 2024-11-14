using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба_6_завдання_4
{
    internal class Program


    {
        public static void ReverseNumber(int n)
        {
            if (n > 0)
            {
                Console.Write(n % 10);
                ReverseNumber(n / 10);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Input n");
            int n = int.Parse(Console.ReadLine());
            ReverseNumber(n);
            Console.WriteLine();
        }
    }

}
    

