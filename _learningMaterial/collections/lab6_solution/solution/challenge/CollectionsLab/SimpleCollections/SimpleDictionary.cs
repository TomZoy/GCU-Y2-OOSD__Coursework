using System;


namespace SimpleCollections
{
    /// <summary>
    /// a simple dictionary data structure
    /// implemented using a hash table
    /// </summary>
    public class SimpleDictionary
    {
        public const int CAPACITY = 20;
        public Object[] keys = new Object[CAPACITY];
        public Object[] values = new Object[CAPACITY];
        public String[] status = new String[CAPACITY];

        /// <summary>
        /// the number of items in the dictionary
        /// </summary>
        public int Size
        {
            get
            {
                int count = 0;
                for (int i = 0; i < CAPACITY; i++)
                {
                    if (status[i] == "occup")
                        count++;
                }
                return count;
            }
        }

        /// <summary>
        /// default constructor
        /// </summary>
        public SimpleDictionary()
        {
            for (int i = 0; i < CAPACITY; i++)
            {
                status[i] = "empty";
                keys[i] = "empty";
                values[i] = null;
            }
        }

        /// <summary>
        /// checks whether dictionary is empty
        /// </summary>
        /// <returns>true if dictionary is empty</returns>
        public bool IsEmpty()
        {
            int count = 0;
            for (int i = 0; i < CAPACITY; i++)
            {
                if (status[i] == "occup")
                    count++;
            }
            if (count == 0) return true;
            else return false;
        }

        

        /// <summary>
        /// puts a new key/value pair in this dictionary
        /// Calculates array position from hashcode, and rehashes if that position 
        /// is occupied
        /// </summary>
        /// <param name="key">the key to be stored</param>
        /// <param name="value">the value to be stored</param>
        public void Put(Object key, Object value)
        {
            int hashcode = (key.GetHashCode() & 0x7FFFFFFF) % CAPACITY;   // AND with largest int value to deal with negative hashcode()
            if (status[hashcode] == "occup")
            {
                hashcode = Rehash(hashcode, 0);
            }
            keys[hashcode] = key;
            values[hashcode] = value;
            status[hashcode] = "occup";
        }

        /// <summary>
        /// checks whether the specified key is present
        /// in the dictionary
        /// </summary>
        /// <param name="key">the key</param>
        /// <returns>true if the key is present</returns>
        public bool ContainsKey(Object key)
        {
            bool found = false;
            for (int i = 0; i < CAPACITY; i++)
            {
                if (keys[i] != null)
                    if (keys[i].Equals(key))
                        found = true;
            }
            return found;
        }

        /// <summary>
        /// Returns the value for a specified key
        /// Uses hashcode to select starting point for search, and uses
        /// linear probing to search from there
        /// </summary>
        /// <param name="key">the key to be found</param>
        /// <returns>the value associated with key</returns>
        public Object Get(Object key)
        {
            int hashcode = (key.GetHashCode() & 0x7FFFFFFF) % CAPACITY;
            // System.out.println(hashcode);
            int attempts = 0;
            if (keys[hashcode].Equals(key)) return values[hashcode];
            else
            {
                while (!keys[hashcode].Equals(key) && status[hashcode] != "empty" && hashcode <= CAPACITY && attempts < 10)
                {
                    hashcode++;
                    if (status[hashcode] == "occup")
                    {
                        if (keys[hashcode].Equals(key)) return values[hashcode];
                    }
                    else attempts++;
                }
                return null;
            }

        }

        /// <summary>
        /// sets the value for a specified key.
        /// Uses hashcode to select starting point for search, and uses
        ///  linear probing to search from there
        /// </summary>
        /// <param name="key">the key to be found</param>
        /// <param name="value">the value to be stored</param>
        public void Set(Object key, Object value)
        {
            int hashcode = (key.GetHashCode() & 0x7FFFFFFF) % CAPACITY;
            int attempts = 0;
            if (keys[hashcode].Equals(key)) values[hashcode] = value;
            else
            {
                while (!keys[hashcode].Equals(key) && status[hashcode] != "empty" && hashcode <= CAPACITY && attempts < 10)
                {
                    hashcode++;
                    if (status[hashcode] == "occup")
                    {
                        if (keys[hashcode].Equals(key)) values[hashcode] = value;
                    }
                    else attempts++;
                }
            }

        }

        //Recursively recalculates an array position to find an unoccupied position, based
        //on a linear probing method for handling hashcode clashes
        //Checks whether allowed number of attempts has been exceeded.
        private int Rehash(int hashcode, int attempts)
        {
            if (hashcode < (CAPACITY) && attempts < CAPACITY)
            {
                hashcode++;
                if (hashcode == CAPACITY) hashcode = 0;
                //System.out.println("rehashing: " + hashcode);
                if (status[hashcode] == "occup")
                {
                    hashcode = Rehash(hashcode, attempts + 1);
                }
                return hashcode;
            }
            else
                return -1;
        }

    }
}
