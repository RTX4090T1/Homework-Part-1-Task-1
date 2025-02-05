using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    public class AlpHaBetOperations: IAlphabetOperations
    {
        AlphabetOperationsRealization alphabetOperationsRealization = new AlphabetOperationsRealization();
        public char GetElement(int index)
        {
            return alphabetOperationsRealization.GetElement(index);
        }
        public List<char> GetElements()
        {
            return alphabetOperationsRealization.GetElements();
        }
        public List<char> GetElementsRange(int startIndex, int endIndex)
        {
            return alphabetOperationsRealization.GetElementsRange(startIndex, endIndex);
        }
        public List<char> GetElementsRangeByStep(int startIndex, int endIndex, int step)
        {
            return alphabetOperationsRealization.GetElementsRangeByStep(startIndex, endIndex, step);
        }
        public List<char> GetElementsVowels()
        {
            return alphabetOperationsRealization.GetElementsVowels();
        }
        public List<char> GetElementsConsonants()
        {
            return alphabetOperationsRealization.GetElementsConsonants();
        }
    }
}
