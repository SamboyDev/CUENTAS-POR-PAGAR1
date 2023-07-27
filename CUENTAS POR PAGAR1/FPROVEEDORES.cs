using Microsoft.Win32;
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
    public partial class FPROVEEDORES : Form
    {
        FAGREGARPROV FAP = new FAGREGARPROV();

        public FPROVEEDORES()
        {
            InitializeComponent();
        }

        private void FPROVEEDORES_Load(object sender, EventArgs e)
        {
            //INVOCAMOS EL MÉTODO MÉTODO MOSTRARPROVEEDORES DE LA CLASE DATOSPROVEEDORES
            DGVPROVEEDORES.DataSource = DATOSPROVEEDORES.MOSTRARDATOS();
            //OCULTAMOS LA COLUMNA FACTURAS PARA QUE NO APAREZCA EN EL DATAGRID VIEW


        }

        private void TCODIGO_TextChanged(object sender, EventArgs e)
        {
            DGVPROVEEDORES.DataSource = DATOSPROVEEDORES.BUSCARPORCODIGO(TCODIGO.Text);
        }

        private void TNOMBRES_TextChanged(object sender, EventArgs e)
        {
            DGVPROVEEDORES.DataSource = DATOSPROVEEDORES.BUSCARNOMBRES(TNOMBRES.Text);
        }

        private void TAPELLIDOS_TextChanged(object sender, EventArgs e)
        {
            DGVPROVEEDORES.DataSource = DATOSPROVEEDORES.BUSCARPORAPELLIDOS(TAPELLIDOS.Text);
        }

        private void TDIRECCION_TextChanged(object sender, EventArgs e)
        {
            DGVPROVEEDORES.DataSource = DATOSPROVEEDORES.BUSCARPORDIRECCION(TDIRECCION.Text);
        }

        private void TCIUDAD_TextChanged(object sender, EventArgs e)
        {
            DGVPROVEEDORES.DataSource = DATOSPROVEEDORES.BUSCARPORCIUDAD(TCIUDAD.Text);
        }

        private void TTELEFONO_TextChanged(object sender, EventArgs e)
        {
            DGVPROVEEDORES.DataSource = DATOSPROVEEDORES.BUSCARPORTELEFONO(TTELEFONO.Text);
        }

        private void FPROVEEDORES_FormClosed(object sender, FormClosedEventArgs e)
        {
            DGVPROVEEDORES.DataSource = DATOSPROVEEDORES.MOSTRARDATOS();
        }

        private void BAGREGAR_Click(object sender, EventArgs e)
        {
            //Creamos una instancia tipo FMODIFICARPROV
            FAGREGARPROV FMP = new FAGREGARPROV();
            /*Abrimos el formulario y actualizamos DataGrid View DGVPROVEEDORES
            después de cerrarlo */
            FMP.FormClosed += new
            System.Windows.Forms.FormClosedEventHandler(FPROVEEDORES_FormClosed);
            FMP.Show();

        }

        private void TCODIGO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                TNOMBRES.Focus();
            }
        }

        private void TNOMBRES_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                TAPELLIDOS.Focus();
            }
        }

        private void TAPELLIDOS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                TDIRECCION.Focus();
            }
        }

        private void TDIRECCION_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                TCIUDAD.Focus();
            }
        }

        private void TCIUDAD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                TTELEFONO.Focus();
            }
        }

        private void TTELEFONO_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void BMODIFICAR_Click(object sender, EventArgs e)
        {
            DataGridViewRow FILA = DGVPROVEEDORES.CurrentRow;
            string codigo = Convert.ToString(FILA.Cells[0].Value);
            FMODIFICARPROV FMP = new FMODIFICARPROV();
            FMP.FormClosed += new System.Windows.Forms.FormClosedEventHandler(FPROVEEDORES_FormClosed);

            FMP.CODIGOPROVEEDORES = codigo;
            FMP.Show();
        }

        private void BELIMINAR_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("DESEA ELIMINAR EL PROVEEDOR?", "BORRAR PROVEEDOR", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
            {
                DataGridViewRow FILA = DGVPROVEEDORES.CurrentRow;
                string codigo = Convert.ToString(FILA.Cells[0].Value);
                DATOSPROVEEDORES.ELIMINARPROVEEDOR(codigo);
                MessageBox.Show("SE HA BORRADO EL PROVEEDOR" + TNOMBRES.Text  + " "+ TAPELLIDOS.Text, "REGISTRO ELIMINADO");
               
                DGVPROVEEDORES.DataSource = DATOSPROVEEDORES.MOSTRARDATOS();
            }
        }
    }
}
