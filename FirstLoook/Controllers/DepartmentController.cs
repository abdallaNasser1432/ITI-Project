using FirstLoook.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace FirstLoook.Controllers
{
    public class DepartmentController : Controller
    {
        CollegeContext Db=new CollegeContext();
        public IActionResult GettAll()
        {
            //Model
            List<Department> DeptList = Db.Departments.ToList();
            return View(DeptList); 

        }
        public IActionResult getOne(int id)
        {
            Department dept = Db.Departments.FirstOrDefault(d => d.Id == id);
            return View(dept);
        }
        public IActionResult getEmp(int id)
        {
            Department dept = Db.Departments.FirstOrDefault(d => d.Id == id);
            return View(dept);
        }
        public IActionResult New()
        {
            return View(new Department());
        }
        public IActionResult Create(Department emp)
        {
            if (emp.Name != null)
            {
                Db.Departments.Add(emp);
                Db.SaveChanges();
                return RedirectToAction("GettAll");
            }
            return View("New", emp);
        }
        public IActionResult Edite(int id)
        {
            Department old = Db.Departments.FirstOrDefault(d => d.Id == id);

            return View(old);
        }
        public IActionResult EditeSave(int id, Department empupdated)
        {
            if (empupdated.Name != null)
            {
                Department old = Db.Departments.FirstOrDefault(d => d.Id == id);
                old.Name = empupdated.Name;
                old.Manger_Name = empupdated.Manger_Name;
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
