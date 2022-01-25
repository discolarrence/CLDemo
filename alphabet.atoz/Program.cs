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
            AToZEveyOther();
        }

        private static void AToZ()
        {
            string alphabet;
            var builder = new StringBuilder();
            char letter = 'A';
            while (letter <= 'Z')
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
            char letter = 'Z';
            while (letter >= 'A')
            {
                builder.Append(letter);
                letter--;
            }
            backwardsAlphabet = builder.ToString();
            Console.WriteLine($"{backwardsAlphabet}");
        }

        private static void AToZEveyOther()
        {
            string alphabet;
            var builder = new StringBuilder();
            char letter = 'A';
            while (letter <= 'Z')
            {
                builder.Append(letter);
                letter++;
                letter++;
            }
            alphabet = builder.ToString();
            Console.WriteLine($"{alphabet}");
        }

    }
}
