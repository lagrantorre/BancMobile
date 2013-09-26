using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BancMobile.Models.Servicios;
using BancMobile.Models.Modelos;

namespace BancMobile.Controllers.Recarga
{
    public class RecargaController : Controller
    {
       

          public ActionResult Recargar(CelularModel celular)
        {
            return View();
        }

    }
}
