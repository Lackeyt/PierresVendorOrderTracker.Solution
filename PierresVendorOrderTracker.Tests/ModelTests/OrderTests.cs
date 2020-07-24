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

    [TestMethod]
    public void GetOrderTitle_ReturnsTitle_String()
    {
      string testTitle =  "Test Title";
      Order newOrder = new Order(testTitle, "testDescription", 10, "testDate");
      string result = newOrder.Title;
      Assert.AreEqual(testTitle, result);
    }

    [TestMethod]
    public void GetOrderDescription_ReturnsDescription_String()
    {
      string testDescription =  "Test Description";
      Order newOrder = new Order("Test Name", testDescription, 10, "testDate");
      string result = newOrder.Description;
      Assert.AreEqual(testDescription, result);
    }
  }
}