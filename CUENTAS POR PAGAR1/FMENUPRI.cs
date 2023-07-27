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
    public partial class FMENUPRI : Form
    {
        public FMENUPRI()
        {
            InitializeComponent();
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mANTENMIENTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FPROVEEDORES formulario = new FPROVEEDORES();
            formulario.TopLevel = false;
            formulario.Dock = DockStyle.Fill;
            panelContenedor.Controls.Clear();
            panelContenedor.Controls.Add(formulario);
            formulario.Show();
        }

        private void fACTURASToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void mANTEMIENTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FFACTURAS formulario = new FFACTURAS();
            formulario.TopLevel = false;
            formulario.Dock = DockStyle.Fill;
            panelContenedor.Controls.Clear();
            panelContenedor.Controls.Add(formulario);
            formulario.Show();
        }

        private void mANTENIMIENTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FCHEQUES formulario = new FCHEQUES();
            formulario.TopLevel = false;
            formulario.Dock = DockStyle.Fill;
            panelContenedor.Controls.Clear();
            panelContenedor.Controls.Add(formulario);
            formulario.Show();
        }

        private void eSTADOSDECUENTASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FESTADODECUENTAS formulario = new FESTADODECUENTAS();
            formulario.TopLevel = false;
            formulario.Dock = DockStyle.Fill;
            panelContenedor.Controls.Clear();
            panelContenedor.Controls.Add(formulario);
            formulario.Show();
        }

        private void rEPORTESDEPROVEEDORESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRPROVEEDORES formulario = new FRPROVEEDORES();
            formulario.TopLevel = false;
            formulario.Dock = DockStyle.Fill;
            panelContenedor.Controls.Clear();
            panelContenedor.Controls.Add(formulario);
            formulario.Show();
        }

        private void rEPORTEDEEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRESTADO formulario = new FRESTADO();
            formulario.TopLevel = false;
            formulario.Dock = DockStyle.Fill;
            panelContenedor.Controls.Clear();
            panelContenedor.Controls.Add(formulario);
            formulario.Show();
        }

        private void rEPORTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRFACTURAS formulario = new FRFACTURAS();
            formulario.TopLevel = false;
            formulario.Dock = DockStyle.Fill;
            panelContenedor.Controls.Clear();
            panelContenedor.Controls.Add(formulario);
            formulario.Show();
        }

        private void rEPORTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRCHEQUES formulario = new FRCHEQUES();
            formulario.TopLevel = false;
            formulario.Dock = DockStyle.Fill;
            panelContenedor.Controls.Clear();
            panelContenedor.Controls.Add(formulario);
            formulario.Show();
        }
    }
}
