using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BancMobile.Models.Servicios;
using BancMobile.Models.Modelos;

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
        public ActionResult ListaCompanias()
        {
            CompaniaServicios companiasServices = new CompaniaServicios();

            //companiasServices.addCompania();

            IEnumerable<CompaniaModel> listaCompanias = companiasServices.getDataCompanias();
            return View(listaCompanias);
        }

        public ActionResult EditarCompania(int idCompania)
        {

            return View();
        }
        [HttpPost]
        public ActionResult EditarCompania(CompaniaModel compania)
        {


            return RedirectToAction("ListaCompanias", "Compania");
        }



        [HttpPost]
        public ActionResult AgregarCompania(CompaniaModel compania)
        {
            CompaniaServicios companiasServices = new CompaniaServicios();
            try
            {
                companiasServices.addCompania(compania);

            }
            catch (Exception)
            {
                
                throw;
            }

            return RedirectToAction("ListaCompanias", "Compania");
        }

        public ActionResult AgregarCompania()
        {
            return View();
        }

        /*
        [HttpPost]
        public ActionResult AgregarCompania(CompaniaModel compania)
        {
            return View();
        }
         * */


    }
}
