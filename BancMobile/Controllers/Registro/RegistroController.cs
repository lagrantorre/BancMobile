using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using BancMobile.Models.Modelos;
using System.Xml.Linq;
using BancMobile.Models.Servicios;

namespace BancMobile.Controllers.Registro
{
    public class RegistroController : Controller
    {
        
        public ActionResult Registro()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AgregarRegistro(RegistroModel registro)
        {
            RegistroServicios regServ = new RegistroServicios();
            try
            {
                regServ.addRegistro(registro);

            }
            catch (Exception)
            {

                throw;
            }

            return View();
        }




     /*   public ActionResult Index(int ident)
        {
            // TODO: it would be better to externalize the parsing of the XML
            // file into a separate repository class to avoid cluttering your
            // controller actions with such code which is not what they should
            // be responsible for. But for the purpose of this answer it should 
            // be enough 

            var file = Path.Combine(Server.MapPath("~/App_Data/Planes.xml"));
            var model = new UnitViewModel
            {
                Units =
                    from unit in XDocument.Load(file).Document.Descendants("Unit")
                    
                    select new SelectListItem
                    {
                        Value = unit.Attribute("id_plan").Value,
                        Text = unit.Attribute("nombre_plan").Value
                    }
            };
            return View(model);
        }
        */


    }
}
