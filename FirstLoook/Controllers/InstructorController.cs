using FirstLoook.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace FirstLoook.Controllers
{
    public class InstructorController : Controller
    {
        CollegeContext Db = new CollegeContext();
        public IActionResult GettAll()
        {
            //Model
            List<Instructor> DeptList = Db.Instructors.ToList();
            return View(DeptList);

        }
        public IActionResult getOne(int id)
        {
            Instructor dept = Db.Instructors.FirstOrDefault(d => d.Id == id);
            return View(dept);
        }
        public IActionResult New()
        {
            return View(new Instructor());
        }
        public IActionResult Create(Instructor emp)
        {
            if (emp.Name != null)
            {
                Db.Instructors.Add(emp);
                Db.SaveChanges();
                return RedirectToAction("GettAll");
            }
            return View("New", emp);
        }
        public IActionResult Edite(int id)
        {
            Instructor old = Db.Instructors.FirstOrDefault(d => d.Id == id);

            return View(old);
        }
        public IActionResult EditeSave(int id, Instructor empupdated)
        {
            if (empupdated.Name != null)
            {
                Instructor old = Db.Instructors.FirstOrDefault(d => d.Id == id);
                old.Name = empupdated.Name;
                old.Address = empupdated.Address;
                old.Salary = empupdated.Salary;
                old.Image = empupdated.Image;
                old.DeptId = empupdated.DeptId;

                Db.SaveChanges();
                return RedirectToAction("GettAll");
            }
            else
            {
                return View("Edite", empupdated);
            }
        }
    }
}
