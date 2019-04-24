using System;
using System.Collections.Generic;

namespace PingPong
{
  public class PingPong
  {

    public static void Main()
    {
      PingPong newPingPong = new PingPong();
      Console.WriteLine("Welcome to Ping Pong program. This program will count up to a number you enter and replace:");
      Console.WriteLine("- numbers divisible by 3 with 'Ping!'");
      Console.WriteLine("- numbers divisible by 5 with 'Pong!'");
      Console.WriteLine("- numbers divisible by 3 and 5 with 'Ping Pong!'");
      Console.WriteLine("-----------------------");
      Console.WriteLine("Please enter a number: ");
      string stringUserInput = Console.ReadLine();
      int userInput = int.Parse(stringUserInput);
      for (int i = 1; i <= userInput; i++)
      {
        Console.WriteLine(newPingPong.ReplacePingPong(i));
      }
    }

    public string ReplacePingPong(int number)
    {
      if (number % 15 == 0)
      {
        return ("Ping Pong!");
      }
      if (number % 3 == 0)
      {
        return ("Ping!");
      }
      if (number % 5 == 0)
      {
        return ("Pong!");
      }
      return number.ToString();
    }
  }
}
