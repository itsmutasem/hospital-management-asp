using Microsoft.AspNetCore.Mvc;

namespace hospital_management.Controllers;

public class DoctorController : Controller
{
    
    public IActionResult Index()
    {
        return View();
    }
}