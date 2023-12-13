using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tyuiu.PimenovaTS.Sprint6.TaskReview.V6.Lib
{
    public class DataService
    {
        public int[,] GetRandomMatrix(int n, int m, int n1, int n2)
        {
            Random rand = new Random();
            int[,] array = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    array[i, j] = rand.Next(n1, n2 - 1);
                }
            }
            return array;
        }


        public int GetMatrix(int[,] array, int c, int k, int l)
        {

            if (k < 0 || l < k || c < 0 || c >= array.GetLength(0))
            {
                throw new ArgumentException("некорректные вводные данные");
            }


            int pr = 1;
            for (int i = k; i <= l; i++)
            {
                if (array[i, c] % 2 != 0)
                {
                    pr *= array[i, c];
                }
            }
            return pr;
        }
    }
}
