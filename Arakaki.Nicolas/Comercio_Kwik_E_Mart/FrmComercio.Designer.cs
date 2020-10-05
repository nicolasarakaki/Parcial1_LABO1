namespace Comercio_Kwik_E_Mart
{
    partial class FrmComercio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmComercio));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarHardcodeoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarListaDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarTodosLosProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasGeneradasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.inventarioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(942, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(63, 21);
            this.archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compraToolStripMenuItem,
            this.generarHardcodeoToolStripMenuItem});
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevoToolStripMenuItem.Text = "&Nuevo";
            // 
            // compraToolStripMenuItem
            // 
            this.compraToolStripMenuItem.Name = "compraToolStripMenuItem";
            this.compraToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.compraToolStripMenuItem.Text = "&Compra...";
            this.compraToolStripMenuItem.Click += new System.EventHandler(this.compraToolStripMenuItem_Click);
            // 
            // generarHardcodeoToolStripMenuItem
            // 
            this.generarHardcodeoToolStripMenuItem.Name = "generarHardcodeoToolStripMenuItem";
            this.generarHardcodeoToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.generarHardcodeoToolStripMenuItem.Text = "Generar Hardcodeo...";
            this.generarHardcodeoToolStripMenuItem.Click += new System.EventHandler(this.generarHardcodeoToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Cerrar Sesión...";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaDeProductosToolStripMenuItem});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(54, 21);
            this.editarToolStripMenuItem.Text = "&Editar";
            // 
            // listaDeProductosToolStripMenuItem
            // 
            this.listaDeProductosToolStripMenuItem.Name = "listaDeProductosToolStripMenuItem";
            this.listaDeProductosToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.listaDeProductosToolStripMenuItem.Text = "Lista de Productos...";
            this.listaDeProductosToolStripMenuItem.Click += new System.EventHandler(this.listaDeProductosToolStripMenuItem_Click);
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarProductosToolStripMenuItem,
            this.comprasGeneradasToolStripMenuItem,
            this.listaDeClientesToolStripMenuItem,
            this.listaDeEmpleadosToolStripMenuItem});
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(40, 21);
            this.inventarioToolStripMenuItem.Text = "&Ver";
            // 
            // mostrarProductosToolStripMenuItem
            // 
            this.mostrarProductosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarListaDeProductosToolStripMenuItem,
            this.mostrarTodosLosProductosToolStripMenuItem});
            this.mostrarProductosToolStripMenuItem.Name = "mostrarProductosToolStripMenuItem";
            this.mostrarProductosToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.mostrarProductosToolStripMenuItem.Text = "Productos...";
            // 
            // editarListaDeProductosToolStripMenuItem
            // 
            this.editarListaDeProductosToolStripMenuItem.Name = "editarListaDeProductosToolStripMenuItem";
            this.editarListaDeProductosToolStripMenuItem.Size = new System.Drawing.Size(358, 22);
            this.editarListaDeProductosToolStripMenuItem.Text = "Mostrar productos con menos de 10 unidades...";
            this.editarListaDeProductosToolStripMenuItem.Click += new System.EventHandler(this.verProdMenos10ToolStripMenuItem_Click);
            // 
            // mostrarTodosLosProductosToolStripMenuItem
            // 
            this.mostrarTodosLosProductosToolStripMenuItem.Name = "mostrarTodosLosProductosToolStripMenuItem";
            this.mostrarTodosLosProductosToolStripMenuItem.Size = new System.Drawing.Size(358, 22);
            this.mostrarTodosLosProductosToolStripMenuItem.Text = "Mostrar todos los productos...";
            this.mostrarTodosLosProductosToolStripMenuItem.Click += new System.EventHandler(this.mostrarTodosLosProductosToolStripMenuItem_Click);
            // 
            // comprasGeneradasToolStripMenuItem
            // 
            this.comprasGeneradasToolStripMenuItem.Name = "comprasGeneradasToolStripMenuItem";
            this.comprasGeneradasToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.comprasGeneradasToolStripMenuItem.Text = "Compras generadas...";
            this.comprasGeneradasToolStripMenuItem.Click += new System.EventHandler(this.comprasGeneradasToolStripMenuItem_Click);
            // 
            // listaDeClientesToolStripMenuItem
            // 
            this.listaDeClientesToolStripMenuItem.Name = "listaDeClientesToolStripMenuItem";
            this.listaDeClientesToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.listaDeClientesToolStripMenuItem.Text = "Lista de Clientes...";
            this.listaDeClientesToolStripMenuItem.Click += new System.EventHandler(this.listaDeClientesToolStripMenuItem_Click);
            // 
            // listaDeEmpleadosToolStripMenuItem
            // 
            this.listaDeEmpleadosToolStripMenuItem.Name = "listaDeEmpleadosToolStripMenuItem";
            this.listaDeEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.listaDeEmpleadosToolStripMenuItem.Text = "Lista de Empleados...";
            this.listaDeEmpleadosToolStripMenuItem.Click += new System.EventHandler(this.listaDeEmpleadosToolStripMenuItem_Click);
            // 
            // FrmComercio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(942, 601);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FrmComercio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kwik E Mart System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmComercio_FormClosing);
            this.Load += new System.EventHandler(this.FrmComercio_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarHardcodeoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasGeneradasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarListaDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarTodosLosProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeEmpleadosToolStripMenuItem;
    }
}

