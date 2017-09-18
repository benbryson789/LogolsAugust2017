using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int i = 0;
            do
            {
                if (i == 2 || i == 4)
                { 
                    Console.WriteLine(i.ToString());
                }
                else if (i == 5)
                {
                    Console.WriteLine("= 5");
                }
                else 
                {
                    Console.WriteLine("Not 2 or 4");
                }
                i++;
            } while (i < 10);
            */

            //int count = 5;
            //testVoid(count);
            //Console.WriteLine(count.ToString());
            //Console.WriteLine(testReturnString());

            List<string> strings = new List<string>();
            strings.Add("test1");
            strings.Add("test2");
            strings.Add("test3");

            foreach(string val in strings)
            {
                Console.WriteLine(val);
            }

            List<int> ints = new List<int>();
            ints.Add(1);
            ints.Add(2);
            ints.Add(3);

            foreach(int i in ints)
            {
                Console.WriteLine(i.ToString());
            }

            //var testInstance = new Car();
            //try
            //{
            //    testInstance.MethodWithError();
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{

            //}


            //testInstance.testMethod();

            //testInstance.TestProperty = "something else";
            //Console.WriteLine(testInstance.TestProperty);

            Console.ReadLine();
        }

        private void testVoid(int count)
        {
            Console.WriteLine(count.ToString());

            if (count != 7)
            {
                testVoid(7);
            }
        }

        static void testVoid(int count, int count2)
        {
            count = 6;
            Console.WriteLine(count.ToString());
        }

        static string testReturnString()
        {
            return "test return string";
        }
    }
}
