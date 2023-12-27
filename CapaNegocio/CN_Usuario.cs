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
    public class CN_Usuario
    {
        private CD_Usuario objcd_usuario = new CD_Usuario();

        public List<Usuario> Listar()
        {
            // Devuelve la lista de la clase CD_Usuario que se encuentra en la capa de Datos
            return objcd_usuario.Listar();
        }

    }
}
