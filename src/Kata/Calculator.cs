using System.ComponentModel.Design;

namespace Kata
{
    public class Calculator
    {
        public int Add(string userInput)
        {
            if (!string.IsNullOrEmpty(userInput))
            {
                return int.Parse(userInput);
            }

            return 0;
        }
        
        
    }
}