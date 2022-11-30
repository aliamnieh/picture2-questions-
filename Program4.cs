using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soal4_with_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a number as n : ");
            int n = Convert.ToInt32(Console.ReadLine());
            function(n);
            Console.ReadKey();
        }
        static void function(int n)
        {
            for (int i = 0; i < n; i++)
                Console.WriteLine("XXXXXXXXXX");
        }
    }
}
