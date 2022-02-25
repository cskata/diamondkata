using System.Text.RegularExpressions;

namespace DiamondKata.ConsoleApp
{
    public static class ConsoleHandler
    {
        private static readonly string _singleLetterOnlyRegex = @"^[a-zA-Z]{1}$";

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

        public static bool IsSingleLetter(string input)
        {
            return Regex.IsMatch(input, _singleLetterOnlyRegex);
        }
    }
}
