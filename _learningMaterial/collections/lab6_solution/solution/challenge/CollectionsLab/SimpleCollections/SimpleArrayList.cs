using System;


namespace SimpleCollections
{
    /// <summary>
    /// a simple implementation of an array list data structure
    /// </summary>
    public class SimpleArrayList : ISimpleList
    {
        private Object[] entries;
        private int capacity;
        private int size;

        /// <summary>
        /// the number of entries in the list
        /// </summary>
        public int Size
        {
            get { return size; }
        }

        /// <summary>
        /// default constructor
        /// </summary>
        public SimpleArrayList()
        {
            entries = new Object[10];
            this.capacity = 10;
            size = 0;
        }

        /// <summary>
        /// constructor with specified capacity
        /// </summary>
        /// <param name="capacity">he capcity</param>
        public SimpleArrayList(int capacity)
        {
            entries = new Object[capacity];
            this.capacity = capacity;
            size = 0;
        }

        /// <summary>
        /// make the list empty
        /// </summary>
        private void MakeEmpty()
        {
            size = 0;
        }

        /// <summary>
        /// test whether list is full
        /// </summary>
        /// <returns>true if list is full</returns>
        public bool IsFull()
        {
            return size == entries.Length;
        }

        /// <summary>
        /// test whether list is empty
        /// </summary>
        /// <returns>true if list is empty</returns>
        public bool IsEmpty()
        {
            return size == 0;
        }

        /// <summary>
        /// add an entry at a specified position 
        /// </summary>
        /// <param name="index">the position</param>
        /// <param name="o">the entry to add</param>
        public void Add(int index, Object o)
        {
            if (index > size)
                index = size;
            if (!IsFull())
            {
                for (int i = size; i > index; i--)
                    entries[i] = entries[i - 1];
                entries[index] = o;
                size++;
            }
        }

        /// <summary>
        /// adds an entry at the end of the list
        /// </summary>
        /// <param name="o">the entry to add</param>
        public void Add(Object o)
        {
            if (!IsFull())
            {
                entries[size] = o;
                size++;
            }
        }

        /// <summary>
        /// removes the first entry which matches the target object
        /// </summary>
        /// <param name="o">the target object</param>
        /// <returns></returns>
        public bool Remove(Object o)
        {
            if (IsEmpty())
                return false;
            int index = -1;
            int i = 0;
            while (index < 0 && i < size)
            {
                if (entries[i].Equals(o))
                    index = i;
                i++;
            }
            if (index < 0)
                return false;
            else
            {
                for (i = index; i < size - 1; i++)
                    entries[i] = entries[i + 1];
                size--;
                return true;
            }
        }

        /// <summary>
        /// finds the position of the first entry which matches the target objectt
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public int IndexOf(Object o)
        {
            if (IsEmpty())
                return -1;
            int index = -1;
            int i = 0;
            while (index < 0 && i < size)
            {
                if (entries[i].Equals(o))
                    index = i;
                i++;
            }
            return index;
        }

        /// <summary>
        /// gets the entry at the specified position
        /// </summary>
        /// <param name="index">the position</param>
        /// <returns>the entry</returns>
        public Object Get(int index)
        {
            if (IsEmpty())
                return null;
            else
                return entries[index];
        }

        /// <summary>
        /// sets the entry at the specified position
        /// </summary>
        /// <param name="index">the position</param>
        /// <param name="o">the entry previously at that position</param>
        /// <returns></returns>
        public Object Set(int index, Object o)
        {
            if (IsEmpty())
                return null;
            else
            {
                Object oldEntry = entries[index];
                entries[index] = o;
                return oldEntry;
            }
        }
    }
}
