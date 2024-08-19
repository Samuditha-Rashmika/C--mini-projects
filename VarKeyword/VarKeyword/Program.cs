using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            var age = 23;
            Console.WriteLine(age);
            
            Console.WriteLine();

            var bignumber = 9000000000000L;
            Console.WriteLine(bignumber);
           
            Console.WriteLine();

            var negative = 44.4D;
            Console.WriteLine(negative);
           
            Console.WriteLine();

            var precision = 5.123432F;
            Console.WriteLine(precision);
           
            Console.WriteLine();

            var money = 14.99M;
            Console.WriteLine(money);
            
            Console.WriteLine();

            var name = "Samuditha";
            Console.WriteLine(name);
            Console.WriteLine();

            var letter = 'R';
            Console.WriteLine(letter);
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
