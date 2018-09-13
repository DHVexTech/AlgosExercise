using Algorithm._2.Helpers;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm._2
{
    class Exo3
    {
        public static void Remove(LinkedListModelExo1 item)
        {
            while (item.Next.Next != null)
            {
                item.Number = item.Next.Number;
                item = item.Next;
            }

            item.Number = item.Next.Number;
            item.Next = null;
        }
    }

    [TestFixture]
    class Exo3Test
    {
        //[Test]
        public void __()
        {
            LinkedListModelExo1 head = ConverterLinkedList.ArrayToLinkedList(new List<int> { 1, 2, 3, 4, 5, 6 });
            LinkedListModelExo1 item = head.Next.Next.Next;

            Exo3.Remove(item);

            CollectionAssert.AreEqual(ConverterLinkedList.LinkedlistToArrayList(head), new[] { 1, 2, 3, 4, 5, 6, 7 });
        }
    }
}
