using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        #region Atributos
        protected int codigo;
        protected int cantidad;
        protected double precioPorUnidad;
        protected double precioTotalComprado;
        protected string descripcion;
        protected ECategoria categoria;
        #endregion


        #region Enum y Propiedades

        public enum ECategoria
        {
            Comida, Bebida, Kiosko
        }

        public int Codigo
        {
            get
            {
                return this.codigo;
            }
        }

        public string Descripcion
        {
            get
            {
                return this.descripcion;
            }
            set
            {
                this.descripcion = value;
            }
        }

        public int Cantidad
        {
            get
            {
                return this.cantidad;
            }
            set
            {
                if (value >= 0)
                    this.cantidad = value;
                else
                {
                    this.cantidad = 0;
                }
            }
        }

        public double Precio
        {
            get
            {
                return this.precioPorUnidad;
            }
            set
            {
                this.precioPorUnidad = value;
            }
        }

        public ECategoria Categoria
        {
            get
            {
                return this.categoria;
            }
            set
            {
                this.categoria = value;
            }
        }

        public string PrecioString
        {
            get
            {
                return string.Format($"${this.precioPorUnidad}");
            }
        }

        public double PrecioTotalComprado
        {
            get
            {
                return this.precioTotalComprado;
            }
        }

        public string PrecioTotalCompradoString
        {
            get
            {
                return string.Format($"${this.precioTotalComprado}");
            }
        }
        #endregion


        #region Constructores
        public Producto(int codigo, string descripcion, double precioUnidad, ECategoria categoria)
        {
            this.codigo = codigo;
            this.descripcion = descripcion;
            this.precioPorUnidad = precioUnidad;
            this.categoria = categoria;
            this.cantidad = 0;
            this.precioTotalComprado = 0;
        }

        public Producto(int codigo, string descripcion, double precioUnidad, ECategoria categoria, int cantidad)
            : this(codigo, descripcion, precioUnidad, categoria)
        {
            this.cantidad = cantidad;
        }
        #endregion


        #region Metodos
        public void ActualizarPrecioTotal()
        {
            this.precioTotalComprado = this.cantidad * this.precioPorUnidad;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Codigo: {this.codigo}");
            sb.AppendLine($"Decripcion: {this.descripcion}");
            sb.AppendLine($"Precio Unit.: {this.PrecioString}");
            sb.AppendLine($"Cantidad: {this.cantidad} unid.");
            sb.AppendLine($"Categoria: {this.categoria}");
            sb.AppendLine("==========================");

            return sb.ToString();

        }
        #endregion


        #region Sobrecargas
        public static bool operator ==(Producto p1, Producto p2)
        {
            return p1.codigo == p2.codigo;
        }

        public static bool operator !=(Producto p1, Producto p2)
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
