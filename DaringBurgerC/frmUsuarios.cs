using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DaringBurgerC.Utilidades;
using CapaEntidad;
using CapaNegocio;

namespace DaringBurgerC
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            cboEstado.Items.Add(new OpcionCombo() { valor = 1, Texto = "Activo" });
            cboEstado.Items.Add(new OpcionCombo() { valor = 0, Texto = "No Activo" });
            cboEstado.DisplayMember = "Texto";
            cboEstado.ValueMember = "valor";
            cboEstado.SelectedIndex = 0;
            // Obtenermos el evento de lista creado en CD_Rol
            List<Rol> ListaRol = new CN_Rol().Listar();
        
            foreach (Rol item in ListaRol)
            {
                cboRol.Items.Add(new OpcionCombo() { valor = item.IdRol, Texto = item.Descripcion });
            }

            // Establecer los DisplayMember y ValueMember fuera del bucle
            cboRol.DisplayMember = "Texto";
            cboRol.ValueMember = "valor";

            // Seleccionar el índice deseado, por ejemplo, seleccionar el primer elemento
            cboRol.SelectedIndex = 0;





            // Obtener en la lista del filtro, los datos a mostrar
            foreach (DataGridViewColumn columna in dgvDataUsuario.Columns)
            {
                // Si la lista de búsqueda es visible, que muestre los valores de la columna (( Pero que no muestre el botón vacío))
                if (columna.Visible == true && columna.Name != "btnSeleccionar")
                {
                    // Muestra todas las columnas disponibles para realizar la busqueda
                    cboBusqueda.Items.Add(new OpcionCombo() { valor = columna.Name, Texto = columna.HeaderText });
                }
            }
           // Campos que mosrtará la lista
            cboBusqueda.DisplayMember = "Texto";
            cboBusqueda.ValueMember = "valor";
            cboBusqueda.SelectedIndex = 0;

            // Mostrar todos los usuarios
            List<Usuario> Listausuarios = new CN_Usuario().Listar();

           foreach (Usuario item in Listausuarios) // Ésta lista procederá a enviarle todos los datos de la grilla
            {
                dgvDataUsuario.Rows.Add(new object[]
                {"", // Boton
                item.IdUsuario, // Id (Txt oculto)
                item.NombreCompleto, // txtNombre
                item.oRol.Descripcion, // Nombre del Rol (Administrador / Empleado)
                item.Estado == true ? "Activo" : "No Activo",  // Texto indicado en lista del Estado ( Activo / No Activo )
                item.Clave, // Clave del usuario
                item.oRol.IdRol, // Valor del Rol ( 1: ADMINISTRADOR / 2: EMPLEADO )
                item.Estado == true ? 1 : 0, // Valor del estado ( 1: Activo / 0: No Activo )
               
            });
            }


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            Usuario obj_usuario = new Usuario()
            {
                IdUsuario = Convert.ToInt32(txtId.Text),
                NombreCompleto = txtNombreCompleto.Text,
                Clave = txtClave.Text,
                oRol = new Rol() { IdRol = Convert.ToInt32(((OpcionCombo)cboRol.SelectedItem).valor) },
                Estado = Convert.ToInt32(((OpcionCombo)cboEstado.SelectedItem).valor) == 1 ? true : false
            };


            // Validación para cuando se EDITE el Usuario
            if (obj_usuario.IdUsuario == 0)
            {
                int IdUsuarioGenerado = new CN_Usuario().Registrar(obj_usuario, out mensaje);

                if (IdUsuarioGenerado != 0) // Si el usuario generado es diferente a 0, que lo muestre en la grilla
                {
                    // Pasar los datos de los txt a la Grilla
                    dgvDataUsuario.Rows.Add(new object[]
                        {"", // Boton
                IdUsuarioGenerado, // Id (Txt oculto)
                txtNombreCompleto.Text, // txtNombre
                // El Id al ser 1 y 2 (roles) se utiliza el siguiente evento... De esta forma obtenemos el item seleccionado.
                ((OpcionCombo)cboRol.SelectedItem).Texto.ToString(), // Nombre del Rol (Administrador / Empleado)
                // El cboRol, necesita ser "casteado" por (OpcionCombo) para convertirlo. Entonces ahora puede acceder a las propiedades valor.
                // al ser texto, se le especifica con la cadena de texto "ToString". Al siguiente, en vez de valor, si se obtiene el Texto, del item seleccionado.
                ((OpcionCombo)cboEstado.SelectedItem).Texto.ToString(),  // Texto indicado en lista del Estado ( Activo / No Activo )
                txtClave.Text, // Clave del usuario
                ((OpcionCombo)cboEstado.SelectedItem).valor.ToString(), // Valor del estado ( 1: Activo / 0: No Activo )
                ((OpcionCombo)cboRol.SelectedItem).valor.ToString() // Valor del Rol ( 1: ADMINISTRADOR / 2: EMPLEADO )
                        });
                    // Llamamos al evento limpiar
                    Limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
            else
            {
                bool resultado = new CN_Usuario().Editar(obj_usuario, out mensaje); // Reutilizamos funcionalidad de Registrar, para "editar" llamando al evento de CN_Usuario

                if (resultado)
                {
                    DataGridViewRow row = dgvDataUsuario.Rows[Convert.ToInt32(txtIndice.Text)];
                    row.Cells["Id"].Value = txtId.Text;
                    row.Cells["NombreCompleto"].Value = txtNombreCompleto.Text;
                    row.Cells["Rol"].Value = ((OpcionCombo)cboRol.SelectedItem).Texto.ToString();
                    row.Cells["Estado"].Value = ((OpcionCombo)cboEstado.SelectedItem).Texto.ToString();
                    row.Cells["Clave"].Value = txtClave.Text;
                    row.Cells["EstadoValor"].Value = ((OpcionCombo)cboEstado.SelectedItem).valor.ToString();
                    row.Cells["IdRol"].Value = ((OpcionCombo)cboRol.SelectedItem).valor.ToString();
                    Limpiar();

                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }




        }
        // Limpiar los txt al presionar "Guardar"
        private void Limpiar()
        {
            txtIndice.Text = "-1";
            txtId.Text = "0";
            txtNombreCompleto.Text = "";
            txtClave.Text = "";
            txtConfirmarClave.Text = "";
            cboEstado.SelectedIndex = 0;
            cboRol.SelectedIndex = 0;

            txtNombreCompleto.Select();
        }

        private void dgvDataUsuario_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            // Agregar dibujo al botón de la celda
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                // Asignamos las posiciones y la imágen que tendrá
                var w = Properties.Resources.Accept.Width;
                var h = Properties.Resources.Accept.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2; // determinamos el ancho y restamos con el ancho de la imágen, dividimos en 2 para que pinte al medio de la imágen
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.Accept, new Rectangle(x, y, w, h)); // Procede a pintar la imagen "Accept" <- nombre de la foto (Y pasamos los puntos donde pintará, cómo? "Rectangulo" y en las posiciones)
                e.Handled = true; // Damos permiso para que proceda con el evento clic al botón, le indicamos si continúa o no
            }
        }

        private void dgvDataUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Sólo si seleccionas el botón de la fila, realizará el evento
            if (dgvDataUsuario.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int indice = e.RowIndex;
                if (indice >= 0) //Pintará la columna específica que se selecciona
                {
                    // Pasará los datos de la grilla a los "TextBox"
                    txtIndice.Text = indice.ToString();
                    txtId.Text = dgvDataUsuario.Rows[indice].Cells["Id"].Value.ToString();
                    txtNombreCompleto.Text = dgvDataUsuario.Rows[indice].Cells["NombreCompleto"].Value.ToString();
                    txtClave.Text = dgvDataUsuario.Rows[indice].Cells["Clave"].Value.ToString();
                    txtConfirmarClave.Text = dgvDataUsuario.Rows[indice].Cells["Clave"].Value.ToString();

                    // Agregar la listas de Rol y EStado
                    foreach (OpcionCombo oc in cboRol.Items)
                    {
                        //  Si el valor del item es igual al que se muestra en grilla, entonces obtiene ese Indice del combo box
                        if (Convert.ToInt32(oc.valor) == Convert.ToInt32(dgvDataUsuario.Rows[indice].Cells["IdRol"].Value))
                        {
                            // Al obtener el indice (oc: optionCombo) devuelve la coleccion del elemento. Entonces mostrará dentro de cboRol, el indice obtenido.
                            int indice_combo = cboRol.Items.IndexOf(oc);
                            cboRol.SelectedIndex = indice_combo;
                            break; //Termina
                        }
                    }
                    foreach (OpcionCombo oc in cboEstado.Items)
                    {
                        //  Si el valor del item es igual al que se muestra en grilla, entonces obtiene ese Indice del combo box
                        if (Convert.ToInt32(oc.valor) == Convert.ToInt32(dgvDataUsuario.Rows[indice].Cells["EstadoValor"].Value)) // Lista desplegable "Activo / No activo"
                        {
                            // Al obtener el indice (oc: optionCombo) devuelve la coleccion del elemento. Entonces mostrará dentro de cboRol, el indice obtenido.
                            int indice_combo = cboEstado.Items.IndexOf(oc);
                            cboEstado.SelectedIndex = indice_combo;
                            break; //Termina
                        }
                    }
                }
            }
        }



        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtId.Text) != 0) // Si el usuario seleccionado es diferente a 0 (Se selecciona un usuario de grilla) Entonces
            {   // Si luego del mensaje de alerta, presiona "Si" entonces
                if (MessageBox.Show("¿Desea eliminar el usuario?","Mensaje",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes) 
                {
                    string mensaje = string.Empty; // Declaramos mensaje como vacío
                    Usuario obj_usuario = new Usuario() //Declaramos usuario
                    {
                        IdUsuario = Convert.ToInt32(txtId.Text), //Al usuario seleccionado
                    };
                    bool respuesta = new CN_Usuario().Eliminar(obj_usuario, out mensaje); //Se llama al evento "Eliminar" de (CN_Usuario)
                    if (respuesta) 
                    {
                        dgvDataUsuario.Rows.RemoveAt(Convert.ToInt32(txtIndice.Text)); // Entonces, una vez confirmado todo, se removerá el usuario seleccionado (Dejará como "INACTIVO")
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        private void btnLupa_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cboBusqueda.SelectedItem).valor.ToString();

            if (dgvDataUsuario.Rows.Count > 0) // Si existe alguna lista de usuarios
            {   // Recorre cada fila de la grilla
                foreach (DataGridViewRow row in dgvDataUsuario.Rows)
                {
                    // Trim: Elimina espacios al inicio o al final
                    // ToUpper: Coloca los caracteres en Mayuscula
                    // Contains(): Indicamos que necesitamos buscar lo que (contenga) el "TextBox"
                    // En las celdas de las filas, donde las columnas retornen el valor, que limpie los espacios al final o inicio y que convierta en mayuscula. Si es que contiene (lo que se busca en la caja de texto) sin espacios al inicio y final y con mayusculas
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtBusqueda.Text.Trim().ToUpper()))
                        row.Visible = true; // En el caso que contenga el texto que buscamos, muestralo.
                    else
                        row.Visible = false; // Si no lo contiene, no muestra.
                }
            }
        }

        private void btnLimpiarBuscador_Click(object sender, EventArgs e)
        {
            txtBusqueda.Text = ""; // Limpiamos el textbox
            foreach(DataGridViewRow row in dgvDataUsuario.Rows) // Especificamos que al haber limpiado, busque los datos de la grilla
            {
                row.Visible = true; // Y que los muestre a todos
            }
        }

        private void btnLimpiarGrilla_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        
    }
}
