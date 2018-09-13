using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithm
{
    class Exo3
    {
        public static void Checkv1(char[] chars)
        {
            int whitespaceCount = 0;
            int count = 0;
            foreach(char c in chars)
            {
                if (c == 0) break;
                if (char.IsWhiteSpace(c)) whitespaceCount++;
                count++;
            }

            if (whitespaceCount == 0) return;

            for (int j = count - 1; j >= 0; j--)
            {
                if (char.IsWhiteSpace(chars[j]))
                {
                    chars[j + whitespaceCount * 2 - 2] = '%';
                    chars[j + whitespaceCount * 2 - 1] = '2';
                    chars[j + whitespaceCount * 2] = '0';
                    whitespaceCount--;
                }
                else
                {
                    chars[j + whitespaceCount * 2] = chars[j];
                }
            }

        }
    }

    [TestFixture]
    class Exo3Test
    {
        [TestCase("qsd sqd sqd sq ")]
        [TestCase("ezf dssdfg gg")]
        public void __(string input)
        {
            string exepted = input.Replace(" ", "%20");
            char[] chars = new char[exepted.Length];
            input.CopyTo(0, chars, 0, input.Length);
            Exo3.Checkv1(chars);
            CollectionAssert.AreEqual(chars, exepted);
        }
    }
}
