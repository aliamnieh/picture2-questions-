using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soal2_with_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter an integer number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            int haselzarb = 1, digit;
            while(number!=0)
            {
                digit = number % 10;
                if (digit > 5) haselzarb *= digit;
                number /= 10;
            }
            Console.WriteLine("haselzarb argham bozorgtar az 5 = " + haselzarb);
            Console.ReadKey();
        }
    }
}
