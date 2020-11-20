using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW02
{
    class Vertex
    {
        public string value;//Düğüm değerini tutar
        List<Edge> edges = new List<Edge>();//Kenar listesi
        public Vertex(string value)//Kurucu metod
        {
            this.value = value;
        }
        public void addEdge(Vertex to)//Parametre olarak verilen düğüme doğru bir kenar ekler
        {
            Edge edge = new Edge(this, to);//Kenarı oluştur
            edges.Add(edge);//Kenarı listeye ekle
        }
        public void print()
        {
            Console.Write(this.value + ":");
            foreach (Edge edge in edges)
            {
                Console.Write(edge.to.value + "->");
            }
            Console.WriteLine();
        }
    }
}
