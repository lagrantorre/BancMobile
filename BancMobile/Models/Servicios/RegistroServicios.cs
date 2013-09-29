using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BancMobile.Models.Modelos;
using System.Xml.Linq;
using System.Web.Mvc;

namespace BancMobile.Models.Servicios
{
    public class RegistroServicios
    {
        private string pathR = HttpContext.Current.Server.MapPath("~/App_Data/LogRegistros.xml");
        private string pathU = HttpContext.Current.Server.MapPath("~/App_Data/Usuarios.xml");
        private string pathC = HttpContext.Current.Server.MapPath("~/App_Data/Celulares.xml");
       
        public bool addRegistro(RegistroModel registro)
        {
            
            XElement xmlRegistros = XElement.Load(this.pathR);
            
            XElement insXML = new XElement(
                new XElement("RegLog",
                    new XElement("idReg", 0),
                    new XElement("idUsr", 0),
                    new XElement("idCel", 0),
                    new XElement("fechaReg", System.DateTime.Today)));

            
            xmlRegistros.Add(insXML);
            ////////////////////////////////////
            XElement xmlUsuarios = XElement.Load(this.pathU);

            XElement usrXML = new XElement(
                new XElement("usuario",
                    new XElement("id_usuario", 0),
                    new XElement("rut", registro.rutUsuario),
                    new XElement("nombre", registro.nombreUsuario),
                    new XElement("direccion", registro.direccionUsuario),
                    new XElement("email", registro.mailUsuario),
                    new XElement("password", registro.passUsuario)));
            
            
                    xmlUsuarios.Add(usrXML);
            ////////////////////////////////////
            XElement xmlCelulares = XElement.Load(this.pathC);

            XElement celXML = new XElement(
                new XElement("celular",
                    new XElement("id_celular", 0),
                    new XElement("id_compania", registro.id_compania),
                    new XElement("num_celular", registro.numCelular),
                    new XElement("tipo", registro.tipo),
                    new XElement("id_usuario",0)));

            xmlCelulares.Add(celXML);


            return true;
        }

        


    }
}