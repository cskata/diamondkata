using System.Text.RegularExpressions;

namespace DiamondKata.ConsoleApp
{
    internal static class ConsoleHandler
    {
        private static readonly string LetterOnlyRegex = @"^[a-zA-Z]{1}$";

        internal static string GetUserInput()
        {
            Console.WriteLine("Please type a single letter.");
            var letter = Console.ReadLine();

            while (!IsSingleLetter(letter))
            {
                Console.WriteLine("That is not a single letter. Please try again.");
                letter = Console.ReadLine();
            }

            return letter.ToUpper();
        }

        internal static bool IsSingleLetter(string? input)
        {
            if (input == null)
            {
                return false;
            }

            return Regex.IsMatch(input, LetterOnlyRegex);
        }
    }
}
