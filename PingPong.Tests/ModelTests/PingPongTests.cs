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
      Assert.AreEqual("4", testPingPong.IsNumberToCountTo(4));
    }

    [TestMethod]
    public void IsNumberToCountTo_NumberDivisibleByThree_True()
    {
      PingPongClass testPingPong = new PingPongClass();
      Assert.AreEqual("ping", testPingPong.IsNumberToCountTo(3));
    }

    [TestMethod]
    public void IsNumberToCountTo_NumberDivisibleByFive_True()
    {
      PingPongClass testPingPong = new PingPongClass();
      Assert.AreEqual("pong", testPingPong.IsNumberToCountTo(5));
    }

    [TestMethod]
    public void IsNumberToCountTo_NumberDivisibleByFifteen_True()
    {
      PingPongClass testPingPong = new PingPongClass();
      Assert.AreEqual("ping-pong", testPingPong.IsNumberToCountTo(15));
    }

  }
}
