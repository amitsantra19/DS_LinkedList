using static LinkedList.SingleLinkedList;
using System;

namespace LinkedList
{
    class LinkedListDS
    {
        public static void Main(string[] args)
        {
            SingleLinkedList slst = new SingleLinkedList
            {
                head = new Node(50)
            };
            Node second = new Node(10);
            Node third = new Node(15);
            slst.head.next = second;
            second.next = third;
            slst.InsertAtBegining(111);
            slst.InsertAtEnd(241);
            slst.InsertAtEnd(245);
            slst.InsertAtMiddle(266);
            slst.InsertAtGivenPosition(4, 290);
            slst.PrintSingleLinkedList();
            Console.WriteLine();
            Console.WriteLine("After Delete operation is performed at First");
            int first = slst.DeleteFirstItemFromList();
            Console.WriteLine("First Item:  " + first);
            slst.PrintSingleLinkedList();
            Console.WriteLine();
            Console.WriteLine("After Delete operation is performed at last");
            int last = slst.DeleteFromEnd();
            Console.WriteLine("Last Item:  " + last);
            slst.PrintSingleLinkedList();
            Console.WriteLine();
            Console.WriteLine("After Delete operation is performed in any given position");
            int anypos = slst.DeleteAtAnyPosition(3);
            Console.WriteLine("Any Pos Item:  " + anypos);
            slst.PrintSingleLinkedList();
            Console.WriteLine();
            bool isFound = slst.FindAElementInLinkedList(10);
            Console.WriteLine(isFound);
            bool isFound1 = slst.FindAElementInLinkedList(266);
            Console.WriteLine(isFound1);
            bool isFound2 = slst.FindAElementInLinkedList(2410);
            Console.WriteLine(isFound2);
            Console.WriteLine();
            slst.ReverseALinkedList();
            slst.PrintSingleLinkedList();
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
