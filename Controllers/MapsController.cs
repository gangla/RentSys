using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RentSys.Models.Errors;

namespace AspnetCoreMvcFull.Controllers;

public class MapsController : Controller
{
  public IActionResult Leaflet() => View();
}
