using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Compra
    {
        #region Atributos
        protected List<Producto> listaProductosDeCompra;
        protected int idCompra;
        protected static int contadorId;
        protected string nombreClienteCompra;
        #endregion


        #region Propiedades e Indexadores
        public int IdCompra
        {
            get
            {
                return this.idCompra;
            }
        }

        public List<Producto> ListaProductos
        {
            get
            {
                return this.listaProductosDeCompra;
            }
        }

        public string NombreClienteCompra
        {
            get
            {
                return this.nombreClienteCompra;
            }
            set
            {
                this.nombreClienteCompra = value;
            }
        }

        public Producto this[string nomProducto]
        {
            get
            {
                return this.ObtenerProducto(nomProducto);
            }
        }
        #endregion


        #region Constructores
        public Compra()
        {
            this.nombreClienteCompra = string.Empty;
            listaProductosDeCompra = new List<Producto>();
            IncrementarId();
            this.idCompra = contadorId;
        }

        public Compra(string nombreCliente) : this()
        {
            this.nombreClienteCompra = nombreCliente;
        }

        #endregion


        #region Metodos

        private void IncrementarId()
        {
            contadorId++;
        }

        public static void DesincrementarID()
        {
            contadorId--;
        }

        private Producto ObtenerProducto(string nombreProducto)
        {
            foreach (Producto producto in this.listaProductosDeCompra)
            {
                if (producto.Descripcion.ToLower() == nombreProducto.ToLower())
                {
                    return producto;
                }
            }

            return null;

        }

        private double ObtenerTotalPrecioCompra()
        {
            double total = 0;
            foreach (Producto producto in listaProductosDeCompra)
            {
                total += producto.PrecioTotalComprado;
            }

            return total;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"ID de Compra: {this.idCompra}");
            sb.AppendLine($"Cliente: {this.nombreClienteCompra}");
            sb.AppendLine($"Total de la compra: ${this.ObtenerTotalPrecioCompra()}");

            return sb.ToString();
        }

        #endregion


        #region Sobrecargas

        public static bool operator ==(Compra c, Producto p)
        {
            bool retorno = false;

            if (!object.Equals(p, null))
            {
                foreach (Producto auxProducto in c.listaProductosDeCompra)
                {
                    if (auxProducto.Codigo == p.Codigo)
                    {
                        retorno = true;
                        break;
                    }
                }
            }

            return retorno;
        }

        public static bool operator !=(Compra c, Producto p)
        {
            return !(c == p);
        }

        public static Compra operator +(Compra c, Producto p)
        {
            if (!object.Equals(p, null))
            {
                if (c != p)
                {
                    c.listaProductosDeCompra.Add(p);
                }
                else
                {
                    c[p.Descripcion].Cantidad += p.Cantidad;
                }
                c[p.Descripcion].ActualizarPrecioTotal();
            }

            return c;
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
