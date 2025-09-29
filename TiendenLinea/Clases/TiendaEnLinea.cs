using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendenLinea.Clases
{
    class TiendaEnLinea
    {
       private string nombre;
        private int precio;
        private int cantidadDisponible;


        public TiendaEnLinea(string nombre, int precio, int cantidadDisponible)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.cantidadDisponible = cantidadDisponible;
        }   


        public string GetProductos()
        {
            return nombre;
        }
        public void setProductoDisponible(int cantidad)
        {
            cantidadDisponible += cantidad;  
        }
        public void setVenderProducto(int cantidad)
        {
            cantidadDisponible -= cantidad;
        }


    }
}
