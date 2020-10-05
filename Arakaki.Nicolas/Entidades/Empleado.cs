using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado : Persona
    {
        #region Atributos
        protected List<Compra> listaCompras;
        protected string usuario;
        protected string pass;
        #endregion


        #region Propiedades
        public List<Compra> ListaCompras
        {
            get
            {
                return this.listaCompras;
            }
        }

        public string Usuario
        {
            get
            {
                return this.usuario;
            }
        }

        public string Pass
        {
            get
            {
                return this.pass;
            }
        }
        #endregion


        #region Constructores
        public Empleado(string nombre, string apellido, int dni, string usuario, string pass)
            : base(nombre, apellido, dni)
        {
            this.usuario = usuario;
            this.pass = pass;
            this.listaCompras = new List<Compra>();
        }

        #endregion


        #region Metodos
        public override string ToString()
        {
            return this.Mostrar();
        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("EMPLEADO:");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Nombre de Usuario: {this.usuario}");
            sb.AppendLine($"Cant. de ventas realizadas: {this.listaCompras.Count}");
            sb.AppendLine("==========================");

            return sb.ToString();
        }
        #endregion


        #region Sobrecargas

        public static Empleado operator +(Empleado e, Compra c)
        {
            if (e != c)
            {
                e.ListaCompras.Add(c);
                return e;
            }
            else
            {
                return e;
            }
        }

        public static bool operator ==(Empleado e, Compra c)
        {
            bool retorno = false;

            foreach (Compra compra in e.listaCompras)
            {
                if (compra.IdCompra == c.IdCompra)
                {
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }

        public static bool operator !=(Empleado e, Compra c)
        {
            return !(e == c);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        #endregion

    }
}
