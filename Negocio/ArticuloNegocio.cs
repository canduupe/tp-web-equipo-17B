using Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ArticuloNegocio
    {

        public bool obtnerArticulo(Articulo articulo)
        {

            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("");


                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        public List<Articulo> ListarSp()
        {
            AccesoDatos datos = new AccesoDatos();
            List<Articulo> lista = new List<Articulo>();    
            try
            {
                datos.setearProcedimiento("listaDeArticulos");
                datos.realizarLectura();


                while (datos.Lector.Read())
                {
                    Articulo articulo = new Articulo();

                    articulo.IdArticulo= (int)datos.Lector["Ids"];
                    articulo.Descripcion = (string)datos.Lector["Descripcion"];
                    articulo.Nombre = (string)datos.Lector["Nombre"];
                    articulo.URLImagen = (string)datos.Lector["Urlimagen"];
                    articulo.DescripcionCategoria = (string)datos.Lector["CDescrip"];
                    articulo.DescripcionMarca = (string)datos.Lector["MDescrip"];

                    lista.Add(articulo);

                       
                }
                return lista;

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }




    }
}
