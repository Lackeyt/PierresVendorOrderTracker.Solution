using Microsoft.AspNetCore.Mvc;

namespace PierresVendorOrderTracker.Controllers
{
  public class OrderController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

  }
}