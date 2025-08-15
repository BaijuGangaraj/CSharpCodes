using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    internal class MyClass
    {
        public void Exception_1()
        {
            int a = 10;
            int b = 0;
            try 
            { 
                int c = a / b;
                Console.WriteLine(c);
            }
            catch(ArithmeticException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Thank you");
            }
            int d = a + b;
            Console.WriteLine(d);
        }
    }
}
