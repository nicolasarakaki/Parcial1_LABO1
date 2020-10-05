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
    public partial class FrmLogin : Form
    {

        #region Atributos

        FrmComercio frmComercio;

        #endregion


        #region Constructores

        public FrmLogin()
        {
            InitializeComponent();
        }

        #endregion


        #region Evento Load y FormClosing

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            frmComercio = new FrmComercio();
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Seguro que desea salir?", "Cerrando el programa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }


        #endregion


        #region Eventos de Button Click

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string usuario = tbxUsuario.Text;
            string pass = tbxPass.Text;

            if (Login.Autenticar(usuario, pass))
            {
                FrmComercio.Usuario = Login.NombreEmpleado;
                this.Limpiar();
                this.Hide();
                frmComercio.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Usuario y Contraseña incorrectos", "Inicio de Sesión",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion


        #region Metodos

        private void Limpiar()
        {
            tbxUsuario.Clear();
            tbxPass.Clear();
        }

        #endregion


    }
}
