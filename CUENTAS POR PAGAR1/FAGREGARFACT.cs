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
    public partial class FAGREGARFACT : Form
    {
        public FAGREGARFACT()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void TNUMFACT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                TCODIGO.Focus();
            }
        }

        private void TCODIGO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                TVALFACT.Focus();
            }
        }

        private void TVALFACT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                TFECHAFACT.Focus();
            }
        }

        private void TFECHAFACT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                TFECHAVENC.Focus();
            }
        }

        private void BAGREGAR_Click(object sender, EventArgs e)
        {
            DATOSFACTURAS.INSERTARFACTURA(
            Convert.ToInt16(TNUMFACT.Text),
            TCODIGO.Text,
            Convert.ToDecimal(TVALFACT.Text),
            Convert.ToDateTime(TFECHAFACT.Text),
            Convert.ToDateTime(TFECHAVENC.Text));
            MessageBox.Show("LA FACTURA SE AGREGÓ SATISFACTORIAMENTE", "AGREGAR FACTURA");
            Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panel6_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
