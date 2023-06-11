using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab2_task_2.Models;

namespace Lab2_task_2.Controllers
{
    public class CompanyController : Controller
    {

        public ActionResult Index()
        {
            ViewBag.name = "Roy ITs";
            return View();
        }

        public ActionResult Service() {

            var s1 = new Service() {
                Name = "Hardware Support",
                List = new string[] { "Service 1", "Service 2", "Service 3" }
            };
            var s2 = new Service()
            {
                Name = "Software Support",
                List = new string[] { "Service 1", "Service 2", "Service 3" }
            };

            var s3 = new Service()
            {
                Name = "Call Support",
                List = new string[] { "Service 1", "Service 2", "Service 3" }
            };

            Service[] ser = new Service[] { s1, s2, s3 };

            return View(ser);

        }  

        public ActionResult Teams()
        {
            var T1 = new Teams()
            {
                ServiceName = "Softwer Support",
                Name = "Devoloper",
                Members = new Member[]
                {
                    new Member { Id = 1, Name = "Member 1" },
                    new Member { Id = 2, Name = "Member 2" },
                    new Member { Id = 3, Name = "Member 3" }
                }

            };
            var T2 = new Teams()
            {
                ServiceName = "Softwer Support",
                Name = "SRS Team",
                Members = new Member[]
               {
                    new Member { Id = 4, Name = "Member 1" },
                    new Member { Id = 5, Name = "Member 2" },
                    new Member { Id = 6, Name = "Member 3" }
               }

            };
            var T3 = new Teams() {
                ServiceName = "Softwer Support",
                Name = "Tester Team",
                Members = new Member[]
               {
                    new Member { Id = 7, Name = "Member 1" },
                    new Member { Id = 8, Name = "Member 2" },
                    new Member { Id = 9, Name = "Member 3" }
               }
            };

            Teams[] te = new Teams[] { T2, T1,T3 };

            return View(te);
        }

        public ActionResult Contact()
        {
            ViewBag.num = "018150****8";
            ViewBag.mail = "www.gmail.com";
            return View();
        }
    }
}