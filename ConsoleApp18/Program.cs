using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Завдання 1
//Створіть клас «Алфавіт», в якому мають міститися
//літери англійського алфавіту. Реалізуйте підтримку іте-
//ратора. Протестуйте можливість використання foreach
//для класу «Алфавіт».
//Завдання 2
//Створіть клас «Будинок», в якому має міститися ін-
//формація про квартири в цьому будинку. Створіть клас
//«Квартира» з інформацією про мешканців квартир. Реалі-
//зуйте підтримку ітератора для класів «Будинок» і «Квар-
//тира». Протестуйте можливість використання foreach для
//класів «Будинок» і «Квартира».
//Завдання 3
//Створіть клас «Гараж». Клас має містити інформацію
//про машини, які знаходяться в гаража. Створіть клас
//«Автомобіль», в якому, відповідно, міститься інформація
//про автомобіль. Реалізуйте підтримку ітератора для класу
//«Гараж». Протестуйте можливість використання foreach
//для класу «Гараж».
namespace ConsoleApp18
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, let`s learn alphabet(en, ukr) togather!");
            ALPHABET alphabet = ALPHABET.GetInstance;
            AlphabetFiller alphabetFiller = new AlphabetFiller();
            AlpHaBetOperations alphabetOperations = new AlpHaBetOperations();

            void GetLanguage()
            {           
                    Console.WriteLine("Choose language(eng, ukr)");
                    string language = Console.ReadLine();
                    if (alphabetFiller.CheckLanguageOption(language))
                    {
                        AlphabetOperations();
                    }
                    else
                    {
                        Console.WriteLine("Incorrect language choosen");
                    }
            }
            void AlphabetOperations()
            {
                int startStop;
                do
                {
                    Console.WriteLine("Enter 1 to start 0 to finish: ");
                    startStop = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Choose operation:");
                    Console.WriteLine("1. Get element by index");
                    Console.WriteLine("2. Get all elements");
                    Console.WriteLine("3. Get elements by range");
                    Console.WriteLine("4. Get elements by range and step");
                    Console.WriteLine("5. Get vowels");
                    Console.WriteLine("6. Get consonants");
                    int operation = Convert.ToInt32(Console.ReadLine());
                    switch (operation)
                {
                    case 1:
                        Console.WriteLine("Enter index:");
                        int index = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(string.Join(", ", alphabetOperations.GetElement(index)));
                        break;
                    case 2:
                        Console.WriteLine(string.Join(", ", alphabetOperations.GetElements())); 
                        break;
                    case 3:
                        Console.WriteLine("Enter start index:");
                        int startIndex = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter end index:");
                        int endIndex = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(string.Join(", ", alphabetOperations.GetElementsRange(startIndex, endIndex)));
                        break;
                    case 4:
                        Console.WriteLine("Enter start index:");
                        int startIndexStep = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter end index:");
                        int endIndexStep = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter step:");
                        int step = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(string.Join(", ", alphabetOperations.GetElementsRangeByStep(startIndexStep, endIndexStep, step)));
                        break;
                    case 5:
                        Console.WriteLine(string.Join(", ", alphabetOperations.GetElementsVowels()));
                        break;
                    case 6:
                        Console.WriteLine(string.Join(", ", alphabetOperations.GetElementsConsonants()));
                        break;
                    default:
                        Console.WriteLine("Unknown operation");
                        break;
                }
                } while (startStop != 0);             
            }
        GetLanguage();
        }
    }
}
