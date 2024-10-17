using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionAssignment
{
   

    class ExceptionProgram
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("Enter a number: ");
                try
                {
                    int number = int.Parse(Console.ReadLine());
                    Console.WriteLine($"You entered: {number}");
                }
                catch (FormatException)
                {
                    Console.WriteLine("That's not a valid number. Please try again.");
                }
            }
        }
    }

}
