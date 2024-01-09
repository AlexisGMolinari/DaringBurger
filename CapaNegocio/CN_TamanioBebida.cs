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
    public class CN_TamanioBebida
    {
        private CD_Tamanio objcd_TamanioBebidas = new CD_Tamanio();

        public List<TamanioBebida> Listar()
        {
            // Devuelve la lista de la clase CD_Usuario que se encuentra en la capa de Datos
            return objcd_TamanioBebidas.Listar();
        }


        public int Registrar(TamanioBebida obj, out string Mensaje) // Llamado al evento "Registrar" de (CD_Usuario)
        {
            // Validación para no poder cargar usuarios vacío:
            Mensaje = string.Empty; //Decimos que el mensaje sea "vacio" (Empty)

            if (obj.Tamanio == "") // Validación para que se inserte un Nombre en el campo "TextBox"
            {
                Mensaje += "Es necesario indicar el tamaño de la Bebida\n";
            }
            if (obj.Envase == "") // Validación para que se inserte una Clave en el campo "TextBox"
            {
                Mensaje += "Es necesario indicar el Envase\n";
            }
            if (Mensaje != string.Empty) // Si es diferente, entonces retorna un 0
            {
                return 0;
            }
            else
            {
                // Retornamos el usuario que se registra y mostramos mensaje
                return objcd_TamanioBebidas.Registrar(obj, out Mensaje);
            }
        }

        public bool Editar(TamanioBebida obj, out string Mensaje) // Llamado al evento "Editar" de (CD_Usuario)
        {
            // Validación para no poder cargar usuarios vacío:
            Mensaje = string.Empty; //Decimos que el mensaje sea "vacio" (Empty)

            if (obj.Tamanio == "") // Validación para que se inserte un Nombre en el campo "TextBox"
            {
                Mensaje += "Es necesario indicar el tamaño de la Bebida\n";
            }
            if (obj.Envase == "") // Validación para que se inserte una Clave en el campo "TextBox"
            {
                Mensaje += "Es necesario indicar el Envase\n";
            }
            if (Mensaje != string.Empty) // Si es diferente, entonces retorna un false
            {
                return false;
            }
            // Retornamos el usuario que se registra y mostramos mensaje
            return objcd_TamanioBebidas.Editar(obj, out Mensaje);
        }

        public bool Eliminar(TamanioBebida obj, out string Mensaje) // Llamado al evento "Eliminar" de (CD_Usuario)
        {
            // Retornamos el usuario que se registra y mostramos mensaje
            return objcd_TamanioBebidas.Eliminar(obj, out Mensaje);
        }
    }
}
