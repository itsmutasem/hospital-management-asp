using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using hospital_management.ViewModels;

namespace YourNamespace.Controllers
{
    public class AppointmentController : Controller
    {
        private static readonly List<SlotViewModel> _slots = new List<SlotViewModel>
        {
            new SlotViewModel { Day = new DateTime(2025,5,26), Time="09:00 AM", DoctorId=1, DoctorName="Dr. Sarah Lee", Major="Cardiology" },
            new SlotViewModel { Day = new DateTime(2025,5,26), Time="10:00 AM", DoctorId=2, DoctorName="Dr. Ahmed Khan", Major="Orthopedics" },
            new SlotViewModel { Day = new DateTime(2025,5,27), Time="01:00 PM", DoctorId=3, DoctorName="Dr. Maria Ruiz", Major="Dermatology" },
        };
        private static readonly HashSet<string> _bookedKeys = new();
        
        public IActionResult BookAppointment()
        {
            ViewBag.BookedKeys = _bookedKeys;
            return View(_slots);
        }

        [HttpPost]
        public IActionResult Book(SlotViewModel slot)
        {
            var key = $"{slot.DoctorId}_{slot.Day:O}_{slot.Time}";
            _bookedKeys.Add(key);

            TempData["SuccessMessage"] =
                $"Your appointment on {slot.Day:MMMM d, yyyy} at {slot.Time} with {slot.DoctorName} has been booked.";

            return RedirectToAction(nameof(BookAppointment));
        }
    }
}