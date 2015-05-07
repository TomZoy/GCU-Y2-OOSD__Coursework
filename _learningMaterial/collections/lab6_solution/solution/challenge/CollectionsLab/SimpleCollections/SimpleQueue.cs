using System;


namespace SimpleCollections
{
    /// <summary>
    /// a simple queue data structure 
    /// implemented using linked nodes
    /// </summary>
    public class SimpleQueue
    {
        public Node head;
        public Node tail;

        /// <summary>
        /// the number of items in the queue
        /// </summary>
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
        public SimpleQueue()
        {
            // initialise head and tail references
            head = null;
            tail = null;
        }

        /// <summary>
        /// sets all queue entries to null
        /// </summary>
        public void Destroy()
        {
            Node temp = new Node();
            Node setNull = new Node();
            temp = head;
            while (temp != null)
            {
                setNull = temp;
                temp = temp.nextNode;
                setNull = null;
            }
            head = null;
            tail = null;
        }

        /// <summary>
        /// checks whether queue is empty
        /// </summary>
        /// <returns>true if queue is empty</returns>
        public bool IsEmpty()
        {
            return head == null;
        }

        /// <summary>
        /// checks whether queue is full
        /// </summary>
        /// <returns>true if queue is full</returns>
        public bool IsFull()
        {
            return false;
        }

        /// <summary>
        /// enqueues an item
        /// </summary>
        /// <param name="o">the item to enqueue</param>
        public void Enqueue(Object o)
        {
            Node newNode = new Node();
            newNode.dataItem = o;
            if (tail == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.nextNode = newNode;
                tail = newNode;
            }
        }

        /// <summary>
        /// dequeues the item at the head of the queue
        /// </summary>
        /// <returns>the item dequeued</returns>
        public Object Dequeue()
        {
            if (head == null)
                return null;
            else
            {
                Node temp = new Node();
                temp = head;
                head = head.nextNode;
                if (head == null) tail = null;
                return temp.dataItem;
            }
        } 
    }
}
