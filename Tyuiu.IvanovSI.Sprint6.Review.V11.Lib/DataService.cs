using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.IvanovSI.Sprint6.Review.V11.Lib
{
    public class DataService
    {
        public int[,] GetMatrix(int n, int m, int n1, int n2)
        {
            Random rand = new Random();
            int[,] array = new int[n, m];
            int count = 99999;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (n1 < n2)
                    {
                        if (j == 2 || j == count)
                        {
                            count = j + 3;
                            array[i, j] = (int)array[i, j - 2] + (int)array[i, j - 1];
                        }
                        else
                        {
                            array[i, j] = rand.Next(n1, n2 + 1);
                        }
                    }
                }
            }
            return array;

        }
        public int GetMax(int[,] array, int c, int k, int l)
        {
            int maxElement = int.MinValue;
            c -= 1;
            for (int i = k; i <= l; i++)
            {
                if (i % 2 != 0) 
                {
                    int element = array[i,c];
                    if (element > maxElement)
                    {
                        maxElement = element;
                    }
                }
            }
            return maxElement;
        }
    }
}
