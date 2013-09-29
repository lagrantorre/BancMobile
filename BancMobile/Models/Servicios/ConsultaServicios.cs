using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BancMobile.Models.Modelos;
using System.Xml.Linq;

namespace BancMobile.Models.Servicios
{
    public class ConsultaServicios
    {

        private string path = HttpContext.Current.Server.MapPath("~/App_Data/Celulares.xml");
        XDocument loaded = XDocument.Load("~/App_Data/Celulares.xml");

        public void ConsultaCelular(int num)
        {
            
           /* XElement cel = new XElement("celulares",
                   from c in path
                   orderby c.
                   select new XElement("celular",
                             new XAttribute("contactId", c.ContactId),
                             new XElement("firstName", c.FirstName),
                             new XElement("lastName", c.LastName))
                   );*/

                                // Query the data and write out a subset of contacts
                    var q = from c in loaded.Descendants("celular")
                            where (int)c.Attribute("num_celular") == num
                            select (string)c.Element("num_celular") + "" +
                               (string)c.Element("tipo")
                               + "" + (string)c.Element("id_compannia");
            
                    foreach (string name in q)
                        Console.WriteLine(name);


          //  return cel;


        }







    }
}