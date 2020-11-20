using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> st = new Stack<int>(16);
            stackOperation oper = new stackOperation();
            st.push(26);
            st.push(48);
            st.push(21);
            st.push(26);
            st.push(48);
            st.push(22);
            st.push(17);
            st.push(21);
            st.push(17);
            st.push(7);
            st.push(13);
            st.push(22);
            st.push(9);
            st.push(13);
            st.push(7);
            st.display();
            Console.WriteLine("Sıralanmış Çıkan");
            st = oper.TekCiftSiralama(st);
            st.display();
        }

    }
}