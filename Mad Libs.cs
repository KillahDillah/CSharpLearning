using System;

namespace MadLibs
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
      This program is a Mad-Lib app
      Author: MEEEE

      dotnet run
      */

      // Let the user know that the program is starting:
			Console.WriteLine("Ready...Begin!");

      // Give the Mad Lib a title:
      string title = "White Rabbit";

      Console.WriteLine(title);
      // Define user input and variables:
      Console.Write("Enter a noun: ");
			string noun = Console.ReadLine();
      
      Console.Write("Enter an adj: ");
			string adj1 = Console.ReadLine();
      
      Console.Write("Enter an adj: ");
			string adj2 = Console.ReadLine();      
      
      Console.Write("Enter an adj: ");
			string adj3 = Console.ReadLine();

      // The template for the story:
			
      string story = "This morning _ woke up feeling _. 'It is going to be a _ day!' Outside, a bunch of _s were protesting to keep _ in stores. They began to _ to the rhythm of the _, which made all the _s very _. Concerned, _ texted _, who flew _ to _ and dropped _ in a puddle of frozen _. _ woke up in the year _, in a world where _s ruled the world.";


      // Print the story:

    }
  }
}
