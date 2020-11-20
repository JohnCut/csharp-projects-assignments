using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW02
{
    class Edge//Kenar sınıfı
    {
        Vertex from;//Kenarın başladığı düğüm
        public Vertex to;//Kenarın bittiği düğüm
        public Edge(Vertex from, Vertex to)//kurucu metod
        {
            this.from = from;
            this.to = to;
        }
    }
}
