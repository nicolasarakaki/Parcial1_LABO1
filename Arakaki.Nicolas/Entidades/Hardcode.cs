using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Hardcode
    {
        public static string Harcodear()
        {
            Inventario inventario = Comercio.Inventario;

            #region Productos
            Producto producto1 = new Producto(1001, "HotDog", 80, Producto.ECategoria.Comida, 20);
            Producto producto2 = new Producto(1002, "Donut", 55, Producto.ECategoria.Comida, 60);
            Producto producto3 = new Producto(1003, "Duff", 50, Producto.ECategoria.Bebida, 150);
            Producto producto4 = new Producto(1004, "Cerveza X", 60, Producto.ECategoria.Bebida, 5);
            Producto producto5 = new Producto(1005, "Cigarrillo", 20, Producto.ECategoria.Kiosko, 60);
            Producto producto6 = new Producto(1006, "Chicle", 20, Producto.ECategoria.Kiosko, 120);
            Producto producto7 = new Producto(1007, "Hamburguesa", 100, Producto.ECategoria.Comida, 20);
            Producto producto8 = new Producto(1008, "Papa Frita", 20, Producto.ECategoria.Kiosko, 200);
            Producto producto9 = new Producto(1009, "Cereales Krusty", 20, Producto.ECategoria.Kiosko, 200);
            Producto producto10 = new Producto(1010, "Buzz Cola", 60, Producto.ECategoria.Bebida, 300);
            Producto producto11 = new Producto(1011, "Barrita de Chocolate", 40, Producto.ECategoria.Kiosko, 100);
            Producto producto12 = new Producto(1012, "Pastel Lunar", 70, Producto.ECategoria.Comida, 50);
            Producto producto13 = new Producto(1013, "Batido Squishee", 70, Producto.ECategoria.Bebida, 70);
            Producto producto14 = new Producto(1014, "Galleta X", 40, Producto.ECategoria.Kiosko, 250);
            Producto producto15 = new Producto(1015, "Caramelo", 15, Producto.ECategoria.Kiosko, 400);              

            inventario += producto1;
            inventario += producto2;
            inventario += producto3;
            inventario += producto4;
            inventario += producto5;
            inventario += producto6;
            inventario += producto7;
            inventario += producto8;
            inventario += producto9;
            inventario += producto10;
            inventario += producto11;
            inventario += producto12;
            inventario += producto13;
            inventario += producto14;
            inventario += producto15;
            #endregion

            #region Empleados
            Empleado empleado1 = new Empleado("Sebastian", "Sanchez", 654987, "seba", "1234");
            Empleado empleado2 = new Empleado("Nicolas", "Arakaki", 987654, "nico", "1234");
            Comercio.AgregarEmpleado(empleado1);
            Comercio.AgregarEmpleado(empleado2);
            Login.RecargarCuentas();
            #endregion

            #region Clientes
            Cliente cliente1 = new Cliente("Pepe", "Peposo", 111111);
            Cliente cliente2 = new Cliente("Jose", "Juan", 222222);
            Cliente cliente3 = new Cliente("Homero", "Simpson", 333333, true);
            Comercio.AgregarCliente(cliente1);
            Comercio.AgregarCliente(cliente2);
            Comercio.AgregarCliente(cliente3);
            #endregion

            #region Compras
            Compra compra1 = new Compra(cliente1.NombreCompleto);
            Compra compra2 = new Compra(cliente2.NombreCompleto);
            Compra compra3 = new Compra(cliente3.NombreCompleto);
            Compra compra4 = new Compra(cliente1.NombreCompleto);
            Compra compra5 = new Compra(cliente2.NombreCompleto);
            Compra compra6 = new Compra(cliente3.NombreCompleto);
            Compra compra7 = new Compra(cliente2.NombreCompleto);
            Compra compra8 = new Compra(cliente1.NombreCompleto);
            Compra compra9 = new Compra(cliente3.NombreCompleto);
            Compra compra10 = new Compra(cliente2.NombreCompleto);

            compra1 += new Producto(1001, "Pancho", 60, Producto.ECategoria.Comida, 3);
            compra2 += new Producto(1002, "Donut", 55, Producto.ECategoria.Comida, 5);
            compra3 += new Producto(1003, "Duff", 50, Producto.ECategoria.Bebida, 4);
            compra4 += new Producto(1004, "CervezaX", 40, Producto.ECategoria.Bebida, 5);
            compra5 += new Producto(1005, "Cigarrillo", 20, Producto.ECategoria.Kiosko, 8);
            compra6 += new Producto(1009, "Cereales Krusty", 20, Producto.ECategoria.Kiosko, 3);
            compra7 += new Producto(1010, "Buzz Cola", 60, Producto.ECategoria.Bebida, 300);
            compra8 += new Producto(1011, "Barrita de Chocolate", 40, Producto.ECategoria.Kiosko, 10);
            compra9 += new Producto(1012, "Pastel Lunar", 70, Producto.ECategoria.Comida, 4);
            compra10 += new Producto(1013, "Batido Squishee", 70, Producto.ECategoria.Bebida, 1);
            compra10 += new Producto(1014, "Galleta X", 40, Producto.ECategoria.Kiosko, 5);
            compra10 += new Producto(1015, "Caramelo", 15, Producto.ECategoria.Kiosko, 15); 
            #endregion   
                                       
            #region Compras agregadas a Empleados
            empleado1 += compra1;
            empleado1 += compra2;
            empleado2 += compra3;
            empleado2 += compra4;
            empleado2 += compra5;
            empleado1 += compra6;
            empleado2 += compra7;
            empleado1 += compra8;
            empleado2 += compra9;
            empleado1 += compra10;
            #endregion


            StringBuilder sb = new StringBuilder();
            sb.AppendLine("==========================");
            sb.AppendLine("Se han agregado:\n");
            sb.AppendLine($"{Comercio.Inventario.ListaProductos.Count} Productos");
            sb.AppendLine($"{Comercio.ListaEmpleados.Count - 1} Empleados");
            sb.AppendLine($"{Comercio.ListaClientes.Count} Clientes");
            sb.AppendLine($"{Comercio.ListaCompras.Count} Compras");
            sb.AppendLine("==========================");

            return sb.ToString();
        }
    }
}
