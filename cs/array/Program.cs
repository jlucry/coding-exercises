using System;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "Hello, I want you to remove some letters. Thank!";
            string toRemove = "aeiouy";
            
            Console.WriteLine(sentence);
            Console.WriteLine(toRemove);

            string result = RemoveCharacters.RunEnhanced(sentence, toRemove);
            Console.WriteLine(result+":"+result.Length);
            result = RemoveCharacters.RunBasic(sentence, toRemove);
            Console.WriteLine(result+":"+result.Length);

            sentence = "Hello google go fast";
            Console.WriteLine(sentence);
            result = DeduplicateCharacters.RunBasic(sentence);
            Console.WriteLine(result+":"+result.Length);
        }
    }
}
