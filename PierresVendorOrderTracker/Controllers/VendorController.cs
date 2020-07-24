using Microsoft.AspNetCore.Mvc;

namespace PierresVendorOrderTracker.Controllers
{
  public class VendorController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

  }
}