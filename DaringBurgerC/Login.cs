using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Capa de negocio es la unica que sirve de intermediario entre "Datos y Daring"
using CapaNegocio;

// Declaramos la capa Entidades para poder tener los permisos de utilizar sus campos
using CapaEntidad;

namespace DaringBurgerC
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LogoDB_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
       
        private void btnIngresar_Click(object sender, EventArgs e)
        {

            //List<Usuario> TEST = new CN_Usuario().Listar();
            // Nuestro "Usuario" declara el objeto usuario como un "nuevo usuario de CapaNegocio" utiliza evento "Listar" y con el evento "donde(where)" nos ayuda a automatizar la busqueda de un objeto, como "u (usuario)"
            // Y que al ingresar en los campos "TextBox" el Nombre y Clave similar a lo cargado en sql.. "FirstOrDefault = si no encuentra, devuelve usuario nulo"
            Usuario ousuario = new CN_Usuario().Listar().Where(u => u.NombreCompleto == txtNombreCompleto.Text && u.Clave == txtClave.Text).FirstOrDefault();
            // si el objeto usuario es nulo, procede a las siguientes acciones
            if(ousuario != null)
            {
                // Indicamos al botón "Ingresar" que muestre "Inicio.cs" y se oculte "Login.cs"
                Inicio form = new Inicio(ousuario);

                form.Show(); // Muestra
                this.Hide();    // Oculta

                form.FormClosing += frm_closing;    // Aplicamos el evento "Frm_Closing" Para que, cuando el formulario se esté cerrando, pueda unirse con el Evento "ForClosing" (Mostrar lo ocultado anteriormente)

            }
            // si no se encuentra el usuario, se envia el siguiente mensaje
            else
            {
                MessageBox.Show("El nombre o contraseña, son incorrectos.", "Error al intentar ingresar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombreCompleto.Text = ""; // Mostrar campo vacío
                txtClave.Text = "";// Mostrar campo vacío
            }
          }

        // Evento para mostrar el formulario que se ocultó al cerrarse
        
        private void frm_closing(object sender, FormClosingEventArgs e){

            this.Show(); // Muestra el formulario oculto al cerrarse el anterior

            // Al abrirse nuevamente el formulario oculto, comenzará por lo siguiente:
            txtNombreCompleto.Text = ""; // Mostrar campo vacío
            txtClave.Text = ""; // Mostrar campo vacío

        }

       
    }
}
