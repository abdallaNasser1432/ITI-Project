using FirstLoook.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace FirstLoook.Controllers
{
    public class TraineeController : Controller
    {
        CollegeContext Db = new CollegeContext();
        public IActionResult GettAll()
        {
            //Model
            List<Trainee> DeptList = Db.Trainees.ToList();
            return View(DeptList);

        }
        public IActionResult getOne(int id)
        {
            Trainee dept = Db.Trainees.FirstOrDefault(d => d.Id == id);
            return View(dept);
        }
        public IActionResult New()
        {
            return View(new Trainee());
        }
        public IActionResult Create(Trainee emp)
        {
            if (emp.Name != null)
            {
                Db.Trainees.Add(emp);
                Db.SaveChanges();
                return RedirectToAction("GettAll");
            }
            return View("New", emp);
        }
        public IActionResult Edite(int id)
        {
            Trainee old = Db.Trainees.FirstOrDefault(d => d.Id == id);

            return View(old);
        }
        public IActionResult EditeSave(int id, Trainee empupdated)
        {
            if (empupdated.Name != null)
            {
                Trainee old = Db.Trainees.FirstOrDefault(d => d.Id == id);
                old.Name = empupdated.Name;
                old.Address = empupdated.Address;
                old.Grade = empupdated.Grade;
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
