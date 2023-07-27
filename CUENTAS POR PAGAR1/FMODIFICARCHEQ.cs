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
    public partial class FMODIFICARCHEQ : Form
    {
        private int NUMERO;
        public int NUMEROCHEQUE { get; internal set; }
        public FMODIFICARCHEQ(int numeero)
        {
            InitializeComponent();
            NUMEROCHEQUE = NUMERO;
        }

        private void TVALCHEQ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                TFECHACHEQ.Focus();
            }
        }

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

        private void FMODIFICARCHEQ_FormClosed(object sender, FormClosedEventArgs e)
        {
            CargarNumeroCheque();
        }

        private void CargarNumeroCheque()
        {
            // Aquí puedes obtener los datos del proveedor según el código y cargarlos en los TextBox
            // Por ejemplo:
            using (SCXSAMBOYEntities BD = new SCXSAMBOYEntities())
            {
                var chq = BD.CHEQUESSAMBOY.SingleOrDefault(C => C.NUMEROCHEQUE == NUMERO);
                if (chq != null)
                {
                    NUMERO = chq.NUMEROCHEQUE;
                    TNUMCHEQ.Text = Convert.ToString(NUMERO);
                    TNUMFACT.Text = Convert.ToString(TNUMFACT.Text);
                    TVALCHEQ.Text = Convert.ToString(chq.VALORCHEQUE);
                    TFECHACHEQ.Text = Convert.ToString(chq.FECHACHEQUE);
                }
            }
        }

        private void FMODIFICARCHEQ_Load(object sender, EventArgs e)
        {
            CargarNumeroCheque();
        }

        private void BMODIFICAR_Click(object sender, EventArgs e)
        {
            try
            {
                DATOSCHEQUES.MODIFICARCHEQUE(
               int.Parse(TNUMCHEQ.Text),
               int.Parse(TNUMFACT.Text),
               Convert.ToDecimal(TVALCHEQ.Text),
               Convert.ToDateTime(TFECHACHEQ.Text)
                );
                MessageBox.Show("EL CHEQUE SE MODIFICÓ SATISFACTORIAMENTE", "AGREGAR FACTURA");
                Close();
            }
            catch
            {
                MessageBox.Show("ENTRADA IVÁLIDA. TRATE DE NUEVO", "ERROR DE ENTRADA");
            }
        }
    }
}
