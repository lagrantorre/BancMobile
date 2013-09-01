using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BancMobile.Models.Modelos
{
    //Se crea una clase de instancia (Nuevo tipo de dato) con los campos que involucra a esta clase
    public class CompaniaModel
    {
        // Todos los ids deben ser de tipo entero (int)
        public int idCompania { get; set; }
        // Se crea una variable de tipo string para el nombre de la compañia
        public string nombreCompania { get; set; }
    }
}