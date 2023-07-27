using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CUENTAS_POR_PAGAR1
{
    public partial class FAGREGARCHEQ : Form
    {
        public FAGREGARCHEQ()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void TNUMCHEQ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                TNUMFACT.Focus();
            }
        }

        private void TNUMFACT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                TVALCHEQ.Focus();
            }
        }

        private void TVALCHEQ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                TFECHACHEQ.Focus();
            }
        }

        private void BAGREGAR_Click(object sender, EventArgs e)
        {
            try
            {
                DATOSCHEQUES.INSERTARCHEQUE(
                int.Parse(TNUMCHEQ.Text),
                int.Parse(TNUMFACT.Text),
                decimal.Parse(TVALCHEQ.Text),
                DateTime.Parse(TFECHACHEQ.Text)
                );
                MessageBox.Show("EL CHEQUE SE AGREGÓ SATISFACTORIAMENTE", "AGREGAR CHEQUE");
                Close();
            }
            catch
            {
                MessageBox.Show("ENTRADA INVALIDA. TRATE DE NUEVO");
                TNUMCHEQ.Focus();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
