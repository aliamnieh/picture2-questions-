using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soal3_with_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("haselzarb argham zoj = " + function(number));
            Console.ReadKey();
        }
        static int function(int x)
        {
            int haselzarb=1,digit;
            while(x!=0)
            {
                digit=x%10;
                if(digit%2==0) haselzarb*=digit;
                x/=10;
            }
            return haselzarb;
        }
    }
}
