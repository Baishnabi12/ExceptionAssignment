using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionAssignment
{
   

    class Program5
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            try
            {
                string input = Console.ReadLine();
                int number = int.Parse(input);
                Console.WriteLine($"You entered: {number}");
            }
            catch (FormatException)
            {
                Console.WriteLine("That's not a valid number. Please try again.");
            }
        }
    }

}
