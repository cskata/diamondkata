namespace DiamondKata.ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var givenLetter = ConsoleHandler.GetUserInput();

            var diamondBuilder = new DiamondBuilder(givenLetter);
            diamondBuilder.BuildDiamond();
            diamondBuilder.PrintDiamond();
        }
    }
}