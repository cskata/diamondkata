using System.Text;

namespace DiamondKata.ConsoleApp
{
    public class DiamondBuilder
    {
        private const string Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private string _givenLetter { get; }

        public DiamondBuilder(string givenLetter)
        {
            _givenLetter = givenLetter;
        }

        public string BuildDiamond()
        {
            var lineLength = GetLineLength();
            var middleIndex = (lineLength - 1) / 2;

            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < lineLength; i++)
            {
                var newLine = InitializeLineTemplate(lineLength);
                builder.AppendLine(BuildLine(i, middleIndex, newLine));
            }

            return builder.ToString();
        }

        internal void PrintDiamond(string diamond)
        {
            Console.WriteLine(diamond);
        }

        private int GetLineLength()
        {
            var indexInAlphabet = Alphabet.IndexOf(_givenLetter);
            return (indexInAlphabet * 2) + 1;
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

        private void SwapLetters(int middleIndex, int index, ref StringBuilder lineToSwap)
        {
            var letter = Alphabet.ToCharArray()[index];

            var indexToSwap1 = middleIndex + index;
            var indexToSwap2 = middleIndex - index;

            lineToSwap[indexToSwap1] = letter;
            lineToSwap[indexToSwap2] = letter;
        }

        private string InitializeLineTemplate(int lineLength)
        {
            var emptyLine = new StringBuilder(lineLength).Insert(0, " ", lineLength);
            return emptyLine.ToString();
        }
    }
}
