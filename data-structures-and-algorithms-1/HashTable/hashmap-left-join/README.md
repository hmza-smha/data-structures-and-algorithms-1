# Hashmap LEFT JOIN
The LEFT JOIN mechanisim returns all rows from the left table, and the matching rows from the right table. The result is NULL from the right side, if there is no match.

## Challenge
Write a function that LEFT JOINs two hashmaps into a single data structure.
- Arguments: two hash maps
    - The first parameter is a hashmap that has word strings as keys, and a synonym of the key as values.
    - The second parameter is a hashmap that has word strings as keys, and antonyms of the key as values.
- Return: The returned data structure that holds the results is up to you. It doesn’t need to exactly match the output below, so long as it achieves the LEFT JOIN logic
## Solution
```c#
public List<string> LeftJoin(Hashtable table1, Hashtable table2)
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
```