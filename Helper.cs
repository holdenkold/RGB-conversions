using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGB_Separation
{
    class Helper
    {
        static public double[,] MatrixMultiply(double[,] a, double[,] b)
        {
            double[,] c = null;
            if (a.GetLength(1) == b.GetLength(0))
            {
                c = new double[a.GetLength(0), b.GetLength(1)];
                for (int i = 0; i < c.GetLength(0); i++)
                {
                    for (int j = 0; j < c.GetLength(1); j++)
                    {
                        c[i, j] = 0;
                        for (int k = 0; k < a.GetLength(1); k++) // OR k<b.GetLength(0)
                            c[i, j] = c[i, j] + a[i, k] * b[k, j];
                    }
                }
            }
            else
            {
                Console.WriteLine("\n Number of columns in First Matrix should be equal to Number of rows in Second Matrix.");
                Console.WriteLine("\n Please re-enter correct dimensions.");
                Environment.Exit(-1);
            }
            return c;
        }
    }
}
