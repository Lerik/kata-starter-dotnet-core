using System;
using System.Linq;

namespace Kata
{
    public class Calculator
    {
        public int Add(string userInput = "")
        {
            if (string.IsNullOrEmpty(userInput))
            {
                return 0;
            }

            string[] delimiters = new[] {",", "\n"};
            var input = userInput;

            if (userInput.StartsWith("//"))
            {
                var parts = userInput.Split('\n');
                delimiters = new[] {parts.First().Replace("//", "")};
                input = parts.Last();
            }
            
            var numbers = input.Split(delimiters, StringSplitOptions.None).Select(int.Parse).ToArray();
            
            var negativeNumbers = numbers.Where(n => n < 0).ToArray();

            if (negativeNumbers.Length > 0)
            {
                throw new Exception($"negatives not allowed: {string.Join(", ", negativeNumbers)}");
            }

            return numbers.Sum();
        }
    }
}
