using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BancMobile.Models.Modelos;
using System.Xml.Linq;


namespace BancMobile.Models.Servicios
{
    public class UsuarioServicios
    {
        private string path = HttpContext.Current.Server.MapPath("~/App_Data/Usuarios.xml");

        public IEnumerable<UsuarioModel> getDataUsuarios()
        {
            XElement xmlUsuario = XElement.Load(this.path);
           
            IEnumerable<UsuarioModel> dataUsuarios =
                (from usuario in xmlUsuario.Descendants("usuario")
                 select new UsuarioModel
                 {
                    idUsuario = Int32.Parse(usuario.Element("id").Value),
                    rutUsuario = usuario.Element("rut").Value,
                    nombreUsuario = usuario.Element("nombre").Value,
                    direccionUsuario = usuario.Element("direccion").Value,
                    mailUsuario = usuario.Element("email").Value,
                    passUsuario = usuario.Element("password").Value
                 }).ToList();
            
            return dataUsuarios;
        }

        public UsuarioModel getUsuario(int idUsuario)
        {
            UsuarioModel usuario = new UsuarioModel();

            XElement xmlUsuario = XElement.Load(this.path);

            var getUsuario = (from c in xmlUsuario.Descendants("usuario")
                               where c.Element("id_usuario").Value.Equals(idUsuario.ToString())
                               select c).FirstOrDefault();

            usuario.idUsuario = Int32.Parse(getUsuario.Element("id_usuario").Value);
            usuario.rutUsuario = getUsuario.Element("rut").Value;
            usuario.nombreUsuario = getUsuario.Element("nombre").Value;
            usuario.direccionUsuario = getUsuario.Element("direccion").Value;
            usuario.mailUsuario = getUsuario.Element("email").Value;
            usuario.passUsuario = getUsuario.Element("password").Value;

            return usuario;
        }

        public bool addUsuario(UsuarioModel usuario) // Recibo un usuario
        {
            try
            {
                XElement xmlUsuario = XElement.Load(this.path);

                XElement parteXML = new XElement(
                    new XElement("usuario",
                        new XElement("id_usuario", usuario.idUsuario),
                        new XElement("rut", usuario.rutUsuario),
                        new XElement("nombre", usuario.nombreUsuario),
                        new XElement("direccion", usuario.direccionUsuario),
                        new XElement("email", usuario.mailUsuario),
                        new XElement("password", usuario.passUsuario)
                        ));

                    xmlUsuario.Element("usuarios").Add(parteXML);
                    xmlUsuario.Save(this.path);
                    return true;
            }
            catch (Exception)
            {
                return false;
            }            
        }

        public bool deleteUsuario(int idUsuario)
        {
            XElement xmlUsuario = XElement.Load(this.path);

            var usuario = (from c in xmlUsuario.Descendants("usuario")
                            where c.Element("id_usuario").Value.Equals("3")
                            select c).FirstOrDefault();

            //compania.Remove();



            XElement parteXML = new XElement(
                new XElement("compania",
                    new XElement("id_compania", "10"),
                    new XElement("nombre_compania", "LO QUE SEA")));

            //compania.ReplaceAll(parteXML.DescendantNodes());


            //xmlUsuario.Element("companias").Add(parteXML);
            //xmlUsuario.Save(this.path);          

            return true;
        }

        public bool loginUsuario(string pass, string rut)
        {
            UsuarioModel usuario = new UsuarioModel();
            XElement xmlUsuario = XElement.Load(this.path);

            var getUsuario = (from c in xmlUsuario.Descendants("usuario")
                              where c.Element("rut").Value.Equals(rut)
                              select c).FirstOrDefault();

            if (getUsuario == null)
            {
                return false;
            }

            return getUsuario.Element("password").Value.Equals(pass);
        }

        public bool modifyUsuario(UsuarioModel usuario)
        {

            //CompaniaModel compania = new CompaniaModel();
            try
            {
                XElement xmlUsuario = XElement.Load(this.path);

                var getUsuario = (from c in xmlUsuario.Descendants("usuario")
                                   where c.Element("id_usuario").Value.Equals(usuario.idUsuario.ToString())
                                   select c).FirstOrDefault();

                XElement parteXML = new XElement(
                       new XElement("usuario",
                       new XElement("id_usuario", usuario.idUsuario),
                       new XElement("rut", usuario.rutUsuario),
                       new XElement("nombre", usuario.nombreUsuario),
                       new XElement("direccion", usuario.direccionUsuario),
                       new XElement("email", usuario.mailUsuario),
                       new XElement("password", usuario.passUsuario)
                       ));

                getUsuario.ReplaceAll(parteXML.DescendantNodes());

                xmlUsuario.Save(this.path);

            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }


		

    }
}