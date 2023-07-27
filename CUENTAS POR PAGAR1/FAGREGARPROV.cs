using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CUENTAS_POR_PAGAR1
{
    public partial class FAGREGARPROV : Form
    {
        public FAGREGARPROV()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FAGREGARPROV_FormClosed(object sender, FormClosedEventArgs e)
        {
            DATOSPROVEEDORES.MOSTRARDATOS();

        }

        private void BAGREGAR_Click(object sender, EventArgs e)
        {
            DATOSPROVEEDORES.INSERTARPROVEEDOR(
            TCODIGO.Text,
            TNOMBRES.Text,
            TAPELLIDOS.Text,
            TDIRECCION.Text,
            TCIUDAD.Text,
            TTELEFONO.Text);
            MessageBox.Show("EL PROVEEDOR" + " " + TNOMBRES.Text + " " + TAPELLIDOS.Text + " " + "HA  SIDO AGREGADO", "AGREGAR PROVEEDOR");
            this.Close();
        }
    }
}
