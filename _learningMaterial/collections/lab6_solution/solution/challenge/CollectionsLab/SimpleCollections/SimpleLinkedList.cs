using System;


namespace SimpleCollections
{
    public class Node
    {
        public Object dataItem;
        public Node nextNode;
    }

    /// <summary>
    /// a simple implementation of a linked list data structure
    /// </summary>
    public class SimpleLinkedList : ISimpleList
    {
        private Node head;

        public int Size
        {
            get
            {
                int count = 0;
                for (Node current = head; current != null; current = current.nextNode)
                    count++;
                return count;
            }
        }

        /// <summary>
        /// default constructor
        /// </summary>
        public SimpleLinkedList()
        {
            // initialise head reference
            head = null;
        }


        // <summary>
        /// test whether list is empty
        /// </summary>
        /// <returns>true if list is empty</returns>
        public bool IsEmpty()
        {
            return head == null;
        }

        /// <summary>
        /// test whether list is full
        /// </summary>
        /// <returns>true if list is full</returns>
        public bool IsFull()
        {
            return false;
        }

        /// <summary>
        /// add an entry at a specified position 
        /// </summary>
        /// <param name="index">the position</param>
        /// <param name="o">the entry to add</param>
        public void Add(int index, Object o)
        {
            Node newNode = new Node();
            Node probe;

            newNode.dataItem = o;
            if (head == null)
            {
                newNode.nextNode = null;
                head = newNode;
            }
            else
            {
                if (index == 0)
                {
                    newNode.nextNode = head;
                    head = newNode;
                }
                else
                {
                    probe = head;
                    int i = 0;
                    while ((i < index - 1) && (probe.nextNode != null))
                    {
                        probe = probe.nextNode;
                        i++;
                    }
                    newNode.nextNode = probe.nextNode;
                    probe.nextNode = newNode;
                }
            }
        }

        /// <summary>
        /// adds an entry at the end of the list
        /// </summary>
        /// <param name="o">the entry to add</param>
        public void Add(Object o)
        {
            Add(Size, o);
        }

        /// <summary>
        /// removes the first entry which matches the target object
        /// </summary>
        /// <param name="o">the target object</param>
        /// <returns></returns>
        public bool Remove(Object o)
        {
            Node probe = new Node();
            Node previous = new Node();

            if (head == null)
                return false;
            else
            {
                if (head.dataItem.Equals(o))
                {
                    head = head.nextNode;
                    return true;
                }
                else
                {
                    probe = head;
                    previous = head;
                    while (!probe.dataItem.Equals(o) && probe.nextNode != null)
                    {
                        previous = probe;
                        probe = probe.nextNode;
                    }
                    if (probe.dataItem.Equals(o))
                    {
                        previous.nextNode = probe.nextNode;
                        probe = null;
                        return true;
                    }
                    else
                        return false;
                }
            }
        }

        /// <summary>
        /// finds the position of the first entry which matches the target objectt
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public int IndexOf(Object o)
        {
            Node probe;
            int index = 0;

            if (head == null)
                return -1;
            else
            {
                probe = head;
                while (!probe.dataItem.Equals(o) && probe.nextNode != null)
                {
                    probe = probe.nextNode;
                    index++;
                }
                if (probe.dataItem.Equals(o))
                    return index;
                else
                    return -1;
            }
        }

        /// <summary>
        /// gets the entry at the specified position
        /// </summary>
        /// <param name="index">the position</param>
        /// <returns>the entry</returns>
        public Object Get(int index)
        {
            Node probe;

            if (head == null)
                return null;
            else
            {
                if (index == 0)
                {
                    return head.dataItem;
                }
                else
                {
                    probe = head;
                    int i = 0;
                    while ((i < index - 1) && (probe.nextNode != null))
                    {
                        probe = probe.nextNode;
                        i++;
                    }
                    if (probe.nextNode != null)
                        return probe.nextNode.dataItem;
                    else
                        return null;
                }
            }
        }

        /// <summary>
        /// sets the entry at the specified position
        /// </summary>
        /// <param name="index">the position</param>
        /// <param name="o">the entry previously at that position</param>
        /// <returns></returns>
        public Object Set(int index, Object o)
        {
            Node probe;
            Node oldNode = new Node();

            if (head == null)
                return null;
            else
            {
                if (index == 0)
                {
                    oldNode.dataItem = head.dataItem;
                    head.dataItem = o;
                    return oldNode.dataItem;
                }
                else
                {
                    probe = head;
                    int i = 0;
                    while ((i < index - 1) && (probe.nextNode != null))
                    {
                        probe = probe.nextNode;
                        i++;
                    }
                    if (probe.nextNode != null)
                    {
                        oldNode.dataItem = probe.nextNode.dataItem;
                        probe.nextNode.dataItem = o;
                        return oldNode.dataItem;
                    }
                    else
                        return null;
                }
            }
        }
    }
}
