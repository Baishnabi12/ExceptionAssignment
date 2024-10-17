using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionAssignment
{
    internal class ExceptionProgram4
    {

        class Program
        {
            static void Main()
            {
                string filePath = "nonexistentfile.txt";
                try
                {
                    string content = File.ReadAllText(filePath);
                    Console.WriteLine(content);
                }
                catch (FileNotFoundException ex)
                {
                    Console.WriteLine($"Error: {ex.Message} - The file was not found.");
                }
            }
        }

    }
}
