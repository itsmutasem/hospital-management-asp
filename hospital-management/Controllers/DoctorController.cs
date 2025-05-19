using hospital_management.Models;
using Microsoft.AspNetCore.Mvc;

namespace hospital_management.Controllers;

public class DoctorController : Controller
{
    private static List<Doctor> doctors = new List<Doctor>
    {
        new Doctor { DoctorId = 1, FullName = "Dr. Sarah Lee", Specialty = "Cardiology" },
        new Doctor { DoctorId = 2, FullName = "Dr. Ahmed Khan", Specialty = "Orthopedics" },
        new Doctor { DoctorId = 3, FullName = "Dr. Maria Ruiz", Specialty = "Dermatology" },
    };
    public IActionResult Index()
    {
        return View();
    }
}