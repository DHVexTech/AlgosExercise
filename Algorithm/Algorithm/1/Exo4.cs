using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithm
{
    class Exo4
    {
        public static bool Checkv1(string input1, string palin)
        {
            if (!Exo4Helpers.CheckIfIsPalin(palin)) return false;

            return input1.GroupBy(c => c).Count(c => c.Count() % 2 == 1) <= 1;
        }

        public static bool Checkv2(string input1, string palin)
        {
            if (!Exo4Helpers.CheckIfIsPalin(palin)) return false;
            var frequency = Exo4Helpers.Frequency(input1);
            int oddFound = 0;

            foreach(int count in frequency.Values)
            {
                if (count % 2 != 0 && ++oddFound == 2) return false;
            }
            return true;
        }
    }


    [TestFixture]
    class Exo4Test
    {
        [TestCase("kkaay", "kayak", true)]
        [TestCase("nnappa", "nappan", true)]
        [TestCase("ddnnappa", "dada",  false)]
        [TestCase("nnappa", "patate", false)]
        public void __(string input1, string palin, bool expected)
        {
            Assert.That(Exo4.Checkv1(input1, palin), Is.EqualTo(expected));
            Assert.That(Exo4.Checkv2(input1, palin), Is.EqualTo(expected));
        }
    }

    class Exo4Helpers
    {
        public static string Reverse(string stringToReverse)
        {
            char[] charArray = stringToReverse.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static bool CheckIfIsPalin(string input)
        {
            string input2Reversed = Reverse(input);
            decimal occuranceNeeded = Math.Ceiling((decimal)(input.Length / 2));
            int occurencePalin = 0;
            for (int i = 0; i < occuranceNeeded; i++)
            {
                if (input[i] == input2Reversed[i]) occurencePalin++;
            }
            return occurencePalin == occuranceNeeded;
        }

        public static Dictionary<char, int> Frequency(string s)
        {
            Dictionary<char, int> result = new Dictionary<char, int>();

            foreach (char c in s)
            {
                int n;
                if (result.TryGetValue(c, out n)) result[c] = n + 1;
                else result[c] = 1;
            }

            return result;
        }
    }
}
