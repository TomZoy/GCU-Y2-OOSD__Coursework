using System;

namespace SimpleCollections
{
    /// <summary>
    /// a simple list data structure
    /// </summary>
    public interface ISimpleList
    {
        /// <summary>
        /// the number of entries in the list
        /// </summary>
        int Size
        {
            get;
        }

        /// <summary>
        /// test whether list is full
        /// </summary>
        /// <returns>true if list is full</returns>
        bool IsFull();

        /// <summary>
        /// test whether list is empty
        /// </summary>
        /// <returns>true if list is empty</returns>
        bool IsEmpty();

        /// <summary>
        /// add an entry at a specified position 
        /// </summary>
        /// <param name="index">the position</param>
        /// <param name="o">the entry to add</param>
        void Add(int index, Object o);

        /// <summary>
        /// adds an entry at the end of the list
        /// </summary>
        /// <param name="o">the entry to add</param>
        void Add(Object o);

        /// <summary>
        /// removes the first entry which matches the target object
        /// </summary>
        /// <param name="o">the target object</param>
        /// <returns></returns>
        bool Remove(Object o);

        /// <summary>
        /// finds the position of the first entry which matches the target objectt
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        int IndexOf(Object o);

        /// <summary>
        /// gets the entry at the specified position
        /// </summary>
        /// <param name="index">the position</param>
        /// <returns>the entry</returns>
        Object Get(int index);

        /// <summary>
        /// sets the entry at the specified position
        /// </summary>
        /// <param name="index">the position</param>
        /// <param name="o">the entry previously at that position</param>
        /// <returns></returns>
        Object Set(int index, Object o);

    }
}
