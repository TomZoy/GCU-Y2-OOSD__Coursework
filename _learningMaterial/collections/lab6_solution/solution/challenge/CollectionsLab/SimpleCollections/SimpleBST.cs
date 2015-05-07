using System;


namespace SimpleCollections
{
    public class SimpleBST
    {
        SimpleBST leftSubTree;
        SimpleBST rightSubTree;
        Object dataItem;
        IComparable key;

       
        /// <summary>
        /// Constructor for objects of class SimpleBST
        /// </summary>
        public SimpleBST()
        {
            dataItem = null;
            key = null;
        }

        
        /// <summary>
        /// adds a new item to the tree
        /// </summary>
        /// <param name="newKey">the key for the new entry</param>
        /// <param name="o">the new item<</param>
        /// <returns>true id added successfully</returns>
        public bool Put(IComparable newKey, Object o)
        {
            if (key == null)
            {
                key = newKey;
                dataItem = o;
                return true;
            }
            else if (newKey.CompareTo(key) > 0)
            {
                if (rightSubTree == null)
                    rightSubTree = new SimpleBST();
                bool result = rightSubTree.Put(newKey, o);
                return result;
            }
            else if (newKey.CompareTo(key) < 0)
            {
                if (leftSubTree == null)
                    leftSubTree = new SimpleBST();
                bool result = leftSubTree.Put(newKey, o);
                return result;
            }
            else
                return false;
        }


        /// <summary>
        /// finds an  item by key
        /// </summary>
        /// <param name="target">the key for the target item</param>
        /// <returns>the item found</returns>
        public Object Get(IComparable target)
        {
            Object o = null;

            if (target.CompareTo(key) == 0)
                o = dataItem;
            else if (target.CompareTo(key) > 0)
            {
                o = rightSubTree.Get(target);
            }
            else if (target.CompareTo(key) < 0)
            {
                o = leftSubTree.Get(target);
            }

            return o;
        }
    }
}
