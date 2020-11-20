using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace denemeYanilma
{
    class Program
    {
        static void Main(string[] args)
        {

            //char ch;

            //foreach (char c in vert)
            //{
            //    string cString = c.ToString();
            //}



            string vert = "000101";
            int j = 0;

            foreach (char item in vert)
            {
                if (item.ToString() == "1")
                {
                    Console.WriteLine(j);

                }
                j++;
            }

            //    bool positiveResult = false;
            //    foreach (char item in vert)
            //    {
            //        if (item.ToString() == "1")
            //        {
            //            positiveResult = true;

            //            break;
            //        }
            //    }

            //    if (!positiveResult)
            //    {
            //        Console.WriteLine(j);
            //    }
            //    j++;
            //}



            //char toFind = '1';
            //int count = 0;
            //foreach (char item in vert)
            //{
            //    if (item.Equals(toFind))
            //    {
            //        Console.WriteLine(item);
            //        count++;
            //    }

            //}


            //Console.WriteLine("Found '{0}' in '{1}' at position {2}",
            //                                              toFind, str, index);






        }
    }
}

