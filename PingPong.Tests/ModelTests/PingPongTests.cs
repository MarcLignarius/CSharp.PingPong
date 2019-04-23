using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPong;

namespace PingPong.Tests
{
  [TestClass]
  public class PingPongTest
  {

    [TestMethod]
    public void NumberToCountTo_IsEnteredByUser_True()
    {
      PingPongClass testPingPong = new PingPongClass();
      Assert.AreEqual("5", testPingPong.NumberToCountTo(5));
    }
  }
}
