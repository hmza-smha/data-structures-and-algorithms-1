using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structures_and_algorithms_1.HashTable.hashmap_repeated_word
{
    public class HashTable : Hashtable
    {
        public string GetRepeatedWord(string text)
        {
            string[] words = text.Split(' ', ',', '.', ';', '!','?');

            words = words.Where(x => x != "").ToArray();

            foreach (string e in words)
            {
                if (e == " ") continue;

                if (this.ContainsKey(e.ToLower()))
                {
                    return e;
                }
                else
                {
                    this.Add(e.ToLower(), e);
                }
            }

            return "";
        }
    }
}
