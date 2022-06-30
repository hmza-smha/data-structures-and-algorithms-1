using data_structures_and_algorithms_1.BusinessTrip;
using System;

namespace data_structures_and_algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph graph = new Graph();

            Vertex v1 = new Vertex("1");
            Vertex v2 = new Vertex("2");
            Vertex v3 = new Vertex("3");
            Vertex v4 = new Vertex("4");
            Vertex v5 = new Vertex("5");


            graph.Add(v1);
            graph.Add(v2);
            graph.Add(v3);
            graph.Add(v4);
            graph.Add(v5);

            graph.AddEdge(v1, v2, 0);

            foreach (var e in graph.GetNeighbors(v1))
            {
                Console.WriteLine(e.Value);
            }


        }
    }
}
