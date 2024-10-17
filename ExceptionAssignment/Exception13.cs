using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionAssignment
{
    using System;

    class Program13
    {
        static void Main()
        {
            int invalidAttempts = 0;
            while (invalidAttempts < 3)
            {
                Console.Write("Enter password: ");
                string password = Console.ReadLine();
                if (password != "password123") // Simulated password check
                {
                    invalidAttempts++;
                    if (invalidAttempts == 3)
                    {
                        throw new InvalidOperationException("Too many invalid login attempts.");
                    }
                    Console.WriteLine("Invalid password. Try again.");
                }
                else
                {
                    Console.WriteLine("Access granted.");
                    break;
                }
            }
        }
    }

}
