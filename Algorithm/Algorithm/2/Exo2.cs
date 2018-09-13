using Algorithm._2.Helpers;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithm._2
{
    class Exo2
    {
        public static int GetAt(LinkedListModelExo1 head, int idx)
        {
            LinkedListModelExo1 ref1 = head;
            for (int i = 0; i < idx; i++) ref1 = ref1.Next;

            LinkedListModelExo1 ref2 = head;

            while(ref1.Next != null)
            {
                ref1 = ref1.Next;
                ref2 = ref2.Next;
            }

            return ref2.Number;
        }
    }

    [TestFixture]
    class Exo2Test
    {
        [TestCase(3, 3)]
        [TestCase(0, 6)]
        [TestCase(5, 1)]
        public void ___(int idx, int value)
        {
            LinkedListModelExo1 head = ConverterLinkedList.ArrayToLinkedList(new List<int> { 1, 2, 3, 4, 5, 6 });
            int result = Exo2.GetAt(head, idx);
            Assert.That(result, Is.EqualTo(value));
        }
    }
}
