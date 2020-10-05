using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Comercio
    {
        #region Atributos
        private static List<Persona> listaPersonas;
        private static Inventario inventario;
        private static string nombrePrograma;
        #endregion


        #region Propiedades

        public static Inventario Inventario
        {
            get
            {
                return inventario;
            }
        }

        public static string NombreComercio
        {
            get
            {
                return nombrePrograma;
            }
        }

        public static List<Empleado> ListaEmpleados
        {
            get
            {
                return ObtenerListaEmpleados();
            }
        }

        public static List<Cliente> ListaClientes
        {
            get
            {
                return ObtenerListaClientes();
            }
        }

        public static List<Compra> ListaCompras
        {
            get
            {
                return ObtenerListaCompras();
            }
        }
        #endregion


        #region Constructores
        static Comercio()
        {
            listaPersonas = new List<Persona>();
            nombrePrograma = "Kwik E Mart System";
            inventario = Inventario.NuevaInstancia;
            AgregarEmpleado(new Empleado("Apu", "Nahasapeemapetilon", 123456, "admin", "1234"));
        }

        #endregion


        #region Metodos
        private static List<Empleado> ObtenerListaEmpleados()
        {
            List<Empleado> auxListaEmpleados = new List<Empleado>();

            foreach (Persona persona in listaPersonas)
            {
                if (persona is Empleado)
                {
                    auxListaEmpleados.Add((Empleado)persona);
                }
            }

            return auxListaEmpleados;
        }

        private static List<Cliente> ObtenerListaClientes()
        {
            List<Cliente> auxListaClientes = new List<Cliente>();

            foreach (Persona persona in listaPersonas)
            {
                if (persona is Cliente)
                {
                    auxListaClientes.Add((Cliente)persona);
                }
            }

            return auxListaClientes;
        }

        private static List<Compra> ObtenerListaCompras()
        {
            List<Compra> auxListaCompra = new List<Compra>();
            List<Empleado> listaEmpleados = ObtenerListaEmpleados();

            foreach (Empleado empleado in listaEmpleados)
            {
                foreach (Compra compra in empleado.ListaCompras)
                {
                    auxListaCompra.Add(compra);
                }
            }

            return auxListaCompra;
        }

        public static string MostrarPersonas(string clasePersona)
        {
            StringBuilder sb = new StringBuilder();

            foreach (Persona persona in listaPersonas)
            {
                switch (clasePersona)
                {
                    case "clientes":
                        if (persona is Cliente)
                        {
                            sb.AppendLine(persona.ToString());
                        }
                        break;

                    case "empleados":
                        if (persona is Empleado)
                        {
                            sb.AppendLine(persona.ToString());
                        }
                        break;
                }
            }

            return sb.ToString();
        }

        public static string MostrarCompras()
        {
            StringBuilder sb = new StringBuilder();
            List<Empleado> listaEmpleados = ObtenerListaEmpleados();

            foreach (Empleado empleado in listaEmpleados)
            {
                sb.AppendLine($"Empleado: {empleado.NombreCompleto}\n");
                if (empleado.ListaCompras.Count == 0)
                {
                    sb.AppendLine("No generó ninguna compra\n");
                }
                else
                {
                    foreach (Compra compra in empleado.ListaCompras)
                    {
                        sb.AppendLine(compra.ToString());
                    }
                }
                sb.AppendLine("==========================");
            }

            return sb.ToString();
        }

        public static void AgregarEmpleado(Empleado empleado)
        {
            bool flag = false;

            foreach (Empleado auxEmpleado in ObtenerListaEmpleados())
            {
                if (auxEmpleado == empleado)
                {
                    flag = true;
                    break;
                }
            }

            if (!flag)
            {
                listaPersonas.Add(empleado);
            }
        }

        public static void AgregarCliente(Cliente cliente)
        {
            bool flag = false;

            foreach (Cliente auxCliente in ObtenerListaClientes())
            {
                if (auxCliente == cliente)
                {
                    flag = true;
                    break;
                }
            }

            if (!flag)
            {
                if (cliente.Apellido == "Simpson")
                {
                    cliente.EsVip = true;
                }
                listaPersonas.Add(cliente);
            }
        }

        public static Cliente BuscarCliente(string apellido)
        {
            Cliente cliente = null;

            foreach (Cliente auxCliente in ObtenerListaClientes())
            {
                if (auxCliente.Apellido == apellido)
                {
                    cliente = auxCliente;
                    break;
                }
            }

            return cliente;
        }

        public static Empleado BuscarEmpleado(string nombreApellido)
        {
            Empleado empleado = null;

            foreach (Empleado auxEmpleado in ObtenerListaEmpleados())
            {
                if (auxEmpleado.NombreCompleto == nombreApellido)
                {
                    empleado = auxEmpleado;
                    break;
                }
            }

            return empleado;
        }

        public static bool VerificarClienteVip(string apellidoCliente)
        {
            bool retorno = false;
            Cliente cliente = BuscarCliente(apellidoCliente);

            if (!object.Equals(cliente, null) && cliente.EsVip || apellidoCliente == "Simpson")
            {
                retorno = true;
            }

            return retorno;

        }

        #endregion

    }
}
