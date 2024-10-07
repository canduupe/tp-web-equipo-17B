using Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ClienteNegocio
    {
        public List<Cliente> listar()
        {
            List<Cliente> lista = new List<Cliente>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select id, documento,nombre, apellido, email, direccion, ciudad, cp from clientes");
                datos.realizarLectura();

                while (datos.Lector.Read())
                {
                    Cliente cliente = new Cliente()
                    {
                        Id = (int)datos.Lector["id"],
                        Documento = (string)datos.Lector["documento"],
                        Nombre = (string)datos.Lector["nombre"],
                        Apellido = (string)datos.Lector["apellido"],
                        Email = (string)datos.Lector["email"],
                        Direccion = (string)datos.Lector["direccion"],
                        Ciudad = (string)datos.Lector["ciudad"],
                        Cp = (int)datos.Lector["cp"]
                        
                    };
                    lista.Add(cliente);
                    

                }
                    return lista;

            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar los artículos: " + ex.Message);
            }
            finally
            {
                datos.cerrarConexion();

            }

        }

        public void agregar(Cliente cli)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("insert into CLIENTES (documento, nombre, apellido, email, direccion, ciudad, cp) values (@Doc,@Nomb, @Ape, @mail, @direc, @ciu, @CP)");

                datos.setearParametro("@Doc", cli.Documento);
                datos.setearParametro("@Nomb", cli.Nombre);
                datos.setearParametro("@Ape",cli.Apellido);
                datos.setearParametro("@mail",cli.Email);
                datos.setearParametro("@direc", cli.Direccion);
                datos.setearParametro("@ciu",cli.Ciudad);
                datos.setearParametro("@CP",cli.Cp);

                datos.realizarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }


        }


    }
}
