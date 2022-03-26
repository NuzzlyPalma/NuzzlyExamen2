using System;

namespace DATOS.ENTIDADES
{
    public class PedidoBase
    {
        public int IdPedido { get; set; }
        public string Cliente { get; set; }

        public String Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Cantidad { get; set; }

        public PedidoBase()
        {
        }

        public PedidoBase(int idPedido, string cliente, string codigo, string descripcion, string cantidad)
        {
            IdPedido = idPedido;
            Cliente = cliente;
            Codigo = codigo;
            Descripcion = descripcion;
            Cantidad = cantidad;
        }

   
    }



}