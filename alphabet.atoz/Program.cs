using System;
using System.Text;

namespace alphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            string mainMenuChoice = "";

            while (mainMenuChoice != "0")
            {
                Console.WriteLine("Type a number for what you want to see.\n" +
                    "1 Alphabetical Order\n" +
                    "2 Backwards Alphabetical Order\n" +
                    "3 Alphabetical Order with Skipped Letters\n" +
                    "0 Exit");

                mainMenuChoice = Console.ReadLine();

                if (mainMenuChoice == "1")
                {
                    Console.WriteLine($"\n{ AToZ(GetStartLetter()) }\n");
                }
                if (mainMenuChoice == "2")
                {
                    Console.WriteLine($"\n{ ZToA(GetStartLetter()) }\n");
                }
                if (mainMenuChoice == "3")
                {
                    Console.WriteLine($"\n{ AToZSkip(GetSkipNumber(), GetStartLetter()) }\n");
                }

            }

        }

        private static int GetSkipNumber()
        {
            bool validInt = false;
            int skipInt = 0;

            while (skipInt == 0 || validInt == false)
            {
                Console.WriteLine("How many letters would you like to skip?");
                string skipString = Console.ReadLine();
                validInt = int.TryParse(skipString, out skipInt);
            }

            return skipInt;
        }

        private static char GetStartLetter()
        {
            bool validChar = false;
            char startLetterChar = '0';

            while (char.ToUpper(startLetterChar) < 'A' || char.ToUpper(startLetterChar) > 'Z' || validChar == false)
            {
                Console.WriteLine("What is the starting letter?");
                string startLetterString = Console.ReadLine();
                validChar = char.TryParse(startLetterString, out startLetterChar);

            }

            return char.ToUpper(startLetterChar);
        }

        public static string AToZ(char startLetter)
        {
            StringBuilder builder = new();
            char letter = startLetter;
            while (letter <= 'Z')
            {
                builder.Append(letter);
                letter++;
            }
            return builder.ToString();
        }

        public static string ZToA(char startLetter)
        {
            StringBuilder builder = new();
            char letter = startLetter;
            while (letter >= 'A')
            {
                builder.Append(letter);
                letter--;
            }
            return builder.ToString();
        }

        public static string AToZSkip(int step, char startLetter)
        {
            StringBuilder builder = new();
            char letter = startLetter;
            while (letter <= 'Z')
            {
                builder.Append(letter);
                letter = (char)(letter + step);
            }
            return builder.ToString();
        }

    }
}
