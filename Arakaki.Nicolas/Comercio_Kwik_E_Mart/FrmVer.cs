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
    public partial class FrmVer : Form
    {

        #region Constructores

        public FrmVer()
        {
            InitializeComponent();
        }

        #endregion


        #region Evento Load

        private void FrmAltaEmpleado_Load(object sender, EventArgs e)
        {
            switch (this.Text)
            {
                case "Productos con menos de 10 unidades:":

                    this.lblDatos.Text = "PRODUCTOS:";
                    this.richTbxDatos.Text = Comercio.Inventario.MostrarStockMenos10();
                    break;

                case "Listado de Productos:":

                    this.lblDatos.Text = "PRODUCTOS:";
                    this.richTbxDatos.Text = Comercio.Inventario.MostrarStock();
                    break;

                case "Listado de Compras:":

                    this.lblDatos.Text = "COMPRAS:";
                    this.richTbxDatos.Text = Comercio.MostrarCompras();
                    break;


                case "Listado de Clientes:":

                    this.lblDatos.Text = "CLIENTES:";
                    this.richTbxDatos.Text = Comercio.MostrarPersonas("clientes");
                    break;

                case "Listado de Empleados:":

                    this.lblDatos.Text = "EMPLEADOS:";
                    this.richTbxDatos.Text = Comercio.MostrarPersonas("empleados");
                    break;

            }

        }

        #endregion

    }
}
