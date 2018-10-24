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
           // int a[];
           //int i = 0;
            int number;
            int bin_num = 0;
            bin_num = int.Parse(args[1]);
            if(args.Length == 0 )
            {
                Console.WriteLine("No number provided!");
                return;
            }
            /*
            Console.WriteLine("Give me a number: ");
            string num = Console.ReadLine();
            int bin_num = Int32.Parse(num);
            */
            /*
            while(bin_num / 2 >1 )
            {
                a[i] = bin_num % 2;
                bin_num = bin_num / 2;
                i++;
            }
            Console.WriteLine("The binary number is: ");
            */
        }
    }
}
