using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ThirdProgram
    {
        static void Main(string[] args)
        {
            // SecondProgram.AcceptData();

            string name = "Hari";
            string uname = name;
            Console.WriteLine("Working with Strings");
            Console.WriteLine("== " + name==uname);
            Console.WriteLine("equals  " + name.Equals(uname));
            Console.WriteLine("-----------------");
            Console.WriteLine("Working with nos");
            int i = 10;
            int j = i;
            if (i==j)
            {
                Console.WriteLine("both r equal");
            }
            else
            {
                Console.WriteLine("not equal");
            }
            Console.WriteLine("---------------------");
            //struct and enums are value types
            object u1 = "Hari";
            char[] u2 = {'H','a','r','i' };//reference
            object u3 = u2;//reference
            char ans = 'Y';
            
            Console.WriteLine("==" + u1==u3.ToString());
            Console.WriteLine("equals" + u1.Equals(u3));

            Console.Read();
        }
    }
}
