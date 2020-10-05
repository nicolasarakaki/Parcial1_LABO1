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
    public partial class FrmAltaEmpleado : Form
    {
        private Empleado empleado1;
        private Empleado empleado2;

        public FrmAltaEmpleado()
        {
            InitializeComponent();

            empleado1 = new Empleado("Apu", "Nahasapeemapetilon", 123456); //TODO Borrar, tiene que estar en la lista de Comercio
            empleado2 = new Empleado("Nicolas", "Arakaki", 987654);

            Comercio.ListaPersonas.Add(empleado1);
            Comercio.ListaPersonas.Add(empleado2);

        }

        private void FrmAltaEmpleado_Load(object sender, EventArgs e)
        {
            
        }
    }
}
