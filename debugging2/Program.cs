using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace debugging2
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                //This project has 5 syntax errors and no logical errors.
                int userInput;

                WriteLine("Enter a 1-multiply\n2-divide");
                userInput = Convert.ToInt32(ReadLine());

                WriteLine("Enter first number");
                double a = Convert.ToString(ReadLine()); //converting string to string
                WriteLine("Enter second Number");
                double b = Convert.ToDouble(ReadLine());

                if (userInput == 1)
                {
                    multNums(a, b); //Multnums is not registering as a method, also they INT and Strings with the method and are doubles in the main
                }
                else if (userInput == 2)
                {
                    divNums(a, b);
                }

                ReadKey();
            }

            static void multNums(int num1, string num2)//these should be doubles
            {
                double total = num1 * num2;
                WriteLine("your total is" + total); //missing quotation mark
            }
            static void divNums(double num1, double num2)
            {

                double total2 = num1 / num2;
                WriteLine("your total is " + total); //total does not excist

            }

        }
    }
    }
}
