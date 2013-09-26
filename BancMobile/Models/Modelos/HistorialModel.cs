using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BancMobile.Models.Modelos
{
    public class HistorialModel
    {
       
    }

    public class HistorialRecargaModel
    {
        public int idHistorial { get; set; }
        public int idUsuario { get; set; }
        public int numeroCelular { get; set; }
        public int idCompania { get; set; }
        public String nombreCompania { get; set; }
        public int valor { get; set; }
        public String descripcion_recarga { get; set; }
        public DateTime fecha { get; set; }
    }


} 