using Algorithm._2.Helpers;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithm._2
{
    static class Exo1
    {
        public static void Checkv1(LinkedListModelExo1 item)
        {
            HashSet<int> values = new HashSet<int>();
            values.Add(item.Number);

            LinkedListModelExo1 previous = item;
            while(previous != null && previous.Next != null)
            {
                if (!values.Contains(previous.Next.Number))
                {
                    values.Add(previous.Next.Number);
                    previous = previous.Next;
                }
                else
                {
                    previous.Next = previous.Next.Next;
                }

            }

        }

        public static List<int> LinkedlistToArrayList(LinkedListModelExo1 head)
        {
            List<int> result = new List<int>();

            LinkedListModelExo1 current = head;
            while(current != null)
            {
                result.Add(current.Number);
                current = current.Next;
            }
            result.Reverse();
            return result;
        }

        public static LinkedListModelExo1 ArrayToLinkedList(List<int> list)
        {
            LinkedListModelExo1 next = null;

            for(int i = 0; i < list.Count; i++)
            {
                LinkedListModelExo1 item = new LinkedListModelExo1(list[i]);
                item.Next = next;
                next = item;
            }

            return next;
        }
    }

    [TestFixture]
    class Exo1Test
    {
        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 1, 2, 3, 4 })]
        [TestCase(new int[] { 1, 2, 3, 4, 2, 3, 4 }, new int[] { 1, 2, 3, 4 })]
        [TestCase(new int[] { 1, 2, 3, 4, 1, 2, 3, 2, 4 }, new int[] { 1, 2, 3, 4 })]
        public void ___(int[] input, int[] expected)
        {
            LinkedListModelExo1 head = Exo1.ArrayToLinkedList(input.ToList());

            Exo1.Checkv1(head);

            List<int> result = Exo1.LinkedlistToArrayList(head);
            result.Sort();
            CollectionAssert.AreEqual(expected, result);
        }
    }
}