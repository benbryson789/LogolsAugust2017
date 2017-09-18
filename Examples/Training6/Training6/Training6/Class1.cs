using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training6
{
    public static class Class1
    {
        public static void Main()
        {
            VariableDeclaration();
            Console.ReadLine();
        }

        private static void Comments()
        {
            //This is a single line comment.

            /*
            This is for
            multi-line
            comments
            */
        }

        private static void VariableDeclaration()
        {
            string testString;
            testString = "test";

            string testString2 = "test";

            StringBuilder builder;
            builder = new System.Text.StringBuilder();

            StringBuilder builder2 = new System.Text.StringBuilder();

            var builder3 = new System.Text.StringBuilder();
        }

        private static void Conversions()
        {
            int number = 241;
            string numberString = number.ToString();
            string numberString2 = Convert.ToString(number);
            double doubleVal = (double)number;
        }

        private static void IfStatement()
        {
            if(2 == 2)
            {
                Console.WriteLine("2 does equal 2");
            }
        }

        private static void IfElseStatement()
        {
            if (2 == 2)
            {
                Console.WriteLine("2 does equal 2");
            }
            else
            {
                Console.WriteLine("2 does not equal 2");
            }
        }

        private static void NestedIfStatement()
        {
            if (2 == 2)
            {
                if (3 == 3)
                {
                    Console.WriteLine("2 does equal 2 and 3 equals 3");
                }
            }
        }

        private static void IfStatementWithAnd()
        {
            if (2 == 2 && 3 == 3)
            {
                Console.WriteLine("2 does equal 2 and 3 equals 3");
            }
        }

        private static void IfStatementMultipleElse()
        {
            int var = 3;

            if (var == 1)
            {
                Console.WriteLine("var is equal to 1");
            }
            else if (var == 2)
            {
                Console.WriteLine("var is equal to 2");
            }
            else if (var == 3)
            {
                Console.WriteLine("var is equal to 3");
            }
            else
            {
                Console.WriteLine("var does not equal 1, 2, or 3");
            }
        }

        private static void Switch()
        {
            int var = 3;

            switch(var)
            {
                case 1:
                    Console.WriteLine("var is equal to 1");
                    break;
                case 2:
                    Console.WriteLine("var is equal to 2");
                    break;
                case 3:
                    Console.WriteLine("var is equal to 3");
                    break;
                default:
                    Console.WriteLine("var does not equal 1, 2, or 3");
                    break;
            };
        }

        private static void Ternary()
        {
            string output = 3 == 3 ? "3 is equal to 3" : "3 is not equal to 3";
        }

        private static void Comparison()
        {
            //<, >, <=, >=, ==, !=, ===, !==
            if(3 > 2)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }

        private static void Logical()
        {
            //&, |, &&, ||
            if (3 > 2 && 6 > 4)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }

        private static void WhileLoop()
        {
            int count = 0;

            while(count < 10)
            {
                Console.WriteLine(count);
                count++;
            }
        }

        private static void DoWhileLoop()
        {
            int count = 0;

            do
            {
                Console.WriteLine(count);
                count++;
            } while (count < 10);
        }

        private static void ForLoop()
        {
            for(int count = 0; count < 10; count++)
            {
                Console.WriteLine(count);
            }
        }

        private static void ForEachLoop()
        {
            List<String> strings = new List<String>() { "test 1", "test 2", "test 3", "test 4", "test 5" };

            foreach(String item in strings)
            {
                Console.WriteLine(item);
            }
        }
    }
}
