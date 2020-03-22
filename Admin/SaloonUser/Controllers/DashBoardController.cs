using DataLayer.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SaloonUser.Controllers
{
    public class DashBoardController : Controller
    {
        public ActionResult Index()
        {
            List<tblcheckin> checkins = new List<tblcheckin>();
            using (var context = new saloondbEntities())
            {
                DateTime startDateTime = DateTime.Today; //Today at 00:00:00
                DateTime endDateTime = DateTime.Today.AddDays(1).AddTicks(-1); //Today at 23:59:59

                int saloonid = Convert.ToInt32(TempData["saloonid"]);


                checkins = context.checkins.Include("tbluser")
                    .Where(a => a.checkin_time >= startDateTime && a.checkin_time <= endDateTime)
                    .Where(p => p.saloon_id == saloonid)
                    .ToList();
            }
            return View(checkins);
        }
        public ActionResult logout()
        {
            return View();
        }

        public ActionResult mywallet()
        {
            return View();
        }
        public ActionResult setting()
        {
            return View();
        }
        public ActionResult profile()
        {
            return View();
        }

    }
}