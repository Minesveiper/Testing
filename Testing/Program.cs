using System;
using System.IO;
using System.Collections;
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

            //  14.Write a C# program to convert from celsius degrees to Kelvin and Fahrenheit
            /*
            Console.WriteLine("Celsius");
            var celsius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kelvin :  {0}",celsius +273);
            Console.WriteLine("Fahrenheit : {0}",celsius * 18 / 10 + 32);
            */

            //  15. Write a C# program remove specified a character from a non-empty string using index of a character
            /*
            var input = "Andre Samuelsen Nilsen";
            var input2 = "w3resource";
            Console.WriteLine(input.Remove(6,9)); // Andre  Nilsen
            Console.WriteLine("Andre S. Nilsen".Remove(6,9)); //Andre
            Console.WriteLine(input2.Remove(1, 1));
            Console.WriteLine(input2.Remove(9, 1));
            Console.WriteLine(input2.Remove(0, 1));
            */


            //  16. Write a C# program to create a new string from a given string where the first and last characters will change their positions.
            /*
            //var w3 = Console.ReadLine();      //swap
            var w3 = "typiskstring";        //swap
            var lengde = w3.Length;

            var final = w3.Substring(w3.Length-1,1) + w3.Substring(1, lengde-2) + w3.Substring(0, 1);

            Console.WriteLine(final);
            */


            /* w3-site code for testing after I finished my code.
            Console.WriteLine(first_last("w3resource"));
            Console.WriteLine(first_last("Python"));
            Console.WriteLine(first_last("x"));

            string first_last(string ustr)
            {
                return ustr.Length > 1  //if ustr is longer than 1 char: Dostuff, else print ustr.
                    ? ustr.Substring(ustr.Length - 1) + ustr.Substring(1, ustr.Length - 2) + ustr.Substring(0, 1) : ustr;
            }

            Console.WriteLine(first_last(w3));
            */


            //  17. Write a C# program to create a new string from a given string (length 1 or more ) with the first character added at the front and back.
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


            //  18. Write a C# program to check two given integers and return true if one is negative and one is positive.
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


            //  20. Write a C# program to get the absolute value of the difference between two given numbers.
            //  Return double the absolute value of the difference if the first number is greater than second number.
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


            //  22. Write a C# program to check if an given integer is within 20 of 100 or 200.
            /*
            Console.WriteLine("\nInput an integer:");
            int intager = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(result(intager));

            if(intager > 79 && intager < 121 || intager > 179 && intager < 221)
            {
                Console.WriteLine(true);
            }
            else Console.WriteLine(false);
            */

            // w3 site code for checking.
            //Console.WriteLine("\nInput an integer:");
            //int x = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(result(x));


            //  23. Write a C# program to convert a given string into lowercase.
            /*
            string input = Console.ReadLine().ToLower();
            Console.WriteLine(input);
            */


            //  24. Write a C# program to find the longest word in a string.
            /*
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
            */


            //  21. Write a C# program to check the sum of the two given integers
            //  and return true if one of the integer is 20 or if their sum is 20. 
            /*
            Console.WriteLine("int1:");
            int int1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("int2:");
            int int2 = Convert.ToInt32(Console.ReadLine());

            var sum = int1 + int2;

            // Skriv ut bool for de tre forkjellige mulighetan. Hvis 1 2 eller 3 e sann så e d true. Hvis ingen e true e d false.
            Console.WriteLine(int1 == 20 || int2 == 20 || (sum == 20)); // Not my code. But loved the solution.
            */

            // Had to use breakpoints to find out how this worked. Actually surprised it was made understandable.
            //int n = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;
            /* while (n != 0)
             {
                 sum += n % 10;
                 n /= 10;
             }
             Console.WriteLine("Sum of the digits of the said integer: " + sum);
             */


            //    28.Write a C# program to reverse the words of a sentence.
            /*
            var sentence = "Display the pattern like pyramid using the alphabet.";

            string[] words = sentence.Split(' ');
            Stack stækk = new Stack();

            foreach (string word in words)
            {
                stækk.Push(word);
            }

            while(stækk.Count > 0)
            {
                Console.WriteLine(stækk.Pop());
            }
            */


            //  30.Write a C# program to convert a hexadecimal number to decimal number.
            /*
            var bitValue = "11110111";
            var hexValue = "10DA";

            int interValue = Convert.ToInt32(bitValue, 2); // 2base system. 0-1 Binary.
            int integerValue = Convert.ToInt32(hexValue, 16); // 16base number system. 1-F HEX


            Console.WriteLine(interValue);
            Console.WriteLine(integerValue);
            */

            //  33. Write a C# program to check if a given positive number is a multiple of 3 or a multiple of 7
            /*
            Console.WriteLine("a :");
            int a = Convert.ToInt32(Console.ReadLine());

            if(a % 3 == 0 | a % 7 == 0)
            {
                Console.WriteLine(true);
            }
            else Console.WriteLine(false);
            */


            //  34. Write a C# program to check if a string starts with a specified word.
            //  Note: Suppose the sentence starts with "Hello"
            /*
            string hallo = "Hello how are you?";

            if (hallo.StartsWith("Hello"))
            {
                Console.WriteLine(true);
            }
            else Console.WriteLine(false);
            */

            //  39. Write a C# program to find the largest and lowest values from three integer values.
            /*
            var tall1 = Convert.ToInt32(Console.ReadLine());
            var tall2 = Convert.ToInt32(Console.ReadLine());
            var tall3 = Convert.ToInt32(Console.ReadLine());


            int størst = Math.Max(tall1, Math.Max(tall2, tall3)); //neat
            int minst = Math.Min(tall1, Math.Min(tall2, tall3));
            //Math.Max(tall1, tall2);  // messy
            //Math.Max(tall2, tall3);
            Console.WriteLine("Largest: " + størst);
            Console.WriteLine("Smallest: " + minst);
            */


            //  40. Write a C# program to check the nearest value of 20 of two given integers
            //  and return 0 if two numbers are same.
            /*
            Console.WriteLine("input 2 integers.");
            var tall1 = Convert.ToInt32(Console.ReadLine());
            var tall2 = Convert.ToInt32(Console.ReadLine());

            int diff1 = Math.Abs(tall1 - 20);
            int diff2 = Math.Abs(tall2 - 20);

            if(diff1 > diff2)
            {
                Console.WriteLine($"{tall2} is closer to 20 than {tall1}");
            }
            else
            {
                Console.WriteLine($"{tall1} is closer to 20 than {tall2}");
            }
            */

            //  41. Write a C# program to check if a given string contains ‘w’ character between 1 and 3 times.
            //Test Data:
            //Input a string(contains at least one 'w' char) : w3resource
            //Test the string contains 'w' character between 1 and 3 times:
            /*
            string input = "world wide web weavers";

            //Console.WriteLine(input.Contains('w'));

            char[] charray = new char[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                charray[i] = input[i];
            }

            int counter = 0;

            foreach (char bokstav in charray)
            {
                if (bokstav.Equals('w'))
                {
                    counter++;
                }
            }
            Console.WriteLine("There are {0} 'w' inside the '{1}' string",counter, input);
            Console.WriteLine("The statement is: " + (counter > 0 && counter < 4));
            */

            //  42. Write a C# program to create a new string where the first 4 characters will be in lower case.
            //  If the string is less than 4 characters then make the whole string in upper case. 
            /*
            var stringeling =Console.ReadLine();

            if(stringeling.Length > 4)
            {
                Console.WriteLine(stringeling.Substring(0, 4).ToLower() + stringeling.Substring(4));
            }
            else
            {
                Console.WriteLine(stringeling.ToUpper());
            }
            */

            //  43.Write a C# program to check if a given string starts with "w" and immediately followed by two "ww"
            /*
            string sample = "w ww ww string";

            string nospace = sample.Replace(" ", string.Empty);

            Console.WriteLine(nospace.StartsWith("wwwww"));
            */

            //  44. Write a C# program to create a new string of every other character
            //  (odd position) from the first position of a given string
            /*
            var full = "IWillMakeANewStringOfEveryOtherCharacter.";
            int lengde = full.Length;
            string oddString = "";


            for(int i = 0; i < lengde; i++) 
            {
                if (i % 2 == 0)
                {
                    oddString += full[i];
                }
            }
            Console.WriteLine(oddString);
            */

            //  45. Write a C# program to count a specified number in a given array of integers.
            /*
            int[] arra = { 7,6,7,4,7,9 };

            Console.WriteLine("Insert number to search for in array:");
            int search = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(arra.Count(n => n == search));
            */

            //  46.Write a C# program to check if a number appears as either the first or
            //  last element of an array of integers and the length is 1 or more.
            /*
            Console.WriteLine("What integer to scan for?");
            int search = Convert.ToInt32(Console.ReadLine());

            int[] arra = { 7, 6, 7, 4, 7, 9 };

            Console.WriteLine(arra[0] == search || arra[arra.Length -1] == search);
            */

            //  50. Write a C# program to rotate an array (length 3) of integers in left direction.
            /*
            int[] arra = { 7, 6, 7, 4, 7, 9 };
            var temp = arra[0];

            for (int i = 0; i < arra.Length -1; i++)
            {
                arra[i] = arra[i + 1];
            }
            arra[arra.Length - 1] = temp;

            Console.Write("Array now holds: ");
            foreach (var item in arra)
            {
                Console.Write($"{item}, ");
            }
            */

            //  51.Write a C# program to get the larger value between first and
            //  last element of an array (length 3) of integers.
            /*
            int[] array1 = { 1, 2, 5, 7, 8 };

            int max = 0;

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[ i ] > max)
                {
                    max = array1[i];
                }
            }

            Console.WriteLine("Maxvalue in the array is {0}.", max);
            */


            //  58.Write a C# program which will accept a list of integers and checks how many
            //  integers are needed to complete the range. Go to the editor
            //  Sample Example[1, 3, 4, 7, 9], between 1 - 9-> 2, 5, 6, 8 are not present in the list.
            //  So output will be 4.
            /*
            int[] array = {1, 3, 4, 7, 9};
            Array.Sort(array);

            int counter = 0;

            for (int i = array.Min(); i < array.Max(); i++)
            {
                if (!array.Contains(i))
                {
                    counter++;
                }

            }

            Console.WriteLine("Number of integers missing for complete chain is: " + counter);
            */


            //  64. Write a C# Sharp program to get the file name (including extension) from a given path.
            /*
            string filePath;
            filePath = "c:/csharp/ex/test.cpp";
            
            Console.WriteLine(Fila(filePath));

            filePath = @"E:\Unreal Tournament GOTY\System\editorres\TexturePan.bmp";
            
            Console.WriteLine(Fila(filePath));
            */


            //  67. Write a C# Sharp program to create a coded string from a given string, using specified formula.
            //  Replace all 'P' with '9', 'T' with '0', 'S' with '1', 'H' with '6' and 'A' with '8'.
            //  Sample Output: 969 J8V81CRI90

            var decoded = "This will be alphabetsoup after encoding. abcdefghijklmnopqrstuvwxyzæøå";

            string[] array1;

            foreach (char bokstav in decoded)
            {
                Encoder(bokstav);
                
            }

            
            





        }


        public static char Encoder(char bokstav)
        {
            switch (bokstav)
            {
                case 'a':
                case 'A':
                    {
                        return '8';
                    }
                case 't':
                case 'T':
                    {
                        return '0';
                    }
                case 'p':
                case 'P':
                    {
                        return '9';
                    }
                case 's':
                case 'S':
                    {
                        return '1';
                    }
                case 'h':
                case 'H':
                    {
                        return '6';
                    }
                default:
                    {
                        return bokstav;
                    }
                    
            }
        }

        public static string Fila(string filePath)
        {
            return Path.GetFileName(filePath);
            
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
