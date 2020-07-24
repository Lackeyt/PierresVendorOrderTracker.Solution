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
  }
}