using System.Collections.Generic;
using System.Linq;

namespace Runner
{
    public class SumOfMultiple
    {

        public int UpTo(int max)
        {
            var values = new List<int>();
            values.AddRange(new GetMultiplesOf(3).UpTo(max - 1));
            values.AddRange(new GetMultiplesOf(5).UpTo(max - 1));
            return values.Distinct().Sum();
        }
    }

    internal class GetMultiplesOf
    {
        private readonly int _multiplier;

        public GetMultiplesOf(int multiplier)
        {
            _multiplier = multiplier;
        }

        public int[] UpTo(int max)
        {
            var returnVal = new List<int>();
            for (int i = 1; i <= max; i++)
            {
                if (IsDivisibleBy(i, _multiplier))
                {
                    returnVal.Add(i);
                }
            }
            return returnVal.ToArray();
        }

        private static bool IsDivisibleBy(int dividend, int divisor)
        {
            return dividend % divisor == 0;
        }
    }
}
