using System.Collections.Generic;
using System.Linq;
using System;

namespace data_structures_and_algorithms_1.HashTable
{
    public class HashTable
    {
        private int _hashSize;
        private Node[] _hashtable;

        public HashTable(int hashSize)
        {
            _hashSize = hashSize;
            _hashtable = new Node[hashSize];
        }

        public void Set(int key, string value)
        {
            if (key < 0)
                throw new Exception("Negative keys are not allowed.");

            int hashedKey = Hash(key);

            if (_hashtable[hashedKey] == null)
            {
                _hashtable[hashedKey] = new Node(key, value);
            }
            else
            {
                // Solving the Collision
                Node temp = _hashtable[hashedKey];
                while (temp.Next != null)
                {
                    // if the key exists in the _hashtable, then overrite it's value.
                    if (temp.Key == key)
                    {
                        temp.Value = value;
                        return;
                    }

                    temp = temp.Next;
                }

                temp.Next = new Node(key, value);
            }
        }

        public bool Contains(int key)
        {
            int hashedKey = Hash(key);
            Node temp = _hashtable[hashedKey];

            while(temp != null)
            {
                if (temp.Key == key)
                    return true;

                temp = temp.Next;
            }

            return false;
        }

        public string Get(int key)
        {
            if (!Contains(key))
                throw new Exception("Key does't exist!");

            int hashedKey = Hash(key);

            Node temp = _hashtable[hashedKey];
            while (temp.Key != key)
            {
                temp = temp.Next;
            }

            return temp.Value;

        }

	/*

        public List<int> Keys()
        {
            List<int> keys = new List<int>();

            // the _hashtable but without nulls
            List<Node> hashed = _hashtable.Where(x => x != null).ToList();

            foreach (Node node in hashed)
            {
                if (node.Next == null)
                {
                    keys.Add(node.Key);
                }
                else
                {
                    Node temp = node;
                    while(temp.Next != null)
                    {
                        keys.Add(temp.Key);
                        temp = temp.Next;
                    }
                }
            }

            return keys;

        }
	*/

        /* Function Rules:
         * 1) 100 % 100 = 0
         * 2) x % 100 = x , x < 100
         * 3) y % 100 = NOT ALLOWED , y < 0
         */
        private int Hash(int key)
        {
            return key % _hashSize;
        }
    }
}
