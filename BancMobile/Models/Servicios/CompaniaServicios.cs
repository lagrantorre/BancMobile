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
    public class CompaniaServicios
    {

        private string path = HttpContext.Current.Server.MapPath("~/App_Data/Companias.xml");

        public IEnumerable<CompaniaModel> getDataCompanias()
        {
            //List<CompaniaModel> dataCompanias = new List<CompaniaModel>();
            //VirtualPathUtility.ToAbsolute("~/App_Data/somedata.xml");
            //string path = HttpContext.Current.Server.MapPath("~/App_Data/Companias.xml");
            XElement xmlCompania = XElement.Load(this.path);

            IEnumerable<CompaniaModel> dataCompanias =
                (from compania in xmlCompania.Descendants("compania")
                 select new CompaniaModel
                 {
                     idCompania = Int32.Parse(compania.Element("id_compania").Value),
                     nombreCompania = compania.Element("nombre_compania").Value

                 }).ToList();


            return dataCompanias;
        }

        public CompaniaModel getCompania(int idCompania)
        {
            CompaniaModel compania;

            XElement xmlCompania = XElement.Load(this.path);

            var getCompania = (from c in xmlCompania.Descendants("compania")
                               where c.Element("id_compania").Value.Equals(idCompania)
                               select c).FirstOrDefault();

      
            compania = new CompaniaModel {
                                                            idCompania = Int32.Parse(getCompania.Element("id_compania").Value),
                                                            nombreCompania = getCompania.Element("nombre_compania").Value 
                                                            };
           return compania;
        }

        public bool addCompania(CompaniaModel compania)
        {
            XElement xmlCompania = XElement.Load(this.path);
            /*
            var compania = (from c in xmlCompania.Descendants("compania")
                            where c.Element("id_compania").Value.Equals("3")
                            select c).FirstOrDefault();
            */
            //compania.Remove();
            


            XElement parteXML = new XElement(
                new XElement("compania",
                    new XElement("id_compania",compania.idCompania),
                    new XElement("nombre_compania", compania.nombreCompania)));

            //compania.ReplaceAll(parteXML.DescendantNodes());
           

            xmlCompania.Element("companias").Add(parteXML);
            xmlCompania.Save(this.path);           
            return true;
        }

        public bool deleteCompania()
        {
            XElement xmlCompania = XElement.Load(this.path);

            var compania = (from c in xmlCompania.Descendants("compania")
                            where c.Element("id_compania").Value.Equals("3")
                            select c).FirstOrDefault();

            //compania.Remove();



            XElement parteXML = new XElement(
                new XElement("compania",
                    new XElement("id_compania", "10"),
                    new XElement("nombre_compania", "LO QUE SEA")));

            //compania.ReplaceAll(parteXML.DescendantNodes());


            //xmlCompania.Element("companias").Add(parteXML);
            //xmlCompania.Save(this.path);          

            return true;
        }

        public bool modifyCompania()
        {
            return true;
        }
    }
}