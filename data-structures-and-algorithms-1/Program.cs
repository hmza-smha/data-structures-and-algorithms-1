using System;
using System.Collections;
using System.Collections.Generic;
using data_structures_and_algorithms_1.hashmap_left_join;
using data_structures_and_algorithms_1.HashTable.hashmap_repeated_word;

namespace data_structures_and_algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Data Structures & Algorithms!");

            Hashtable t1 = new Hashtable();
            Hashtable t2 = new Hashtable();

            t1.Add("diligent", "employed");
            t1.Add("fond", "enamored");
            t1.Add("guide", "usher");
            t1.Add("outfit", "garb");
            t1.Add("wrath", "anger");

            t2.Add("diligent", "idle");
            t2.Add("fond", "averse");
            t2.Add("guide", "follow");
            t2.Add("flow", "jam");
            t2.Add("wrath", "delight");

            foreach (var e in Hashmap.LeftJoin(t1, t2))
            {
                for (int i = 0; i < e.Length; i++)
                {
                    Console.Write(e[i]);
                }

                Console.WriteLine();
            }

        }
    }
}
