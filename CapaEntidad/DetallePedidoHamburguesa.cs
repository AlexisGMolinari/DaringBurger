using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class DetallePedidoHamburguesa
    {
        public int DetalleID { get; set; }
        public Pedidos oPedido { get; set; }
        public Talles oTalle { get; set; }
        public decimal PrecioTotalTalle { get; set; }
        public int CantidadPedidoH { get; set; }
        public Toppings oTopping { get; set; }
        public Aderezos oAderezo { get; set; }
    }
}
