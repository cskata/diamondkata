using Xunit;
using DiamondKata.ConsoleApp;

namespace DiamondKata.UnitTest
{
    public class ConsoleHandlerUnitTests
    {
        [Theory]
        [InlineData("a", true)]
        [InlineData("A", true)]
        [InlineData(" ", false)]
        [InlineData("aA", false)]
        [InlineData("aA aA", false)]
        [InlineData("123", false)]
        [InlineData(".-[]", false)]
        public void Console_Only_Accepts_Letter_As_Input(string input, bool result)
        {
            var isLetter = ConsoleHandler.IsSingleLetter(input);
            Assert.Equal(result, isLetter);
        }
    }
}
