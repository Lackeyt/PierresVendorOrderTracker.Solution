using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierresVendorOrderTracker.Models;
using System;

namespace PierresVendorOrderTracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {

    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("testTitle", "TestDesc", 10, "testDate");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
  }
}