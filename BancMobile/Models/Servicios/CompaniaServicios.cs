using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BancMobile.Models.Modelos;
using System.Xml.Linq;
using System.IO;
using System.Web.Mvc;


namespace BancMobile.Models.Servicios
{
    public static class CompaniaServicios
    {
        public static List<CompaniaModel> getDataCompanias()
        {
            List<CompaniaModel> dataCompanias = new List<CompaniaModel>();
            //VirtualPathUtility.ToAbsolute("~/App_Data/somedata.xml");
            string path = HttpContext.Current.Server.MapPath("~/App_Data/Companias.xml");
            XElement xmlCompania = XElement.Load(path);

            IEnumerable<XElement> companias = xmlCompania.Elements();

            foreach (var compania in companias)
            {
                CompaniaModel companiaArr = new CompaniaModel(Int32.Parse(compania.Element("id_compania").Value), compania.Element("nombre_compania").Value);
                dataCompanias.Add(companiaArr); 
                   
                             
            }

            return dataCompanias;
        }
    }
}