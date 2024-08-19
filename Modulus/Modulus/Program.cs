using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulus
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = 10;
            int secondNum = 3;

            Console.WriteLine(firstNum / secondNum);

            //10 / 3 = reminder1
            //3 x 3 = 9 , 1 left over to get 10
            Console.WriteLine(firstNum % secondNum);
            Console.WriteLine(1000 % 90);
            Console.WriteLine(100 % 90);
            Console.WriteLine(71 % 10);

            Console.ReadLine();
        }
    }
}
