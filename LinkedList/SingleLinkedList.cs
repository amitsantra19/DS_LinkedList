using System;

namespace LinkedList
{ 
    public class SingleLinkedList
    {
        public Node head;
        public class Node
        {
            public int data;
            public Node next;
            public Node(int d)
            {
                data = d;
                next = null;
            }
        }

        /// <summary>
        /// Insert a node at the bengining of the linked list
        /// </summary>
        /// <param name="data"></param>
        public void InsertAtBegining(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
                return;
            }
            else
            {
                //node.data = data;
                node.next = head;
                head = node;
            }
        }

        /// <summary>
        /// Insert a node at the End of the linked list
        /// </summary>
        /// <param name="data"></param>
        public void InsertAtEnd(int data)
        {
            Node node = new Node(data);
            Node last = head;
            if (head == null)
            {
                head = node;
                return;
            }
            else
            {
                while (last.next != null)
                {
                    last = last.next;
                }
                last.next = node;
                return;
            }

        }

        /// <summary>
        /// Insert a node at the Middle of the linked list
        /// </summary>
        /// <param name="data"></param>
        public void InsertAtMiddle(int data)
        {
            Node node = new Node(data);
            Node count = head;
            int ctn = 0;
            Node temp = head;
            Node temp1 = head;
            if (head == null)
            {
                head = node;
                return;
            }
            else
            {
                while (count.next != null)
                {
                    count = count.next;
                    ctn++;
                }
                int mid = ctn / 2;
                while (mid != 0)
                {
                    temp = temp.next;
                    temp1 = temp1.next;
                    mid--;
                }
                temp1 = temp1.next;
                node.next = temp1;
                node.data = data;
                temp.next = node;
            }

        }

        /// <summary>
        /// Insert a node at the given position of the linked list
        /// </summary>
        /// <param name="pos"></param>
        /// <param name="data"></param>
        public void InsertAtGivenPosition(int pos, int data)
        {
            Node node = new Node(data);
            Node temp = head;
            Node temp1 = head;
            if (head == null)
            {
                head = node;
                return;
            }
            else
            {
                while (pos != 0)
                {
                    temp = temp.next;
                    temp1 = temp1.next;
                    pos--;
                }
                temp1 = temp1.next;
                node.next = temp1;
                //node.data = data;
                temp.next = node;
            }

        }

        /// <summary>
        /// Delete First item from the Linked List
        /// </summary>
        /// <returns></returns>
        public int DeleteFirstItemFromList()
        {
            int val;
            Node node = head;
            val = node.data;
            head = node.next;
            return val;
        }

        /// <summary>
        /// Delete Last item from the Linked List
        /// </summary>
        /// <returns></returns>
        public int DeleteFromEnd()
        {
            int val;
            Node node = head;
            while (node.next.next!=null)
            {
                node = node.next;
            }
            val = node.next.data;
            node.next = null;
            return val;
        }

        /// <summary>
        /// Delete User provided item from the Linked List
        /// </summary>
        /// <param name="pos"></param>
        /// <returns></returns>
        public int DeleteAtAnyPosition(int pos)
        {
            int val;
            Node temp = head;
            Node temp1 = head;
            if (head == null)
            {
                return -1;
            }
            else
            {
                while (pos-1 != 0)
                {
                    temp = temp.next;
                    temp1 = temp1.next;
                    pos--;
                }
                val = temp.next.data;
                temp1.next = temp.next.next;
            }

            return val;
        }


        /// <summary>
        /// Search element in Linked list
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public bool FindAElementInLinkedList(int info)
        {
            Node node = head;
            bool isFound = false;
            if (head== null)
            {
                isFound = false;
            }
            else
            {
                while(node != null )
                {
                    if (node.data == info)
                    {
                        isFound = true;
                        break;
                    }
                    node = node.next;
                }
            }
            return isFound;
        }

        /// <summary>
        /// Revese a Linked List
        /// </summary>
        public void ReverseALinkedList()
        {
            Node current = head;
            Node tNext;
            Node prev = null;
            if (head == null)
            {
                return;
            }
            while(current != null)
            {
                tNext = current.next;
                current.next = prev;
                prev = current;
                current = tNext;
            }
            head = prev;
        }

        /// <summary>
        /// Print Linked List
        /// </summary>
        public void PrintSingleLinkedList()
        {
            Node node = head;
            while (node!=null)
            {
                Console.Write(node.data + " -> ");
                node = node.next;
            }
        }
    }
}
