using System;

namespace PlanetCalculations
{
  class Program
  {
    static void Main(string[] args)
    {  
      //Ask user what their age is
      Console.WriteLine("What is your current earth age?:  "); // or Console.Write("Type any number:  "); to enter number in the same line
      int x = Int32.Parse(Console.ReadLine());
      
      // Your Age
      int userAge = x;

      // Length of years on Jupiter (in Earth years)
      double jupiterYears = 11.86;

      // Age on Jupiter
      double jupiterAge = userAge/jupiterYears;

      // Time to Jupiter
      double journeyToJupiter = 6.142466;

      // New Age on Earth
      double newEarthAge = userAge + journeyToJupiter;

      // New Age on Jupiter
      double newJupiterAge = newEarthAge/jupiterYears;

      // Log calculations to console
      Console.WriteLine();
      Console.WriteLine("Current Earth Age: " + userAge);
      Console.WriteLine("Current Age on Jupiter: " + jupiterAge);
      Console.WriteLine("After travelling to Jupiter, your Earth age would be: " + newEarthAge);
      Console.WriteLine("After travelling to Jupiter, your Jupiter age would be: " + newJupiterAge);


    }
  }
}
