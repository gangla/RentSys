using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RentSys.Models.Errors;

namespace AspnetCoreMvcFull.Controllers;

public class IconsController : Controller
{
  public IActionResult MdiIcons() => View();
}
