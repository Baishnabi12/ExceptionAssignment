using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionAssignment
{
    using System;

    class UnderageException : Exception
    {
        public UnderageException(string message) : base(message) { }
    }

    class Pro
    {
        static void Main()
        {
            try
            {
                Console.Write("Enter your age: ");
                int age = Convert.ToInt32(Console.ReadLine());

                if (age < 18)
                {
                    throw new UnderageException("You must be at least 18 years old.");
                }

                Console.WriteLine("You are eligible to vote.");
            }
            catch (UnderageException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid age input. Please enter a number.");
            }
        }
    }

}
