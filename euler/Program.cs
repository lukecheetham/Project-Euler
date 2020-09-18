using System;
using System.Collections.Generic;
using System.Linq;

namespace euler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            List<int> multiples = new List<int>() {};
            foreach(int i in Enumerable.Range(1,999))
            {
                if((i % 3) == 0 || (i % 5) ==0)
                {
                    Console.WriteLine($"{i} is a multiple");
                    multiples.Add(i);
                }

            }
            foreach(var item in multiples)
            {
                System.Console.WriteLine(item.ToString());
                sum += item;
            }
            System.Console.WriteLine($"The total sum of the multiples is: {sum}");
        }
    }
}
