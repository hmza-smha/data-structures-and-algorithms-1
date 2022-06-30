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
        public void Breadth_First_Test()
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

        [Fact]
        public void Depth_First_Test1()
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
            g.AddEdge(b, c);
            g.AddEdge(a, d);
            g.AddEdge(d, b);
            g.AddEdge(b, e);

            var expected = new List<Vertex> { a,d,b,e,c };

            Assert.True(expected.SequenceEqual(g.DepthFirst()));
        }

        [Fact]
        public void Depth_First_Test2()
        {
            Graph g = new Graph();

            Vertex a = new Vertex("a");
            Vertex b = new Vertex("b");
            Vertex c = new Vertex("c");
            Vertex d = new Vertex("d");
            Vertex e = new Vertex("e");
            Vertex f = new Vertex("f");
            Vertex i = new Vertex("i");
            Vertex h = new Vertex("h");

            g.Add(a);
            g.Add(b);
            g.Add(c);
            g.Add(d);
            g.Add(e);
            g.Add(f);
            g.Add(i);
            g.Add(h);


            g.AddEdge(a, d);
            g.AddEdge(a, b);
            g.AddEdge(b, c);
            g.AddEdge(b, d);
            g.AddEdge(c, i);
            g.AddEdge(d, f);
            g.AddEdge(d, h);
            g.AddEdge(d, e);
            g.AddEdge(f, h);

            var expected = new List<Vertex> { a,b,c,i,d,e,h,f };
            Assert.True(expected.SequenceEqual(g.DepthFirst()));
        }
    }
}
