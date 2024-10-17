using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionAssignment
{
   

class Program
    {
        static void Main()
        {
            try
            {
                string[] names = null;
                Console.WriteLine(names[0]);  // Attempt to access element of a null array
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine($"Error: {ex.Message} - The array is not initialized.");
            }
        }
    }

}

