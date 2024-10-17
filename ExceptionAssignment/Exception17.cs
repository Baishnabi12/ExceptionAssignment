using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionAssignment
{
     class Exception17
    {
      

        static void Main()
        {
            try
            {
                CauseStackOverflow(0);
            }
            catch (StackOverflowException)
            {
                Console.WriteLine("Stack overflow occurred.");
            }
            finally
            {
                Console.WriteLine("Terminating program safely.");
            }
        }

        static void CauseStackOverflow(int counter)
        {
            
            CauseStackOverflow(counter + 1);
        }
    }

}

