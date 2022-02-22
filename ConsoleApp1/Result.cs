using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace ConsoleApp1
{
    class Result
    {

        /*
         * Complete the 'kangaroo' function below.
         *
         * The function is expected to return a STRING.
         * The function accepts following parameters:
         *  1. INTEGER x1
         *  2. INTEGER v1
         *  3. INTEGER x2
         *  4. INTEGER v2
         */

        public static string kangaroo(int x1, int v1, int x2, int v2)
        {
            if (x2 > x1 && v2 > v1) return "NO";
            if ((v1 > v2) && (x1 - x2) % (v2 - v1) == 0)
                return "YES";
            return "NO";
        }
        public static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
        {
            var ApplesLanding = apples.Select(apple => apple + a);
            var orangsLanding = oranges.Select(orangs => orangs + b);
            int noOfApplesinRange = 0, noOfOrangesInRange = 0;
            foreach (int apple in ApplesLanding)
            {
                noOfApplesinRange = isFruitInRange(s, t, apple) ? noOfApplesinRange + 1 : noOfApplesinRange;
            }
        }
        private static bool isFruitInRange(int min, int max, int fruitLanding)
        {
            if (fruitLanding > min && fruitLanding < max)
                return true;
            return false;
        }
    }
}
