using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelViewControllerProject.Models;

namespace ModelViewControllerProject.Controllers
{
    public class HomeController : Controller
    {
       public ViewResult Index()
        {
            
            return View();
        }

        [HttpGet]
        public ViewResult Formularz()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Formularz(OdpowiedziGoscia gosc)
        {
            if (ModelState.IsValid)
                
                return View("Dziekuje", gosc);
            else
                // Wykryto błąd sprawdzania wiarygodności
                return View();
        }


    }
}