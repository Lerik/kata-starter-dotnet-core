using FluentAssertions;
using Machine.Specifications;

namespace Kata.Spec
{
    public class when_receiving_an_empty_string
    {
        Establish _context = () =>
        {
            _systemUnderTest = new Calculator();
        };

        Because of = () => { _result = _systemUnderTest.Add(""); };

        It should_return_zero = () => { _result.Should().Be(0); };
        
        private static Calculator _systemUnderTest;
        private static int _result;
    }

    public class when_receiving_one_number_as_string
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
    
    public class when_receiving_two_numbers_as_string
    {
        Establish _context = () =>
        {
            _systemUnderTest = new Calculator();
        };

        Because of = () => { _result = _systemUnderTest.Add("1,2"); };

        It should_return_the_sum_of_the_numbers = () => { _result.Should().Be(3); };
        
        private static Calculator _systemUnderTest;
        private static int _result;
    }
}