using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionAssignment
{
     class ExceptionProgram16
    {
 
        static async Task Main()
        {
            try
            {
                await PerformAsyncOperation();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Caught exception in async code: {ex.Message}");
            }
        }

        static async Task PerformAsyncOperation()
        {
            await Task.Delay(1000); // Simulate some asynchronous work
            throw new InvalidOperationException("An error occurred in the async operation.");
        }
    }

}

