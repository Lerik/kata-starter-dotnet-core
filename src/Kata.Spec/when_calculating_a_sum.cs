using FluentAssertions;
using Machine.Specifications;

namespace Kata.Spec
{
    public class when_input_is_empty
    {
        Establish _context = () =>
        {
            _systemUnderTest = new Calculator();
        };

        Because of = () => { _result = _systemUnderTest.Add(""); };

        It should_return_0 = () => { _result.Should().Be(0); };
        
        private static Calculator _systemUnderTest;
        private static int _result;
    }

    public class when_input_is_one_number
    {
        Establish _context = () =>
        {
            _systemUnderTest = new Calculator();
        };

        Because of = () => { _result = _systemUnderTest.Add("1"); };

        It should_return_the_same_number = () => { _result.Should().Be(1); };
        
        private static Calculator _systemUnderTest;
        private static int _result;
    }
    
    public class when_input_is_two_numbers
    {
        Establish _context = () =>
        {
            _systemUnderTest = new Calculator();
        };

        Because of = () => { _result = _systemUnderTest.Add("1,2"); };

        It should_return_the_sum_both_numbers = () => { _result.Should().Be(3); };
        
        private static Calculator _systemUnderTest;
        private static int _result;
    }
}