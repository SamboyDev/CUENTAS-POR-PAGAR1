using CUENTAS_POR_PAGAR1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace CUENTAS_POR_PAGAR1
{
    internal class DATOSFACTURAS
    {
        public static List<FACTURASSAMBOY> MOSTRARFACTURAS()
        {

            using (SCXSAMBOYEntities BD = new SCXSAMBOYEntities())
            {
                var INFO = (from U in BD.FACTURASSAMBOY
                            select U).ToList();
                return INFO;
            }
        }

        public static List<FACTURASSAMBOY> BUSCARELNUMERO(int numerofactura)
        {
            using (SCXSAMBOYEntities BD = new SCXSAMBOYEntities())
            {
                //USAMOS LINQ. PARA BUSCAR UN FACTURA POR EL NUMERO
                var INFO = (from F in BD.FACTURASSAMBOY
                            where F.NUMEROFACTURA == numerofactura
                            select F).ToList();
                /*StartsWith HACE QUE VAYA MOSTRANDO LOS PROVEEDORES QUE
                EMPIEZEN CON LAS LETRAS QUE VAMOS ESCRIBIENDO*/
                return INFO;
            }
        }
        public static List<FACTURASSAMBOY> BUSCARECODIGO(string codigoproveedor)
        {
            using (SCXSAMBOYEntities BD = new SCXSAMBOYEntities())
            {
                //USAMOS LINQ. PARA BUSCAR FACTURAS POR EL CODIGO DEL PROEEDOR
                var INFO = (from F in BD.FACTURASSAMBOY
                            where F.CODIGO == codigoproveedor
                            select F).ToList();
                /*StartsWith HACE QUE VAYA MOSTRANDO LOS PROVEEDORES QUE
                EMPIEZEN CON LAS LETRAS QUE VAMOS ESCRIBIENDO*/
                return INFO;
            }
        }

        public static void INSERTARFACTURA
         (
         int numerofactura,
        string codigoproveedor,
        decimal valorfactura,
        DateTime fechafactura,
        DateTime fechavencimiento
         )
        {
            using (SCXSAMBOYEntities BD = new SCXSAMBOYEntities())
            {
                BD.FACTURASSAMBOY.Add(new FACTURASSAMBOY
                {
                    NUMEROFACTURA = numerofactura,
                    CODIGO = codigoproveedor,
                    VALORFACTURA = valorfactura,
                    FECHAFACTURA = fechafactura,
                    FECHAVENCIMIENTO = fechavencimiento,
                });
                BD.SaveChanges();
            }
        }

        public static void MODIFICARFACTURA
        (
            int numerofactura,
            string codigoproveedor,
            decimal valorfactura,
            DateTime fechafactura,
            DateTime fechavencimiento
        )
        {
            using (SCXSAMBOYEntities BD = new SCXSAMBOYEntities())
            {
                var MODIFICAR = (from F in BD.FACTURASSAMBOY
                                 where F.NUMEROFACTURA == numerofactura
                                 select F).Single();
                MODIFICAR.NUMEROFACTURA = numerofactura;
                MODIFICAR.CODIGO = codigoproveedor;
                MODIFICAR.VALORFACTURA = valorfactura;
                MODIFICAR.FECHAFACTURA = fechafactura;
                MODIFICAR.FECHAVENCIMIENTO = fechavencimiento;
                BD.SaveChanges();
            }
        }
        public static void ELIMINARFACTURA(int numerofactura)
        {
            using (SCXSAMBOYEntities BD = new SCXSAMBOYEntities())
            {
                var ELIMINA = (from F in BD.FACTURASSAMBOY
                               where F.NUMEROFACTURA == numerofactura
                               select F).Single();
                BD.FACTURASSAMBOY.Remove(ELIMINA);
                BD.SaveChanges();
            }
        }

        public static FACTURASSAMBOY CARGAR(int numerofactura)
        {
            FACTURASSAMBOY fact = new FACTURASSAMBOY();
            using (SCXSAMBOYEntities BD = new SCXSAMBOYEntities())
            {
                var INFO = (from F in BD.FACTURASSAMBOY
                            where F.NUMEROFACTURA == numerofactura
                            select F).Single();
                fact.NUMEROFACTURA = INFO.NUMEROFACTURA;
                fact.CODIGO = INFO.CODIGO;
                fact.VALORFACTURA = INFO.VALORFACTURA;
                fact.FECHAFACTURA = INFO.FECHAFACTURA;
                fact.FECHAVENCIMIENTO = INFO.FECHAVENCIMIENTO;
                return fact;
            }
        }
    }
}