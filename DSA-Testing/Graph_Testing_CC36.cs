using data_structures_and_algorithms_1.Graphs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DSA_Testing
{
    public class Graph_Testing_CC36
    {
        [Fact]
        public void Test1()
        {
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

            var expected = new List<Vertex> { a, b, d, e, c };

            Assert.True(expected.SequenceEqual(g.BreadthFirst()));
        }
    }
}
