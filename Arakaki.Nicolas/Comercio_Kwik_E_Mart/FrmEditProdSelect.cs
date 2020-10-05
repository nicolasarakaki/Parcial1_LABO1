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
    public partial class FrmEditProdSelect : Form
    {

        #region Atributos

        private Producto producto;

        #endregion


        #region Propiedades

        public Producto ProductoSelec
        {
            get
            {
                return this.producto;
            }
            set
            {
                this.producto = value;
            }
        }

        #endregion


        #region Constructores

        public FrmEditProdSelect()
        {
            InitializeComponent();
        }

        #endregion


        #region Evento Load y FormClosing

        private void FrmEditProdSelect_Load(object sender, EventArgs e)
        {
            List<Producto.ECategoria> categorias = new List<Producto.ECategoria>() { Producto.ECategoria.Comida,
                                                                                     Producto.ECategoria.Bebida,
                                                                                     Producto.ECategoria.Kiosko};
            cmbCategoria.DataSource = categorias;

            tbxDesc.Text = producto.Descripcion;
            tbxPrecioUni.Text = producto.Precio.ToString();
            tbxCantidad.Text = producto.Cantidad.ToString();
            cmbCategoria.Text = producto.Categoria.ToString();

        }

        private void FrmEditProdSelect_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult != DialogResult.OK)
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }

        #endregion


        #region Eventos de Button Click

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int cantidad;
            double precio;

            if (ValidarEdicion()
            && int.TryParse(tbxCantidad.Text, out cantidad) && double.TryParse(tbxPrecioUni.Text, out precio)
            && MessageBox.Show("Confirmar?", "Editar el producto",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.producto.Descripcion = tbxDesc.Text;
                this.producto.Cantidad = cantidad;
                this.producto.Precio = precio;
                this.producto.Categoria = (Producto.ECategoria)cmbCategoria.SelectedItem;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion


        #region Metodos

        private bool ValidarEdicion()
        {
            bool retorno = false;

            if (tbxDesc.Text != string.Empty
            && tbxCantidad.Text != string.Empty && Validacion.EsNumero(tbxCantidad.Text)
            && tbxPrecioUni.Text != string.Empty && Validacion.EsNumero(tbxPrecioUni.Text))
            {
                retorno = true;
            }
            else if (tbxDesc.Text == string.Empty || tbxCantidad.Text == string.Empty
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

        #endregion

    }
}
