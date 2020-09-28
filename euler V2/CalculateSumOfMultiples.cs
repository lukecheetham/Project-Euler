using System;
using System.Collections.Generic;
using System.Text;

namespace euler
{
    public class CalculateSumOfMultiples
    {
        public int Calculate(IEnumerable<int> range)
        {
            int sum = 0;

            foreach (int i in range)
            {
                if ((i % 3) == 0 || (i % 5) == 0)
                {
                    Console.WriteLine($"{i} is a multiple");

                    sum += i;

                }

            }
            return sum;
        }
    }
}
