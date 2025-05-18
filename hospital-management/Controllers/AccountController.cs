using Microsoft.AspNetCore.Mvc;

namespace hospital_management.Controllers;

public class AccountController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}