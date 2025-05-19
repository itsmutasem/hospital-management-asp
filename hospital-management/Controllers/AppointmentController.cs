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
        
        public IActionResult BookAppointment()
        {
            return View(_slots);
        }

        [HttpPost]
        public IActionResult Book(SlotViewModel slot)
        {
            // Here you would save to the database; for now just show a message:
            TempData["SuccessMessage"] = 
                $"Your appointment on {slot.Day:MMMM d, yyyy} at {slot.Time} with {slot.DoctorName} has been booked.";

            // Optionally remove the booked slot from the static list:
            _slots.RemoveAll(s => 
                s.DoctorId == slot.DoctorId 
                && s.Day == slot.Day 
                && s.Time == slot.Time);

            return RedirectToAction(nameof(BookAppointment));
        }
    }
}