using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;
using System.Security.Cryptography;

namespace Negocioo
{
    public class Negocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
      
                datos.setearConsulta(@"
            SELECT A.Id, Codigo, Nombre, A.Descripcion, Precio, 
                   M.Descripcion AS Marca, C.Descripcion AS Categoria, 
                   I.ImagenUrl, A.IdMarca, A.IdCategoria
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
                        CodArticulo = (string)datos.Lector["Codigo"],
                        NombreArticulo = (string)datos.Lector["Nombre"],
                        DescripcionArticulo = (string)datos.Lector["Descripcion"],
                        PrecioArticulo = (decimal)datos.Lector["Precio"],
                        
                        Marca = new Marca
                        {
                            MarcaID = (int)datos.Lector["IdMarca"],
                            Descripcion = (string)datos.Lector["Marca"]
         
                        },
                        Categoria = new Categoria
                        {
                            IdCategoria = (int)datos.Lector["IdCategoria"],
                            Descripcion = (string)datos.Lector["Categoria"]
                        },
                        Imagen = new Imagen
                        {
                            URlImagen = datos.Lector["ImagenUrl"] as string
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

        public void agregar(Articulo art)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) " +
                                     "VALUES (@Codigo, @Nombre, @Descripcion, @IdMarca, @IdCategoria, @Precio)");

                datos.setearParametro("@Codigo", art.CodArticulo);
                datos.setearParametro("@Nombre", art.NombreArticulo);
                datos.setearParametro("@Descripcion", art.DescripcionArticulo);
                datos.setearParametro("@IdMarca", art.IdMarca); 
                datos.setearParametro("@IdCategoria", art.IdCategoria); 
                datos.setearParametro("@Precio", art.PrecioArticulo);

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

                datos.setearParametro("@cod",articulo.CodArticulo);
                datos.setearParametro("@nombre",articulo.NombreArticulo);
                datos.setearParametro("@desc",articulo.DescripcionArticulo);
                datos.setearParametro("@IdMar",articulo.Marca.MarcaID);
                datos.setearParametro("@Idcate",articulo.Categoria.IdCategoria);
                datos.setearParametro("@Prec",articulo.PrecioArticulo); 
                datos.setearParametro("@ID",articulo.Id);

                datos.realizarAccion();
            }
            catch (Exception ex)
            {

                throw ex ;
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
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}

