using System;

namespace Kata
{
    public class Calculator
    {
        public int Add(string input)
        {
            if (input.Equals(""))
                return 0;
            
            return Int32.Parse(input);
        }
    }
}