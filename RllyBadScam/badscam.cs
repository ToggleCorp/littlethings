using System;

namespace NameGrab
{
  class Program
  {
    static void Main(string[] args)
    {
      // User Name
      string name = "Farhad Hesam Abbasi";

      // Get first letter
      int charPosition = name.IndexOf("F");
      char firstLetter = name[charPosition];

      // Get last name
      int lastnamePosition = name.IndexOf("Hesam Abbasi");
      string lastName = name.Substring(lastnamePosition);

      // Print results
      Console.WriteLine($"Dear {firstLetter}. {lastName}, you have one millon dollar!\r\nPlese clik on the link beloe!");
      Console.WriteLine("");

      //Press any key to exit.
      Console.WriteLine("Please press the enter key on your keyboard to exit the program. ");
      string exitkey = Console.ReadLine();

    }
  }
}
