using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATOS.ACCESOS;
using DATOS.ENTIDADES;


namespace DATOS.ACCESOS
{
    
    public class PedidoDA
    {
        readonly string cadena = "Server=localhost; Port=3306; Database=BaseDatos; Uid=root; Pwd=1Nulympe.;";

        MySqlConnection conn;
        MySqlCommand cmd;

        public int Insertarpedido(PedidoDA pedidoBase)
        {
            int idPedido = 0;
            try
            {
                string sql = "INSERT INTO Pedidos ( Cliente , Codigo , Descripcion , Cantidad ) VALUES ( @Cliente, @Codigo, @Descripcion, @Cantidad); select last_insert_idpedidos();";

                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Cliente", pedidoBase.Cliente);
                cmd.Parameters.AddWithValue("@Codigo", pedidoBase.Codigo);
                cmd.Parameters.AddWithValue("@Descripcion", pedidoBase.Descripcion);
                cmd.Parameters.AddWithValue("@Cantidad", pedidoBase.cantidad);
                idPedido = Convert.ToInt32(cmd.ExecuteScalar());


                conn.Close();
            }
            catch (Exception ex)
            {
            }
            return idPedido;
        }
    }

    public class pedidoBas
    {
    }

}