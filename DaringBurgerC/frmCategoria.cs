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
    public partial class frmCategoria : Form
    {
        public frmCategoria()
        {
            InitializeComponent();
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            cboEstadoCat.Items.Add(new OpcionCombo() { valor = 1, Texto = "Activo" });
            cboEstadoCat.Items.Add(new OpcionCombo() { valor = 0, Texto = "No Activo" });
            cboEstadoCat.DisplayMember = "Texto";
            cboEstadoCat.ValueMember = "valor";
            cboEstadoCat.SelectedIndex = 0;

            foreach (DataGridViewColumn columna in dgvData.Columns)
            {
                // Si la lista de búsqueda es visible, que muestre los valores de la columna (( Pero que no muestre el botón vacío))
                if (columna.Visible == true && columna.Name != "btnSeleccionar")
                {
                    // Muestra todas las columnas disponibles para realizar la busqueda
                    cboBusquedaCat.Items.Add(new OpcionCombo() { valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            // Campos que mosrtará la lista
            cboBusquedaCat.DisplayMember = "Texto";
            cboBusquedaCat.ValueMember = "valor";
            cboBusquedaCat.SelectedIndex = 0;


            // Mostrar todas las categorias

            List<Categoria> lista = new CN_Categoria().Listar();

            foreach (Categoria item in lista) // Ésta lista procederá a enviarle todos los datos de la grilla
            {
                dgvData.Rows.Add(new object[]
                {"", // Boton
                item.CategoriaID, // Id (Txt oculto)
                item.NombreCategoria, // txtNombre
                item.Estado == true ? "Activo" : "No Activo",  // Texto indicado en lista del Estado ( Activo / No Activo )
                item.Estado == true ? 1 : 0, // Valor del estado ( 1: Activo / 0: No Activo )
            });
            }
        }

        private void btnGuardarCat_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            Categoria obj_Categoria = new Categoria()
            {
                CategoriaID = Convert.ToInt32(txtId.Text),
                NombreCategoria = txtNombreCategoria.Text,
                Estado = Convert.ToInt32(((OpcionCombo)cboEstadoCat.SelectedItem).valor) == 1 ? true : false
            };


            // Validación para cuando se EDITE el Categoria
            if (obj_Categoria.CategoriaID == 0)
            {
                int IdCategoriaGenerado = new CN_Categoria().Registrar(obj_Categoria, out mensaje);

                if (IdCategoriaGenerado != 0) // Si el Categoria generado es diferente a 0, que lo muestre en la grilla
                {
                    // Pasar los datos de los txt a la Grilla
                    dgvData.Rows.Add(new object[]
                        {"", // Boton
                IdCategoriaGenerado, // Id (Txt oculto)
                txtNombreCategoria.Text, // txtNombre
                // El cboRol, necesita ser "casteado" por (OpcionCombo) para convertirlo. Entonces ahora puede acceder a las propiedades valor.
                // al ser texto, se le especifica con la cadena de texto "ToString". Al siguiente, en vez de valor, si se obtiene el Texto, del item seleccionado.
                ((OpcionCombo)cboEstadoCat.SelectedItem).Texto.ToString(),  // Texto indicado en lista del Estado ( Activo / No Activo )
                ((OpcionCombo)cboEstadoCat.SelectedItem).valor.ToString(), // Valor del estado ( 1: Activo / 0: No Activo )
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
                bool resultado = new CN_Categoria().Editar(obj_Categoria, out mensaje); // Reutilizamos funcionalidad de Registrar, para "editar" llamando al evento de CN_Categoria

                if (resultado)
                {
                    DataGridViewRow row = dgvData.Rows[Convert.ToInt32(txtIndice.Text)];
                    row.Cells["Id"].Value = txtId.Text;
                    row.Cells["NombreCategoria"].Value = txtNombreCategoria.Text;
                    row.Cells["Estado"].Value = ((OpcionCombo)cboEstadoCat.SelectedItem).Texto.ToString();
                    row.Cells["EstadoValor"].Value = ((OpcionCombo)cboEstadoCat.SelectedItem).valor.ToString();
                    Limpiar();

                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
        }
        private void Limpiar()
        {
            txtIndice.Text = "-1";
            txtId.Text = "0";
            txtNombreCategoria.Text = "";
            cboEstadoCat.SelectedIndex = 0;
            txtNombreCategoria.Select();
        }

        private void dgvDataCat_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void dgvDataCat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Sólo si seleccionas el botón de la fila, realizará el evento
            if (dgvData.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int indice = e.RowIndex;
                if (indice >= 0) //Pintará la columna específica que se selecciona
                {
                    // Pasará los datos de la grilla a los "TextBox"
                    txtIndice.Text = indice.ToString();
                    txtId.Text = dgvData.Rows[indice].Cells["Id"].Value.ToString();
                    txtNombreCategoria.Text = dgvData.Rows[indice].Cells["NombreCategoria"].Value.ToString();

                    
                    }
                    foreach (OpcionCombo oc in cboEstadoCat.Items)
                    {
                        //  Si el valor del item es igual al que se muestra en grilla, entonces obtiene ese Indice del combo box
                        if (Convert.ToInt32(oc.valor) == Convert.ToInt32(dgvData.Rows[indice].Cells["EstadoValor"].Value)) // Lista desplegable "Activo / No activo"
                        {
                            // Al obtener el indice (oc: optionCombo) devuelve la coleccion del elemento. Entonces mostrará dentro de cboRol, el indice obtenido.
                            int indice_combo = cboEstadoCat.Items.IndexOf(oc);
                            cboEstadoCat.SelectedIndex = indice_combo;
                            break; //Termina
                        }
                    }
                }
            }

        private void btnEliminarCat_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtId.Text) != 0) // Si el usuario seleccionado es diferente a 0 (Se selecciona un usuario de grilla) Entonces
            {   // Si luego del mensaje de alerta, presiona "Si" entonces
                if (MessageBox.Show("¿Desea eliminar la Categoría?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty; // Declaramos mensaje como vacío
                    Categoria obj_categoria = new Categoria() //Declaramos usuario
                    {
                        CategoriaID = Convert.ToInt32(txtId.Text), //Al usuario seleccionado
                    };
                    bool respuesta = new CN_Categoria().Eliminar(obj_categoria, out mensaje); //Se llama al evento "Eliminar" de (CN_Usuario)
                    if (respuesta)
                    {
                        dgvData.Rows.RemoveAt(Convert.ToInt32(txtIndice.Text)); // Entonces, una vez confirmado todo, se removerá el usuario seleccionado (Dejará como "INACTIVO")
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        private void btnLupaCat_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cboBusquedaCat.SelectedItem).valor.ToString();

            if (dgvData.Rows.Count > 0) // Si existe alguna lista de usuarios
            {   // Recorre cada fila de la grilla
                foreach (DataGridViewRow row in dgvData.Rows)
                {
                    // Trim: Elimina espacios al inicio o al final
                    // ToUpper: Coloca los caracteres en Mayuscula
                    // Contains(): Indicamos que necesitamos buscar lo que (contenga) el "TextBox"
                    // En las celdas de las filas, donde las columnas retornen el valor, que limpie los espacios al final o inicio y que convierta en mayuscula. Si es que contiene (lo que se busca en la caja de texto) sin espacios al inicio y final y con mayusculas
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtBusquedaCat.Text.Trim().ToUpper()))
                        row.Visible = true; // En el caso que contenga el texto que buscamos, muestralo.
                    else
                        row.Visible = false; // Si no lo contiene, no muestra.
                }
            }
        }

        private void btnLimpiarBuscadorCat_Click(object sender, EventArgs e)
        {
            txtBusquedaCat.Text = ""; // Limpiamos el textbox
            foreach (DataGridViewRow row in dgvData.Rows) // Especificamos que al haber limpiado, busque los datos de la grilla
            {
                row.Visible = true; // Y que los muestre a todos
            }
        }

        private void btnLimpiarGrillaCat_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}

