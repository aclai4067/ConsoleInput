using System;

namespace ConsoleInput
{
    class Program
    {
        static void Main(string[] args)
        {
            var readInt = Console.Read();
            var readString = Convert.ToChar(readInt);
            Console.WriteLine($"{readInt}, {readString}");

            ConsoleKeyInfo enteredKey;

            do
            {
                enteredKey = Console.ReadKey();
                Console.WriteLine($"You input the {enteredKey.Key.ToString()} key");
            } while (enteredKey.Key != ConsoleKey.Escape);


            string sentence;

            do
            {
                Console.WriteLine("Please type a sentence and then press [Enter]");
                sentence = Console.ReadLine();
                Console.WriteLine($@"The sentence you entered:
    {sentence}");
            } while (sentence != "quit");
        }
    }
}
