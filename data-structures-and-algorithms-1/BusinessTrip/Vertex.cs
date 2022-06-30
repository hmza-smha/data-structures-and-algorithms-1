using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structures_and_algorithms_1.BusinessTrip
{
    public class Vertex
    {
        public string Value { get; set; }
        public List<Edge> Edges { get; set; }

        public Vertex()
        {
            Edges = new List<Edge>();
        }

        public Vertex(string value)
        {
            Value = value;
            Edges = new List<Edge>();
        }
    }
}
