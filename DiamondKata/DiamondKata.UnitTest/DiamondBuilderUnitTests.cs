using Xunit;
using DiamondKata.ConsoleApp;

namespace DiamondKata.UnitTest
{
    public class DiamondBuilderUnitTests
    {
        [Theory]
        [InlineData("A", "A")]
        [InlineData("B", " A B B A ")]
        [InlineData("C", "  A   B B C   C B B   A  ")]
        [InlineData("D", "   A     B B   C   C D     D C   C   B B     A   ")]
        public void Input_Gives_Correct_Diamond_Shape(string input, string result)
        {
            var diamondBuilder = new DiamondBuilder(input);
            var diamond = diamondBuilder.BuildDiamond().Replace("\r\n", "");
            Assert.Equal(result, diamond);
        }

        [Theory]
        [InlineData("A", 1)]
        [InlineData("B", 3 * 3)]
        [InlineData("C", 5 * 5)]
        [InlineData("D", 7 * 7)]
        public void Diamond_Has_Proper_Size(string input, int expectedLength)
        {
            var diamondBuilder = new DiamondBuilder(input);
            var diamond = diamondBuilder.BuildDiamond().Replace("\r\n", "");
            Assert.Equal(expectedLength, diamond.Length);
        }
    }
}