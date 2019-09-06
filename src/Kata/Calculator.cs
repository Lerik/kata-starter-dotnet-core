using System.ComponentModel.Design;

namespace Kata
{
    public class Calculator
    {
        public int Add(string userInput)
        {
            if (string.IsNullOrEmpty(userInput))
                return 0;

            var numbers = userInput.Split(',');
            
            if (numbers.Length == 1)
                return int.Parse(numbers[0]);

            return int.Parse(numbers[0]) + int.Parse(numbers[1]);
        }
        
        
    }
}