using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BancMobile.Models.Modelos
{
    public class CelularModel
    {
        public int id_compania { get; set; }
        public int numCelular { get; set; }
        public String tipo { get; set; }
        public int idUsuario { get; set; }
    }
}