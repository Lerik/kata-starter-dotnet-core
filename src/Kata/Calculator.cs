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

            var numbers = input.Split(',');

            if (numbers.Length == 1)
                return Int32.Parse(numbers[0]);

            var total = 0;

            foreach (var number in numbers)
            {
                total += Int32.Parse(number);
            }

            return total;
        }
    }
}