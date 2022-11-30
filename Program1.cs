using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soal1_with_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter the amount of salary you get : ");
            int salary = Convert.ToInt32(Console.ReadLine());
            if (salary >= 0 && salary < 100000000)
            {
                Console.WriteLine("darsad maliat = " + maliat(salary));
            }
            else Console.WriteLine("the number is out of rate!");
            Console.ReadKey();
        }
        private static int maliat(int x)
        {
            if (x >= 0 && x <= 483000) return 0;
            else if (x > 483000 && x <= 600000) return 10;
            else if (x > 600000 && x <= 1000000) return 15;
            else if (x > 1000000 && x <= 2000000) return 20;
            else if (x > 2000000 && x < 100000000) return 30;
            return -1;
        }
    }
}
