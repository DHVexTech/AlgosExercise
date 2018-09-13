using Algorithm._2.Helpers;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithm._2
{
    class Exo4
    {
        public static LinkedListModelExo1 Partition(LinkedListModelExo1 head, int pivot)
        {
            throw new NotImplementedException();
        }
    }

    class Exo4Test
    {
        [TestCase(new int[] { 3, 5, 12, 4, 7, 1, 13 }, 6, new int[] { 3, 5, 4, 1, 12, 7, 13 })]
        [TestCase(new int[] { 3, 5, 12, 4, 7, 1, 13 }, 6, new int[] { 3, 5, 4, 1, 12, 7, 13 })]
        [TestCase(new int[] { 3, 5, 12, 4, 7, 1, 13 }, 6, new int[] { 3, 5, 4, 1, 12, 7, 13 })]
        public void __(int[] input, int pivot, int[] expected)
        {
            LinkedListModelExo1 head = ConverterLinkedList.ArrayToLinkedList(input.ToList());

            head = Exo4.Partition(head,pivot);

            CollectionAssert.AreEqual(ConverterLinkedList.LinkedlistToArrayList(head), expected);
        }
    }
}
