using Microsoft.AspNetCore.Mvc;

namespace hospital_management.Controllers;

public class PatientController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}