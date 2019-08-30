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

            var numbers = userInput.Split(new[] {',', '\n'}).Select(int.Parse).ToArray();

            return numbers.Sum();
        }
    }
}
