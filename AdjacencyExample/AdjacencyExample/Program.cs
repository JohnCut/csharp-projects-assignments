using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdjacencyExample
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter the number of vertices -");
            int vertices = Int32.Parse(Console.ReadLine());

            AdjacencyList adjacencyList = new AdjacencyList(vertices + 1);

            Console.WriteLine("Enter the number of edges -");
            int edges = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter the edges with weights -");
            int startVertex, endVertex, weight;

            for (int i = 0; i < edges; ++i)
            {
                startVertex = Int32.Parse(Console.ReadLine());
                endVertex = Int32.Parse(Console.ReadLine());
                weight = Int32.Parse(Console.ReadLine());

                adjacencyList.addEdgeAtEnd(startVertex, endVertex, weight);
            }

            adjacencyList.printAdjacencyList();
            adjacencyList.removeEdge(1, 2, 1);
            adjacencyList.printAdjacencyList();
        }
    }
}