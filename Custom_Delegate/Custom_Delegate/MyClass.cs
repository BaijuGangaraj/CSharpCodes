using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Delegate
{
    internal class MyClass
    {
        public delegate int Mydelegate(int x);
        int num = 10;
        public void f()
        {
            Mydelegate del1 = new Mydelegate(Add);
            del1(5);
            Console.WriteLine(num);
        }
        public int Add(int x)
        {
            num = num + x;
            return num;

        }
    }
}
