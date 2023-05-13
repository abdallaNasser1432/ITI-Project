using FirstLoook.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace FirstLoook.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult GetAll()
        {
            List<Student> student = StudentDate.StudentList;
            return View("Display01", student);
        }
        public IActionResult GetOne(int id)
        {
            Student student = StudentDate.StudentList.FirstOrDefault(p => p.Id == id);
            return View("Display02", student);
        }
    }
}
