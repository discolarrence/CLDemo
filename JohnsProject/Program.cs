using System;
using System.Collections.Generic;
using CodeLouisvilleLibrary;

namespace JohnsProject
{
    class Program
    {
        static void Main(string[] args)
        {
            bool doesThisMakeSense = CodeLouisvilleAppBase.Prompt4YesNo("Does this make sense? ");
            if (doesThisMakeSense)
                Console.WriteLine("I've got this!!!");
            else
                Console.WriteLine("Blame John");

            var menuItem1 = new KeyValuePair<string, string>("A", "Option #1");
            var menuItem2 = new KeyValuePair<string, string>("B", "Option #2");
            var menuItem3 = new KeyValuePair<string, string>("C", "Option #3");
            var menu = new List<KeyValuePair<string, string>>();
            menu.Add(menuItem1);
            menu.Add(menuItem2);
            menu.Add(menuItem3);
            string userSelection = CodeLouisvilleAppBase.Prompt4MenuItem("Please select one of the following options: ", menu);
            switch (userSelection)
            {
                case "A":
                    // do something
                    break;
                case "B":
                    // do something
                    break;
                case "C":
                    // do something
                    break;
                default:
                    // user didn't select one of the available options
                    // we should handle accordingly
                    break;
            }
        }
    }
}
