using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class FourthClass
    {

        static void Main(string[] args)
        {
            FourthClass.M1();
            Console.Read();
        }

       internal static void M1()
        {
            Console.WriteLine("Static method can be called without creating object of the class \n It is accessed using Classname.MethodName");
        }
    }
}
