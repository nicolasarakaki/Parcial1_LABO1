using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente : Persona
    {
        #region Atributos

        private bool esClienteVip;

        #endregion


        #region Propiedades
        public bool EsVip
        {
            get
            {
                return this.esClienteVip;
            }
            set
            {
                this.esClienteVip = value;
            }
        }

        #endregion


        #region Constructores
        public Cliente(string nombre, string apellido, int dni) : base(nombre, apellido, dni)
        {
            this.esClienteVip = false;
        }

        public Cliente(string nombre, string apellido, int dni, bool clienteVip) : this(nombre, apellido, dni)
        {
            this.esClienteVip = clienteVip;
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
            string esVip;

            if (this.esClienteVip)
            {
                esVip = "Si";
            }
            else
            {
                esVip = "No";
            }

            sb.AppendLine("CLIENTE:");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Es VIP?: {esVip}");
            sb.AppendLine("==========================");

            return sb.ToString();
        }
        #endregion

    }
}
