using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Type.Algorithms
{
    internal class binary_search_2d
    {
        public int[] search2d(int[][] matrix, int target)
        {
            int r = 0;
            int c = matrix.Length - 1;
            while(r<matrix.Length&& c>=0)
            {
                if (matrix[r][c] == target)
                    return new int[] { r, c };
                if(matrix[r][c] > target)
                {
                    r++;
                }
                else
                {
                    c--;
                }
            }
            return new int[] { -1, -1 };
        }
    }
}
