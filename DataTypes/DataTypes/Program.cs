using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = 10,
                y = 20, 
                z = 30;



            //initialize the veriable 
            int age = 23;
            Console.WriteLine(age);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);
            Console.WriteLine();

            long bignumber = 9000000000000L;
            Console.WriteLine(bignumber);
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(long.MinValue);
            Console.WriteLine();

            double negative = 44.4D;
            Console.WriteLine(negative);
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue);
            Console.WriteLine();

            float precision = 5.123432F;
            Console.WriteLine(precision);
            Console.WriteLine(float.MaxValue);
            Console.WriteLine(float.MinValue);
            Console.WriteLine();

            decimal money = 14.99M;
            Console.WriteLine(money);
            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(decimal.MinValue);
            Console.WriteLine();


            //assign the value 

            age = 100;

            Console.ReadLine();
        }
    }
}
