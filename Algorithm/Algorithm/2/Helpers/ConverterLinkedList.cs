using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm._2.Helpers
{
    public static class ConverterLinkedList
    {
        public static List<int> LinkedlistToArrayList(LinkedListModelExo1 head)
        {
            List<int> result = new List<int>();

            LinkedListModelExo1 current = head;
            while (current != null)
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
            list.Reverse();

            for (int i = 0; i < list.Count; i++)
            {
                LinkedListModelExo1 item = new LinkedListModelExo1(list[i]);
                item.Next = next;
                next = item;
            }

            return next;
        }
    }
}
