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
    public partial class FMODIFICARFACT : Form
    {
        private int NUMERO;
        public int NUMEROFACTURA { get; internal set; }
        public FMODIFICARFACT()
        {
            InitializeComponent();

        }

        private void FMODIFICARFACT_FormClosed(object sender, FormClosedEventArgs e)
        {
            CargarNumeroFactura();
        }

        private void CargarNumeroFactura()
        {
            // Aquí puedes obtener los datos del proveedor según el código y cargarlos en los TextBox
            // Por ejemplo:
            using (SCXSAMBOYEntities BD = new SCXSAMBOYEntities())
            {
                var fact = BD.FACTURASSAMBOY.SingleOrDefault(F => F.NUMEROFACTURA == NUMERO);
                if (fact != null)
                {
                    NUMERO = fact.NUMEROFACTURA;
                    TCODIGO.Text = fact.CODIGO;
                    TVALFACT.Text = Convert.ToString(fact.VALORFACTURA);
                    TFECHAFACT.Text = Convert.ToString(fact.FECHAFACTURA);
                    TFECHAVENC.Text = Convert.ToString(fact.FECHAVENCIMIENTO);

                }
            }
        }

        private void BMODIFICAR_Click(object sender, EventArgs e)
        {
            DATOSFACTURAS.MODIFICARFACTURA(
            Convert.ToInt16(TNUMFACT.Text),
            TCODIGO.Text,
            Convert.ToDecimal(TVALFACT.Text),
            Convert.ToDateTime(TFECHAFACT.Text),
            Convert.ToDateTime(TFECHAVENC.Text));
            MessageBox.Show("LA FACTURA SE MODIFICÓ SATISFACTORIAMENTE", "AGREGAR FACTURA");
            Close();

        }

        private void FMODIFICARFACT_Load(object sender, EventArgs e)
        {
            CargarNumeroFactura();
        }
    }
}
