using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication15
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stack yigin = new Stack();
            //int input;
            //Console.WriteLine("   ");
            //input = Convert.ToInt32(Console.ReadLine());

            //if (input)
            //{

            //}

            postfix e1 = new postfix();
            Console.WriteLine("enter any postfix expression");
            e1.pfix = Console.ReadLine();
            e1.e();
            Console.WriteLine("\n\t\tpostfix evaluation:  " + e1.answer);
            Console.ReadKey();
        }
    }
}
