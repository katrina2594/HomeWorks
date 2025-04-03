namespace Task_6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение без знаков препинания, состоящее из нескольких слов");
            string str = Console.ReadLine();
            str = str.Replace(" ", "").ToLower();
            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            string str2 = new String(arr);
            int result = string.Compare(str, str2);
            if (result != 0)
            {
                Console.WriteLine("Предложение не является палиндромом");
            }
            else
            {
                Console.WriteLine("Предложение является палиндромом");
            }
            Console.ReadKey();
        }
    }
}
