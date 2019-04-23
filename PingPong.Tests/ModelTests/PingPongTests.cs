using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPong;

namespace PingPong.Tests
{
  [TestClass]
  public class PingPongTest
  {

    [TestMethod]
    public void IsNumberToCountTo_NumberEnteredByUser_True()
    {
      PingPongClass testPingPong = new PingPongClass();
      Assert.AreEqual("4", testPingPong.NumbersInOrder(4)[3]);
    }

    [TestMethod]
    public void IsNumberToCountTo_NumberDivisibleByThree_String()
    {
      PingPongClass testPingPong = new PingPongClass();
      Assert.AreEqual("ping", testPingPong.NumbersInOrder(3)[2]);
    }

    [TestMethod]
    public void IsNumberToCountTo_NumberDivisibleByFive_String()
    {
      PingPongClass testPingPong = new PingPongClass();
      Assert.AreEqual("pong", testPingPong.NumbersInOrder(5)[4]);
    }

    [TestMethod]
    public void IsNumberToCountTo_NumberDivisibleByFifteen_String()
    {
      PingPongClass testPingPong = new PingPongClass();
      Assert.AreEqual("ping-pong", testPingPong.NumbersInOrder(15)[14]);
    }

  }
}
