using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class DetallePedidoBebida
    {
        public int DetalleID { get; set; }
        public Pedidos oPedido { get; set; }
        public int CantidadPedido { get; set; }
        public Bebidas oBebida { get; set; }
    }
}
