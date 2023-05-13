using FirstLoook.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace FirstLoook.Controllers
{
    public class CourseController : Controller
    {
        CollegeContext Db = new CollegeContext();
        public IActionResult GettAll()
        {
            //Model
            List<Course> DeptList = Db.Courses.ToList();
            return View(DeptList);

        }
        public IActionResult getOne(int id)
        {
            Course dept = Db.Courses.FirstOrDefault(d => d.Id == id);
            return View(dept);
        }
        public IActionResult getIns(int id)
        {
            Course dept = Db.Courses.FirstOrDefault(d => d.Id == id);
            return View(dept);
        }
    }
}
