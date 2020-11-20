using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Graph g = new Graph();
            //Vertex v1 = new Vertex("1");
            //Vertex v2 = new Vertex("2");
            //Vertex v3 = new Vertex("3");
            //Vertex v4 = new Vertex("4");
            //Vertex v5 = new Vertex("5");
            //v1.addEdge(v2);
            //v1.addEdge(v5);
            //v2.addEdge(v1);
            //v2.addEdge(v3);
            //v2.addEdge(v4);
            //v2.addEdge(v5);
            //v3.addEdge(v2);
            //v3.addEdge(v4);
            //v4.addEdge(v2);
            //v4.addEdge(v3);
            //v4.addEdge(v5);
            //v5.addEdge(v1);
            //v5.addEdge(v2);
            //v5.addEdge(v4);
            //g.addVertex(v1);
            //g.addVertex(v2);
            //g.addVertex(v3);
            //g.addVertex(v4);
            //g.addVertex(v5);
            //g.print();

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
        }
    }
}
