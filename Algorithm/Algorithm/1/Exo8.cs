using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    static class Exo8
    {
        public static void Checkv1Exo8(this int[,] matrix)
        {
            int size = matrix.GetLength(0);
            List<int> colZeroReference = new List<int>();
            List<int> lineZeroReference = new List<int>();

            for (int line = 0; line < size; line++)
            {
                for (int col = 0; col < size; col++)
                {
                    if (matrix[line, col] == 0)
                    {
                        colZeroReference.Add(col);
                        lineZeroReference.Add(line);
                    }
                }
            }

            foreach (int i in colZeroReference)
            {
                for (int col = 0; col < size; col++)
                {
                    matrix[col, i] = 0;
                }
            }

            foreach (int i in lineZeroReference)
            {
                for (int line = 0; line < matrix.GetLength(1); line++)
                {
                    matrix[i, line] = 0;
                }
            }

        }

        public static void Checkv2Exo8Correction(this int[,] matrix)
        {
            HashSet<int> lineContainingZero = new HashSet<int>();
            HashSet<int> columnsContainingZero = new HashSet<int>();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j =0; j < matrix.GetLength(1); j++ )
                {
                    if (matrix[i,j] == 0)
                    {
                        lineContainingZero.Add(i);
                        columnsContainingZero.Add(j);
                    }
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (lineContainingZero.Contains(i) || columnsContainingZero.Contains(j))
                    {
                        matrix[i,j] = 0;
                    }
                }
            }
        }
    }

    [TestFixture]
    class Exo8Tests
    {
        [TestCase()]
        public void __()
        {
            int[,] matrix = { { 1, 2, 3, 4 }, { 0, 6, 7, 8 }, { 9, 10, 0, 12 }};
            matrix.Checkv1Exo8();
            int[,] expected = { { 0, 2, 0, 4 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 } };
            CollectionAssert.AreEqual(matrix, expected);
        }
    }
}
