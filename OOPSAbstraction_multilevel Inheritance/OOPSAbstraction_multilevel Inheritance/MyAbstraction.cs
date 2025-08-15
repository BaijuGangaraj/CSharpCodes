using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSAbstraction_multilevel_Inheritance
{

    interface IAdmin : IAccountant
    {

        
        void f3();
    }

    interface IAccountant: ISG
    {
        void f2();
        

    }

    interface ISG
    {
        void f1();
    }

    internal class MyAbstraction: IAdmin, IAccountant, ISG
    {
        public void f1()
        {
            Console.WriteLine("This is f1");
        }

        public void f2()
        {
            Console.WriteLine("This is f2");
        }
        public void f3()
        {
            Console.WriteLine("This is f3");
        }

    }
}
