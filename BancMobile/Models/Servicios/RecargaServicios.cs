using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BancMobile.Models.Modelos;
using System.Xml.Linq;

namespace BancMobile.Models.Servicios
{
    public class RecargaServicios
    {
        private string path = HttpContext.Current.Server.MapPath("~/App_Data/Recargas.xml");
        private string pathLog = HttpContext.Current.Server.MapPath("~/App_Data/LogRecargas.xml");

          public bool addRecarga(RecargaModel recarga, CelularModel celular)
        {
            
            XElement xmlRec = XElement.Load(this.path);
            
            XElement insXML = new XElement(
                new XElement("recarga",
                    new XElement("id_recarga", recarga.id_recarga),
                    new XElement("valor", recarga.valor),
                    new XElement("duracion", recarga.descripcion_recarga)));

            xmlRec.Add(insXML);
              ////////////

            XElement xmlLogRec = XElement.Load(this.path);

            XElement insLogXML = new XElement(
                new XElement("recarga",
                    new XElement("id_recarga", recarga.id_recarga),
                    new XElement("NumCelular", celular.numCelular),
                    new XElement("Compania", celular.id_compania),
                    new XElement("Fecha_Ini",System.DateTime.Now),
                    new XElement("valor", recarga.valor),
                    new XElement("duracion", recarga.descripcion_recarga)
                    ));

            xmlLogRec.Add(insLogXML);



            return true;
        }







    }
}