using CLASE02.DAORE;
using CLASE02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CLASE02.Controllers
{
    public class PersonaController : Controller
    {
        // GET: Persona
        public ActionResult Descripcion(string variable )
        {
            ViewBag.variabledinamica = variable;
            //var per = new ClsPersona { nombre = "Nelson Calles " };
            //return View(per);
            PersonaRepositore Per = new PersonaRepositore();
            

            return View(Per.ObtenerPersona());
        }
    } 
}