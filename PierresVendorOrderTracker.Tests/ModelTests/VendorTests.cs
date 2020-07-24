using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierresVendorOrderTracker.Models;
using System;

namespace PierresVendorOrderTracker.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {

    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("testName", "testDescription");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetVendorName_ReturnsName_String()
    {
      string testVendorName =  "Test Name";
      Vendor newVendor = new Vendor(testVendorName, "testDescription");
      string result = newVendor.VendorName;
      Assert.AreEqual(testVendorName, result);
    }

    [TestMethod]
    public void GetVendorDesc_ReturnsDescription_String()
    {
      string testVendorDesc =  "Test Description";
      Vendor newVendor = new Vendor("Test Name", testVendorDesc);
      string result = newVendor.VendorDescription;
      Assert.AreEqual(testVendorDesc, result);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      Vendor newVendor = new Vendor("Test Name", "Test Description");
      int result = newVendor.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      Vendor newVendor1 = new Vendor("Test Name", "Test Description");
      Vendor newVendor2 = new Vendor("Test Name2", "Test Description2");
      List<Vendor> newList = new List<Vendor> {newVendor1, newVendor2};
      CollectionAssert.AreEqual(newList, Vendor.GetAll());
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendorById_Vendor()
    {
      Vendor newVendor1 = new Vendor("Test Name", "Test Description");
      Vendor newVendor2 = new Vendor("Test Name2", "Test Description2");
      Assert.AreEqual(newVendor2, Vendor.Find(2));
    }

    [TestMethod]
    public void AddOrder_AssignsOrderToVendor_VendorOrderList()
    {
      Order newOrder = new Order("testTitle", "TestDesc", 10, "testDate");
      List<Order> newOrderList = new List<Order> {newOrder};
      Vendor newVendor1 = new Vendor("Test Name", "Test Description");
      newVendor1.AddOrder(newOrder);
      List<Order> result = newVendor1.VendorOrders;
      CollectionAssert.AreEqual(newOrderList, result);
    }
  }
}