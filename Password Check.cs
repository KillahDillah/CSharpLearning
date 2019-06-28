using System;

namespace PasswordChecker
{
  class Program
  {
    public static void Main(string[] args)
    {
			int minLength = 8;
      string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
      string lowercase = "abcdefghijklmnopqrstuvwxyz";
      string digits = "1234567890";
      string specialChars = "!@#$%^&*'/?:;";
      
      Console.WriteLine("Password:");
      string password = Console.ReadLine();
      
      int score = 0;
      
      if (password.Length >= minLength)
      {
        score++;
      }
      if (Tools.Contains(password, uppercase))
      {
        score++;
      }      
      if (Tools.Contains(password, lowercase))
      {
        score++;
      }      
      if (Tools.Contains(password, digits))
      {
        score++;
      }
      Console.WriteLine(score);
      switch (score)
      {
        case 5:
          Console.WriteLine("Strongest Password");
          break;
        case 4:
          Console.WriteLine("Strong Password");
          break;
        case 3:
          Console.WriteLine("Strong");
          break;
        case 2:
          Console.WriteLine("medium");
          break;
        case 1:
          Console.WriteLine("weak");
          break;
        default:
          Console.WriteLine("NOPE");
          break;
      }
    }
  }
}
