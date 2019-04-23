using System;
using System.Collections.Generic;

namespace PingPong
{
  public class PingPongClass
  {

    public List<string> NumbersInOrder(int number)
    {
      List<string> numberList = new List<string>();

      for (int i = 1; i <= number; i++)
      {
        numberList.Add(IsNumberToCountTo(i));
      }
      return numberList;
    }

    public string IsNumberToCountTo(int number)
    {
      if (number % 15 == 0)
      {
        return ("ping-pong");
      }
      if (number % 3 == 0)
      {
        return ("ping");
      }
      if (number % 5 == 0)
      {
        return ("pong");
      }
      return number.ToString();
    }
  }
}












        // function makeArray(number) {
        //   var output = [];
        //   var numberString = number.toString();
        //   for (var i = 0; i <= number; i++)
        //   output.push(changeNumber(i));
        //   return output;
