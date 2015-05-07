using System;

namespace SimpleCollections
{
    /// <summary>
    /// a simple stack data structure
    /// implemented using an array
    /// </summary>
    public class SimpleStack
    {
        private Object[] stack;
        private int size;      // to track number of items

        /// <summary>
        /// the number of items in the stack
        /// </summary>
        public int Size
        {
            get { return size; }
        }

        /// <summary>
        /// default constructor
        /// </summary>
        /// <param name="size"></param>
        public SimpleStack(int capacity)
        {
            stack = new Object[capacity];    // size array with parameter
            size = 0;          // set number of items to zero
        }

        /// <summary>
        /// push an item onto the stack
        /// </summary>
        /// <param name="obj">the item to add</param>
        /// <returns>true if added successfully</returns>
        public bool Push(Object obj)
        {
            if (IsFull() == false)         // checks if space in stack
            {
                stack[size] = obj;   // add item
                size++;        // increment item counter
                return true;        // to indicate success
            }
            else
            {
                return false;       // to indicate failure
            }
        }

        /// <summary>
        /// remove the item which was added last
        /// </summary>
        /// <returns>the item removed</returns>
        public Object Pop()
        {
            if (IsEmpty() == false)     // makes sure stack is not empty
            {
                // reduce counter by one
                Object obj = stack[size - 1];
                stack[size - 1] = null;    // to indicate success
                size--;
                return obj;
            }
            else
            {
                return null;       // to indicate failure
            }
        }

        /// <summary>
        /// checks whether stack is empty
        /// </summary>
        /// <returns>true if stack is empty</returns>
        public bool IsEmpty()
        {
            if (size == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// checks whether stack is full
        /// </summary>
        /// <returns>true if stack is full</returns>
        public bool IsFull()
        {
            if (size == stack.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
