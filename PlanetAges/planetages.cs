using System;

namespace PlanetCalculations
{
  class Program
  {
    static void Main(string[] args)
    {  
      //Please keep in mind that things like 'universalAge' refer to the planet the user has chosen, for example,
      //Ask user what their age is
      Console.WriteLine("What is your current earth age?:  "); // or Console.Write("Type any number:  "); to enter number in the same line
      int x = Int32.Parse(Console.ReadLine());
      
      // Your Age
      int userAge = x;

      //Ask the user what planet they want to here about
      Console.WriteLine("Please choose a planet by typing a number.\r\n1 => Mercury\r\n2 => Venus\r\n3 => Earth\r\n4 => Mars\r\n5 => Jupiter\r\n6 => Saturn\r\n7 => Uranus\r\n8 => Neptune\r\n9 => Pluto");
      int y = Int32.Parse(Console.ReadLine());

      // Chosen Planet
      int chosenPlanet = y;

      // Misplacement

      // Length of years on Chosen Planet (in Earth years)
      if (chosenPlanet == 1) 
        {
          double UniversalYears = 0.2410;
          Console.WriteLine(UniversalYears);

      // Age on the chosen planet
      double universalAge = userAge/UniversalYears;

      // Time to ChosenPlanet
      

      // New Age on Earth
      string appology2 = ("Could not calculate due to unreliable results.");

      // New Age on Jupiter
      string appology3 = ("Could not calculate due to unreliable results.");

      // Log calculations to console
      Console.WriteLine();
      Console.WriteLine("Current Earth Age: " + userAge);
      Console.WriteLine($"Current Age on Mercury: " + universalAge);
      Console.WriteLine("After travelling to Jupiter, your Earth age would be: " + appology2);
      Console.WriteLine("After travelling to Jupiter, your Jupiter age would be: " + appology3);
        } 
      else if (chosenPlanet == 2) 
        {
          double UniversalYears = 0.61561644;
          Console.WriteLine(UniversalYears);

      // Age on the chosen planet
      double universalAge = userAge/UniversalYears;

      // Time to ChosenPlanet
      

      // New Age on Earth
      string appology2 = ("Could not calculate due to unreliable results.");

      // New Age on Jupiter
      string appology3 = ("Could not calculate due to unreliable results.");

      // Log calculations to console
      Console.WriteLine();
      Console.WriteLine("Current Earth Age: " + userAge);
      Console.WriteLine($"Current Age on Venus: " + universalAge);
      Console.WriteLine("After travelling to Jupiter, your Earth age would be: " + appology2);
      Console.WriteLine("After travelling to Jupiter, your Jupiter age would be: " + appology3);
        } 
      else if (chosenPlanet == 3)
      {
        double UniversalYears = 1;
        Console.WriteLine(UniversalYears);

      // Age on the chosen planet
      double universalAge = userAge/UniversalYears;

      // Time to ChosenPlanet
      

      // New Age on Earth
      string appology2 = ("Could not calculate due to unreliable results.");

      // New Age on Jupiter
      string appology3 = ("Could not calculate due to unreliable results.");

      // Log calculations to console
      Console.WriteLine();
      Console.WriteLine("Current Earth Age: " + userAge);
      Console.WriteLine($"Current Age on Earth: " + universalAge);
      Console.WriteLine("After travelling to Jupiter, your Earth age would be: " + appology2);
      Console.WriteLine("After travelling to Jupiter, your Jupiter age would be: " + appology3);
      }
      else if (chosenPlanet == 4)
      {
        double UniversalYears = 1.88219;
        Console.WriteLine(UniversalYears);

      // Age on the chosen planet
      double universalAge = userAge/UniversalYears;

      // Time to ChosenPlanet
      

      // New Age on Earth
      string appology2 = ("Could not calculate due to unreliable results.");

      // New Age on Jupiter
      string appology3 = ("Could not calculate due to unreliable results.");

      // Log calculations to console
      Console.WriteLine();
      Console.WriteLine("Current Earth Age: " + userAge);
      Console.WriteLine($"Current Age on Mars: " + universalAge);
      Console.WriteLine("After travelling to Jupiter, your Earth age would be: " + appology2);
      Console.WriteLine("After travelling to Jupiter, your Jupiter age would be: " + appology3);
      }
      else if (chosenPlanet == 5)
      {
        double UniversalYears = 11.86;
        Console.WriteLine(UniversalYears);

      // Age on the chosen planet
      double universalAge = userAge/UniversalYears;

      // Time to ChosenPlanet
      

      // New Age on Earth
      string appology2 = ("Could not calculate due to unreliable results.");

      // New Age on Jupiter
      string appology3 = ("Could not calculate due to unreliable results.");

      // Log calculations to console
      Console.WriteLine();
      Console.WriteLine("Current Earth Age: " + userAge);
      Console.WriteLine($"Current Age on Jupiter: " + universalAge);
      Console.WriteLine("After travelling to Jupiter, your Earth age would be: " + appology2);
      Console.WriteLine("After travelling to Jupiter, your Jupiter age would be: " + appology3);
      }
      else if (chosenPlanet == 6)
      {
        double UniversalYears = 29;
        Console.WriteLine(UniversalYears);

      // Age on the chosen planet
      double universalAge = userAge/UniversalYears;

      // Time to ChosenPlanet
      

      // New Age on Earth
      string appology2 = ("Could not calculate due to unreliable results.");

      // New Age on Jupiter
      string appology3 = ("Could not calculate due to unreliable results.");

      // Log calculations to console
      Console.WriteLine();
      Console.WriteLine("Current Earth Age: " + userAge);
      Console.WriteLine($"Current Age on Saturn: " + universalAge);
      Console.WriteLine("After travelling to Jupiter, your Earth age would be: " + appology2);
      Console.WriteLine("After travelling to Jupiter, your Jupiter age would be: " + appology3);
      }
      else if (chosenPlanet == 7)
      {
        double UniversalYears = 84;
        Console.WriteLine(UniversalYears);

      // Age on the chosen planet
      double universalAge = userAge/UniversalYears;

      // Time to ChosenPlanet
      

      // New Age on Earth
      string appology2 = ("Could not calculate due to unreliable results.");

      // New Age on Jupiter
      string appology3 = ("Could not calculate due to unreliable results.");

      // Log calculations to console
      Console.WriteLine();
      Console.WriteLine("Current Earth Age: " + userAge);
      Console.WriteLine($"Current Age on Uranus: " + universalAge);
      Console.WriteLine("After travelling to Jupiter, your Earth age would be: " + appology2);
      Console.WriteLine("After travelling to Jupiter, your Jupiter age would be: " + appology3);
      }
      else if (chosenPlanet == 8)
      {
        double UniversalYears = 165;
        Console.WriteLine(UniversalYears);

      // Age on the chosen planet
      double universalAge = userAge/UniversalYears;

      // Time to ChosenPlanet
      

      // New Age on Earth
      string appology2 = ("Could not calculate due to unreliable results.");

      // New Age on Jupiter
      string appology3 = ("Could not calculate due to unreliable results.");

      // Log calculations to console
      Console.WriteLine();
      Console.WriteLine("Current Earth Age: " + userAge);
      Console.WriteLine($"Current Age on Neptune: " + universalAge);
      Console.WriteLine("After travelling to Jupiter, your Earth age would be: " + appology2);
      Console.WriteLine("After travelling to Jupiter, your Jupiter age would be: " + appology3);
      }
      else if (chosenPlanet == 9)
      {
        double UniversalYears = 248;
        Console.WriteLine(UniversalYears);

      // Age on the chosen planet
      double universalAge = userAge/UniversalYears;

      // Time to ChosenPlanet
      

      // New Age on Earth
      string appology2 = ("Could not calculate due to unreliable results.");

      // New Age on Jupiter
      string appology3 = ("Could not calculate due to unreliable results.");

      // Log calculations to console
      Console.WriteLine();
      Console.WriteLine("Current Earth Age: " + userAge);
      Console.WriteLine($"Current Age on Pluto: " + universalAge);
      Console.WriteLine("After travelling to Jupiter, your Earth age would be: " + appology2);
      Console.WriteLine("After travelling to Jupiter, your Jupiter age would be: " + appology3);
      }
      else
      {
        Console.WriteLine("Sorry! You didn't choose a correct number. Try again.");
      }
    }
  }
}
