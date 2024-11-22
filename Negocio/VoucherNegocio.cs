using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class VoucherNegocio
    {

        public void Canjeado(int IDVoucher, int IdCliente, int IdArticulo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearProcedimiento("EstadoVouchers");
                datos.setearParametro("@Id", IDVoucher);
                datos.setearParametro("@NuevoCliente", IdCliente);
                datos.setearParametro("@IdArticulo", IdArticulo);

                datos.realizarLectura();
                
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

        public bool ValidarVoucher(Vouchers voucher) 
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Select Id, CodigoVoucher from Vouchers where CodigoVoucher = @codigo AND Estado = 1");
                datos.setearParametro("@codigo", voucher.CodigoVaucher);
                datos.realizarLectura();

                if (datos.Lector.Read())
                {

                    voucher.Id = (int)datos.Lector["Id"];
                    return true;
                }
                return false;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion(); }
            

        
        }







    }
}
