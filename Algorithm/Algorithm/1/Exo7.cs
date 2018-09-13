using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Algorithm
{
    static class Exo7
    {
        public static void Checkv1(this int[,] matrix)
        {
            int size = matrix.GetLength(0);
            int[,] result = new int[size, size];

            for(int i = 0; i < size; i++)
            {
                for (int y = 0; y < size; y++)
                {
                    result[y,size - i - 1] = matrix[i, y];
                }
            }

            Array.Copy(result, matrix, result.Length);
        }
    }

    [TestFixture]    
    class Exo7Test
    {
        [TestCase]
        public void __()
        {
            int[,] matrix = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } };
            matrix.Checkv1();
            int[,] expected = { { 13, 9, 5, 1 }, { 14, 10, 6, 2 }, { 15, 11, 7, 3 }, { 16, 12, 8, 4 } };
            CollectionAssert.AreEqual(matrix, expected);
        }
    }
}

// 1 1 1 1
// 0 1 0 1
// 2 3 1 2
// 8 5 6 3

// 1 1 2 3
// 1 0 1 6
// 1 1 3 5 
// 1 0 2 8
