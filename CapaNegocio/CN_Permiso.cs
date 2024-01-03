using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Declaramos el uso de la "capa Datos" para poder utilizar el private al "cd_usuario"
using CapaDatos;
// Declaramos la referencia de Entidades
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Permiso
    {
        private CD_Permiso objcd_permiso = new CD_Permiso();

        public List<Permiso> Listar(int IdUsuario)
        {
            // Devuelve la lista de la clase CD_Usuario que se encuentra en la capa de Datos
            return objcd_permiso.Listar(IdUsuario);
        }
    }
}
