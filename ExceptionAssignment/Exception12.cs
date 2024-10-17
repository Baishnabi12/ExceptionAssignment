using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionAssignment
{
    using System;

    class Programs
    {
        static void Main()
        {
            int attempts = 0;
            while (attempts < 3)
            {
                try
                {
                    Console.Write("Enter an integer: ");
                    int number = int.Parse(Console.ReadLine());
                    Console.WriteLine($"You entered: {number}");
                    break; // Exit loop if input is valid
                }
                catch (FormatException)
                {
                    attempts++;
                    Console.WriteLine($"Invalid input. Attempts left: {3 - attempts}");
                }
            }
            if (attempts == 3)
            {
                Console.WriteLine("Exceeded maximum attempts.");
            }
        }
    }

}
