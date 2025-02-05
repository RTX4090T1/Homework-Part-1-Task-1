using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    public interface IAlphabetOperations
    {
        char GetElement(int index);
        List<char> GetElements();
        List<char> GetElementsRange(int startIndex, int endIndex);
        List<char> GetElementsRangeByStep(int startIndex, int endIndex, int step);
        List<char> GetElementsVowels();
        List<char> GetElementsConsonants();
    }
}
