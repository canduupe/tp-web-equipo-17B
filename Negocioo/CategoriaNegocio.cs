using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocioo
{
    public class CategoriaNegocio
    {
        public List<Categoria> listar()
        {
            List<Categoria> lista = new List<Categoria>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT id, Descripcion FROM CATEGORIAS");
                datos.realizarLectura();

                while (datos.Lector.Read())
                {
                    Categoria categoria = new Categoria
                    {
                        IdCategoria = (int)datos.Lector["id"],
                        Descripcion = (string)datos.Lector["Descripcion"]
                    };

                    lista.Add(categoria);
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

        public void Agregar (Categoria cat)
        {
            AccesoDatos datos = new AccesoDatos ();



            try
            {

                datos.setearConsulta("insert into CATEGORIAS (Descripcion) values ('" + cat.Descripcion + "')"); 
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

        public void Eliminar(string cat)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("delete from CATEGORIAS where Descripcion = @descripcion");
                datos.setearParametro("@descripcion", cat);
                datos.realizarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void Modificar(string cat1, string cat2)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update CATEGORIAS set Descripcion = @new where Descripcion = @old");
                datos.setearParametro("@new", cat1);
                datos.setearParametro("@old", cat2);
                datos.realizarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion(); }



        }







    }
}