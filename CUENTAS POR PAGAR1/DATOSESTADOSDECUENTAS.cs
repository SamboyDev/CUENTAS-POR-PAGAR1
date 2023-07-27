using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace CUENTAS_POR_PAGAR1
{
    internal class DATOSESTADOSDECUENTAS
    {
        //ESTE ES EL MÉTODO QUE SE LLAMA MOSTRARFACTURAS
        public static List<ESTADODECUENTAS> MOSTRARESTADO()
        {
            //ESTA ES UNA INSTANCIA DE NUESTRO MODELO DE LA BASE DE DATOS
            using (SCXSAMBOYEntities BD = new SCXSAMBOYEntities())
            {
                //USAMOS LINQ. PARA QUE NOS MUESTRE TODAS LAS FACTURAS EXISTENTES
                var INFO = (from E in BD.ESTADODECUENTAS
                            select E).ToList();
                return INFO;
            }
        }
        public static List<ESTADODECUENTAS> BUSCARPORNUMEROFACTURA(int numerofactura)
        {
            using (SCXSAMBOYEntities BD = new SCXSAMBOYEntities())
            {
                var INFO = (from E in BD.ESTADODECUENTAS
                            where E.NUMEROFACTURA == numerofactura
                            select E).ToList();
                return INFO;
            }
        }
        //ESTE ES EL MÉTODO QUE SE LLAMA BUSCARPORCODIGO
        public static List<ESTADODECUENTAS> BUSCARPORCOIGO(string codigo)
        {
            /*USAMOS LINQ. PARA BUSCAR UN USUARIO POR EL
            * CÓDIGO DEL PROVEEDOR EMPEZANDO CON CUALQUIER LETRA*/
            using (SCXSAMBOYEntities BD = new SCXSAMBOYEntities())
            {
                var INFO = (from E in BD.ESTADODECUENTAS
                            where E.CODIGO == codigo
                            select E).ToList();
                return INFO;
            }
        }

    }
}
