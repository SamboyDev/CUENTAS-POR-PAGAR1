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
    public partial class FESTADODECUENTAS : Form
    {
        public FESTADODECUENTAS()
        {
            InitializeComponent();
        }

        private void FESTADODECUENTAS_Load(object sender, EventArgs e)
        {
            DGVESTADOCUENTAS.DataSource = DATOSESTADOSDECUENTAS.MOSTRARESTADO();
        }

        private void TPORCODIGO_TextChanged(object sender, EventArgs e)
        {
            DGVESTADOCUENTAS.DataSource = DATOSESTADOSDECUENTAS.BUSCARPORCOIGO(TPORCODIGO.Text);
        }

        private void TPORNUMFACT_TextChanged(object sender, EventArgs e)
        {
            DGVESTADOCUENTAS.DataSource = DATOSESTADOSDECUENTAS.BUSCARPORNUMEROFACTURA(int.Parse(TPORNUMFACT.Text));
        }

        private void BVERTODOS_Click(object sender, EventArgs e)
        {
            DGVESTADOCUENTAS.DataSource = DATOSESTADOSDECUENTAS.MOSTRARESTADO();
        }
    }
}
