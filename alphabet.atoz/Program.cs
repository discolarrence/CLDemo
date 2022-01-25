using System;
using System.Text;

namespace alphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            AToZ();
            ZToA();
            Console.ReadLine();
        }

        private static void AToZ()
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

        private static void ZToA()
        {
            string backwardsAlphabet;
            var builder = new StringBuilder();
            char letter = 'z';
            while (letter >= 'a')
            {
                builder.Append(letter);
                letter--;
            }
            backwardsAlphabet = builder.ToString();
            Console.WriteLine($"{backwardsAlphabet}");
        }
   
    }
}
