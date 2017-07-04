using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class ClientController : Controller
    {
        //
        // GET: /Client/

        public ActionResult ListClients()
        {
            var client = new[]
         {
                
         
               new Models.Client()
            {
                Id = Convert.ToInt32("1"),
                Name = "Andrey",
                Date = DateTime.Now,
                Salary = Convert.ToDouble("500")
             },
             new Models.Client()
             {
             Id = Convert.ToInt32("2"),
                Name = "Miriam",
                Date = DateTime.Now,
                Salary = Convert.ToDouble("1000")
             
             }


            //ViewData["Client"] = client;
        };
            //return View();
            return View(client);
        }

        public ActionResult TestTemp()
        {
            TempData["message"] = "The action succeeded!";
            return RedirectToAction("Client");

        }


        public ActionResult Client(Int32 id)
        {

            var client = new MvcApplication1.Models.Client()

            {
                Id = Convert.ToInt32("1"),
                Name = "Andrey",
                Date = DateTime.Now,
                Salary = Convert.ToDouble("500")



            };

            ViewData["Client"] = client;

            //return View();
            return View(client);
        }

        [HttpGet]
        public ActionResult Create()
        {
            var salary = new SelectList(new[] { "$500", "$1000", "$2000" });
            ViewBag.Salary = salary;
            return View();

        }
        [HttpPost]
        public ActionResult Create([Bind(Exclude="Salary")]Models.Client client)
        {

            if (string.IsNullOrWhiteSpace(client.Name))
            {
                ModelState.AddModelError("Name", "Name is required");
            }



            if (ModelState.IsValid)
            {
                //save to db
                return RedirectToAction("ListClients");
            }

            return Create();
        }


    }
}
