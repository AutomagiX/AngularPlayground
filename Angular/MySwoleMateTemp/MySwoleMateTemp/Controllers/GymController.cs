using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MySwoleMateTemp.Models;

namespace MySwoleMateTemp.Controllers
{
    public class GymController : Controller
    {
        MySwoleMateEntities db = new MySwoleMateEntities();
        // GET: Gym
        public ActionResult Index()
        {
            return View();
        }

        // GET: All Gyms
        public JsonResult AllGyms()
        {
            var gyms = db.Gyms.ToList();
            var gymList = new List<GymContainer>();
            foreach(var item in gyms)
            {
                gymList.Add(new GymContainer
                {
                    GymName = item.GymName,
                    City = item.City,
                    State = item.State,
                    Zip = item.Zip.ToString()
                });
            }

            return Json(gymList, JsonRequestBehavior.AllowGet);
        }
    }
}