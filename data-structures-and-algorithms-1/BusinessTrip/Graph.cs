using System;
using System.Collections.Generic;

namespace data_structures_and_algorithms_1.BusinessTrip
{
    public class Graph
    {
        private HashSet<Vertex> _graph { get; set; }

        public Graph()
        {
            _graph = new HashSet<Vertex>();
        }

        public void Add(Vertex vertex)
        {
            //Vertex vertex = new Vertex(value);

            if (_graph.Contains(vertex))
            {
                throw new Exception($"Vertex '{vertex.Value}' Is Exists Before!");
            }
            else
            {
                _graph.Add(vertex);
            }
        }

        public void AddEdge(Vertex from, Vertex to, int weight)
        {
            Edge forward_edge = new Edge();
            Edge backward_edge = new Edge();

            Vertex from_vertex = null;
            Vertex to_vertex = null;

            foreach (Vertex vertex in _graph)
            {
                if (from_vertex != null && to_vertex != null)
                    break;

                if (vertex == from)
                    from_vertex = vertex;

                if (vertex == to)
                    to_vertex = vertex;
            }


            forward_edge.Weight = weight;
            backward_edge.Weight = weight;

            from_vertex.Edges.Add(forward_edge);
            to_vertex.Edges.Add(backward_edge);
        }

        public List<Vertex> GetNeighbors(Vertex vertex)
        {

            if(!_graph.Contains(vertex))
                throw new Exception("Vartex Does not exist!");

            Vertex temp = null;
            List<Vertex> neighbors = new List<Vertex>();

            foreach (Vertex v in _graph)
            {
                if (v == vertex)
                {
                    temp = v;
                    break;
                }
            }

            if (temp.Edges.Count != 0)
            {
                foreach (Edge edge in temp.Edges)
                {
                    neighbors.Add(edge.To);
                }
            }

            return neighbors;
        }
    }
}
