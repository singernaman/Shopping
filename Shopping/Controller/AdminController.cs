using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shopping.Model;

namespace Shopping
{
    public class AdminController : Controller
    {
        DatabaseContext db = new DatabaseContext();

        public IActionResult login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult login(Admin adm)
        {
            var data = (from a in db.Admins where a.admin_email == adm.admin_email && a.admin_password == adm.admin_password select a).ToList();
            if (data.Count > 0)
            {
                return RedirectToAction("", "Index");
            }
            else
            {
                ViewBag.msg = "Admin Login failed";
            }
            return View();
        }
    }
}

    
