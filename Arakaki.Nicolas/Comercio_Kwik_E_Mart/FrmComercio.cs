using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Comercio_Kwik_E_Mart
{
    public partial class FrmComercio : Form
    {
        #region Atributos

        private FrmCompra frmCompra;
        private FrmVer frmVer;
        private FrmEditarProductos frmEditarProductos;
        private static string usuario;

        #endregion


        #region Propiedades

        public static string Usuario
        {
            get
            {
                return usuario;
            }
            set
            {
                usuario = value;
            }
        }

        #endregion


        #region Constructores

        public FrmComercio()
        {
            InitializeComponent();
        }

        #endregion


        #region Evento Load Y FromClosing

        private void FrmComercio_Load(object sender, EventArgs e)
        {
            this.Text = Comercio.NombreComercio;
            if (usuario != "Apu Nahasapeemapetilon")
            {
                editarToolStripMenuItem.Enabled = false;
            }
        }

        private void FrmComercio_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Seguro que desea cerrar sesión?", "Cerrando Sesión",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        #endregion


        #region Eventos de click de ToolStripMenu

        private void compraToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (frmCompra == null || frmCompra.DialogResult == DialogResult.Cancel)
            {
                frmCompra = new FrmCompra();
                frmCompra.MdiParent = this;
                frmCompra.Dock = DockStyle.Fill;
                frmCompra.Show();
            }
            else if (frmCompra.DialogResult == DialogResult.None)
            {
                frmCompra.Activate();
            }

        }

        private void listaDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditarProductos = new FrmEditarProductos();

            frmEditarProductos.ShowDialog();
        }

        private void verProdMenos10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVer = new FrmVer();
            frmVer.Text = "Productos con menos de 10 unidades:";

            frmVer.ShowDialog();
            frmVer = null;
        }

        private void mostrarTodosLosProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVer = new FrmVer();
            frmVer.Text = "Listado de Productos:";

            frmVer.ShowDialog();
            frmVer = null;
        }

        private void comprasGeneradasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVer = new FrmVer();
            frmVer.Text = "Listado de Compras:";

            frmVer.ShowDialog();
            frmVer = null;
        }

        private void listaDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVer = new FrmVer();
            frmVer.Text = "Listado de Clientes:";

            frmVer.ShowDialog();
            frmVer = null;
        }

        private void listaDeEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVer = new FrmVer();
            frmVer.Text = "Listado de Empleados:";

            frmVer.ShowDialog();
            frmVer = null;
        }

        private void generarHardcodeoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Hardcode.Harcodear(), "Datos cargados", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

    }
}
