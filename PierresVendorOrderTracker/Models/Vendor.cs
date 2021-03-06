using System.Collections.Generic;

namespace PierresVendorOrderTracker.Models
{
  public class Vendor
  {
    public string VendorName { get; set; }
    public string VendorDescription { get; set; }
    public int Id { get; }
    private static List<Vendor> _instances = new List<Vendor> {};
    public List<Order> VendorOrders { get; set; }
    private static int IdAssignment = 1;

    public Vendor(string vendorName, string vendorDescription)
    {
      VendorName = vendorName;
      VendorDescription = vendorDescription;
      Id = IdAssignment;
      IdAssignment += 1;
      _instances.Add(this);
      VendorOrders = new List<Order>{};
    }

    public static void ClearAll()
    {
      _instances.Clear();
      IdAssignment = 1;
    }

    public static List<Vendor> GetAll()
    {
      return _instances;
    }

    public static Vendor Find(int searchId)
    {
      return _instances[searchId-1];
    }

    public void AddOrder(Order order)
    {
      VendorOrders.Add(order);
    }
  }
}