using System;

//dotnet run

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Money Maker!");
      Console.WriteLine("Enter an amount to convert to coins: ");
      string howMuch = Console.ReadLine();
      double howMuchInt = Convert.ToDouble(howMuch);
      
      Console.WriteLine($"{howMuchInt} cent is equal to...");
      
      int gold = 10;
      int silver = 5;
      
      double goldCoins = Math.Floor(howMuchInt/gold);
			double remaining = goldCoins % gold;
      
      double silverCoins = Math.Floor(remaining / silver);
      remaining = remaining % silver;
      
      Console.WriteLine($"Gold Coins: {goldCoins}, Silver Coins:{silverCoins}, Bronze Coins: {remaining}");
    }
  }
}
