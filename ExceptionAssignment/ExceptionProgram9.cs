using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionAssignment
{
    class Test
    {
        static void Main()
        {
            try
            {
                Console.Write("Enter a number: ");
                int num = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter a divisor: ");
                int divisor = Convert.ToInt32(Console.ReadLine());

                int result = num / divisor;
                Console.WriteLine($"Result: {result}");

                int[] array = { 1, 2, 3 };
                Console.Write("Enter an index for the array: ");
                int index = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Array value: {array[index]}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Division by zero is not allowed.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Input was not a valid number.");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Index is out of bounds of the array.");
            }
        }
    }

}
