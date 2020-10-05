using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Inventario
    {
        #region Atributos
        private static Inventario instancia;
        private static List<Producto> listaProductos;
        #endregion


        #region Propiedades
        public static Inventario NuevaInstancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new Inventario();
                }

                return instancia;
            }
        }

        public List<Producto> ListaProductos
        {
            get
            {
                return listaProductos;
            }
        }

        public Producto this[string nomProducto]
        {
            get
            {
                return this.ObtenerProducto(nomProducto);
            }
        }

        public Producto this[int codProducto]
        {
            get
            {
                return this.ObtenerProducto(codProducto);
            }
        }
        #endregion


        #region Constructores
        protected Inventario()
        {
            listaProductos = new List<Producto>();
        }

        #endregion


        #region Metodos
        public string MostrarStockMenos10()
        {
            StringBuilder sb = new StringBuilder();
            bool flag = false;

            if (listaProductos.Count == 0)
            {
                sb.AppendLine("NO HAY PRODUCTOS CARGADOS");
            }
            else
            {
                foreach (Producto producto in listaProductos)
                {
                    if (producto.Cantidad <= 10)
                    {
                        sb.AppendLine($"{producto.ToString()}");
                        flag = true;
                    }
                }

                if (!flag)
                {
                    sb.AppendLine("NO HAY PRODUCTOS CON MENOS DE 10 UNID.");
                }
            }

            return sb.ToString();
        }

        public string MostrarStock()
        {
            StringBuilder sb = new StringBuilder();

            if (listaProductos.Count == 0)
            {
                sb.AppendLine("NO HAY PRODUCTOS CARGADOS");
            }
            foreach (Producto producto in listaProductos)
            {
                sb.AppendLine($"{producto.ToString()}");
            }

            return sb.ToString();
        }

        private Producto ObtenerProducto(string nombreProducto)
        {
            foreach (Producto producto in this.ListaProductos)
            {
                if (producto.Descripcion.ToLower() == nombreProducto.ToLower())
                {
                    return producto;
                }
            }

            return null;

        }
        private Producto ObtenerProducto(int codProducto)
        {
            foreach (Producto producto in this.ListaProductos)
            {
                if (producto.Codigo == codProducto)
                {
                    return producto;
                }
            }

            return null;

        }
        #endregion


        #region Sobrecargas
        public static Inventario operator +(Inventario i, Producto p)
        {
            foreach (Producto producto in i.ListaProductos)
            {
                if (p == producto)
                {
                    return i;
                }
            }

            i.ListaProductos.Add(p);
            return i;

        }

        public static Inventario operator -(Inventario i, Producto p)
        {
            foreach (Producto producto in i.ListaProductos)
            {
                if (p == producto)
                {
                    i.ListaProductos.Remove(producto);
                    return i;
                }
            }

            return i;

        }
        #endregion

    }
}
