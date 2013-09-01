using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BancMobile.Controllers
{
    public class CompaniaController : Controller
    {
        
        // Se crea un nuevo controlador, ojo con colocar el nombre "Controller" al finalizar la palabra del controlador, 
        // commo por ejemplo este controlador "CompaniaController"
        public ActionResult Inicio()
        {
            // Esta acción retornará la vista. Llamará a la vista que tenga el mismo nombre del método, en este caso
            // a la vista Inicio
            return View();
        }

    }
}
