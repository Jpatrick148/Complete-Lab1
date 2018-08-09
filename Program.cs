using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            string num1, num2;
            int total1 = 0;

            Console.WriteLine("Please Enter 2 Numbers ");
            num1 = Console.ReadLine();
            num2 = Console.ReadLine();


            if (num1.Length == num2.Length)

                for (int i = 0; i < num1.Length; i++)
                {
                    char c = num1[i];
                    total1 += Convert.ToInt32((string)c);
                }

            else

            {
                Console.WriteLine("The numbers must be the same length. Try again.");
            }
            Console.WriteLine(total1);
            Console.ReadLine();

        }
    }
        public int totalNumericString(string s)
        {
            int total = 0;
            for (int i = 0; i < num1.Length; i++)
            {
                char c = num1[i];
                total += Convert.ToInt32((string)c);
            }
            return total;
        }

}