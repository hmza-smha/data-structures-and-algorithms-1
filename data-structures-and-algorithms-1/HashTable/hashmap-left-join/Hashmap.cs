using System.Collections.Generic;
using System.Collections;
using System;

namespace data_structures_and_algorithms_1.hashmap_left_join
{
    public class Hashmap
    {
        public static List<string> LeftJoin(Hashtable table1, Hashtable table2)
        {

            List<string> result = new List<string>();

            foreach (DictionaryEntry pair in table1)
            {
                string row;

                if (table2.ContainsKey(pair.Key))
                {
                    row = pair.Key + "," +  table1[pair.Key].ToString() + "," + table2[pair.Key].ToString();
                }
                else
                {
                    row = pair.Key + "," + table1[pair.Key].ToString() + ",null";
                }

                result.Add(row);
            }

            return result;
        }
    }
}
