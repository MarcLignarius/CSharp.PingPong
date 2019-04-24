using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPong;

namespace PingPong.Tests
{
  [TestClass]
  public class PingPongTest
  {

    [TestMethod]
    public void ReplacePingPong_NumberEnteredByUser_True()
    {
      PingPong testPingPong = new PingPong();
      Assert.AreEqual("4", testPingPong.ReplacePingPong(4)[3]);
    }

    [TestMethod]
    public void ReplacePingPong_NumberDivisibleByThree_String()
    {
      PingPong testPingPong = new PingPong();
      Assert.AreEqual("Ping!", testPingPong.ReplacePingPong(3)[2]);
    }

    [TestMethod]
    public void ReplacePingPong_NumberDivisibleByFive_String()
    {
      PingPong testPingPong = new PingPong();
      Assert.AreEqual("Pong!", testPingPong.ReplacePingPong(5)[4]);
    }

    [TestMethod]
    public void ReplacePingPong_NumberDivisibleByFifteen_String()
    {
      PingPong testPingPong = new PingPong();
      Assert.AreEqual("Ping-Pong!", testPingPong.ReplacePingPong(15)[14]);
    }

  }
}
