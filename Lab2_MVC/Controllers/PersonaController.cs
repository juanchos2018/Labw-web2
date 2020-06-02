using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab2_MVC.Models;
namespace Lab2_MVC.Controllers
{
    public class PersonaController : Controller
    {
        // GET: Persona

       // ClsPersona o = new ClsPersona();
        List<ClsPersona> lista=new List<ClsPersona>();

        public ActionResult Index()
        {

            ClsPersona o1 = new ClsPersona();
            o1.apellido = "Porlles";
            o1.nombre = "Diego";
            o1.edad = 20;
            o1.email = "vaguito@mgail.com";
            o1.sexo = true;
            o1.talla = 1.65;
            lista.Add(o1);

            ClsPersona o2 = new ClsPersona();
            o2.apellido = "Sosa";
            o2.nombre = "Sharon";
            o2.edad = 20;
            o2.email = "sharon@mgail.com";
            o2.sexo = false;
            o2.talla = 1.45;
            lista.Add(o2);

            ClsPersona o3 = new ClsPersona();
            o3.apellido = "Ayalla";
            o3.nombre = "Brando";
            o3.edad = 20;
            o3.email = "brandonn@mgail.com";
            o3.sexo = true;
            o3.talla = 1.45;
            lista.Add(o3);

            ClsPersona o4 = new ClsPersona();
            o4.apellido = "EStrrell Palacioh";
            o4.nombre = "Katherine";
            o4.edad = 20;
            o4.email = "katherin@mgail.com";
            o4.sexo = false;
            o4.talla = 1.45;
            lista.Add(o4);



            return View(lista);
        }

        
    }
}