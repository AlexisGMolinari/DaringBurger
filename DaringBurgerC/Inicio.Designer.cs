﻿
namespace DaringBurgerC
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.MenuTitulo = new System.Windows.Forms.ToolStrip();
            this.LogoDB = new System.Windows.Forms.PictureBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Menu = new System.Windows.Forms.ToolStrip();
            this.Usuarios = new FontAwesome.Sharp.IconDropDownButton();
            this.Inventario = new FontAwesome.Sharp.IconDropDownButton();
            this.categoríasBebidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BebidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CargarHamburguesasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CargarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Informes = new FontAwesome.Sharp.IconDropDownButton();
            this.InformeCaja = new FontAwesome.Sharp.IconDropDownButton();
            this.Pedidos = new FontAwesome.Sharp.IconDropDownButton();
            this.TotalCaja = new FontAwesome.Sharp.IconDropDownButton();
            this.Contenedor = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblusuario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LogoDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuTitulo
            // 
            this.MenuTitulo.AutoSize = false;
            this.MenuTitulo.BackColor = System.Drawing.Color.Black;
            this.MenuTitulo.Location = new System.Drawing.Point(0, 0);
            this.MenuTitulo.Name = "MenuTitulo";
            this.MenuTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MenuTitulo.Size = new System.Drawing.Size(800, 106);
            this.MenuTitulo.TabIndex = 1;
            this.MenuTitulo.Text = "ToolStrip1";
            // 
            // LogoDB
            // 
            this.LogoDB.Cursor = System.Windows.Forms.Cursors.Default;
            this.LogoDB.Image = ((System.Drawing.Image)(resources.GetObject("LogoDB.Image")));
            this.LogoDB.Location = new System.Drawing.Point(9, 9);
            this.LogoDB.Margin = new System.Windows.Forms.Padding(0);
            this.LogoDB.Name = "LogoDB";
            this.LogoDB.Size = new System.Drawing.Size(86, 84);
            this.LogoDB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoDB.TabIndex = 3;
            this.LogoDB.TabStop = false;
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.Color.Black;
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(299, 33);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(195, 39);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 4;
            this.PictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Usuarios,
            this.Inventario,
            this.Informes,
            this.InformeCaja,
            this.Pedidos,
            this.TotalCaja});
            this.Menu.Location = new System.Drawing.Point(0, 106);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(800, 70);
            this.Menu.TabIndex = 5;
            this.Menu.Text = "ToolStrip2";
            // 
            // Usuarios
            // 
            this.Usuarios.AutoSize = false;
            this.Usuarios.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            this.Usuarios.IconColor = System.Drawing.Color.Black;
            this.Usuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Usuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Usuarios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Usuarios.Name = "Usuarios";
            this.Usuarios.Size = new System.Drawing.Size(80, 67);
            this.Usuarios.Text = "Usuarios";
            this.Usuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Usuarios.ToolTipText = "Usuarios";
            this.Usuarios.Click += new System.EventHandler(this.Usuarios_Click);
            // 
            // Inventario
            // 
            this.Inventario.AutoSize = false;
            this.Inventario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoríasBebidasToolStripMenuItem,
            this.BebidasToolStripMenuItem,
            this.CargarHamburguesasToolStripMenuItem,
            this.CargarProductoToolStripMenuItem});
            this.Inventario.IconChar = FontAwesome.Sharp.IconChar.DollyFlatbed;
            this.Inventario.IconColor = System.Drawing.Color.Black;
            this.Inventario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Inventario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Inventario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Inventario.Name = "Inventario";
            this.Inventario.Size = new System.Drawing.Size(80, 67);
            this.Inventario.Text = "Inventario";
            this.Inventario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Inventario.ToolTipText = "Inventario";
            // 
            // categoríasBebidasToolStripMenuItem
            // 
            this.categoríasBebidasToolStripMenuItem.Name = "categoríasBebidasToolStripMenuItem";
            this.categoríasBebidasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.categoríasBebidasToolStripMenuItem.Text = "Categorías Bebidas";
            this.categoríasBebidasToolStripMenuItem.Click += new System.EventHandler(this.categoríasBebidasToolStripMenuItem_Click);
            // 
            // BebidasToolStripMenuItem
            // 
            this.BebidasToolStripMenuItem.Name = "BebidasToolStripMenuItem";
            this.BebidasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.BebidasToolStripMenuItem.Text = "Bebidas";
            this.BebidasToolStripMenuItem.Click += new System.EventHandler(this.categoríasToolStripMenuItem_Click);
            // 
            // CargarHamburguesasToolStripMenuItem
            // 
            this.CargarHamburguesasToolStripMenuItem.Name = "CargarHamburguesasToolStripMenuItem";
            this.CargarHamburguesasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.CargarHamburguesasToolStripMenuItem.Text = "Hamburguesas";
            this.CargarHamburguesasToolStripMenuItem.Click += new System.EventHandler(this.CargarProductoToolStripMenuItem_Click);
            // 
            // CargarProductoToolStripMenuItem
            // 
            this.CargarProductoToolStripMenuItem.Name = "CargarProductoToolStripMenuItem";
            this.CargarProductoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.CargarProductoToolStripMenuItem.Text = "Cargar Producto";
            this.CargarProductoToolStripMenuItem.Click += new System.EventHandler(this.EstablecerPreciosToolStripMenuItem_Click);
            // 
            // Informes
            // 
            this.Informes.AutoSize = false;
            this.Informes.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            this.Informes.IconColor = System.Drawing.Color.Black;
            this.Informes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Informes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Informes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Informes.Name = "Informes";
            this.Informes.Size = new System.Drawing.Size(80, 67);
            this.Informes.Text = "Informes";
            this.Informes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Informes.ToolTipText = "Informes";
            this.Informes.Click += new System.EventHandler(this.Informes_Click);
            // 
            // InformeCaja
            // 
            this.InformeCaja.AutoSize = false;
            this.InformeCaja.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.InformeCaja.IconColor = System.Drawing.Color.Black;
            this.InformeCaja.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.InformeCaja.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.InformeCaja.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.InformeCaja.Name = "InformeCaja";
            this.InformeCaja.Size = new System.Drawing.Size(80, 67);
            this.InformeCaja.Text = "Caja Inicio";
            this.InformeCaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.InformeCaja.ToolTipText = "InformeCaja";
            this.InformeCaja.Click += new System.EventHandler(this.InformeCaja_Click);
            // 
            // Pedidos
            // 
            this.Pedidos.AutoSize = false;
            this.Pedidos.IconChar = FontAwesome.Sharp.IconChar.Hamburger;
            this.Pedidos.IconColor = System.Drawing.Color.Black;
            this.Pedidos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Pedidos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Pedidos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Pedidos.Name = "Pedidos";
            this.Pedidos.Size = new System.Drawing.Size(80, 67);
            this.Pedidos.Text = "Pedidos";
            this.Pedidos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Pedidos.ToolTipText = "Pedidos";
            this.Pedidos.Click += new System.EventHandler(this.Pedidos_Click);
            // 
            // TotalCaja
            // 
            this.TotalCaja.AutoSize = false;
            this.TotalCaja.IconChar = FontAwesome.Sharp.IconChar.Calculator;
            this.TotalCaja.IconColor = System.Drawing.Color.Black;
            this.TotalCaja.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.TotalCaja.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TotalCaja.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TotalCaja.Name = "TotalCaja";
            this.TotalCaja.Size = new System.Drawing.Size(80, 67);
            this.TotalCaja.Text = "Total Caja";
            this.TotalCaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TotalCaja.ToolTipText = "TotalCaja";
            this.TotalCaja.Click += new System.EventHandler(this.TotalCaja_Click);
            // 
            // Contenedor
            // 
            this.Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Contenedor.Location = new System.Drawing.Point(0, 176);
            this.Contenedor.Name = "Contenedor";
            this.Contenedor.Size = new System.Drawing.Size(800, 455);
            this.Contenedor.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(646, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "¡Hola!";
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.BackColor = System.Drawing.Color.Black;
            this.lblusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.ForeColor = System.Drawing.Color.Gold;
            this.lblusuario.Location = new System.Drawing.Point(690, 43);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(76, 16);
            this.lblusuario.TabIndex = 8;
            this.lblusuario.Text = "lblusuario";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 631);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.Contenedor);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.LogoDB);
            this.Controls.Add(this.MenuTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogoDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStrip MenuTitulo;
        internal System.Windows.Forms.PictureBox LogoDB;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal new System.Windows.Forms.ToolStrip Menu;
        internal FontAwesome.Sharp.IconDropDownButton Usuarios;
        internal FontAwesome.Sharp.IconDropDownButton Inventario;
        internal System.Windows.Forms.ToolStripMenuItem CargarProductoToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem CargarHamburguesasToolStripMenuItem;
        internal FontAwesome.Sharp.IconDropDownButton TotalCaja;
        internal System.Windows.Forms.Panel Contenedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.ToolStripMenuItem BebidasToolStripMenuItem;
        internal FontAwesome.Sharp.IconDropDownButton Informes;
        internal FontAwesome.Sharp.IconDropDownButton InformeCaja;
        internal FontAwesome.Sharp.IconDropDownButton Pedidos;
        private System.Windows.Forms.ToolStripMenuItem categoríasBebidasToolStripMenuItem;
    }
}

