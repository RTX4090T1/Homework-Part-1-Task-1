using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    public class AlphabetFiller
    {
        ALPHABET AlphabetAsCreated = ALPHABET.GetInstance;
        public void FillAlphabetOptional(char first, char last)
        {
            for (char letter = first; letter <= last; letter++)
            {
                AlphabetAsCreated.GetAlphabetInstance().Add(letter);
            }
        }
        public bool CheckLanguageOption(string language)
        {
            char first;
            char last;
            if (language == "ukr")
            {
                first = 'а';
                last = 'я';
                FillAlphabetOptional(first, last);
                return true;
            }
            else if (language == "eng")
            {
                first = 'a';
                last = 'z';
                FillAlphabetOptional(first, last);
                return true;
            }
            else
            {
                Console.WriteLine("Unknown language");
                return false;
            }
        }
    }
}
