using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionAssignment
{
    class ExceptionProgram19
    {
        
        static void Main(string[] args)
        {
            try
            {
                if (args.Length < 2)
                {
                    throw new ArgumentException("At least two arguments are required.");
                }
                Console.WriteLine($"Argument 1: {args[0]}");
                Console.WriteLine($"Argument 2: {args[1]}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }

}

