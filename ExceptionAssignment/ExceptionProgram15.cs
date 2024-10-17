using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionAssignment
{
    class ExceptionProgram15
    {



        static void Main()
        {
            try
            {
                try
                {
                    throw new Exception("Original exception");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Caught: {ex.Message}");
                    throw; // Rethrow the caught exception
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Rethrown exception: {ex.Message}");
            }


        }
    }
}
    

