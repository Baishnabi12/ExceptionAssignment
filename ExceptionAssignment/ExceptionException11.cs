using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionAssignment
{
    using System;

    class Program12
    {
        static void Main()
        {
            try
            {
                try
                {
                    Console.WriteLine("Inner try block. Simulating an error.");
                    throw new FormatException("Simulated format exception.");
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"Inner catch: {ex.Message}");
                    throw; // Rethrow the exception to the outer catch
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Outer catch: {ex.Message}");
            }
        }
    }

}
