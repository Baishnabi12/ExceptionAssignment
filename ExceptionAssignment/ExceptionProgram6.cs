using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionAssignment
{
  

    class Program7
    {
        static void Main()
        {
            try
            {
                Console.Write("Enter a large number: ");
                int number = checked(int.Parse(Console.ReadLine())); // Use checked to force overflow
                Console.WriteLine($"You entered: {number}");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow occurred! The number is too large.");
            }
        }
    }

}
