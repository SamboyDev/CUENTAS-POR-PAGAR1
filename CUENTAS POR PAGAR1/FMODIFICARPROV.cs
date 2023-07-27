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
    public partial class FMODIFICARPROV : Form
    {
        private string CODIGO;

        public string CODIGOPROVEEDORES { get; internal set; }

        public FMODIFICARPROV()
        {
            InitializeComponent();
        }

        private void FMODIFICARPROV_FormClosed(object sender, FormClosedEventArgs e)
        {
            CargarDatosProveedor();
        }

        private void CargarDatosProveedor()
        {
            // Aquí puedes obtener los datos del proveedor según el código y cargarlos en los TextBox
            // Por ejemplo:
            using (SCXSAMBOYEntities BD = new SCXSAMBOYEntities())
            {
                var proveedor = BD.PROVEEDORESSAMBOY.SingleOrDefault(p => p.CODIGO == CODIGOPROVEEDORES);
                if (proveedor != null)
                {
                    TCODIGO.Text = proveedor.CODIGO;
                    TNOMBRES.Text = proveedor.NOMBRES;
                    TAPELLIDOS.Text = proveedor.APELLIDOS;
                    TDIRECCION.Text = proveedor.DIRECCION;
                    TCIUDAD.Text = proveedor.CIUDAD;
                    TTELEFONO.Text = proveedor.TELEFONO;
                }
            }
        }
        private void BMODIFICAR_Click(object sender, EventArgs e)
        {
            using (SCXSAMBOYEntities BD = new SCXSAMBOYEntities())
            {
                var proveedor = BD.PROVEEDORESSAMBOY.SingleOrDefault(p => p.CODIGO == CODIGOPROVEEDORES);
                if (proveedor != null)
                {
                    // Modificar los valores de las columnas según los TextBox
                    proveedor.CODIGO = TCODIGO.Text;
                    proveedor.NOMBRES = TNOMBRES.Text;
                    proveedor.APELLIDOS = TAPELLIDOS.Text;
                    proveedor.DIRECCION = TDIRECCION.Text;
                    proveedor.CIUDAD = TCIUDAD.Text;
                    proveedor.TELEFONO = TTELEFONO.Text;
                    // Guardar los cambios en la base de datos
                    BD.SaveChanges();

                    // Cerrar el formulario de modificación
                    this.Close();
                }
            }
        }

        private void FMODIFICARPROV_Load(object sender, EventArgs e)
        {
            CargarDatosProveedor();
        }
    }
}