using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataLayer;
using DataLayer.EntityModel;

namespace SaloonUser.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult OnLogin(FormCollection formCollection)
        {
            tblsaloonuser saloonuser = new tblsaloonuser();
           
            string email = formCollection["email"];
            string password = formCollection["password"];
            using (var ctx = new saloondbEntities())
            {
                saloonuser = ctx.saloonusers.Where(p => p.email == email).FirstOrDefault();
            }
            if (saloonuser == null)
                return View("Error");
            else
            {
                TempData["saloonid"] = saloonuser.id;
                return RedirectToAction("Index", "DashBoard");
            }
        }

        public ActionResult Error()
        {
            return View();
        }

        public ActionResult SignUp()
        {
            return View();
        }

        public ActionResult OnSignUp(FormCollection formCollection)
        {
            tblsaloonuser saloonUser = new tblsaloonuser();
            saloonUser.name = formCollection["name"];
            saloonUser.saloon_name = formCollection["saloon"];
            saloonUser.email = formCollection["email"];
            saloonUser.password = formCollection["password"];
            saloonUser.phone = formCollection["phoneNo"];
            saloonUser.Address = formCollection["address"];
            saloonUser.zipcode = formCollection["zip"];
            saloonUser.businesshrs_from = System.TimeSpan.Parse(formCollection["businesshrs_from"]);
            saloonUser.businesshrs_to = System.TimeSpan.Parse(formCollection["businesshrs_to"]);
            saloonUser.role_id = 2;
            saloonUser.lattitude = 0;
            saloonUser.longitude = 0;
            using (saloondbEntities DBModel = new saloondbEntities())
            {
                DBModel.saloonusers.Add(saloonUser);
                DBModel.SaveChanges();
            }
            return RedirectToAction("Login");
        }
    }
}