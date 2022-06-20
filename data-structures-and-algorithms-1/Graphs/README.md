# Graphs
A graph is a non-linear data structure that can be looked at as a collection of Vertices (= Nodes)

- Undirected Graphs
    - An Undirected Graph is a graph where each edge is undirected or bi-directional.
- Directed Graphs
    - Each node is directed at another node with a specific edge.
Weighted Graphs
A weighted graph is a graph with numbers assigned to its edges. These numbers are called weights.

### Graph Representation
- Adjacency Matrix
    - An Adjacency matrix is represented through a 2-dimensional array. If there are n vertices, then we are looking at an n x n matrix
- Adjacency List
    - An adjacency list is a collection of linked lists or array that lists all of the other vertices that are connected.

### Traversals
- Breadth-First
- Depth-First## Challenge

## Challenge
Implement Graph. The graph should be represented as an adjacency list, and should include the following methods:

- add node
    - Arguments: value
    - Returns: The added node
    - Add a node to the graph

- add edge
    - Arguments: 2 nodes to be connected by the edge, weight (optional)
    - Returns: nothing
    - Adds a new edge between two nodes in the graph
    - If specified, assign a weight to the edge
    - Both nodes should already be in the Graph

- get nodes
    - Arguments: none
    - Returns all of the nodes in the graph as a collection (set, list, or similar)

- get neighbors
    - Arguments: node
    - Returns a collection of edges connected to the given node
    - Include the weight of the connection in the returned collection

- size
    - Arguments: none
    - Returns the total number of nodes in the graph

## Solution

```c#
/* This is a Directed graph.
     * If you want it Undirected, then un-comment the bottom line in the AddEdge() method.
     */

    public class Graph
    {
        private List<Vertex> _list { get; set; }

        public Vertex Add(Vertex vertex)
        {
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
    }

    public class Vertex
    {
        public string Value { get; set; }
        public List<Vertex> Neighbors { get; set; }

        public Vertex(string value)
        {
            Value = value;
        }
    }
```
