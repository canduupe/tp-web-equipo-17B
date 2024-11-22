using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using Dominio;


/*namespace Negocio
{
    public class negocio
    {

        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {

                datos.setearConsulta(@"
            SELECT A.Id, Codigo, Nombre, A.Descripcion, Precio, 
                   M.Descripcion AS Marca, C.Descripcion AS Categoria, ne
                   I.ImagenUrl, I.Id AS ImagenId, A.IdMarca, A.IdCategoria
            FROM ARTICULOS A
            INNER JOIN MARCAS M ON A.IdMarca = M.Id
            INNER JOIN CATEGORIAS C ON A.IdCategoria = C.Id
            LEFT JOIN IMAGENES I ON A.Id = I.IdArticulo
        ");
                datos.realizarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo
                    {
                        Id = (int)datos.Lector["Id"],
                        Codigo = (string)datos.Lector["Codigo"],
                        Nombre = (string)datos.Lector["Nombre"],
                        Descripcion = (string)datos.Lector["Descripcion"],
                        Precio = (decimal)datos.Lector["Precio"],

                        Marca = new Marca
                        {
                            Id = (int)datos.Lector["IdMarca"],
                            Descripcion = (string)datos.Lector["Marca"]

                        },
                        Categoria = new Categoria
                        {
                            Id = (int)datos.Lector["IdCategoria"],
                            Descripcion = (string)datos.Lector["Categoria"]
                        },
                        Imagen = new Imagen
                        {
                            URlImagen =(string) datos.Lector["ImagenUrl"] 
                        }
                        
                    };

                    lista.Add(aux);
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


        public List<Articulo> ListarConSP()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearProcedimiento("storedListar");

                datos.realizarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo
                    {
                        Id = (int)datos.Lector["Id"],
                        Codigo = (string)datos.Lector["Codigo"],
                        Nombre = (string)datos.Lector["Nombre"],
                        Descripcion = (string)datos.Lector["Descripcion"],
                        Precio = (decimal)datos.Lector["Precio"],

                        Marca = new Marca
                        {
                            Id = (int)datos.Lector["IdMarca"],
                            Descripcion = (string)datos.Lector["Marca"]

                        },
                        Categoria = new Categoria
                        {
                            Id = (int)datos.Lector["IdCategoria"],
                            Descripcion = (string)datos.Lector["Categoria"]
                        },
                        /*Imagen = new Imagen
                        {
                            URlImagen = datos.Lector["ImagenUrl"] as string
                        }*/
                     /*   Imagenes = new List<Imagen>();
                    };

                    lista.Add(aux);
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

*/

/*

        public void agregar(Articulo art)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) " +
                                     "VALUES (@Codigo, @Nombre, @Descripcion, @IdMarca, @IdCategoria, @Precio)");

                datos.setearParametro("@Codigo", art.Codigo);
                datos.setearParametro("@Nombre", art.Nombre);
                datos.setearParametro("@Descripcion", art.Descripcion);
                datos.setearParametro("@IdMarca", art.IdMarca);
                datos.setearParametro("@IdCategoria", art.IdCategoria);
                datos.setearParametro("@Precio", art.Precio);

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

        public void modificar(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("update ARTICULOS set Codigo = @cod, Nombre = @nombre, Descripcion = @desc, IdMarca = @IdMar, IdCategoria = @Idcate, Precio = @Prec where Id = @ID");

                datos.setearParametro("@cod", articulo.Codigo);
                datos.setearParametro("@nombre", articulo.Nombre);
                datos.setearParametro("@desc", articulo.Descripcion);
                datos.setearParametro("@IdMar", articulo.Marca.Id);
                datos.setearParametro("@Idcate", articulo.Categoria.Id);
                datos.setearParametro("@Prec", articulo.Precio);
                datos.setearParametro("@ID", articulo.IdArticulo);

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

        public void eliminar(int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("delete from ARTICULOS where id = @Id");
                datos.setearParametro("@Id", id);
                datos.realizarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    } 
}
*/