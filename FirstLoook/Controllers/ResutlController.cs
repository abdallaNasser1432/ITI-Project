using FirstLoook.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace FirstLoook.Controllers
{
    public class ResutlController : Controller
    {
        CollegeContext Db = new CollegeContext();
        public IActionResult GettAll()
        {
            
            //Model
            List<CrsResult> DeptList = Db.Results.ToList();
            return View(DeptList);

        }
        public IActionResult Edite(int id)
        {
            CrsResult old = Db.Results.FirstOrDefault(d => d.Id == id);

            return View(old);
        }
        public IActionResult EditeSave(int id, CrsResult empupdated)
        {
            
                CrsResult old = Db.Results.FirstOrDefault(d => d.Id == id);
                old.degree = empupdated.degree;
                Db.SaveChanges();
                return RedirectToAction("GettAll");
            
        }
    }
}
