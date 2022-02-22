using System;

namespace CodeLouisvilleProjectBase
{
    class Program
    {
        static void Main(string[] args)
        {
            bool doesThisMakeSense = CodeLouisvilleProjectBase.Prompt4YesNo("Does this make sense? ");
            if (doesThisMakeSense)
                Console.WriteLine("I've got this!!!");
            else
                Console.WriteLine("Blame John");
        }
    }
}
