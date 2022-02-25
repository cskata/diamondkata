using System.Text;

namespace DiamondKata.ConsoleApp
{
    internal class DiamondBuilder
    {
        private const string Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private string _givenLetter { get; }
        private string _diamond { get; set; }

        public DiamondBuilder(string givenLetter)
        {
            _givenLetter = givenLetter;
        }

        internal void BuildDiamond()
        {
            var lineLength = GetLineLength();
            var middleIndex = (lineLength - 1) / 2;

            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < lineLength; i++)
            {
                var newLine = InitializeLineTemplate(lineLength);
                builder.AppendLine(BuildLine(i, middleIndex, newLine));
            }

            _diamond = builder.ToString();
        }

        internal void PrintDiamond()
        {
            Console.WriteLine(_diamond);
        }

        private int GetLineLength()
        {
            var placeInAlphabet = Alphabet.IndexOf(_givenLetter);
            return (placeInAlphabet * 2) + 1;
        }

        private string BuildLine(int index, int middleIndex, string newLine)
        {
            StringBuilder lineToSwap = new StringBuilder(newLine);

            if (index <= middleIndex)
            {
                SwapLetters(middleIndex, index, ref lineToSwap);
            }
            else
            {
                var reverseIndex = (middleIndex * 2) - index;
                SwapLetters(middleIndex, reverseIndex, ref lineToSwap);
            }

            return lineToSwap.ToString();
        }

        private void SwapLetters(int middleIndex, int index, ref StringBuilder swappedLine)
        {
            var letter = Alphabet.ToCharArray()[index];

            var indexToSwap1 = middleIndex + index;
            var indexToSwap2 = middleIndex - index;

            swappedLine[indexToSwap1] = letter;
            swappedLine[indexToSwap2] = letter;
        }

        private string InitializeLineTemplate(int lineLength)
        {
            var emptyLine = new StringBuilder(lineLength).Insert(0, " ", lineLength);
            return emptyLine.ToString();
        }
    }
}
