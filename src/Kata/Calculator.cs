using System;

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

            return Int32.Parse(numbers[0]) + Int32.Parse(numbers[1]);
        }
    }
}