namespace DiamondKata.ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var givenLetter = ConsoleHandler.GetUserInput();

            var diamondBuilder = new DiamondBuilder(givenLetter);
            var diamond = diamondBuilder.BuildDiamond();
            diamondBuilder.PrintDiamond(diamond);
        }
    }
}