using System;

class Program
{
    static void Main()
    {
        bool Input = false;
        while (!Input)
        {
            try
            {
                Console.Write("Enter the first number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the second number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                int result = num1 / num2;
                Console.WriteLine($"Result: {result}");
                Input = true;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero. Please try again.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter valid numbers.");
            }
        }
    }
}

