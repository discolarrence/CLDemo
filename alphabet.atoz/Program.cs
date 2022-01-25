using System;
using System.Text;

namespace alphabet.atoz
{
    class Program
    {
        static void Main(string[] args)
        {
            string alphabet;
            var builder = new StringBuilder();
            char letter = 'a';
            while (letter <= 'z')
            {
                builder.Append(letter);
                letter++;
            }
            alphabet = builder.ToString();
            Console.WriteLine($"{alphabet}");
        }
    }
}
