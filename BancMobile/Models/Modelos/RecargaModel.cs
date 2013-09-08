using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BancMobile.Models.Modelos
{
    public class RecargaModel
    {
        public int id_recarga { get; set; }
        public int valor { get; set; }
        public string descripcion_recarga { get; set; }
    }
}