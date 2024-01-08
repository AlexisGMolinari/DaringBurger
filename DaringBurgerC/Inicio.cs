using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Importamos referencia de la capa de Entidad
using CapaEntidad;

// utilizamos los FontAwesomeSharp para los iconos
using FontAwesome.Sharp;

//referenciamos el uso de la capa negocio
using CapaNegocio;


namespace DaringBurgerC
{
    public partial class Inicio : Form
    {
        //Declaramos una variable de tipo: IconMenuItem
        private static IconDropDownButton MenuActivo = null;
        // Declaramos variable para declarar cual formulario se encuentra Activo
        private static Form FormularioActivo = null;

        

        //Declaramos un usuario
        private static Usuario usuarioActual;
        // El constructor Inicio, siempre se ejecutará antes que el Load
        // Al constructor de inicio, le damos un Objetousuario
        public Inicio(Usuario objusuario)
        {
            usuarioActual = objusuario;
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            // Compartimos el "Id" del usuario, para identificar su usuario y ver la lista de permisos que dispone
            List<Permiso> ListaPermisos = new CN_Permiso().Listar(usuarioActual.IdUsuario);
            // Limitamos la vista de los menú por cada usuario
            foreach (IconDropDownButton iconMenu in Menu.Items) // Utilizamos "IconDropDownButton" para reemplazar "IconMenuItem"
            {
                // determinamos si encuentra elementos ___ "iconMenu" es el botón del menu ___ "m" es cada elemento de la lista
                bool encontrado = ListaPermisos.Any(m => m.NombreMenu == iconMenu.Name);

                // Si no se encontró el menú en su lista de permisos, no lo muestra
                if (encontrado == false)
                {
                    iconMenu.Visible = false;
                }

            }

            lblusuario.Text = usuarioActual.NombreCompleto;
        }



       



        private void AbrirFormulario(IconDropDownButton menu, Form Formulario)
        {
            if (MenuActivo != null)
            {
                MenuActivo.BackColor = Color.FromArgb(255, 255, 128);

            }
            menu.BackColor = Color.Goldenrod;
            MenuActivo = menu;

            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }
            // Modificaciones al formulario (Propiedades)
            FormularioActivo = Formulario; //Formulario que se mostrará
            Formulario.TopLevel = false; // No es superior
            Formulario.FormBorderStyle = FormBorderStyle.None; //No tenga borde
            Formulario.Dock = DockStyle.Fill; // Contenido "rellenar" todo el espacio del contenedor
            Formulario.BackColor = Color.DimGray; // Color de fondo

            //Contenedor
            Contenedor.Controls.Add(Formulario); // Agregamos dentro del contenedor, el "Formulario"
            Formulario.Show(); //Se muestra
        }

        // Ejecutamos el evento en el botón "Usuarios"
        // "Sender" <- espacio donde se almacena el menú de formulario (Usuarios) 
        private void Usuarios_Click(object sender, EventArgs e)
        {
            if (sender is IconDropDownButton dropDownButton)
            {
                // Aquí puedes acceder a las propiedades de IconDropDownButton si es necesario

                // Ejemplo: Obtener el formulario que deseas abrir
                Form formulario = new frmUsuarios();

                // Llamar a la función para abrir el formulario
                AbrirFormulario(dropDownButton, formulario);
            }
        }

       

        private void CargarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
                AbrirFormulario(Inventario, new frmTalles()); 
            
        }

        private void EstablecerPreciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(Inventario, new frmProductos());
        }

        private void Informes_Click(object sender, EventArgs e)
        {
            if (sender is IconDropDownButton dropDownButton)
            {
                // Aquí puedes acceder a las propiedades de IconDropDownButton si es necesario

                // Ejemplo: Obtener el formulario que deseas abrir
                Form formulario = new frmInformes();

                // Llamar a la función para abrir el formulario
                AbrirFormulario(dropDownButton, formulario);
            }
        }

        private void InformeCaja_Click(object sender, EventArgs e)
        {
            if (sender is IconDropDownButton dropDownButton)
            {
                // Aquí puedes acceder a las propiedades de IconDropDownButton si es necesario

                // Ejemplo: Obtener el formulario que deseas abrir
                Form formulario = new frmCajaInicial();

                // Llamar a la función para abrir el formulario
                AbrirFormulario(dropDownButton, formulario);
            }
        }

        private void Pedidos_Click(object sender, EventArgs e)
        {
            if (sender is IconDropDownButton dropDownButton)
            {
                // Aquí puedes acceder a las propiedades de IconDropDownButton si es necesario

                // Ejemplo: Obtener el formulario que deseas abrir
                Form formulario = new frmPedidos();

                // Llamar a la función para abrir el formulario
                AbrirFormulario(dropDownButton, formulario);
            }
        }

        private void TotalCaja_Click(object sender, EventArgs e)
        {
            if (sender is IconDropDownButton dropDownButton)
            {
                // Aquí puedes acceder a las propiedades de IconDropDownButton si es necesario

                // Ejemplo: Obtener el formulario que deseas abrir
                Form formulario = new frmCaja();

                // Llamar a la función para abrir el formulario
                AbrirFormulario(dropDownButton, formulario);
            }
        }

        private void categoríasToolStripMenuItem_Click(object sender, EventArgs e)
        {
                AbrirFormulario(Inventario, new frmBebidas());

        }

        private void categoríasBebidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(Inventario, new frmCategoria());

        }
    }
}
