using System;
using System.Collections;
using System.Collections.Generic;
using data_structures_and_algorithms_1.HashTable;

namespace data_structures_and_algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Data Structures & Algorithms!");

            HashTable table = new HashTable(10);

            table.Set(1, "1");
            table.Set(10, "10");
            table.Set(11, "11");


            foreach (var e in table.Keys())
            {
                Console.WriteLine(e);
            }

        }
    }
}
