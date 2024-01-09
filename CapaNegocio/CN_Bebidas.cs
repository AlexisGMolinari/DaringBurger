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
    public class CN_Bebidas
    {
        private CD_Bebidas objcd_bebidas = new CD_Bebidas();

        public List<Bebidas> Listar()
        {
            // Devuelve la lista de la clase CD_Usuario que se encuentra en la capa de Datos
            return objcd_bebidas.Listar();
        }


        public int Registrar(Bebidas obj, out string Mensaje) // Llamado al evento "Registrar" de (CD_Usuario)
        {
            // Validación para no poder cargar usuarios vacío:
            Mensaje = string.Empty; //Decimos que el mensaje sea "vacio" (Empty)

            if (obj.NombreBebida == "") // Validación para que se inserte un Nombre en el campo "TextBox"
            {
                Mensaje += "Es necesario el nombre de Bebida\n";
            }
            decimal? precio = obj.Precio; // Declarado así al ser decimal

            if (!precio.HasValue) // Especificamos que se ingrese un valor ((Declarado de esa manera, ya que es un decimal))
            {
                Mensaje += "Es necesario especificar el Precio\n";
            }

            if (Mensaje != string.Empty) // Si es diferente, entonces retorna un 0
            {
                return 0;
            }
            else
            {
                // Retornamos el usuario que se registra y mostramos mensaje
                return objcd_bebidas.Registrar(obj, out Mensaje);
            }
        }

        public bool Editar(Bebidas obj, out string Mensaje) // Llamado al evento "Editar" de (CD_Usuario)
        {
            // Validación para no poder cargar usuarios vacío:
            Mensaje = string.Empty; //Decimos que el mensaje sea "vacio" (Empty)

            if (obj.NombreBebida == "") // Validación para que se inserte un Nombre en el campo "TextBox"
            {
                Mensaje += "Es necesario el nombre de Bebida\n";
            }
            decimal? precio = obj.Precio; // Declarado así al ser decimal

            if (!precio.HasValue) // Especificamos que se ingrese un valor ((Declarado de esa manera, ya que es un decimal))
            {
                Mensaje += "Es necesario especificar el Precio\n";
            }
            if (Mensaje != string.Empty) // Si es diferente, entonces retorna un false
            {
                return false;
            }
            // Retornamos el usuario que se registra y mostramos mensaje
            return objcd_bebidas.Editar(obj, out Mensaje);
        }

        public bool Eliminar(Bebidas obj, out string Mensaje) // Llamado al evento "Eliminar" de (CD_Usuario)
        {
            // Retornamos el usuario que se registra y mostramos mensaje
            return objcd_bebidas.Eliminar(obj, out Mensaje);
        }
    }
}
