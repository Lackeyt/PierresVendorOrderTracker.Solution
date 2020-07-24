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

    [TestMethod]
    public void GetOrderPrice_ReturnsPrice_String()
    {
      int testPrice =  10;
      Order newOrder = new Order("Test Name", "Test Description", testPrice, "testDate");
      int result = newOrder.Price;
      Assert.AreEqual(testPrice, result);
    }

    [TestMethod]
    public void GetOrderDate_ReturnsDate_String()
    {
      string testDate =  "Test Date";
      Order newOrder = new Order("Test Name", "Test Desc", 10, testDate);
      string result = newOrder.Date;
      Assert.AreEqual(testDate, result);
    }

    [TestMethod]
    public void GetAllOrders_ReturnsOrders_OrderList()
    {
      Order newOrder = new Order("Test Name", "Test Desc", 10, "Test Date");
      Order newOrder2 = new Order("Test Name", "Test Desc", 10, "Test Date");
      List<Order> newList = new List<Order> {newOrder, newOrder2};
      CollectionAssert.AreEqual(newList, Order.GetAll());
    }

    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      Order newOrder = new Order("Test Name", "Test Desc", 10, "Test Date");
      Order newOrder2 = new Order("Test Name", "Test Desc", 10, "Test Date");
      Assert.AreEqual(newOrder2, Order.Find(2));
    }

  }
}