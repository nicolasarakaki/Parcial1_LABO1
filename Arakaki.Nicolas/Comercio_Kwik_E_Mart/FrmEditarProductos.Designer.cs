namespace Comercio_Kwik_E_Mart
{
    partial class FrmEditarProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditarProductos));
            this.lstvProductos = new System.Windows.Forms.ListView();
            this.colCodigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDescripcion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrecioUni = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCantidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCategoria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbxCodigo = new System.Windows.Forms.TextBox();
            this.tbxDescripcion = new System.Windows.Forms.TextBox();
            this.tbxPrecioUni = new System.Windows.Forms.TextBox();
            this.tbxCantidad = new System.Windows.Forms.TextBox();
            this.rbtnComida = new System.Windows.Forms.RadioButton();
            this.groupBoxCategoria = new System.Windows.Forms.GroupBox();
            this.rbtnKiosko = new System.Windows.Forms.RadioButton();
            this.rbtnBebida = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tbxCodProdSelect = new System.Windows.Forms.TextBox();
            this.tbxDescProdSelec = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBoxCategoria.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstvProductos
            // 
            this.lstvProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lstvProductos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colCodigo,
            this.colDescripcion,
            this.colPrecioUni,
            this.colCantidad,
            this.colCategoria});
            this.lstvProductos.Font = new System.Drawing.Font("Monospac821 BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstvProductos.HideSelection = false;
            this.lstvProductos.Location = new System.Drawing.Point(12, 123);
            this.lstvProductos.MultiSelect = false;
            this.lstvProductos.Name = "lstvProductos";
            this.lstvProductos.Size = new System.Drawing.Size(621, 225);
            this.lstvProductos.TabIndex = 0;
            this.lstvProductos.UseCompatibleStateImageBehavior = false;
            this.lstvProductos.View = System.Windows.Forms.View.Details;
            this.lstvProductos.SelectedIndexChanged += new System.EventHandler(this.lstvProductos_SelectedIndexChanged);
            // 
            // colCodigo
            // 
            this.colCodigo.Text = "Código";
            this.colCodigo.Width = 72;
            // 
            // colDescripcion
            // 
            this.colDescripcion.Text = "Descripción";
            this.colDescripcion.Width = 140;
            // 
            // colPrecioUni
            // 
            this.colPrecioUni.Text = "Precio Unitario";
            this.colPrecioUni.Width = 150;
            // 
            // colCantidad
            // 
            this.colCantidad.Text = "Cantidad";
            this.colCantidad.Width = 116;
            // 
            // colCategoria
            // 
            this.colCategoria.Text = "Categoría";
            this.colCategoria.Width = 100;
            // 
            // tbxCodigo
            // 
            this.tbxCodigo.BackColor = System.Drawing.Color.Silver;
            this.tbxCodigo.Enabled = false;
            this.tbxCodigo.ForeColor = System.Drawing.Color.Black;
            this.tbxCodigo.Location = new System.Drawing.Point(119, 22);
            this.tbxCodigo.Name = "tbxCodigo";
            this.tbxCodigo.ReadOnly = true;
            this.tbxCodigo.Size = new System.Drawing.Size(115, 20);
            this.tbxCodigo.TabIndex = 1;
            // 
            // tbxDescripcion
            // 
            this.tbxDescripcion.Location = new System.Drawing.Point(119, 51);
            this.tbxDescripcion.Name = "tbxDescripcion";
            this.tbxDescripcion.Size = new System.Drawing.Size(115, 20);
            this.tbxDescripcion.TabIndex = 2;
            this.tbxDescripcion.TextChanged += new System.EventHandler(this.tbxDescripcion_TextChanged);
            // 
            // tbxPrecioUni
            // 
            this.tbxPrecioUni.Location = new System.Drawing.Point(351, 22);
            this.tbxPrecioUni.Name = "tbxPrecioUni";
            this.tbxPrecioUni.Size = new System.Drawing.Size(76, 20);
            this.tbxPrecioUni.TabIndex = 3;
            // 
            // tbxCantidad
            // 
            this.tbxCantidad.Location = new System.Drawing.Point(351, 54);
            this.tbxCantidad.Name = "tbxCantidad";
            this.tbxCantidad.Size = new System.Drawing.Size(76, 20);
            this.tbxCantidad.TabIndex = 4;
            // 
            // rbtnComida
            // 
            this.rbtnComida.AutoSize = true;
            this.rbtnComida.Checked = true;
            this.rbtnComida.Location = new System.Drawing.Point(23, 22);
            this.rbtnComida.Name = "rbtnComida";
            this.rbtnComida.Size = new System.Drawing.Size(74, 20);
            this.rbtnComida.TabIndex = 5;
            this.rbtnComida.TabStop = true;
            this.rbtnComida.Text = "COMIDA";
            this.rbtnComida.UseVisualStyleBackColor = true;
            // 
            // groupBoxCategoria
            // 
            this.groupBoxCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBoxCategoria.Controls.Add(this.rbtnKiosko);
            this.groupBoxCategoria.Controls.Add(this.rbtnBebida);
            this.groupBoxCategoria.Controls.Add(this.rbtnComida);
            this.groupBoxCategoria.Font = new System.Drawing.Font("Monospac821 BT", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCategoria.Location = new System.Drawing.Point(450, 12);
            this.groupBoxCategoria.Name = "groupBoxCategoria";
            this.groupBoxCategoria.Size = new System.Drawing.Size(141, 100);
            this.groupBoxCategoria.TabIndex = 6;
            this.groupBoxCategoria.TabStop = false;
            this.groupBoxCategoria.Text = "CATEGORIA";
            // 
            // rbtnKiosko
            // 
            this.rbtnKiosko.AutoSize = true;
            this.rbtnKiosko.Location = new System.Drawing.Point(23, 68);
            this.rbtnKiosko.Name = "rbtnKiosko";
            this.rbtnKiosko.Size = new System.Drawing.Size(114, 20);
            this.rbtnKiosko.TabIndex = 7;
            this.rbtnKiosko.TabStop = true;
            this.rbtnKiosko.Text = "ART. KIOSKO";
            this.rbtnKiosko.UseVisualStyleBackColor = true;
            // 
            // rbtnBebida
            // 
            this.rbtnBebida.AutoSize = true;
            this.rbtnBebida.Location = new System.Drawing.Point(23, 45);
            this.rbtnBebida.Name = "rbtnBebida";
            this.rbtnBebida.Size = new System.Drawing.Size(74, 20);
            this.rbtnBebida.TabIndex = 6;
            this.rbtnBebida.TabStop = true;
            this.rbtnBebida.Text = "BEBIDA";
            this.rbtnBebida.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monospac821 BT", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "CODIGO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monospac821 BT", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "DESCRIPCION";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monospac821 BT", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(289, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "PRECIO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monospac821 BT", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(273, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "CANTIDAD";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Enabled = false;
            this.btnAgregar.Location = new System.Drawing.Point(307, 82);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(120, 30);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "(+) Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(264, 408);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(120, 30);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "(-) Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(264, 367);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(120, 30);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Editar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(450, 382);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(173, 43);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // tbxCodProdSelect
            // 
            this.tbxCodProdSelect.Enabled = false;
            this.tbxCodProdSelect.Font = new System.Drawing.Font("Monospac821 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCodProdSelect.Location = new System.Drawing.Point(12, 392);
            this.tbxCodProdSelect.Name = "tbxCodProdSelect";
            this.tbxCodProdSelect.ReadOnly = true;
            this.tbxCodProdSelect.Size = new System.Drawing.Size(120, 23);
            this.tbxCodProdSelect.TabIndex = 15;
            // 
            // tbxDescProdSelec
            // 
            this.tbxDescProdSelec.Enabled = false;
            this.tbxDescProdSelec.Font = new System.Drawing.Font("Monospac821 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDescProdSelec.Location = new System.Drawing.Point(138, 392);
            this.tbxDescProdSelec.Name = "tbxDescProdSelec";
            this.tbxDescProdSelec.ReadOnly = true;
            this.tbxDescProdSelec.Size = new System.Drawing.Size(120, 23);
            this.tbxDescProdSelec.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monospac821 BT", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 374);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "CODIGO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Monospac821 BT", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(138, 374);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "DESCRIPCION";
            // 
            // FrmEditarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(645, 457);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxDescProdSelec);
            this.Controls.Add(this.tbxCodProdSelect);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxCategoria);
            this.Controls.Add(this.tbxCantidad);
            this.Controls.Add(this.tbxPrecioUni);
            this.Controls.Add(this.tbxDescripcion);
            this.Controls.Add(this.tbxCodigo);
            this.Controls.Add(this.lstvProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEditarProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Productos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmEditarProductos_FormClosing);
            this.Load += new System.EventHandler(this.FrmEditarProductos_Load);
            this.groupBoxCategoria.ResumeLayout(false);
            this.groupBoxCategoria.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstvProductos;
        private System.Windows.Forms.TextBox tbxCodigo;
        private System.Windows.Forms.TextBox tbxDescripcion;
        private System.Windows.Forms.TextBox tbxPrecioUni;
        private System.Windows.Forms.TextBox tbxCantidad;
        private System.Windows.Forms.RadioButton rbtnComida;
        private System.Windows.Forms.GroupBox groupBoxCategoria;
        private System.Windows.Forms.RadioButton rbtnKiosko;
        private System.Windows.Forms.RadioButton rbtnBebida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ColumnHeader colCodigo;
        private System.Windows.Forms.ColumnHeader colDescripcion;
        private System.Windows.Forms.ColumnHeader colPrecioUni;
        private System.Windows.Forms.ColumnHeader colCantidad;
        private System.Windows.Forms.ColumnHeader colCategoria;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox tbxCodProdSelect;
        private System.Windows.Forms.TextBox tbxDescProdSelec;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}