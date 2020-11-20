using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication15
{
    class postfix
    {
        public string pfix;
        public string answer;
        Stack i = new Stack();
        public void e()
        {
            var bosluksil = new string[] { " " };
            foreach (var c in bosluksil)
            {
                pfix = pfix.Replace(c, string.Empty);
            }
            //Queue str = new Queue();
            //for (int i = 0; i < pfix.Length; i++)
            //{
            //    str.Enqueue(i);
            //}

            //ArrayList str = new ArrayList();
            //for (int i = 0; i < pfix.Length; i++)
            //{
            //    str.Add(i);
            //}
            int a, b, ans;
            for (int j = 0; j < pfix.Length; j++)
            {
                String c = pfix.Substring(j, 1);
                //char c = pfix[j++];
                //char c = str[j];
                //char[] c = pfix.Take(1).ToArray();
                //string c = str.Dequeue(j);
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
