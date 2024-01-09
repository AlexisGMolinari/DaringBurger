using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Bebidas
    {
        public int BebidaID { get; set; }
        public string NombreBebida { get; set; }
        public decimal Precio { get; set; }
        public int CategoriaID { get; set; }
        public bool Estado { get; set; }
        public int TamanioID { get; set; }

        public TamanioBebida oTamanioBebida { get; set; }
        public Categoria oCategoria { get; set; }
       

    }
}
