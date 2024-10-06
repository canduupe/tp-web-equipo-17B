using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;


namespace Negocioo
{
    public class ImagenBussines
    {
        public List<Imagen> listar()
        {
            List<Imagen> lista = new List<Imagen>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT Id, IdArticulo, ImagenUrl FROM IMAGENES");
                datos.realizarLectura();

                while (datos.Lector.Read())
                {
                    Imagen aux = new Imagen();
                    aux.IdImagen = (int)datos.Lector["Id"];
                    aux.URlImagen = (string)datos.Lector["ImagenUrl"];
                    aux.IdArti = (int)datos.Lector["IdArticulo"];


                    lista.Add(aux);
                }

                return lista;
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


