using Microsoft.AspNetCore.Mvc;
using ParcelCalculator.Models;

namespace ParcelCalculator.Controllers
{
  public class HomeController : Controller
  {

    [Route("/form")]
    public ActionResult Form()
    {
      return View();
    }
    [Route("/parcel_info")]
    public ActionResult ParcelGroup()
    {
      ParcelVariable myParcelVariable = new ParcelVariable();
      myParcelVariable.SetLength(int.Parse(Request.Query["length"]));
      myParcelVariable.SetHeight(int.Parse(Request.Query["height"]));
      myParcelVariable.SetWeight(int.Parse(Request.Query["weight"]));
      myParcelVariable.SetWidth(int.Parse(Request.Query["width"]));
      return View("Parcel_Info", myParcelVariable);
    }
  }
}
