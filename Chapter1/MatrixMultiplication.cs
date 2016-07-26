using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1
{
    public class MatrixMultiplication
    {
        public static void Multiplication()
        {
            var a = new int[2, 3] { { 1, 0, 2 }, { -1, 3, 1 } };
            var b = new int[3, 2] { { 3, 1 }, { 2, 1 }, { 1, 0 } };

            //矩阵乘法必须满足第一个矩阵的 column = 第二个矩阵的 row
            //第一个矩阵式 m * n 的矩阵，第二个矩阵是个 n * p 的矩阵，乘积就是个 m * p 矩阵

            var size = a.GetLength(0);
            var N = a.GetLength(1);
            var c = new int[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    for (int k = 0; k < N; k++)
                    {
                        c[i, j] += a[i, k] * b[k, j];
                    }

                    if (i != 0 && j == 0)
                    {
                        Console.WriteLine();
                    }
                    Console.Write(c[i, j]);
                    Console.Write(" ");
                }
            }
        }


    }
}
