using System.Text.RegularExpressions;

namespace TestDriveDevelopment
{
    public class StringProcessor
    {
        public string FindShortestWord(string sentence)
        {
            return sentence.Split(' ').OrderBy(word => word.Length).First();
        }

        public int CountWords(string sentence)
        {
            return sentence.Split(' ').Length;
        }

        public int CountCharacters(string sentence)
        {
            return sentence.Length;
        }

        public char FindNinthCharacter(string sentence)
        {
            return sentence[8];
        }

        public int CountDigits(string sentence)
        {
            return sentence.Count(char.IsDigit);
        }

        public int MaxConsecutiveDigits(string sentence)
        {
            int maxCount = 0, currentCount = 0;
            foreach (char c in sentence)
            {
                if (char.IsDigit(c))
                    currentCount++;
                else
                    currentCount = 0;

                if (currentCount > maxCount)
                    maxCount = currentCount;
            }
            return maxCount;
        }

        public int CountAmCombinations(string sentence)
        {
            return Regex.Matches(sentence, "ам").Count;
        }
    }
}