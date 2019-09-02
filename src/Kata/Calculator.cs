using System;
using System.Linq;

namespace Kata
{
    public class Calculator
    {
        public int Add(string input)
        {
            if (input.Equals(""))
                return 0;

            var numbers = input.Split(',')
                .Select(n => Int32.Parse(n))
                .ToArray();

            return numbers.Sum();
        }
    }
}