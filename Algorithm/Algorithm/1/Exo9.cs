using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class Exo9
    {
        public static bool Checkv1(string s1, string s2)
        {
            if (s1.Length != s2.Length) return false;
            return IsSubstring(s1 + s2, s2);
        }

        static bool IsSubstring(string s1, string s2)
        {
            return s1.Contains(s2);
        }
    }

    [TestFixture]
    class Exo9Tests
    {
        [TestCase("abcdef","abcdef", true)]
        [TestCase("abcdef","cdefab", true)]
        [TestCase("abcdef","efabcd", true)]
        [TestCase("abcdef", "titi", false)]
        [TestCase("abcdef", "abcde", false)]
        [TestCase("abcdef", "afxabcd", false)]
        public void __(string s1, string s2, bool done)
        {
            Assert.That(Exo9.Checkv1(s1, s2), Is.EqualTo(done));
        }
    }
}
