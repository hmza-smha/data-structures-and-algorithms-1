﻿using System;
using System.Collections;
using System.Collections.Generic;
using data_structures_and_algorithms_1.Graphs;
using data_structures_and_algorithms_1.hashmap_left_join;
using data_structures_and_algorithms_1.HashTable.hashmap_repeated_word;

namespace data_structures_and_algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Data Structures & Algorithms!");
            Graph g = new Graph();

            Vertex a = new Vertex("a");
            Vertex b = new Vertex("b");
            Vertex c = new Vertex("c");
            Vertex d = new Vertex("d");
            Vertex e = new Vertex("e");

            g.Add(a);
            g.Add(b);
            g.Add(c);
            g.Add(d);
            g.Add(e);

            g.AddEdge(a, b);
            g.AddEdge(a, d);
            g.AddEdge(d, b);
            g.AddEdge(b, e);
            g.AddEdge(b, c);

            foreach (var v in g.BreadthFirst())
            {
                Console.WriteLine(v.Value);
            }
        }
    }
}
