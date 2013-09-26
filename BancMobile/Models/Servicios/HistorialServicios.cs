using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BancMobile.Models.Modelos;
using System.Xml.Linq;


namespace BancMobile.Models.Servicios
{
    public class HistorialServicios
    {
        private string histori = HttpContext.Current.Server.MapPath("~/App_Data/HistorialRecargas.xml");//Devuelve la ruta de acceso del xml

        
        //public HistorialRecargaModel getHistoria(int idHistorial)
        //{
        //    HistorialRecargaModel histori = new HistorialRecargaModel();

        //    XElement xmlHistorialRecargas = XElement.Load(this.histori);

        //    var getHistoria = (from c in xmlHistorialRecargas.Descendants("historialRec")
        //                       where c.Element("id").Value.Equals(idHistorial.ToString())
        //                      select c).FirstOrDefault();

        //    histori.idUsuario = Int32.Parse(getHistoria.Element("id").Value);
        //    histori.idHistorial = getHistoria.Element("idHistorialRecarga").Value;
        //    histori.fecha = getHistoria.Element("fecha").Value;
        //    histori.numeroCelular = getHistoria.Element("numeroCelular").Value;
        //    histori.idCompania = getHistoria.Element("idCompania").Value;
        //    histori.nombreCompania = getHistoria.Element("nombreCompania").Value;
        //    histori.valor = getHistoria.Element("valor").Value;
        //    histori.descripcion_recarga = getHistoria.Element("descripcion_recarga").Value;

        //    return histori;
        //}


        public bool addHistorial(HistorialRecargaModel histori)//Recibo la Hiatoria
        {
            try
            {
                XElement xmlHistorialRecargas = XElement.Load(this.histori);

                XElement parteXML = new XElement(
                    new XElement("historialRec", 
                        new XElement("id", histori.idUsuario),
                        new XElement("idHistorialRecarga", histori.idHistorial),
                        new XElement("fecha", histori.fecha),
                        new XElement("numeroCelular", histori.numeroCelular),
                        new XElement("idCompania", histori.idCompania),
                        new XElement("nombreCompania", histori.nombreCompania),
                        new XElement("valor", histori.valor, histori.valor),
                        new XElement("descripcion_recarga", histori.descripcion_recarga)
                        ));

                xmlHistorialRecargas.Element("historialRecargas").Add(parteXML);
                xmlHistorialRecargas.Save(this.histori);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}