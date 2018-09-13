using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithm
{
    public class Exo1
    {
        public static bool Checkv1(string s)
        {
            HashSet<char> seenCharacters = new HashSet<char>();

            foreach (char c in s)
            {
                if (seenCharacters.Contains(c)) return false;
                seenCharacters.Add(c);
            }
            return true;
        }

        public static bool Checkv2(string s)
        {
            return !s.GroupBy(c => c).Any(g => g.Count() != 1);
        }

        public static bool Checkv3(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                for (int y = i + 1; y < s.Length; y++)
                {
                    if (s[i] == s[y]) return false;
                }
            }
            return true;
        }
    }

    [TestFixture]
    public class Exo1Test
    {
        [TestCase("abcde", true)]
        [TestCase("abcdea", false)]
        [TestCase("", true)]
        [TestCase("   ", false)]
        [TestCase("a", true)]
        [TestCase("ab", true)]
        public void __(string input, bool expected)
        {
            Assert.That(Exo1.Checkv1(input), Is.EqualTo(expected));
            Assert.That(Exo1.Checkv2(input), Is.EqualTo(expected));
            Assert.That(Exo1.Checkv3(input), Is.EqualTo(expected));
        }

    }
}
