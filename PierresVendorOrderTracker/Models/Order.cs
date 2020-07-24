using System;
using System.Collections.Generic;

namespace PierresVendorOrderTracker.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public string Date { get; set; }
    public int Id { get; }
    private static int IdAssignment = 1;
    private static List<Order> _instances = new List<Order> {};

    public Order(string title, string desc, int price, string date)
    {
      Title = title;
      Description = desc;
      Price = price;
      Date = date;
      _instances.Add(this);
      Id = IdAssignment;
      IdAssignment += 1;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}