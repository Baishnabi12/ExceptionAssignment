using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionAssignment
{
   
    class exception
    {
        static void Main()
        {
            try
            {
                string text = "Hello, World!";
                Console.Write("Enter start index: ");
                int startIndex = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter length: ");
                int length = Convert.ToInt32(Console.ReadLine());

                string sub = text.Substring(startIndex, length);
                Console.WriteLine($"Substring: {sub}");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("The start index or length is out of range.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter valid numbers.");
            }
        }
    }

}
