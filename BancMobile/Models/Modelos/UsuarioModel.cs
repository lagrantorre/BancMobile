using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BancMobile.Models.Modelos
{
    public class UsuarioModel
    {
        public int idUsuario { get; set; }
        public string rutUsuario { get; set; }
        public string nombreUsuario { get; set; }
        public string direccionUsuario { get; set; } 
        public string mailUsuario { get; set; }
        public string passUsuario { get; set; }         
      
    }
}