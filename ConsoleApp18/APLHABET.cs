using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    public sealed class ALPHABET
    {
        private static ALPHABET Instance = null;    
        public static ALPHABET GetInstance
        {
            get
            {
                if (Instance == null)
                {
                    Instance = new ALPHABET();
                }
                return Instance;
            }
        }
        public List<char> Alphabet { get; set; }
        private ALPHABET()
        {
            Alphabet = new List<char>();
        }
        public List<char> GetAlphabetInstance()
        {
            return Alphabet;
        }
        public override string ToString()
        {
            return string.Join(", ", Alphabet);
        }
    }
}
