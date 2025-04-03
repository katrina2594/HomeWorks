namespace Task_6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение без знаков препинания, состоящее из нескольких слов");
            string str = Console.ReadLine();
            string[] words = str.Split(' ');
            string longestWord = "";
            foreach (string word in words)
            {
                int length = word.Length;
                if(word.Length> longestWord.Length)
                {
                    longestWord = word;
                }
            }
            Console.WriteLine("Самое длинное слово в предложении: {0} ",longestWord);
            Console.ReadKey();
        }
    }
}
