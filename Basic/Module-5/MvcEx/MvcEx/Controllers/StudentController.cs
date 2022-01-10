using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcEx.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }
        public string Welcome()
        {
            return "Hello, this is welcome action message";
        }
        public string ShowStudent(string StudentName)
        {
            return "You selected " + StudentName + " student";
        }
    }
}