using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    public class AlphabetOperationsRealization
    {
        ALPHABET AlphabetFilled = ALPHABET.GetInstance;

        public AlphabetOperationsRealization() { }
        public char GetElement(int index)
        {
            return AlphabetFilled.GetAlphabetInstance()[index];
        }
        public List<char> GetElements()
        {

            return AlphabetFilled.GetAlphabetInstance();
        }
        public List<char> GetElementsRange(int startIndex, int endIndex)
        {
            List<char> alphabetRange = new List<char>();
            for (int i = startIndex; i <= endIndex; i++)
            {
                alphabetRange.Add(AlphabetFilled.GetAlphabetInstance()[i]);
            }
            return alphabetRange;
        }
        public List<char> GetElementsRangeByStep(int startIndex, int endIndex, int step)
        {
            List<char> alphabetRangeByStep = new List<char>();
            for (int i = startIndex; i <= endIndex; i += step)
            {
                alphabetRangeByStep.Add(AlphabetFilled.GetAlphabetInstance()[i]);
            }
            return alphabetRangeByStep;
        }
        public List<char> GetElementsVowels()
        {
            string vowels = "aeiou";
            List<char> vowelsList = new List<char>();
            foreach (char letter in AlphabetFilled.GetAlphabetInstance())
            {
                if (vowels.Contains(letter))
                {
                    vowelsList.Add(letter);
                }
            }
            return vowelsList;
        }
        public List<char> GetElementsConsonants()
        {
            string vowels = "aeiou";
            List<char> alphabetConsonants = new List<char>();
            foreach (char letter in AlphabetFilled.GetAlphabetInstance())
            {
                if (!vowels.Contains(letter))
                {
                    alphabetConsonants.Add(letter);
                }
            }
            return alphabetConsonants;
        }
    }
}
