using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RentSys.Models.Errors;

namespace AspnetCoreMvcFull.Controllers;

public class ModalsController : Controller
{
  public IActionResult Examples() => View();
}
