using System;
using System.Text;

namespace alphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AToZ()); ;
            Console.WriteLine(ZToA()); ;
            Console.WriteLine(AToZEveyOther()); 
        }

        public static string AToZ()
        {
            StringBuilder builder = new();
            char letter = 'A';
            while (letter <= 'Z')
            {
                builder.Append(letter);
                letter++;
            }
            return builder.ToString();
        }

        public static string ZToA()
        {
            StringBuilder builder = new();
            char letter = 'Z';
            while (letter >= 'A')
            {
                builder.Append(letter);
                letter--;
            }
            return builder.ToString();
        }

        public static string AToZEveyOther()
        {
            StringBuilder builder = new();
            char letter = 'A';
            while (letter <= 'Z')
            {
                builder.Append(letter);
                letter = (char)(letter + 2);
            }
            return builder.ToString();
        }

    }
}
