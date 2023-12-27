using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    // Determinamos la tabla "Pedidos" tal cual en Base de datos
    public class Pedidos
    {
        public int PedidoID { get; set; }
        public Cliente oCliente { get; set; }
        public string FechaPedido { get; set; }
        public List<DetallePedidoBebida> oDetallePedidoBebidas { get; set; } // Referencia al "detallePedidoBebida" Tipo lista (porque van a ser varios) Por eso se omite columna "IdDetallePedido"
        public  List<DetallePedidoHamburguesa> oDetallePedidoHamburguesas { get; set; }
        public decimal TotalPedido { get; set; }
        public Usuario oUsuario { get; set; }
    }
}
