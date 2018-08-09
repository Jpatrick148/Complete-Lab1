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

            try
            {
                
            while (true)
            {
                Console.WriteLine("Please Enter 2 Numbers ");
                num1 = Console.ReadLine();
                num2 = Console.ReadLine();


                if (num1.Length == num2.Length)
                {
                    if (TotalNumericString(num1) == TotalNumericString(num2))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else

                {
                    Console.WriteLine("The numbers must be the same length. Try again.");
                }

                while (true)
                {
                    Console.WriteLine("Do you want to run this program again [Y/N] ?");
                    string answer = Console.ReadLine().ToUpper();
                    if (answer == "Y")
                        break;
                    if (answer == "N")
                        return;
                }
            }            
                int TotalNumericString(string str)
                {
                    int total = 0;
                    for (int i = 0; i < str.Length; i++)
                    {
                        char c = str[i];
                        total += Convert.ToInt32(c.ToString());

                    }
                    return total;
                }
            }
            catch (Exception ex)
            {
                while (true)
                {
                    Console.WriteLine( "Please Use Whole Numbers \nDo you want to run this program again [Y/N] ?");
                    string answer = Console.ReadLine().ToUpper();
                    if (answer == "Y")
                        break;
                    if (answer == "N")
                        return;
                }
            }
            
        }
    }
}