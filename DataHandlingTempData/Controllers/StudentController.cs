using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataHandlingTempData.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult StudentView()
        {
            TempData["Name"] = "Anu";
            TempData["Email"] = "anu@gmail.com";
            TempData["DateOfBirth"] = "12-23-2020";
            TempData["Place"] = "Piravom";
            TempData["Malayalam"] = 34;
            TempData["Maths"] =78;
            TempData["English"] = 90;
            return View();
        }
    }
}