using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {

        #region Atributos

        protected string nombre;
        protected string apellido;
        protected int dni;

        #endregion


        #region Propiedades

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
        }
        public int Dni
        {
            get
            {
                return this.dni;
            }
        }

        public string NombreCompleto
        {
            get
            {
                return string.Format($"{this.nombre} {this.apellido}");
            }
        }

        #endregion


        #region Constructores

        public Persona(string nombre, string apellido, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }

        #endregion


        #region Metodos

        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Apellido: {this.apellido}");
            sb.AppendLine($"Num. DNI: {this.dni}");

            return sb.ToString();
        }

        #endregion


        #region Operadores

        public static bool operator ==(Persona p1, Persona p2)
        {
            return p1.dni == p2.dni;
        }

        public static bool operator !=(Persona p1, Persona p2)
        {
            return !(p1 == p2);
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
