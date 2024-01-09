using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Declaramos utilidades y capas necesarias
using DaringBurgerC.Utilidades;
using CapaEntidad;
using CapaNegocio;

namespace DaringBurgerC
{
    public partial class frmBebidas : Form
    {
        public frmBebidas()
        {
            InitializeComponent();
        }

        private void frmBebidas_Load(object sender, EventArgs e)
        {
            cboEstadoBeb.Items.Add(new OpcionCombo() { valor = 1, Texto = "Activo" });
            cboEstadoBeb.Items.Add(new OpcionCombo() { valor = 0, Texto = "No Activo" });
            cboEstadoBeb.DisplayMember = "Texto";
            cboEstadoBeb.ValueMember = "valor";
            cboEstadoBeb.SelectedIndex = 0;
            
            // ComboBox Categoria
            List<Categoria> ListaCat = new CN_Categoria().Listar();

            foreach (Categoria item in ListaCat)
            {
                cboCategoriaBeb.Items.Add(new OpcionCombo() { valor = item.CategoriaID, Texto = item.NombreCategoria });
            }

            // Establecer los DisplayMember y ValueMember fuera del bucle
            cboCategoriaBeb.DisplayMember = "Texto";
            cboCategoriaBeb.ValueMember = "valor";

            // Seleccionar el índice deseado, por ejemplo, seleccionar el primer elemento
            cboCategoriaBeb.SelectedIndex = 0;
            // Fin ComboBox Categoria

            // ComboBox Tamaño
            List<TamanioBebida> ListaTamanio = new CN_TamanioBebida().Listar();

            foreach (TamanioBebida item in ListaTamanio)
            {
                cboTamanioBeb.Items.Add(new OpcionCombo() { valor = item.TamanioID, Texto = item.Tamanio });
            }

            // Establecer los DisplayMember y ValueMember fuera del bucle
            cboTamanioBeb.DisplayMember = "Texto";
            cboTamanioBeb.ValueMember = "valor";

            // Seleccionar el índice deseado, por ejemplo, seleccionar el primer elemento
            cboTamanioBeb.SelectedIndex = 0;
            // Fin ComboBox Tamaño

            // ComboBox Envase
            List<TamanioBebida> ListaEnvase = new CN_TamanioBebida().Listar();

            // Filtrar los elementos únicos
            var envasesUnicos = ListaEnvase.GroupBy(x => x.Envase)
                                           .Select(g => g.First())
                                           .ToList();

            foreach (TamanioBebida item in envasesUnicos)
            {
                cboEnvaseBeb.Items.Add(new OpcionCombo() { valor = item.TamanioID, Texto = item.Envase });
            }

            // Establecer los DisplayMember y ValueMember fuera del bucle
            cboEnvaseBeb.DisplayMember = "Texto";
            cboEnvaseBeb.ValueMember = "valor";

            // Seleccionar el índice deseado, por ejemplo, seleccionar el primer elemento
            cboEnvaseBeb.SelectedIndex = 0;
            // Fin ComboBox Envase



            foreach (DataGridViewColumn columna in dgvData.Columns)
            {
                // Si la lista de búsqueda es visible, que muestre los valores de la columna (( Pero que no muestre el botón vacío))
                if (columna.Visible == true && columna.Name != "btnSeleccionar")
                {
                    // Muestra todas las columnas disponibles para realizar la busqueda
                    cboBusquedaBeb.Items.Add(new OpcionCombo() { valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            // Campos que mosrtará la lista
            cboBusquedaBeb.DisplayMember = "Texto";
            cboBusquedaBeb.ValueMember = "valor";
            cboBusquedaBeb.SelectedIndex = 0;


            // Mostrar todas las categorias

            List<Bebidas> lista = new CN_Bebidas().Listar();

            foreach (Bebidas item in lista) // Ésta lista procederá a enviarle todos los datos de la grilla [[ Son los campos de "CapaEntidad" Bebidas]]
            {
                dgvData.Rows.Add(new object[]
                {"", // Boton
                item.BebidaID, // Id (Txt oculto)
                item.NombreBebida,
                item.Precio,
                item.oCategoria.NombreCategoria,
                item.oTamanioBebida.Tamanio,
                item.oTamanioBebida.Envase,
                item.Estado == true ? "Activo" : "No Activo",  // Texto indicado en lista del Estado ( Activo / No Activo )
                item.Estado == true ? 1 : 0, // Valor del estado ( 1: Activo / 0: No Activo )
            });
            }
        }

        private void dgvData_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                    txtNombreBebida.Text = dgvData.Rows[indice].Cells["NombreBebida"].Value.ToString();
                    txtPrecioBeb.Text = dgvData.Rows[indice].Cells["PrecioBeb"].Value.ToString();


                }
                // Agregar la listas de Categoria
                foreach (OpcionCombo oc in cboCategoriaBeb.Items)
                {
                    //  Si el valor del item es igual al que se muestra en grilla, entonces obtiene ese Indice del combo box
                    if (Convert.ToInt32(oc.valor) == Convert.ToInt32(dgvData.Rows[indice].Cells["NombreCategoria"].Value))
                    {
                        // Al obtener el indice (oc: optionCombo) devuelve la coleccion del elemento. Entonces mostrará dentro de cboRol, el indice obtenido.
                        int indice_combo = cboCategoriaBeb.Items.IndexOf(oc);
                        cboCategoriaBeb.SelectedIndex = indice_combo;
                        break; //Termina
                    }
                }
                // Agregar la listas de Tamaño
                foreach (OpcionCombo oc in cboTamanioBeb.Items)
                {
                    //  Si el valor del item es igual al que se muestra en grilla, entonces obtiene ese Indice del combo box
                    if (Convert.ToInt32(oc.valor) == Convert.ToInt32(dgvData.Rows[indice].Cells["Tamanio"].Value))
                    {
                        // Al obtener el indice (oc: optionCombo) devuelve la coleccion del elemento. Entonces mostrará dentro de cboRol, el indice obtenido.
                        int indice_combo = cboTamanioBeb.Items.IndexOf(oc);
                        cboTamanioBeb.SelectedIndex = indice_combo;
                        break; //Termina
                    }
                }
                foreach (OpcionCombo oc in cboEnvaseBeb.Items)
                {
                    //  Si el valor del item es igual al que se muestra en grilla, entonces obtiene ese Indice del combo box
                    if (Convert.ToInt32(oc.valor) == Convert.ToInt32(dgvData.Rows[indice].Cells["Envase"].Value))
                    {
                        // Al obtener el indice (oc: optionCombo) devuelve la coleccion del elemento. Entonces mostrará dentro de cboRol, el indice obtenido.
                        int indice_combo = cboEnvaseBeb.Items.IndexOf(oc);
                        cboEnvaseBeb.SelectedIndex = indice_combo;
                        break; //Termina
                    }
                }
                foreach (OpcionCombo oc in cboEstadoBeb.Items)
                {
                    //  Si el valor del item es igual al que se muestra en grilla, entonces obtiene ese Indice del combo box
                    if (Convert.ToInt32(oc.valor) == Convert.ToInt32(dgvData.Rows[indice].Cells["EstadoValor"].Value)) // Lista desplegable "Activo / No activo"
                    {
                        // Al obtener el indice (oc: optionCombo) devuelve la coleccion del elemento. Entonces mostrará dentro de cboRol, el indice obtenido.
                        int indice_combo = cboEstadoBeb.Items.IndexOf(oc);
                        cboEstadoBeb.SelectedIndex = indice_combo;
                        break; //Termina
                    }
                }
            }
        }
    }
}
