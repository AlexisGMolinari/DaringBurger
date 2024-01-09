
namespace DaringBurgerC
{
    partial class frmBebidas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGuardarBeb = new FontAwesome.Sharp.IconButton();
            this.label6 = new System.Windows.Forms.Label();
            this.cboEstadoBeb = new System.Windows.Forms.ComboBox();
            this.txtNombreBebida = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIndice = new System.Windows.Forms.TextBox();
            this.btnLimpiarBuscadorBeb = new FontAwesome.Sharp.IconButton();
            this.btnLupaBeb = new FontAwesome.Sharp.IconButton();
            this.txtBusquedaBeb = new System.Windows.Forms.TextBox();
            this.cboBusquedaBeb = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnEliminarCat = new FontAwesome.Sharp.IconButton();
            this.btnLimpiarGrillaCat = new FontAwesome.Sharp.IconButton();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.btnEliminarBeb = new FontAwesome.Sharp.IconButton();
            this.btnLimpiarBeb = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.cboTamanioBeb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboCategoriaBeb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPrecioBeb = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cboEnvaseBeb = new System.Windows.Forms.ComboBox();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreBebida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioBeb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tamanio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Envase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label7.Font = new System.Drawing.Font("Arial Black", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 19);
            this.label7.TabIndex = 48;
            this.label7.Text = "Detalle de Bebidas:";
            // 
            // btnGuardarBeb
            // 
            this.btnGuardarBeb.BackColor = System.Drawing.Color.LimeGreen;
            this.btnGuardarBeb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarBeb.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGuardarBeb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarBeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarBeb.ForeColor = System.Drawing.Color.White;
            this.btnGuardarBeb.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnGuardarBeb.IconColor = System.Drawing.Color.Black;
            this.btnGuardarBeb.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarBeb.IconSize = 25;
            this.btnGuardarBeb.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarBeb.Location = new System.Drawing.Point(24, 359);
            this.btnGuardarBeb.Name = "btnGuardarBeb";
            this.btnGuardarBeb.Size = new System.Drawing.Size(131, 23);
            this.btnGuardarBeb.TabIndex = 54;
            this.btnGuardarBeb.Text = "Guardar";
            this.btnGuardarBeb.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label6.Location = new System.Drawing.Point(17, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 53;
            this.label6.Text = "Estado:";
            // 
            // cboEstadoBeb
            // 
            this.cboEstadoBeb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstadoBeb.FormattingEnabled = true;
            this.cboEstadoBeb.Location = new System.Drawing.Point(12, 306);
            this.cboEstadoBeb.Name = "cboEstadoBeb";
            this.cboEstadoBeb.Size = new System.Drawing.Size(163, 21);
            this.cboEstadoBeb.TabIndex = 52;
            // 
            // txtNombreBebida
            // 
            this.txtNombreBebida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreBebida.Location = new System.Drawing.Point(11, 93);
            this.txtNombreBebida.Name = "txtNombreBebida";
            this.txtNombreBebida.Size = new System.Drawing.Size(163, 20);
            this.txtNombreBebida.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 450);
            this.label1.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(17, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Nombre Categoría:";
            // 
            // txtIndice
            // 
            this.txtIndice.Enabled = false;
            this.txtIndice.Location = new System.Drawing.Point(140, 65);
            this.txtIndice.Name = "txtIndice";
            this.txtIndice.Size = new System.Drawing.Size(35, 20);
            this.txtIndice.TabIndex = 65;
            this.txtIndice.Text = "-1";
            this.txtIndice.Visible = false;
            // 
            // btnLimpiarBuscadorBeb
            // 
            this.btnLimpiarBuscadorBeb.BackColor = System.Drawing.Color.LightGray;
            this.btnLimpiarBuscadorBeb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarBuscadorBeb.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLimpiarBuscadorBeb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarBuscadorBeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarBuscadorBeb.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarBuscadorBeb.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnLimpiarBuscadorBeb.IconColor = System.Drawing.Color.Black;
            this.btnLimpiarBuscadorBeb.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarBuscadorBeb.IconSize = 22;
            this.btnLimpiarBuscadorBeb.Location = new System.Drawing.Point(764, 13);
            this.btnLimpiarBuscadorBeb.Name = "btnLimpiarBuscadorBeb";
            this.btnLimpiarBuscadorBeb.Size = new System.Drawing.Size(23, 23);
            this.btnLimpiarBuscadorBeb.TabIndex = 64;
            this.btnLimpiarBuscadorBeb.UseVisualStyleBackColor = false;
            // 
            // btnLupaBeb
            // 
            this.btnLupaBeb.BackColor = System.Drawing.Color.LightGray;
            this.btnLupaBeb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLupaBeb.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLupaBeb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLupaBeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLupaBeb.ForeColor = System.Drawing.Color.White;
            this.btnLupaBeb.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnLupaBeb.IconColor = System.Drawing.Color.Black;
            this.btnLupaBeb.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLupaBeb.IconSize = 20;
            this.btnLupaBeb.Location = new System.Drawing.Point(735, 13);
            this.btnLupaBeb.Name = "btnLupaBeb";
            this.btnLupaBeb.Size = new System.Drawing.Size(23, 23);
            this.btnLupaBeb.TabIndex = 63;
            this.btnLupaBeb.UseVisualStyleBackColor = false;
            // 
            // txtBusquedaBeb
            // 
            this.txtBusquedaBeb.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBusquedaBeb.Location = new System.Drawing.Point(592, 15);
            this.txtBusquedaBeb.Name = "txtBusquedaBeb";
            this.txtBusquedaBeb.Size = new System.Drawing.Size(137, 20);
            this.txtBusquedaBeb.TabIndex = 62;
            // 
            // cboBusquedaBeb
            // 
            this.cboBusquedaBeb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBusquedaBeb.FormattingEnabled = true;
            this.cboBusquedaBeb.Location = new System.Drawing.Point(449, 14);
            this.cboBusquedaBeb.Name = "cboBusquedaBeb";
            this.cboBusquedaBeb.Size = new System.Drawing.Size(137, 21);
            this.cboBusquedaBeb.TabIndex = 61;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label9.Location = new System.Drawing.Point(390, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 60;
            this.label9.Text = "Filtrar por:";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(140, 43);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(35, 20);
            this.txtId.TabIndex = 59;
            this.txtId.Text = "0";
            this.txtId.Visible = false;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(183, 1);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.label8.Size = new System.Drawing.Size(617, 46);
            this.label8.TabIndex = 58;
            this.label8.Text = "Lista de Bebidas:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnEliminarCat
            // 
            this.btnEliminarCat.BackColor = System.Drawing.Color.Crimson;
            this.btnEliminarCat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarCat.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEliminarCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCat.ForeColor = System.Drawing.Color.White;
            this.btnEliminarCat.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnEliminarCat.IconColor = System.Drawing.Color.Black;
            this.btnEliminarCat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminarCat.IconSize = 25;
            this.btnEliminarCat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarCat.Location = new System.Drawing.Point(24, 243);
            this.btnEliminarCat.Name = "btnEliminarCat";
            this.btnEliminarCat.Size = new System.Drawing.Size(131, 23);
            this.btnEliminarCat.TabIndex = 56;
            this.btnEliminarCat.Text = "Eliminar";
            this.btnEliminarCat.UseVisualStyleBackColor = false;
            // 
            // btnLimpiarGrillaCat
            // 
            this.btnLimpiarGrillaCat.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLimpiarGrillaCat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarGrillaCat.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLimpiarGrillaCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarGrillaCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarGrillaCat.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarGrillaCat.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            this.btnLimpiarGrillaCat.IconColor = System.Drawing.Color.Black;
            this.btnLimpiarGrillaCat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarGrillaCat.IconSize = 25;
            this.btnLimpiarGrillaCat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarGrillaCat.Location = new System.Drawing.Point(24, 214);
            this.btnLimpiarGrillaCat.Name = "btnLimpiarGrillaCat";
            this.btnLimpiarGrillaCat.Size = new System.Drawing.Size(131, 23);
            this.btnLimpiarGrillaCat.TabIndex = 55;
            this.btnLimpiarGrillaCat.Text = "Limpiar";
            this.btnLimpiarGrillaCat.UseVisualStyleBackColor = false;
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AllowUserToResizeColumns = false;
            this.dgvData.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSeleccionar,
            this.Id,
            this.NombreBebida,
            this.PrecioBeb,
            this.NombreCategoria,
            this.Tamanio,
            this.Envase,
            this.Estado,
            this.EstadoValor});
            this.dgvData.Location = new System.Drawing.Point(192, 70);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Yellow;
            this.dgvData.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvData.RowTemplate.Height = 28;
            this.dgvData.Size = new System.Drawing.Size(601, 361);
            this.dgvData.TabIndex = 57;
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
            this.dgvData.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvData_CellPainting);
            // 
            // btnEliminarBeb
            // 
            this.btnEliminarBeb.BackColor = System.Drawing.Color.Crimson;
            this.btnEliminarBeb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarBeb.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEliminarBeb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarBeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarBeb.ForeColor = System.Drawing.Color.White;
            this.btnEliminarBeb.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnEliminarBeb.IconColor = System.Drawing.Color.Black;
            this.btnEliminarBeb.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminarBeb.IconSize = 25;
            this.btnEliminarBeb.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarBeb.Location = new System.Drawing.Point(24, 417);
            this.btnEliminarBeb.Name = "btnEliminarBeb";
            this.btnEliminarBeb.Size = new System.Drawing.Size(131, 23);
            this.btnEliminarBeb.TabIndex = 67;
            this.btnEliminarBeb.Text = "Eliminar";
            this.btnEliminarBeb.UseVisualStyleBackColor = false;
            // 
            // btnLimpiarBeb
            // 
            this.btnLimpiarBeb.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLimpiarBeb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarBeb.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLimpiarBeb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarBeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarBeb.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarBeb.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            this.btnLimpiarBeb.IconColor = System.Drawing.Color.Black;
            this.btnLimpiarBeb.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarBeb.IconSize = 25;
            this.btnLimpiarBeb.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarBeb.Location = new System.Drawing.Point(24, 388);
            this.btnLimpiarBeb.Name = "btnLimpiarBeb";
            this.btnLimpiarBeb.Size = new System.Drawing.Size(131, 23);
            this.btnLimpiarBeb.TabIndex = 66;
            this.btnLimpiarBeb.Text = "Limpiar";
            this.btnLimpiarBeb.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(17, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 69;
            this.label3.Text = "Tamaño:";
            // 
            // cboTamanioBeb
            // 
            this.cboTamanioBeb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTamanioBeb.FormattingEnabled = true;
            this.cboTamanioBeb.Location = new System.Drawing.Point(12, 225);
            this.cboTamanioBeb.Name = "cboTamanioBeb";
            this.cboTamanioBeb.Size = new System.Drawing.Size(163, 21);
            this.cboTamanioBeb.TabIndex = 68;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label4.Location = new System.Drawing.Point(17, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 71;
            this.label4.Text = "Categoría:";
            // 
            // cboCategoriaBeb
            // 
            this.cboCategoriaBeb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoriaBeb.FormattingEnabled = true;
            this.cboCategoriaBeb.Location = new System.Drawing.Point(12, 184);
            this.cboCategoriaBeb.Name = "cboCategoriaBeb";
            this.cboCategoriaBeb.Size = new System.Drawing.Size(163, 21);
            this.cboCategoriaBeb.TabIndex = 70;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label5.Location = new System.Drawing.Point(17, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 72;
            this.label5.Text = "Nombre Bebida:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label10.Location = new System.Drawing.Point(17, 126);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 74;
            this.label10.Text = "Precio:";
            // 
            // txtPrecioBeb
            // 
            this.txtPrecioBeb.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPrecioBeb.Location = new System.Drawing.Point(11, 144);
            this.txtPrecioBeb.Name = "txtPrecioBeb";
            this.txtPrecioBeb.Size = new System.Drawing.Size(163, 20);
            this.txtPrecioBeb.TabIndex = 73;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label11.Location = new System.Drawing.Point(17, 248);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 76;
            this.label11.Text = "Envase:";
            // 
            // cboEnvaseBeb
            // 
            this.cboEnvaseBeb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEnvaseBeb.FormattingEnabled = true;
            this.cboEnvaseBeb.Location = new System.Drawing.Point(12, 265);
            this.cboEnvaseBeb.Name = "cboEnvaseBeb";
            this.cboEnvaseBeb.Size = new System.Drawing.Size(163, 21);
            this.cboEnvaseBeb.TabIndex = 75;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.HeaderText = "";
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.ReadOnly = true;
            this.btnSeleccionar.Width = 28;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 80;
            // 
            // NombreBebida
            // 
            this.NombreBebida.HeaderText = "Nombre Bebida";
            this.NombreBebida.Name = "NombreBebida";
            this.NombreBebida.ReadOnly = true;
            this.NombreBebida.Width = 130;
            // 
            // PrecioBeb
            // 
            this.PrecioBeb.HeaderText = "Precio";
            this.PrecioBeb.Name = "PrecioBeb";
            this.PrecioBeb.ReadOnly = true;
            this.PrecioBeb.Width = 80;
            // 
            // NombreCategoria
            // 
            this.NombreCategoria.HeaderText = "Categoria";
            this.NombreCategoria.Name = "NombreCategoria";
            this.NombreCategoria.ReadOnly = true;
            this.NombreCategoria.Width = 80;
            // 
            // Tamanio
            // 
            this.Tamanio.HeaderText = "Tamaño";
            this.Tamanio.Name = "Tamanio";
            this.Tamanio.ReadOnly = true;
            this.Tamanio.Width = 80;
            // 
            // Envase
            // 
            this.Envase.HeaderText = "Envase";
            this.Envase.Name = "Envase";
            this.Envase.ReadOnly = true;
            this.Envase.Width = 70;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 80;
            // 
            // EstadoValor
            // 
            this.EstadoValor.HeaderText = "EstadoValor";
            this.EstadoValor.Name = "EstadoValor";
            this.EstadoValor.ReadOnly = true;
            this.EstadoValor.Visible = false;
            // 
            // frmBebidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 450);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cboEnvaseBeb);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPrecioBeb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboCategoriaBeb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboTamanioBeb);
            this.Controls.Add(this.btnEliminarBeb);
            this.Controls.Add(this.btnLimpiarBeb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnGuardarBeb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboEstadoBeb);
            this.Controls.Add(this.txtNombreBebida);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIndice);
            this.Controls.Add(this.btnLimpiarBuscadorBeb);
            this.Controls.Add(this.btnLupaBeb);
            this.Controls.Add(this.txtBusquedaBeb);
            this.Controls.Add(this.cboBusquedaBeb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnEliminarCat);
            this.Controls.Add(this.btnLimpiarGrillaCat);
            this.Controls.Add(this.dgvData);
            this.Name = "frmBebidas";
            this.Text = "frmBebidas";
            this.Load += new System.EventHandler(this.frmBebidas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private FontAwesome.Sharp.IconButton btnGuardarBeb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboEstadoBeb;
        private System.Windows.Forms.TextBox txtNombreBebida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIndice;
        private FontAwesome.Sharp.IconButton btnLimpiarBuscadorBeb;
        private FontAwesome.Sharp.IconButton btnLupaBeb;
        private System.Windows.Forms.TextBox txtBusquedaBeb;
        private System.Windows.Forms.ComboBox cboBusquedaBeb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconButton btnEliminarCat;
        private FontAwesome.Sharp.IconButton btnLimpiarGrillaCat;
        private System.Windows.Forms.DataGridView dgvData;
        private FontAwesome.Sharp.IconButton btnEliminarBeb;
        private FontAwesome.Sharp.IconButton btnLimpiarBeb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboTamanioBeb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboCategoriaBeb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPrecioBeb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboEnvaseBeb;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreBebida;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioBeb;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tamanio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Envase;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoValor;
    }
}