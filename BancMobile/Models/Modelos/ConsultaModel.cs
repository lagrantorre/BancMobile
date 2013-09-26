using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BancMobile.Models.Modelos
{
    public class ConsultaModel
    {
        public int numCelular { get; set; }
        public string nombreCompania { get; set;}
        public String tipo { get; set; }
        public String nombre_plan { get; set; }
        public int valorRecarga { get; set; }

    }
}