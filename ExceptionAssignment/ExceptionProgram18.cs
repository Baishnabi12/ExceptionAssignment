using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionAssignment
{
     class ExceptionProgram18
    {
  
        static void Main()
        {
            StreamReader reader = null;
            try
            {
                reader = new StreamReader("data.txt");
                string content = reader.ReadToEnd();
                Console.WriteLine(content);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file was not found.");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"An I/O error occurred: {ex.Message}");
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                    Console.WriteLine("File stream closed.");
                }
            }
        }
    }

}

