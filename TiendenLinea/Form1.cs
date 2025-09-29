using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TiendenLinea.Clases;

namespace TiendenLinea
{
    public partial class Form1: Form
    {
       List<TiendaEnLinea > productos = new List<TiendaEnLinea>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            TiendaEnLinea nuevo= new TiendaEnLinea(txtNombre.Text, 
                Convert.ToInt32(txtPrecio.Text), Convert.ToInt32(txtCantidad.Text));
            productos.Add(nuevo);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < length; i++)
            //{

            //}
            //foreach (var item in collection)
            //{

            //}
           lblMostrar.Text= productos[0].GetProductos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            productos[0].setProductoDisponible(Convert.ToInt32(txtCantidadModificar.Text));  
        }
    }
}
