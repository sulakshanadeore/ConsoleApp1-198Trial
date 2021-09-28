using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class SecondProgram
    {
        static void Main(string[] args)
        {
            AcceptData();

            Console.ReadLine();

        }

        public static void AcceptData()
        {
            //Equals-----------------compares values


            //int i = 100;
            //object obj = i.ToString();//int32

            //if (obj.Equals(i))
            //{
            //    Console.WriteLine("equals");
            //}
            //else
            //{
            //    Console.WriteLine("not equal");
            //}

            //string s = "hello";
            //object obj;
            //if (s.Equals("hello"))
            //{
            //    Console.WriteLine("equals");
            //}
            //else
            //{
            //    Console.WriteLine("not equals");
            //}

            //Console.WriteLine(i.GetType());

            //object obj=i.ToString();
            //Console.WriteLine(obj.GetType());//string
            //object obj = i;
            //Console.WriteLine(obj.GetType()); //Int32

            //float pi = 3.14f;  //C#
            //Single pi = 3.14f;//framework type
            ////int i
            //Int32 i;

            ////object obj;//C#
            //Object obj//framework

            ////    double di = 4342342.234234d;
            //Double di=23423424.3242d;




            Console.WriteLine("Enter a number");
            int no1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            string no2 = Console.ReadLine();
            //==address
            if (no1.Equals(no2))
            {
                Console.WriteLine("They are equal");
            }
            else
            {
                Console.WriteLine("Not equal");
            }

            //object obj="Hello";
            //Object is parent of all datatypes
            //obj = no1;

            //Console.WriteLine(obj.GetType());
            //Console.WriteLine(obj);
            //  no1 = obj;


        }

    }
           
}
