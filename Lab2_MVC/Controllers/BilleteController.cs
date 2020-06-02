using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab2_MVC.Models;
namespace Lab2_MVC.Controllers
{
    public class BilleteController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Visualizar(ClsBillete o)        {
            int cantidad;
            cantidad = o.monto;
            int cant100,cant50,cant20,cant10;
            int rescant100, rescant50, rescant20, rescant10;
            cant100 = cantidad/100;
            rescant100 = cantidad % 100;
            cant50 = rescant100 / 50;
            rescant50 = rescant100 % 50;
            cant20 = rescant50 / 20;
            rescant20 = rescant50 % 20;

            cant10 = rescant20 / 10;
            rescant10 = rescant20 % 10;

            o.b100 = cant100;
            o.b50 = cant50;
            o.b20 = cant20;
            o.b10 = cant10;
            return View(o);
        }
    }
}