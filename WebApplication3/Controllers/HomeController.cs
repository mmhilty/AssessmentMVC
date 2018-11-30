using WebApplication3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        //public ActionResult Confirmation(string firstName, string lastName, string email,
        //    bool attending, string dateChosen, bool bringGuest, string guestFirstName, string guestLastName,
        //    bool bringDish, string dishName, string dishDescription)

        //{
        //   ViewBag.newattendee = new Attendee(firstName, lastName, email,
        //   attending, dateChosen, bringGuest, guestFirstName, guestLastName,
        //   bringDish, dishName, dishDescription);




        //}


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}