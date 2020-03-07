using System;

namespace Corruption
{
    class Edge
    {
        public City fromCity;
        public City toCity;

        public Edge(City a, City b)
        {
            this.fromCity = a;
            this.toCity = b;
        }

        public void printInfoEdge()
        {
            Console.WriteLine(this.fromCity.name + " ==> " + this.toCity.name);
        }
    }
}