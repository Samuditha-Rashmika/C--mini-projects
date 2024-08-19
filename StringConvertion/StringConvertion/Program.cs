using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringConvertion
{
    class Program
    {
        static void Main(string[] args)
        {
            string textAge = "23";
            int age = Convert.ToInt32(textAge);
            Console.WriteLine(age);
            Console.WriteLine();

            string textBigNumber = "-9000000000000";
            long bignumber = Convert.ToInt64(textBigNumber);
            Console.WriteLine(bignumber);
            Console.WriteLine();

            string textNegative = "44.4";
            double negative = Convert.ToDouble(textNegative);
            Console.WriteLine(negative);
            Console.WriteLine();

            string textPrecision = "5.123432";
            float precision = Convert.ToSingle(textPrecision);
            Console.WriteLine(precision);
            Console.WriteLine();

            string textMoney = "14.99";
            decimal money = Convert.ToDecimal(textMoney);
            Console.WriteLine(money);


            Console.ReadLine();
        }
    }
}
