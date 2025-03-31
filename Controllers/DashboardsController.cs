using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RentSys.Models.Errors;
using Microsoft.AspNetCore.Authorization;

namespace AspnetCoreMvcFull.Controllers;

public class DashboardsController : Controller
{
  [Authorize]
  public IActionResult Index() => View();
  public IActionResult CRM() => View();
}
