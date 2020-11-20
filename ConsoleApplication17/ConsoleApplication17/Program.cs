using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter any postfix expression");
            string pfix;
            string answer;
            Stack i = new Stack();
            pfix = Console.ReadLine();
            i.Push(pfix);
            int a, b, ans;
            for (int j = 0; j < pfix.Length; j++)
            {
                String c = pfix.Substring(j, 1);
                if (c.Equals("*"))
                {
                    String sa = (String)i.Pop();
                    String sb = (String)i.Pop();
                    a = Convert.ToInt32(sb);
                    b = Convert.ToInt32(sa);
                    ans = a * b;
                    i.Push(ans.ToString());

                }
                else if (c.Equals("/"))
                {
                    String sa = (String)i.Pop();
                    String sb = (String)i.Pop();
                    a = Convert.ToInt32(sb);
                    b = Convert.ToInt32(sa);
                    ans = a / b;
                    i.Push(ans.ToString());
                }
                else if (c.Equals("+"))
                {
                    String sa = (String)i.Pop();
                    String sb = (String)i.Pop();
                    a = Convert.ToInt32(sb);
                    b = Convert.ToInt32(sa);
                    ans = a + b;
                    i.Push(ans.ToString());

                }
                else if (c.Equals("-"))
                {
                    String sa = (String)i.Pop();
                    String sb = (String)i.Pop();
                    a = Convert.ToInt32(sb);
                    b = Convert.ToInt32(sa);
                    ans = a - b;
                    i.Push(ans.ToString());

                }
                else
                {
                    i.Push(pfix.Substring(j, 1));
                }
            }
            answer = (String)i.Pop();
        }
    }
}
