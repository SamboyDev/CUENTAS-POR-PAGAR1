using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace CUENTAS_POR_PAGAR1
{

    internal class DATOSPROVEEDORES
    {
        public static List<PROVEEDORESSAMBOY> MOSTRARDATOS()
        {
            //ESTA ES UNA INSTANCIA DE NUESTRO MODELO DE LA BASE DE DATOS
            using (SCXSAMBOYEntities BD = new SCXSAMBOYEntities())
            {
                var INFO = (from P in BD.PROVEEDORESSAMBOY
                            select P).ToList();
                return INFO;
            }
        }
        public static List<PROVEEDORESSAMBOY> BUSCARPORCODIGO(string codigo)
        {
            using (SCXSAMBOYEntities BD = new SCXSAMBOYEntities())
            {
                /*USAMOS LINQ. PARA BUSCAR UN PROVEEDOR POR LA DIRECCIÓN
                EMPEZANDO CON CUALQUIER LETRA*/
                var INFO = (from P in BD.PROVEEDORESSAMBOY
                            where P.CODIGO.StartsWith(codigo)
                            select P).ToList();
                /*StartsWith HACE QUE VAYA MOSTRANDO LOS PROVEEDORES QUE
                EMPIEZEN CON LAS LETRAS QUE VAMOS ESCRIBIENDO*/
                return INFO;
            }
        }
        public static List<PROVEEDORESSAMBOY> BUSCARNOMBRES(string nombres)
        {
            using (SCXSAMBOYEntities BD = new SCXSAMBOYEntities())
            {
                var INFO = (from P in BD.PROVEEDORESSAMBOY
                            where P.NOMBRES.StartsWith(nombres)
                            select P).ToList();
                return INFO;
            }
        }
        public static List<PROVEEDORESSAMBOY> BUSCARPORAPELLIDOS(string apellidos)
        {
            using (SCXSAMBOYEntities BD = new SCXSAMBOYEntities())
            {
                var INFO = (from P in BD.PROVEEDORESSAMBOY
                            where P.APELLIDOS.StartsWith(apellidos)
                            select P).ToList();
                return INFO;
            }
        }
        public static List<PROVEEDORESSAMBOY> BUSCARPORDIRECCION(string direccion)
        {
            using (SCXSAMBOYEntities BD = new SCXSAMBOYEntities())
            {
                var INFO = (from P in BD.PROVEEDORESSAMBOY
                            where P.DIRECCION.StartsWith(direccion)
                            select P).ToList();
                return INFO;
            }
        }
        public static List<PROVEEDORESSAMBOY> BUSCARPORCIUDAD(string ciudad)
        {
            using (SCXSAMBOYEntities BD = new SCXSAMBOYEntities())
            {
                var INFO = (from P in BD.PROVEEDORESSAMBOY
                            where P.CIUDAD.StartsWith(ciudad)
                            select P).ToList();
                return INFO;
            }
        }
        public static List<PROVEEDORESSAMBOY> BUSCARPORTELEFONO(string telefono)
        {
            using (SCXSAMBOYEntities BD = new SCXSAMBOYEntities())
            {
                var INFO = (from P in BD.PROVEEDORESSAMBOY
                            where P.TELEFONO.StartsWith(telefono)
                            select P).ToList();
                return INFO;
            }
        }

        public static void INSERTARPROVEEDOR
                (
                string codigo,
                string nombres,
                string apellidos,
                string direccion,
                string ciudad,
                string telefono
                )
        {
            using (SCXSAMBOYEntities BD = new SCXSAMBOYEntities())
            {
                BD.PROVEEDORESSAMBOY.Add(new PROVEEDORESSAMBOY
                {
                    CODIGO = codigo,
                    NOMBRES = nombres,
                    APELLIDOS = apellidos,
                    DIRECCION = direccion,
                    CIUDAD = ciudad,
                    TELEFONO = telefono
                }) ;
                BD.SaveChanges();
            }
        }

        public static void MODIFICARPEOVEEDOR
            (
            string codigo,
            string nombres,
            string apellidos,
            string direccion,
            string ciudad,
            string telefono
            )
        {
            using (SCXSAMBOYEntities BD = new SCXSAMBOYEntities())
            {
                var MODIFICAR = (from P in BD.PROVEEDORESSAMBOY
                                 where P.CODIGO == codigo
                                 select P).Single();
                MODIFICAR.CODIGO = codigo;
                MODIFICAR.NOMBRES = nombres;
                MODIFICAR.APELLIDOS = apellidos;
                MODIFICAR.DIRECCION = direccion;
                MODIFICAR.CIUDAD = ciudad;
                MODIFICAR.TELEFONO = telefono;

                BD.SaveChanges();
            }
        }
        public static void ELIMINARPROVEEDOR(string codigo)
        {
            using (SCXSAMBOYEntities BD = new SCXSAMBOYEntities())
            {
                var eLIMINA = (from P in BD.PROVEEDORESSAMBOY
                               where P.CODIGO == codigo
                               select P).Single();
                BD.PROVEEDORESSAMBOY.Remove(eLIMINA);
                BD.SaveChanges();
            }
        }
    }
}
