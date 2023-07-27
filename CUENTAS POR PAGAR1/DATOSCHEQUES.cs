using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace CUENTAS_POR_PAGAR1
{
    internal class DATOSCHEQUES
    {
        public static List<CHEQUESSAMBOY> MOSTRARCHEQUES()
        {
            //ESTA ES UNA INSTANCIA DE NUESTRO MODELO DE LA BASE DE DATOS
            using (SCXSAMBOYEntities BD = new SCXSAMBOYEntities())
            {
                //MUESTRA TODOS LAS CHEQUES
                var INFO = (from C in BD.CHEQUESSAMBOY
                            select C).ToList();
                return INFO;
            }
        }
        public static List<CHEQUESSAMBOY> BUSCARELNUMERO(int numerocheque)
        {
            using (SCXSAMBOYEntities BD = new SCXSAMBOYEntities())
            {
                //USAMOS LINQ. PARA BUSCAR UN CHEQUE POR EL NÚMERO
                var INFO = (from C in BD.CHEQUESSAMBOY
                            where C.NUMEROCHEQUE == numerocheque
                            select C).ToList();
                /*StartsWith HACE QUE VAYA MOSTRANDO LOS CHEQUES QUE
                EMPIEZEN CON EL NÚMERO QUE VAMOS ESCRIBIENDO*/
                return INFO;
            }
        }
        //ESTE MÉTODO BUSCA LOS CHEQUES DE UNA FACTURA POR EL NÚMERO DE LA FACTURA
        public static List<CHEQUESSAMBOY> BUSCARNUMERO_FACTURA(int NUMEROFACTURA)
        {
            using (SCXSAMBOYEntities BD = new SCXSAMBOYEntities())
            {
                //USAMOS LINQ. PARA BUSCAR CHEQUES POR EL NUMERO_FACTURA
                var INFO = (from C in BD.CHEQUESSAMBOY
                            where C.NUMEROFACTURA == NUMEROFACTURA
                            select C).ToList();
                /*StartsWith HACE QUE VAYA MOSTRANDO LOS CHEQUES HECHOS A LAS FACTURAS
                * QUE EMPIEZEN CON EL NÚMERO QUE VAMOS ESCRIBIENDO*/
                return INFO;
            }
        }

        //EL SIGUIENTE MÉTODO AÑADE UN NUEVO REGISTRO
        public static void INSERTARCHEQUE
        (
        int numerocheque,
        int numerofactura,
        decimal valorcheque,
        DateTime fechacheque
        )
        {
            using (SCXSAMBOYEntities BD = new SCXSAMBOYEntities())
            {
                /*PARA INSERTAR UN NUEVO OBJETO O CHEQUE ASIGNANDO LOS VALORES DE LOS
                PARÁMETROS A LOS CAMPOS DE LA TABLA.*/
                BD.CHEQUESSAMBOY.Add(new CHEQUESSAMBOY
                {
                    NUMEROCHEQUE = numerocheque,
                    NUMEROFACTURA = numerofactura,
                    VALORCHEQUE = valorcheque,
                    FECHACHEQUE = fechacheque
                });
                BD.SaveChanges();
            }
        }

        //EL SIGUIENTE MÉTODO MODIFICA UN REGISTRO
        public static void MODIFICARCHEQUE
        (
        int numerocheque,
        int numerofactura,
        decimal valorcheque,
        DateTime fechacheque
        )
        {
            using (SCXSAMBOYEntities BD = new SCXSAMBOYEntities())
            {
                var MODIFICAR = (from F in BD.CHEQUESSAMBOY
                                 where F.NUMEROCHEQUE == numerocheque
                                 select F).Single();
                MODIFICAR.NUMEROCHEQUE = numerocheque;
                MODIFICAR.NUMEROFACTURA = numerofactura;
                MODIFICAR.VALORCHEQUE = valorcheque;
                MODIFICAR.FECHACHEQUE = fechacheque;
                BD.SaveChanges();
            }
        }
        public static void ELIMINARCHEQUE(int numerocheque)
        {
            using (SCXSAMBOYEntities BD = new SCXSAMBOYEntities())
            {
                var ELIMINA = (from F in BD.CHEQUESSAMBOY
                               where F.NUMEROCHEQUE == numerocheque
                               select F).Single();
                BD.CHEQUESSAMBOY.Remove(ELIMINA);
                BD.SaveChanges();
            }
        }
        public static CHEQUESSAMBOY CARGAR(int numerocheque)
        {
            CHEQUESSAMBOY CHEQUES = new CHEQUESSAMBOY();
            using (SCXSAMBOYEntities BD = new SCXSAMBOYEntities())
            {
                var INFO = (from F in BD.CHEQUESSAMBOY
                            where F.NUMEROCHEQUE == numerocheque
                            select F).Single();
                CHEQUES.NUMEROCHEQUE = INFO.NUMEROCHEQUE;
                CHEQUES.NUMEROFACTURA = INFO.NUMEROFACTURA;
                CHEQUES.VALORCHEQUE = INFO.VALORCHEQUE;
                CHEQUES.FECHACHEQUE = INFO.FECHACHEQUE;

                return CHEQUES;
            }
        }
    }
}
