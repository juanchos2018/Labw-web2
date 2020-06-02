using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab2_MVC.Models;
namespace Lab2_MVC.Controllers
{
    public class BisiestoController : Controller
    {
       // ClsBisiesto o = new ClsBisiesto();

        // GET: Bisiesto
        public ActionResult Index()       {


            return View();
        }
        public ActionResult Visualizar(ClsBisiesto o)
        {

            return View(o);
        }
    }
}