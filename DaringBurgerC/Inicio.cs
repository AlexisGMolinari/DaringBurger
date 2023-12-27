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
            lblusuario.Text = usuarioActual.NombreCompleto;
        }

        private void categoríasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



        private void AbrirFormulario(IconDropDownButton menu, Form Formulario)
        {
            if (MenuActivo != null)
            {
                MenuActivo.BackColor = Color.White;

            }
            menu.BackColor = Color.Goldenrod;
            MenuActivo = menu;

            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }
            // Modificaciones al formulario
            FormularioActivo = Formulario;
            Formulario.TopLevel = false;
            Formulario.FormBorderStyle = FormBorderStyle.None;
            Formulario.Dock = DockStyle.Fill;
            Formulario.BackColor = Color.DimGray;
            //Contenedor
            Contenedor.Controls.Add(Formulario);
            Formulario.Show();
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


    }
}
