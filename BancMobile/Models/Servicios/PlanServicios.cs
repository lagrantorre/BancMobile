using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;
using BancMobile.Models.Modelos;
using System.Text;

namespace BancMobile.Models.Servicios
{
    public class PlanServicios 
    {

        private string path = HttpContext.Current.Server.MapPath("~/App_Data/Planes.xml");
        public IEnumerable<PlanModel> getDataPlanes() {
            XElement xmlPlan = XElement.Load(this.path);
            IEnumerable<PlanModel> dataPlanes = (from plan in xmlPlan.Descendants("Plan")
                                                 select new PlanModel
                                                 {
                                                     id_plan = Int32.Parse(plan.Element("id_plan").Value),
                                                     id_compania = Int32.Parse(plan.Element("id_compania").Value),
                                                     nombre_plan = plan.Element("nombre_plan").Value,
                                                     descripcion_plan = plan.Element("descripcion_plan").Value,
                                                     valor_plan = Int32.Parse(plan.Element("valor_mes_plan").Value)
                                                 }).ToList();
            return dataPlanes;
        }

    }
}