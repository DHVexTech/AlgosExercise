using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithm
{
    class Exo6
    {
        public static string Checkv1(string s1) => s1.Length > 1 ? string.Join("", s1.GroupBy(c => c).Select(c => c.Key.ToString() + c.Count())) : "";
    }

    [TestFixture]
    class exo6Test
    {
        [TestCase("aaaaaeeefhhhbbbccc", "a5e3f1h3b3c3")]
        [TestCase("aaaaaaaaa", "a9")]
        public void __(string s1, string s2)
        {
            Assert.That(Exo6.Checkv1(s1), Is.EqualTo(s2));
        }
    }
}
