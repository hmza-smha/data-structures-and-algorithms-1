using System;
using System.Collections.Generic;
using System.Linq;

namespace data_structures_and_algorithms_1.Graphs
{
    /* This is a Directed graph.
     * If you want it Undirected, then un-comment the bottom line in the AddEdge() method.
     */

    public class Graph
    {
        private List<Vertex> _list { get; set; }
        
        public Graph(){
            _list = new List<Vertex>();
        }

        public Vertex Add(Vertex value)
        {
            //Vertex vertex = new Vertex(value);

            if (_list.Contains(value))
            {
                throw new Exception("Vertex Is Exists Before!");
            }
            else
            {
                _list.Add(value);
            }

            return value;
        }

        public void AddEdge(Vertex from, Vertex to)
        {
            Vertex from_vertex = null, to_vertex = null;

            foreach (var v in _list)
            {
                if (v == from)
                    from_vertex = v;
                if (v == to)
                    to_vertex = v;
            }

            if (from_vertex == null)
                throw new Exception("The 'FROM' Vertex is not exist");

            if (to_vertex == null)
                throw new Exception("The 'TO' Vertex is not exist");

            from_vertex.Neighbors.Add(to_vertex);

            to_vertex.Neighbors.Add(from_vertex);
        }

        public List<Vertex> GetVertices()
        {
            return _list;
        }

        public int Size()
        {
            return _list.Count();
        }

        public List<Vertex> GetNeighbours(Vertex vertex)
        {
            foreach (var node in _list)
            {
                if(node == vertex)
                {
                    return node.Neighbors;
                }
            }

            throw new Exception("Vertex Does NOT Exist!");
        }

        public List<Vertex> BreadthFirst()
        {
            Queue<Vertex> queue = new Queue<Vertex>();
            List<Vertex> visited = new List<Vertex>();

            // enqueue a random node
            queue.Enqueue(_list[0]);

            while(queue.Count != 0)
            {
                Vertex vertex = queue.Dequeue();
                foreach (Vertex v in vertex.Neighbors)
                {
                    if (!queue.Contains(v) && !visited.Contains(v))
                        queue.Enqueue(v);
                }

                visited.Add(vertex);
            }

            return visited;
        }
    }
}
