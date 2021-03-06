﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace BancMobile.Models.Modelos
{
    public class RegistroModel
    {
        public int idRegistro { get; set; }
        public int idUsuario { get; set; }
        public string rutUsuario { get; set; }
        public string nombreUsuario { get; set; }
        public string direccionUsuario { get; set; }
        public string mailUsuario { get; set; }
        public string passUsuario { get; set; }
        public int idCompania { get; set; }
        public string compania { get; set; }
        public int idCelular { get; set; }
        public int numCelular { get; set; }
        public String tipo { get; set; }
        public string plan { get; set; }
        public DateTime fechaReg { get; set; }
        

    }
}