using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BancMobile.Models.Modelos
{
    public class PlanModel
    {
        public int id_plan { get; set; }
        public int id_compania { get; set; }
        public String nombre_plan { get; set; }
        public String descripcion_plan { get; set; }
        public int valor_plan { get; set; }



    }
}