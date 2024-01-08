
namespace DaringBurgerC
{
    partial class frmCategoria
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
            this.txtIndice = new System.Windows.Forms.TextBox();
            this.btnLimpiarBuscadorCat = new FontAwesome.Sharp.IconButton();
            this.btnLupaCat = new FontAwesome.Sharp.IconButton();
            this.txtBusquedaCat = new System.Windows.Forms.TextBox();
            this.cboBusquedaCat = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnEliminarCat = new FontAwesome.Sharp.IconButton();
            this.btnLimpiarGrillaCat = new FontAwesome.Sharp.IconButton();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGuardarCat = new FontAwesome.Sharp.IconButton();
            this.label6 = new System.Windows.Forms.Label();
            this.cboEstadoCat = new System.Windows.Forms.ComboBox();
            this.txtNombreCategoria = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIndice
            // 
            this.txtIndice.Enabled = false;
            this.txtIndice.Location = new System.Drawing.Point(139, 65);
            this.txtIndice.Name = "txtIndice";
            this.txtIndice.Size = new System.Drawing.Size(35, 20);
            this.txtIndice.TabIndex = 47;
            this.txtIndice.Text = "-1";
            this.txtIndice.Visible = false;
            // 
            // btnLimpiarBuscadorCat
            // 
            this.btnLimpiarBuscadorCat.BackColor = System.Drawing.Color.LightGray;
            this.btnLimpiarBuscadorCat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarBuscadorCat.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLimpiarBuscadorCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarBuscadorCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarBuscadorCat.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarBuscadorCat.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnLimpiarBuscadorCat.IconColor = System.Drawing.Color.Black;
            this.btnLimpiarBuscadorCat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarBuscadorCat.IconSize = 22;
            this.btnLimpiarBuscadorCat.Location = new System.Drawing.Point(763, 13);
            this.btnLimpiarBuscadorCat.Name = "btnLimpiarBuscadorCat";
            this.btnLimpiarBuscadorCat.Size = new System.Drawing.Size(23, 23);
            this.btnLimpiarBuscadorCat.TabIndex = 46;
            this.btnLimpiarBuscadorCat.UseVisualStyleBackColor = false;
            this.btnLimpiarBuscadorCat.Click += new System.EventHandler(this.btnLimpiarBuscadorCat_Click);
            // 
            // btnLupaCat
            // 
            this.btnLupaCat.BackColor = System.Drawing.Color.LightGray;
            this.btnLupaCat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLupaCat.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLupaCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLupaCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLupaCat.ForeColor = System.Drawing.Color.White;
            this.btnLupaCat.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnLupaCat.IconColor = System.Drawing.Color.Black;
            this.btnLupaCat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLupaCat.IconSize = 20;
            this.btnLupaCat.Location = new System.Drawing.Point(734, 13);
            this.btnLupaCat.Name = "btnLupaCat";
            this.btnLupaCat.Size = new System.Drawing.Size(23, 23);
            this.btnLupaCat.TabIndex = 45;
            this.btnLupaCat.UseVisualStyleBackColor = false;
            this.btnLupaCat.Click += new System.EventHandler(this.btnLupaCat_Click);
            // 
            // txtBusquedaCat
            // 
            this.txtBusquedaCat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBusquedaCat.Location = new System.Drawing.Point(591, 15);
            this.txtBusquedaCat.Name = "txtBusquedaCat";
            this.txtBusquedaCat.Size = new System.Drawing.Size(137, 20);
            this.txtBusquedaCat.TabIndex = 44;
            // 
            // cboBusquedaCat
            // 
            this.cboBusquedaCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBusquedaCat.FormattingEnabled = true;
            this.cboBusquedaCat.Location = new System.Drawing.Point(448, 14);
            this.cboBusquedaCat.Name = "cboBusquedaCat";
            this.cboBusquedaCat.Size = new System.Drawing.Size(137, 21);
            this.cboBusquedaCat.TabIndex = 43;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label9.Location = new System.Drawing.Point(389, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 42;
            this.label9.Text = "Filtrar por:";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(139, 43);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(35, 20);
            this.txtId.TabIndex = 41;
            this.txtId.Text = "0";
            this.txtId.Visible = false;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(182, 1);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.label8.Size = new System.Drawing.Size(617, 46);
            this.label8.TabIndex = 40;
            this.label8.Text = "Lista de Categoría:";
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
            this.btnEliminarCat.Location = new System.Drawing.Point(23, 243);
            this.btnEliminarCat.Name = "btnEliminarCat";
            this.btnEliminarCat.Size = new System.Drawing.Size(131, 23);
            this.btnEliminarCat.TabIndex = 37;
            this.btnEliminarCat.Text = "Eliminar";
            this.btnEliminarCat.UseVisualStyleBackColor = false;
            this.btnEliminarCat.Click += new System.EventHandler(this.btnEliminarCat_Click);
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
            this.btnLimpiarGrillaCat.Location = new System.Drawing.Point(23, 214);
            this.btnLimpiarGrillaCat.Name = "btnLimpiarGrillaCat";
            this.btnLimpiarGrillaCat.Size = new System.Drawing.Size(131, 23);
            this.btnLimpiarGrillaCat.TabIndex = 36;
            this.btnLimpiarGrillaCat.Text = "Limpiar";
            this.btnLimpiarGrillaCat.UseVisualStyleBackColor = false;
            this.btnLimpiarGrillaCat.Click += new System.EventHandler(this.btnLimpiarGrillaCat_Click);
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
            this.NombreCategoria,
            this.Estado,
            this.EstadoValor});
            this.dgvData.Location = new System.Drawing.Point(330, 53);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Yellow;
            this.dgvData.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvData.RowTemplate.Height = 28;
            this.dgvData.Size = new System.Drawing.Size(325, 385);
            this.dgvData.TabIndex = 39;
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDataCat_CellContentClick);
            this.dgvData.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvDataCat_CellPainting);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label7.Font = new System.Drawing.Font("Arial Black", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "Detalle de Categoría:";
            // 
            // btnGuardarCat
            // 
            this.btnGuardarCat.BackColor = System.Drawing.Color.LimeGreen;
            this.btnGuardarCat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarCat.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGuardarCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCat.ForeColor = System.Drawing.Color.White;
            this.btnGuardarCat.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnGuardarCat.IconColor = System.Drawing.Color.Black;
            this.btnGuardarCat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarCat.IconSize = 25;
            this.btnGuardarCat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarCat.Location = new System.Drawing.Point(23, 185);
            this.btnGuardarCat.Name = "btnGuardarCat";
            this.btnGuardarCat.Size = new System.Drawing.Size(131, 23);
            this.btnGuardarCat.TabIndex = 35;
            this.btnGuardarCat.Text = "Guardar";
            this.btnGuardarCat.UseVisualStyleBackColor = false;
            this.btnGuardarCat.Click += new System.EventHandler(this.btnGuardarCat_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label6.Location = new System.Drawing.Point(16, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Estado:";
            // 
            // cboEstadoCat
            // 
            this.cboEstadoCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstadoCat.FormattingEnabled = true;
            this.cboEstadoCat.Location = new System.Drawing.Point(11, 139);
            this.cboEstadoCat.Name = "cboEstadoCat";
            this.cboEstadoCat.Size = new System.Drawing.Size(163, 21);
            this.cboEstadoCat.TabIndex = 33;
            // 
            // txtNombreCategoria
            // 
            this.txtNombreCategoria.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreCategoria.Location = new System.Drawing.Point(10, 93);
            this.txtNombreCategoria.Name = "txtNombreCategoria";
            this.txtNombreCategoria.Size = new System.Drawing.Size(163, 20);
            this.txtNombreCategoria.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(16, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Nombre Categoría:";
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
            this.label1.TabIndex = 24;
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
            // 
            // NombreCategoria
            // 
            this.NombreCategoria.HeaderText = "NombreCategoria";
            this.NombreCategoria.Name = "NombreCategoria";
            this.NombreCategoria.ReadOnly = true;
            this.NombreCategoria.Width = 150;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // EstadoValor
            // 
            this.EstadoValor.HeaderText = "EstadoValor";
            this.EstadoValor.Name = "EstadoValor";
            this.EstadoValor.ReadOnly = true;
            this.EstadoValor.Visible = false;
            // 
            // frmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtIndice);
            this.Controls.Add(this.btnLimpiarBuscadorCat);
            this.Controls.Add(this.btnLupaCat);
            this.Controls.Add(this.txtBusquedaCat);
            this.Controls.Add(this.cboBusquedaCat);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnEliminarCat);
            this.Controls.Add(this.btnLimpiarGrillaCat);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnGuardarCat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboEstadoCat);
            this.Controls.Add(this.txtNombreCategoria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCategoria";
            this.Text = "frmCategoria";
            this.Load += new System.EventHandler(this.frmCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIndice;
        private FontAwesome.Sharp.IconButton btnLimpiarBuscadorCat;
        private FontAwesome.Sharp.IconButton btnLupaCat;
        private System.Windows.Forms.TextBox txtBusquedaCat;
        private System.Windows.Forms.ComboBox cboBusquedaCat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconButton btnEliminarCat;
        private FontAwesome.Sharp.IconButton btnLimpiarGrillaCat;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Label label7;
        private FontAwesome.Sharp.IconButton btnGuardarCat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboEstadoCat;
        private System.Windows.Forms.TextBox txtNombreCategoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoValor;
    }
}