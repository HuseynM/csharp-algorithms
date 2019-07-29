using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Tutorials.data_structures
{
    /// <summary>
    /// Implementation of LinkedList
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class DynamicList<T>
    {
        private class ListNode
        {
            public T Element { get; set; }
            public ListNode NextNode { get; set; }

            public ListNode(T element)
            {
                Element = element;
                NextNode = null;
            }

            public ListNode(T element, ListNode prevNode)
            {
                Element = element;
                prevNode.NextNode = this;
            }
        }

        private ListNode head;
        private ListNode tail;
        private int count;

        public DynamicList()
        {
            head = null;
            tail = null;
            count = 0;
        }


        /// <summary>Add element at the end of the list</summary>
        /// <param name="item">The element to be added</param>
        public void Add(T item)
        {
            if (head == null)
            {
                head = new ListNode(item);
                tail = head;
            }
            else
            {
                ListNode newNode = new ListNode(item, tail);
                tail = newNode;
            }

            count++;
        }

        /// <summary>Removes and returns element on the specified index
        /// </summary>
        /// <param name="index">The index of the element to be removed
        /// </param>
        /// <returns>The removed element</returns>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// if the index is invalid</exception>
        public T RemoveAt(int index)
        {
            if (index >= count || index < 0)
                throw new ArgumentOutOfRangeException("Invalid index: " + index);

            int currentIndex = 0;
            ListNode currentNode = head;
            ListNode prevNode = null;
            while (currentIndex < index)
            {
                prevNode = currentNode;
                currentNode = currentNode.NextNode;
                currentIndex++;
            }

            RemoveListNode(currentNode, prevNode);

            return currentNode.Element;
        }

        /// <summary>
        /// Remove the specified node from the list of nodes
        /// </summary>
        /// <param name="currentNode">the node for removal</param>
        /// <param name="prevNode">the predecessor of node</param>
        private void RemoveListNode(ListNode currentNode, ListNode prevNode)
        {
            count--;
            if (count == 0)
            {
                head = null;
                tail = null;
            }
            else if (prevNode == null)
                head = currentNode.NextNode;
            else
                prevNode.NextNode = currentNode.NextNode;

            if (ReferenceEquals(tail, currentNode))
                tail = prevNode;
        }

        /// <summary>
        /// Removes the specified item and return its index.
        /// </summary>
        /// <param name="item">The item for removal</param>
        /// <returns>The index of the element or -1 if it does not exist</returns>

        public int Remove(T item)
        {
            int currentIndex = 0;
            ListNode currentNode = head;
            ListNode prevNode = null;
            while (currentNode != null)
            {
                if (Equals(currentNode.Element, item))
                    break;
                prevNode = currentNode;
                currentNode = currentNode.NextNode;
                currentIndex++;
            }

            if (currentNode != null)
            {
                RemoveListNode(currentNode, prevNode);
                return currentIndex;
            }
            else
                return -1;
        }

        /// <summary>Searches for given element in the list</summary>
        /// <param name="item">The item to be searched</param>
        /// <returns>
        /// The index of the first occurrence of the element
        /// in the list or -1 when it is not found
        /// </returns>
        public int IndexOf(T item)
        {
            int index = 0;
            ListNode currentNode = head;
            while (currentNode != null)
            {
                if (Equals(currentNode.Element, item))
                    return index;

                currentNode = currentNode.NextNode;
                index++;
            }

            return -1;

        }

        /// <summary>Searches for given element in the list</summary>
        /// <param name="item">The item to be searched</param>
        /// <returns>
        /// The index of the first occurrence of the element
        /// in the list or -1 when it is not found
        /// </returns>
        public int IndexOfSecond(T item)
        {
            int index = 0;
            for (ListNode currentNode = head;
                currentNode != null;
                currentNode = currentNode.NextNode)
            {
                if (Equals(currentNode.Element, item))
                    return index;

                index++;
            }

            return -1;
        }

        /// <summary>
        /// Checks if the specified element exists in the list
        /// </summary>
        /// <param name="item">The item to be checked</param>
        /// <returns>
        /// True if the element exists or false otherwise
        /// </returns>
        public bool Contains(T item) => IndexOfSecond(item) != -1;

        /// <summary>
        /// Gets or sets the element at the specified position
        /// </summary>
        /// <param name="index">
        /// The position of the element [0 … count-1]
        /// </param>
        /// <returns>The item at the specified index</returns>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// When an invalid index is specified
        /// </exception>
        public T this[int index]
        {
            get
            {
                if (index >= count || index < 0)
                    throw new ArgumentOutOfRangeException("Invalid index: " + index);

                ListNode currentNode = head;
                for (int i = 0; i < index; i++)
                    currentNode = currentNode.NextNode;

                return currentNode.Element;
            }
            set
            {
                if (index >= count || index < 0)
                    throw new ArgumentOutOfRangeException("Invalid index: " + index);

                ListNode currentNode = head;
                for (int i = 0; i < index; i++)
                    currentNode = currentNode.NextNode;

                currentNode.Element = value;
            }
        }


        public int Count { get { return count; } }

    }
}
