using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionAssignment
{
    internal class Program3
    {
        static void Main()
        {
            int[] numbers = { 10, 20, 30, 40, 50 };
            Console.Write("Enter an index (0-4): ");
            try
            {
                int index = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Value at index {index}: {numbers[index]}");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Index is out of range. Please enter a valid index.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }

}

