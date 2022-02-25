namespace DiamondKata.ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var givenLetter = ConsoleHandler.GetUserInput();
            Console.WriteLine("The letter is: " + givenLetter);
        }
    }
}