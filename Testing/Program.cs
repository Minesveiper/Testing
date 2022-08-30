using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            //Convert.ToInt32(Console.ReadLine()
            //int.Parse(Console.ReadLine()
            // var num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Celsius");
            //var celsius = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Kelvin :  {0}",celsius +273);
            //Console.WriteLine("Fahrenheit : {0}",celsius * 18 / 10 + 32);

            /*
            var input = "Andre Samuelsen Nilsen";
            var input2 = "w3resource";
            Console.WriteLine(input.Remove(6,9)); // Andre  Nilsen
            Console.WriteLine("Andre S. Nilsen".Remove(6,9)); //Andre
            Console.WriteLine(input2.Remove(1, 1));
            Console.WriteLine(input2.Remove(9, 1));
            Console.WriteLine(input2.Remove(0, 1));
            */

            /*
            //var w3 = Console.ReadLine();
            var w3 = "typiskstring";
            var lengde = w3.Length;
            
            var final = w3.Substring(w3.Length-1,1) + w3.Substring(1, lengde-2) + w3.Substring(0, 1);

            Console.WriteLine(final);
            */


            /* w3-site koden til test.
            Console.WriteLine(first_last("w3resource"));
            Console.WriteLine(first_last("Python"));
            Console.WriteLine(first_last("x"));

            string first_last(string ustr)
            {
                return ustr.Length > 1
                    ? ustr.Substring(ustr.Length - 1) + ustr.Substring(1, ustr.Length - 2) + ustr.Substring(0, 1) : ustr;
            }

            Console.WriteLine(first_last(w3));
            */

            /*
            var input = "The quick brown fox jumps over the lazy dog.";
            var nystring = input.Substring(0, 1) + input + input.Substring(0, 1);

            Console.WriteLine(nystring);

            var randomstring = Console.ReadLine();
            if(randomstring.Length > 1)
            {
                var finish = randomstring.Substring(0, 1) + randomstring + randomstring.Substring(0, 1);
                Console.WriteLine(finish);
            }
            */

            /*
            Console.WriteLine("nummer1:");
            var nummer1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nummer2:");
            var nummer2 = Convert.ToInt32(Console.ReadLine());

            if (nummer1 > 0 && nummer2 < 0 || nummer1 < 0 && nummer2 > 0) //return true if numbers are both pos and neg.
            {
                Console.WriteLine(true);
            }
            else Console.WriteLine(false);
            */

            /*
            Console.WriteLine("int1:");
            int int1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("int2:");
            int int2 = Convert.ToInt32(Console.ReadLine());


            var sum1 = int1 + int2;
            if(int1 == int2)
            {
                Console.WriteLine("Triple sum: " + sum1 * 3 );
            }
            else Console.WriteLine("Sum of int1 & int2 : " + sum1);
            */

            /*
            Console.WriteLine("int1:");
            int int1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("int2:");
            int int2 = Convert.ToInt32(Console.ReadLine());

            int absolute;
            if (int1 > int2)
            {
                absolute = (int1 - int2) * 2;
            }
            else absolute = int2 - int1;

            Console.WriteLine($"The absolute value of {int1} & {int2} is : " + absolute);
            */

            /*
            Console.WriteLine("\nInput an integer:");
            int intager = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(result(intager));

            if(intager > 79 && intager < 121 || intager > 179 && intager < 221)
            {
                Console.WriteLine(true);
            }
            else Console.WriteLine(false);


            Console.WriteLine("\nInput an integer:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(result(x));
            */


            /*//string to lower fast.
            string input = Console.ReadLine().ToLower();
            Console.WriteLine(input);
            */


            // Find longest word.
            
            string line = "Write a C# Sharp Program to display the following pattern using the alphabet. Supercallifragilisticexpialidocious";

            string[] arrayLine = line.Split(' ', '.');

            string longest = arrayLine[0];

            foreach (var word in arrayLine)
            {
                if(word.Length > longest.Length)
                {
                    longest = word;
                }
            }
            Console.WriteLine("The longest word in the string is: " + longest);
            










        }


        /*
        public static bool result(int n)
        {
            if (Math.Abs(n - 100) <= 20 || Math.Abs(n - 200) <= 20)
                return true;
            return false;









        }
        */
    }
}
