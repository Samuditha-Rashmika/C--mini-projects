using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 23;

            //Increment age by one
            age++;

            //Different ways to increment age by 10
            age = age + 10;
            // + _ * /
            age += 10;

            Console.WriteLine(age);

            age--;
            Console.WriteLine(age);

            string name = "Rashmika";
            name += " is a programmer...!!!";
            Console.WriteLine(name);

            char ch = 'a';
            ch += 'b';
            //Displays the Unicode Value
            Console.WriteLine(ch);

            int i = 0;
            //First Increment, then display
            Console.WriteLine(++i);
            //First display, then Increment
            Console.WriteLine(i++);
            Console.WriteLine(i);

            Console.ReadLine();
        }
    }
}
