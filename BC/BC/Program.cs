using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            /*
            if(args.Length == 0 )
            {
                Console.WriteLine("No number provided!");
                return;
            }
             number = int.Parse(args[0]);
            */
      
            Console.WriteLine("Give me a number");
            number = int.Parse(Console.ReadLine());
            while(number<0)
            {
                Console.WriteLine("Give me a positive number");
                number = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The number you provided is: " +number);
            string result = convert(number);
            Console.WriteLine(result);
            Console.ReadKey();       
            
        }

        static string convert(int number)
        {
            int i = 0;
            int[] digits = new int[32];

            while (number / 2 >= 1)
            {
                digits[i] = number % 2;
                number = number / 2;
                i++;
            }
            digits[i] = number;
            string result = "";

            while (i >= 0)
            {
                result = result + digits[i];
                i = i - 1;
            }
            return result;
        }
    }
}
