using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithm
{
    class Exo2
    {
        public static bool Checkv1(string s1, string s2) => String.Concat(s1?.OrderBy(c => c)) == String.Concat(s2?.OrderBy(c => c));

        public static bool Checkv2(string s1, string s2)
        {
            if (s1.Length != s2.Length) return false;
            Dictionary<char, int> s1Frequency = Frequency(s1);

            foreach(char c in s2)
            {
                int n;
                if (!s1Frequency.TryGetValue(c, out n) || n == 0) return false;
                s1Frequency[c] = n - 1;
            }
            return true;
        }

        static Dictionary<char, int> Frequency(string s)
        {
            Dictionary<char, int> result = new Dictionary<char, int>();

            foreach(char c in s)
            {
                int n;
                if (result.TryGetValue(c, out n)) result[c] = n + 1;
                else result[c] = 1;
            }

            return result;
        }
    }

    [TestFixture]
    class Exo2Test
    {
        [TestCase("ougrspm", "ougrspm", true)]
        [TestCase("ougrspm", "sogmrpu", true)]
        [TestCase("ougrspm", "xougrspm", false)]
        [TestCase("ougrspm", "sogtrpu", false)]
        [TestCase("", "", true)]
        [TestCase("xxy", "xyy", false)]
        public void __(string s1, string s2, bool expected)
        {
            Assert.That(Exo2.Checkv1(s1, s2), Is.EqualTo(expected));
            Assert.That(Exo2.Checkv2(s1, s2), Is.EqualTo(expected));
        }
    }
}
