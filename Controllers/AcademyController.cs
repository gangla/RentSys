using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace AspnetCoreMvcFull.Controllers;

public class AcademyController : Controller
{
  public IActionResult Dashboard() => View();
  public IActionResult MyCourse() => View();
  public IActionResult CourseDetails() => View();
}
