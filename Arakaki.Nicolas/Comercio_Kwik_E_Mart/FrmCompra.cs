using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using Entidades;

namespace Comercio_Kwik_E_Mart
{
    public partial class FrmCompra : Form
    {

        #region Atributos

        private Compra compra;

        #endregion


        #region Constructores

        public FrmCompra()
        {
            InitializeComponent();
        }

        #endregion


        #region Evento Load y FormClosing

        private void FrmCompra_Load(object sender, EventArgs e)
        {
            compra = new Compra();

            this.lblNomEmpleado.Text = FrmComercio.Usuario;
            this.cmbClientes.DataSource = Comercio.ListaClientes;
            this.cmbClientes.DisplayMember = "NombreCompleto";

            this.dgvInventario.DataSource = Comercio.Inventario.ListaProductos;
        }

        private void FrmCompra_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Estás seguro de que quieres salir?", "SALIR",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LimpiarPantalla();
                Compra.DesincrementarID();
                this.DialogResult = DialogResult.Cancel;
            }
            else
            {
                e.Cancel = true;
            }

        }

        #endregion


        #region Eventos de Button Click

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (dgvInventario.RowCount > 0)
            {
                int cantidadPedida;
                Producto productoInventario = (Producto)dgvInventario.CurrentRow.DataBoundItem;
                Producto productoDeCarrito = new Producto(productoInventario.Codigo,
                                                          productoInventario.Descripcion,
                                                          productoInventario.Precio,
                                                          productoInventario.Categoria);

                if (int.TryParse(tbxCantidad.Text, out cantidadPedida)
                    && Validacion.EsNumero(tbxCantidad.Text)
                    && cantidadPedida > 0
                    && cantidadPedida <= productoInventario.Cantidad)
                {
                    productoDeCarrito.Cantidad += cantidadPedida;
                    compra += productoDeCarrito;

                    productoInventario.Cantidad -= cantidadPedida;
                    RefrescarDatagrids();

                }
                else if (tbxCantidad.Text == "0" || string.IsNullOrEmpty(tbxCantidad.Text))
                {
                    MessageBox.Show("El campo \"CANTIDAD\" está vacío o es 0(cero)", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (cantidadPedida > productoInventario.Cantidad)
                {
                    MessageBox.Show("No hay suficiente stock para la cantidad pedida", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El campo \"CANTIDAD\" debe ser un número", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("No hay productos en el inventario", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (dgvCompra.RowCount > 0)
            {
                Producto productoSeleccionado = (Producto)dgvCompra.CurrentRow.DataBoundItem;
                QuitarProdSelectCompra(productoSeleccionado);
                RefrescarDatagrids();
            }
            else
            {
                MessageBox.Show("No hay ningún producto en el cuadro de compras", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConfirmarCompra_Click(object sender, EventArgs e)
        {
            if (ValidarCompra() && MessageBox.Show("Estás seguro que desea confirmar?", "Confirmación de la compra",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int dniCliente;
                if (Validacion.EsNumero(tbxDniCliente.Text) && int.TryParse(tbxDniCliente.Text, out dniCliente))
                {
                    Cliente cliente = new Cliente(tbxNombreCliente.Text, tbxApellidoCliente.Text, dniCliente);
                    Empleado empleado = Comercio.BuscarEmpleado(lblNomEmpleado.Text);
                    compra.NombreClienteCompra = cliente.NombreCompleto;

                    empleado += compra;
                    Comercio.AgregarCliente(cliente);

                    RecargarCompra();

                    lblGracias.Text = string.Format("GRACIAS!!! VUELVA PRONTOSSS!!");

                    try
                    {
                        string ruta = string.Format($@"{Application.StartupPath}\Sound\cashRegister.wav");
                        SoundPlayer sonido = new SoundPlayer(ruta);
                        sonido.PlaySync();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex}");
                    }

                }

            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarPantalla();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion


        #region Eventos de TextBox TextCanged

        private void tbxApellidoCliente_TextChanged(object sender, EventArgs e)
        {
            if (Comercio.VerificarClienteVip(tbxApellidoCliente.Text))
            {
                lblDescuento.Text = "Se aplica el 13% de descuento";
            }
            else
            {
                lblDescuento.Text = string.Empty;
            }
            MostrarPrecioTotal();
        }

        private void tbxDniCliente_TextChanged(object sender, EventArgs e)
        {
            int dniCliente;
            bool flag = true;
            Cliente cliente = null;

            if (Validacion.EsNumero(tbxDniCliente.Text) && int.TryParse(tbxDniCliente.Text, out dniCliente))
            {
                foreach (Cliente auxCliente in Comercio.ListaClientes)
                {
                    if (auxCliente.Dni == dniCliente)
                    {
                        cliente = auxCliente;
                        tbxNombreCliente.Text = cliente.Nombre;
                        tbxNombreCliente.Enabled = false;
                        tbxApellidoCliente.Text = cliente.Apellido;
                        tbxApellidoCliente.Enabled = false;
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    tbxNombreCliente.Enabled = true;
                    tbxApellidoCliente.Enabled = true;
                }
            }
            else if (string.IsNullOrEmpty(tbxDniCliente.Text))
            {
                tbxNombreCliente.Text = string.Empty;
                tbxNombreCliente.Enabled = true;

                tbxApellidoCliente.Text = string.Empty;
                tbxApellidoCliente.Enabled = true;
            }
        }

        private void tbxCantidad_TextChanged(object sender, EventArgs e)
        {
            if (tbxCantidad.Text != "0")
            {
                lblGracias.Text = string.Empty;
            }
        }

        #endregion


        #region Evento de ComboBox

        private void cmbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)cmbClientes.SelectedItem;

            if (!object.Equals(cliente, null))
            {
                tbxDniCliente.Text = cliente.Dni.ToString();
            }
        }

        #endregion


        #region Metodos

        private void QuitarProdSelectCompra(Producto productoSelect)
        {
            Comercio.Inventario[productoSelect.Descripcion].Cantidad += productoSelect.Cantidad;
            compra.ListaProductos.Remove(productoSelect);
        }

        private void RefrescarDatagrids()
        {
            this.dgvInventario.DataSource = null;
            this.dgvInventario.DataSource = Comercio.Inventario.ListaProductos;

            this.dgvCompra.DataSource = null;
            if (compra.ListaProductos.Count > 0)
            {
                this.dgvCompra.DataSource = compra.ListaProductos;
            }

            MostrarPrecioTotal();
        }

        private void LimpiarPantalla()
        {
            if (dgvCompra.RowCount > 0)
            {
                Producto productoSelect;
                for (int i = 0; i < dgvCompra.RowCount; i++)
                {
                    productoSelect = (Producto)dgvCompra.Rows[0].DataBoundItem;
                    QuitarProdSelectCompra(productoSelect);
                }
                RefrescarDatagrids();
            }
            tbxApellidoCliente.Clear();
            tbxNombreCliente.Clear();
            tbxDniCliente.Clear();
            tbxCantidad.Text = "0";
        }

        private void RecargarCompra()
        {
            compra = new Compra();
            RefrescarDatagrids();

            this.cmbClientes.DataSource = null;
            this.cmbClientes.DataSource = Comercio.ListaClientes;
            this.cmbClientes.DisplayMember = "NombreCompleto";

            tbxApellidoCliente.Clear();
            tbxNombreCliente.Clear();
            tbxDniCliente.Clear();
            tbxCantidad.Text = "0";
        }

        private bool ValidarCompra()
        {
            bool retorno = false;

            if (dgvCompra.RowCount > 0
                && !string.IsNullOrEmpty(tbxApellidoCliente.Text) && Validacion.EsString(tbxApellidoCliente.Text)
                && !string.IsNullOrEmpty(tbxNombreCliente.Text) && Validacion.EsString(tbxNombreCliente.Text)
                && !string.IsNullOrEmpty(tbxDniCliente.Text) && Validacion.EsNumero(tbxDniCliente.Text))
            {
                retorno = true;
            }
            else if (dgvCompra.Rows.Count == 0)
            {
                MessageBox.Show("No hay ningún producto en el cuadro de compras", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Validacion.EsNumero(tbxDniCliente.Text))
            {
                MessageBox.Show("El campo \"DNI\" debe ser solo números", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Faltan completar algunos campos", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return retorno;
        }

        private void MostrarPrecioTotal()
        {
            double precioTotal = CalcularPrecioTotal();

            this.lblPrecioTotal.Text = string.Format($"${precioTotal}");
        }

        private double CalcularPrecioTotal()
        {
            double precioTotalDoble;
            double acumulador = 0;

            if (dgvCompra.Rows.Count > 0)
            {
                for (int i = 0; i < dgvCompra.Rows.Count; i++)
                {
                    double.TryParse(dgvCompra.Rows[i].Cells[4].Value.ToString().Replace("$", ""), out precioTotalDoble);
                    acumulador += precioTotalDoble;
                }

                if (!string.IsNullOrEmpty(lblDescuento.Text) && acumulador != 0)
                {
                    acumulador -= (acumulador * 0.13);
                }
            }

            return acumulador;

        }

        #endregion

    }
}
