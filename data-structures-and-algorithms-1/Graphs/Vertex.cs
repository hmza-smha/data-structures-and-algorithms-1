using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structures_and_algorithms_1.Graphs
{
    public class Vertex
    {
        public string Value { get; set; }
        public List<Vertex> Neighbors { get; set; }

        public Vertex(string value)
        {
            Value = value;
        }
    }
}
