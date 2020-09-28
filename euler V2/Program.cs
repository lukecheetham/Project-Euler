using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Schema;

namespace euler
{
    public class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> range = Enumerable.Range(1, 999);
            var multiples = new CalculateSumOfMultiples();
            var sumOfMultiples = multiples.Calculate(range);
            Console.WriteLine($"The total sum of the multiples is: {sumOfMultiples}");
        }
    }
    
}
