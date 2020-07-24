using System;
using System.Collections.Generic;

namespace PierresVendorOrderTracker.Models
{
  public class Vendor
  {
    public string VendorName { get; set; }
    public string VendorDescription { get; set; }
    private static List<Vendor> _instances = new List<Vendor> {};
    public List<Order> VendorOrders { get; set; }

    public Vendor(string vendorName, string vendorDescription)
    {
      VendorName = vendorName;
      VendorDescription = vendorDescription;
    }
  }

  
}