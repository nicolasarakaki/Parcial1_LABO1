using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Login
    {
        //private static List<Empleado> listaEmpleados;
        private static Dictionary<string, string> cuentasUsuarios;
        private static string nombreEmpleado;

        public static string NombreEmpleado
        {
            get
            {
                return nombreEmpleado;
            }
        }

        static Login()
        {
            //listaEmpleados = Comercio.ListaEmpleados;
            cuentasUsuarios = CargarCuentas(Comercio.ListaEmpleados);
        }

        public static bool Autenticar(string usuario, string pass)
        {
            bool retorno = false;

            if(cuentasUsuarios.ContainsKey(usuario) && cuentasUsuarios.ContainsValue(pass))
            {
                nombreEmpleado = ObtenerNombreEmpleado(usuario);
                retorno = true;
            }

            return retorno;

        }

        private static string ObtenerNombreEmpleado(string usuario)
        {
            string retorno = "";
            foreach (Empleado empleado in Comercio.ListaEmpleados)
            {
                if(empleado.Usuario == usuario)
                {
                    retorno = empleado.NombreCompleto;
                }
            }
            return retorno;
        }

        private static Dictionary<string, string> CargarCuentas(List<Empleado> auxListaEmpleados)
        {
            Dictionary<string, string> cuentasUsuarios = new Dictionary<string, string>();
            foreach (Empleado empleado in auxListaEmpleados)
            {
                cuentasUsuarios.Add(empleado.Usuario, empleado.Pass);
            }

            return cuentasUsuarios;
        }

        public static void RecargarCuentas()
        {
            cuentasUsuarios = CargarCuentas(Comercio.ListaEmpleados);
        }

    }
}
