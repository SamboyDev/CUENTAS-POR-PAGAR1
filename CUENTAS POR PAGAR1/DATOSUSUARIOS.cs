using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace CUENTAS_POR_PAGAR1
{
    internal class DATOSUSUARIOS
    {
        public static List<USUARIOSSAMBOY> MOSTRAR()
        {

            using (SCXSAMBOYEntities BD = new SCXSAMBOYEntities())
            {
                var INFO = (from U in BD.USUARIOSSAMBOY
                            select U).ToList();
                return INFO;
            }
        }
        public static List<USUARIOSSAMBOY> BUSCARPORUSUARIO(string usuario)
        {
            /*USAMOS LINQ. PARA BUSCAR UN USUARIO POR EL NOMBRE
            EMPEZANDO CON CUALQUIER LETRA*/
            using (SCXSAMBOYEntities BD = new SCXSAMBOYEntities())
            {
                var INFO = (from U in BD.USUARIOSSAMBOY
                            where U.USUARIO.StartsWith(usuario)
                            select U).ToList();
                return INFO;
            }
        }
        public static List<USUARIOSSAMBOY> BUSCARPORCLAVE(string clave)
        {
            /*USAMOS LINQ. PARA BUSCAR UN USUARIO POR EL NOMBRE
            EMPEZANDO CON CUALQUIER LETRA*/
            using (SCXSAMBOYEntities BD = new SCXSAMBOYEntities())
            {
                var INFO = (from U in BD.USUARIOSSAMBOY
                            where U.CLAVE.StartsWith(clave)
                            select U).ToList();
                return INFO;
            }
        }
    }
}
