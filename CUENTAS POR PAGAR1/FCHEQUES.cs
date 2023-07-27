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
    public partial class FCHEQUES : Form
    {
        public FCHEQUES()
        {
            InitializeComponent();
        }

        private void FCHEQUES_Load(object sender, EventArgs e)
        {
            DGVFCHEQUES.DataSource = DATOSCHEQUES.MOSTRARCHEQUES();

        }

        private void TNUMCHE_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DGVFCHEQUES.DataSource =
               DATOSCHEQUES.BUSCARELNUMERO(int.Parse(TNUMCHE.Text));
            }
            catch
            {
                MessageBox.Show("LA ENTRADA DEBE SER NUMÉRICA");
                TNUMCHE.Focus();
            }
        }

        private void TNUMFACTURA_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DGVFCHEQUES.DataSource =
               DATOSCHEQUES.BUSCARELNUMERO(int.Parse(TNUMFACTURA.Text));
            }
            catch
            {
                MessageBox.Show("LA ENTRADA DEBE SER NUMÉRICA");
                TNUMFACTURA.Focus();
            }
        }

        private void FCHEQUES_FormClosed(object sender, FormClosedEventArgs e)
        {
            DGVFCHEQUES.DataSource = DATOSCHEQUES.MOSTRARCHEQUES();
        }

        private void BAGREGAR_Click(object sender, EventArgs e)
        {
            FAGREGARCHEQ FAC = new FAGREGARCHEQ();
            /* Abrimos el formulario y actualizamos DataGrid View DGVCHEQUES
            después de cerrarlo */
            FAC.FormClosed += new
            System.Windows.Forms.FormClosedEventHandler(FCHEQUES_FormClosed);
            FAC.Show();
        }

        private void TNUMCHE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                TNUMFACTURA.Focus();
            }
        }

        private void BMODIFICAR_Click(object sender, EventArgs e)
        {
            DataGridViewRow FILA = DGVFCHEQUES.CurrentRow;
            int numero = Convert.ToInt16(FILA.Cells[0].Value);
            FMODIFICARCHEQ FMP = new FMODIFICARCHEQ(numero);
            FMP.Show();
            FMP.FormClosed += new
            System.Windows.Forms.FormClosedEventHandler(FCHEQUES_FormClosed);
            DGVFCHEQUES.DataSource = DATOSCHEQUES.MOSTRARCHEQUES();
        }

        private void BELIMINAR_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
            "DESEA ELIMINAR ESTA FACTURA?", "ADVERTENCIA DE ELIMINACION",
            MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
            {
                DataGridViewRow FILA = DGVFCHEQUES.CurrentRow;
                int numercheque = Convert.ToUInt16(FILA.Cells[0].Value);
                DATOSCHEQUES.ELIMINARCHEQUE(numercheque);
                MessageBox.Show(
                "SE HA BORRADO LA FACTURA" + numercheque, "REGISTRO ELIMINADO");
                DGVFCHEQUES.DataSource = DATOSCHEQUES.CARGAR(numercheque);
            }
        }
    }
}
