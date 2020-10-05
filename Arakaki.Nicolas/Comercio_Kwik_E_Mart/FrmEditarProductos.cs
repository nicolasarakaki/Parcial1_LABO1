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
    public partial class FrmEditarProductos : Form
    {

        #region Constructores

        public FrmEditarProductos()
        {
            InitializeComponent();
        }

        #endregion


        #region Evento Load y FormClosing

        private void FrmEditarProductos_Load(object sender, EventArgs e)
        {
            CargarListViewProductos();
        }

        private void FrmEditarProductos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Estás seguro de que quieres salir?", "SALIR",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        #endregion


        #region Eventos de Button Click

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (tbxCodProdSelect.Text != string.Empty && tbxDescProdSelec.Text != string.Empty)
            {
                FrmEditProdSelect frmEditProdSelect = new FrmEditProdSelect();
                frmEditProdSelect.ProductoSelec = Comercio.Inventario[tbxDescProdSelec.Text];

                if (frmEditProdSelect.ShowDialog() == DialogResult.OK)
                {
                    RecargarListView();
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int cantidad;
            double precio;
            Inventario inventario = Comercio.Inventario;

            if (ValidarProducto()
            && int.TryParse(tbxCantidad.Text, out cantidad) && double.TryParse(tbxPrecioUni.Text, out precio)
            && MessageBox.Show("Confirmar?", "Agregar producto",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Producto.ECategoria categoria = Producto.ECategoria.Kiosko;
                foreach (RadioButton radioButton in groupBoxCategoria.Controls)
                {
                    switch (radioButton.Text)
                    {
                        case "COMIDA":
                            if (radioButton.Checked)
                            {
                                categoria = Producto.ECategoria.Comida;
                            }
                            break;

                        case "BEBIDA":
                            if (radioButton.Checked)
                            {
                                categoria = Producto.ECategoria.Bebida;
                            }
                            break;

                        case "ART. KIOSKO":
                            if (radioButton.Checked)
                            {
                                categoria = Producto.ECategoria.Kiosko;
                            }
                            break;
                    }
                }
                Producto producto = new Producto(CrearCodigoNuevo(), tbxDescripcion.Text, precio, categoria, cantidad);
                inventario += producto;

                MessageBox.Show($"Se ha cargado el siguiente producto: \n {producto.ToString()}",
                                    "Producto Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RecargarListView();

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Inventario inventario = Comercio.Inventario;
            if (tbxCodProdSelect.Text != string.Empty && tbxDescProdSelec.Text != string.Empty
                && MessageBox.Show("Estas seguro de eliminar el producto?", "Eliminando Producto",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Producto producto = Comercio.Inventario[tbxDescProdSelec.Text];
                inventario -= producto;
                RecargarListView();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion


        #region Evento de ListView

        private void lstvProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection producto = lstvProductos.SelectedItems;

            foreach (ListViewItem descripcion in producto)
            {
                tbxCodProdSelect.Text = descripcion.SubItems[0].Text;
                tbxDescProdSelec.Text = descripcion.SubItems[1].Text;
            }
        }

        #endregion


        #region Evento de TextChanged

        private void tbxDescripcion_TextChanged(object sender, EventArgs e)
        {
            Producto productoBuscado = Comercio.Inventario[tbxDescripcion.Text];

            if (!object.Equals(productoBuscado, null))
            {
                tbxCodigo.Text = productoBuscado.Codigo.ToString();
                tbxPrecioUni.Text = productoBuscado.Precio.ToString();
                tbxCantidad.Text = productoBuscado.Cantidad.ToString();

                switch (productoBuscado.Categoria)
                {
                    case Producto.ECategoria.Comida:
                        rbtnComida.Checked = true;
                        break;
                    case Producto.ECategoria.Bebida:
                        rbtnBebida.Checked = true;
                        break;
                    case Producto.ECategoria.Kiosko:
                        rbtnKiosko.Checked = true;
                        break;
                }

                tbxCantidad.Enabled = false;
                tbxPrecioUni.Enabled = false;
                btnAgregar.Enabled = false;
            }
            else
            {
                tbxCodigo.Text = string.Empty;
                btnAgregar.Enabled = true;
                tbxCantidad.Enabled = true;
                tbxPrecioUni.Enabled = true;
            }
        }

        #endregion


        #region Metodos

        private void CargarListViewProductos()
        {
            ListViewGroup comidas = new ListViewGroup("Comidas", HorizontalAlignment.Right);
            ListViewGroup bebidas = new ListViewGroup("Bebidas", HorizontalAlignment.Right);
            ListViewGroup kiosko = new ListViewGroup("Art. de Kiosko", HorizontalAlignment.Right);

            foreach (Producto producto in Comercio.Inventario.ListaProductos)
            {
                string[] descripcionFull = new string[5] { producto.Codigo.ToString(),
                                                           producto.Descripcion, 
                                                           producto.PrecioString,
                                                           producto.Cantidad.ToString(),
                                                           producto.Categoria.ToString(),};

                switch (producto.Categoria)
                {
                    case Producto.ECategoria.Comida:

                        lstvProductos.Items.Add(new ListViewItem(descripcionFull, comidas));
                        break;

                    case Producto.ECategoria.Bebida:

                        lstvProductos.Items.Add(new ListViewItem(descripcionFull, bebidas));
                        break;

                    case Producto.ECategoria.Kiosko:

                        lstvProductos.Items.Add(new ListViewItem(descripcionFull, kiosko));
                        break;

                }

            }

            lstvProductos.Groups.Add(comidas);
            lstvProductos.Groups.Add(bebidas);
            lstvProductos.Groups.Add(kiosko);

        }

        private void RecargarListView()
        {
            tbxCantidad.Clear();
            tbxCodigo.Clear();
            tbxCodProdSelect.Clear();
            tbxDescProdSelec.Clear();
            tbxDescripcion.Clear();
            tbxPrecioUni.Clear();
            lstvProductos.Items.Clear();
            CargarListViewProductos();
        }

        private bool ValidarProducto()
        {
            bool retorno = false;

            if (tbxDescripcion.Text != string.Empty
            && tbxCantidad.Text != string.Empty && Validacion.EsNumero(tbxCantidad.Text)
            && tbxPrecioUni.Text != string.Empty && Validacion.EsNumero(tbxPrecioUni.Text))
            {
                retorno = true;
            }
            else if (tbxDescripcion.Text == string.Empty || tbxCantidad.Text == string.Empty
                        || tbxPrecioUni.Text == string.Empty)
            {
                MessageBox.Show("Falta completar los campos", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Los campos CANTIDAD y PRECIO deben ser números", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return retorno;
        }

        private int CrearCodigoNuevo()
        {
            int numMax = 0;

            foreach (Producto producto in Comercio.Inventario.ListaProductos)
            {
                if (producto.Codigo > numMax)
                {
                    numMax = producto.Codigo;
                }
            }

            return numMax + 1;

        }


        #endregion

    }
}
