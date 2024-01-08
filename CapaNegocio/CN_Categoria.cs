using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Declaramos el uso de la "capa Datos" para poder utilizar el private al "cd_Categoria"
using CapaDatos;
// Declaramos la referencia de Entidades
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Categoria
    {
        private CD_Categoria objcd_Categoria = new CD_Categoria();

        public List<Categoria> Listar()
        {
            // Devuelve la lista de la clase CD_Categoria que se encuentra en la capa de Datos
            return objcd_Categoria.Listar();
        }


        public int Registrar(Categoria obj, out string Mensaje) // Llamado al evento "Registrar" de (CD_Categoria)
        {
            // Validación para no poder cargar Categorias vacío:
            Mensaje = string.Empty; //Decimos que el mensaje sea "vacio" (Empty)

          
            if (obj.NombreCategoria == "") // Validación para que se inserte una Clave en el campo "TextBox"
            {
                Mensaje += "Es necesario el nombre de la Categoria\n";
            }
            if (Mensaje != string.Empty) // Si es diferente, entonces retorna un 0
            {
                return 0;
            }
            else
            {
                // Retornamos el Categoria que se registra y mostramos mensaje
                return objcd_Categoria.Registrar(obj, out Mensaje);
            }
        }

        public bool Editar(Categoria obj, out string Mensaje) // Llamado al evento "Editar" de (CD_Categoria)
        {
            // Validación para no poder cargar Categorias vacío:
            Mensaje = string.Empty; //Decimos que el mensaje sea "vacio" (Empty)

            if (obj.NombreCategoria == "") // Validación para que se inserte una Clave en el campo "TextBox"
            {
                Mensaje += "Es necesario el nombre de la Categoria\n";
            }
            
            if (Mensaje != string.Empty) // Si es diferente, entonces retorna un false
            {
                return false;
            }
            // Retornamos el Categoria que se registra y mostramos mensaje
            return objcd_Categoria.Editar(obj, out Mensaje);
        }

        public bool Eliminar(Categoria obj, out string Mensaje) // Llamado al evento "Eliminar" de (CD_Categoria)
        {
            // Retornamos el Categoria que se registra y mostramos mensaje
            return objcd_Categoria.Eliminar(obj, out Mensaje);
        }
    }
}
