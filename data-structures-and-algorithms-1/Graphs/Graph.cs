﻿using System;
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

        public Vertex Add(string value)
        {
            Vertex vertex = new Vertex(value);

            if (_list.Contains(vertex))
            {
                throw new Exception("Vertex Is Exists Before!");
            }
            else
            {
                _list.Add(vertex);
            }

            return vertex;
        }

        public void AddEdge(Vertex from, Vertex to)
        {
            if (!_list.Contains(from))
                throw new Exception("The 'FROM' Vertex is not exist");

            if (!_list.Contains(to))
                throw new Exception("The 'TO' Vertex is not exist");

            from.Neighbors.Add(to);

            //to.Neighbors.Add(from);
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
    }
}
