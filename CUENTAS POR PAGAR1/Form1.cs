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
    public partial class FINICIO : Form
    {
        string USUARIO, CLAVE;
        public FINICIO()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void BENTRADA_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow FILA = DAGVUSUARIOS.CurrentRow;
                //Para copiar los valores de las columnas en las variables US y CL
                string US = Convert.ToString(FILA.Cells[0].Value);
                string CL = Convert.ToString(FILA.Cells[1].Value);
                //Para validar el usuario y la contraseña
                if (TUSUARIO.Text == US & TCLAVE.Text == CL)
                {
                    FMENUPRI FP = new FMENUPRI();
                    FP.Show();
                    this.Hide();
                }
                else
                {
                    //Si dejó los campos en blanco.
                    MessageBox.Show("DEBE ESCRIBIR EL NOMBRE DEL USUARIO Y CONTRASEÑA INVÁLIDOS");
                }
            }
            catch
            {
                //Si el usuario o la contraseña no coinciden o son incorrectos
                MessageBox.Show("USUARIO O CONTRASEÑA INVÁLIDOS");
                TUSUARIO.Focus();
            }
        }

        private void TUSUARIO_TextChanged(object sender, EventArgs e)
        {
            //Para invocar el método BUSCAR USUARIO
            DAGVUSUARIOS.DataSource = DATOSUSUARIOS.BUSCARPORUSUARIO(TUSUARIO.Text);
        }

        private void TCLAVE_TextChanged(object sender, EventArgs e)
        {
            //Para invocar el método BUSCAR CLAVE
            DAGVUSUARIOS.DataSource = DATOSUSUARIOS.BUSCARPORCLAVE(TCLAVE.Text);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void FINICIO_Load(object sender, EventArgs e)
        {
            DAGVUSUARIOS.DataSource = DATOSUSUARIOS.MOSTRAR();
            //Para ocultar la clave.
            DAGVUSUARIOS.Columns[1].Visible = false;
        }
    }
}
