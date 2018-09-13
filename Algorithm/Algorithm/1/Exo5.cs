using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class Exo5
    {
        public static bool Checkv1(string s1, string s2)
        {
            if (s1 == s2) return true;
            if (Math.Abs(s1.Length - s2.Length) > 1) return false;

            if (s1.Length == s2.Length)
            {
                int diff = 0;
                for (int i = 0; i < s1.Length; i++)
                {
                    if (s1[i] != s2[i] && ++diff > 1) return false;
                }
                return true;
            }



            if (s2.Length > s1.Length)
            {
                string tmp = s1;
                s1 = s2;
                s2 = tmp;
            }

            int offset = 0;
            for (int i = 0; i < s1.Length; i++)
            {
                if (i == s1.Length - 1 && offset == 0) return false;
                if (s1[i] != s2[i + offset] && offset-- != 0) return false;
            }
            return true;
        }
    }



    [TestFixture]
    class Exo5Test
    {
        [TestCase("test", "tst", true)]
        [TestCase("test", "tist", true)]
        [TestCase("test", "tesst", true)]
        [TestCase("test", "teeest", false)]
        [TestCase("test", "tt", false)]
        [TestCase("test", "tes", false)]
        public void __(string s1, string s2, bool exepted)
        {
            Assert.That(Exo5.Checkv1(s1, s2), Is.EqualTo(exepted));
        }
    }
}
