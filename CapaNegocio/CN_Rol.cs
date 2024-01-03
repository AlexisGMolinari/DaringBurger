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
    public class CN_Rol
    {
        private CD_Rol objcd_rol = new CD_Rol();

        public List<Rol> Listar()
        {
            // Devuelve la lista de la clase CD_Rol que se encuentra en la capa de Datos
            return objcd_rol.Listar();
        }
    }
}
