using System.Globalization;
using static System.Net.Mime.MediaTypeNames;

namespace Task_Extra_1_2
{
    internal class Program
    {
        const string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст для шифрования");
            string text = Console.ReadLine().ToUpper();
            string newWord = Encrypt(text);
            Console.WriteLine($"Зашифрованный текст: {newWord}");
            string newWord2 = Encrypt(newWord);
            Console.WriteLine($"Дешифрованный текст: {newWord2}");
            Console.ReadKey();
        }
        static string Encrypt(string text)
        {
            string newWord = "";
            foreach (char letter in text)
            {
                int indexLetter = alphabet.IndexOf(letter);
                if (indexLetter >= 0)
                {
                    int indexAfter = (alphabet.Length - 1) - indexLetter;
                    newWord = newWord + alphabet[indexAfter];
                }
                else
                {
                    newWord = newWord + letter;
                }
            }
            return newWord;
        }

    }
}
