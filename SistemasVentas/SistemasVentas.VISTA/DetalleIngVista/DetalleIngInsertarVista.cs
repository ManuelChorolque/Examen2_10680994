using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemasVentas.VISTA.IngresoVista;
using SistemasVentas.VISTA.ProductoVista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.DetalleIngVista
{
    public partial class DetalleIngInsertarVista : Form
    {
        public DetalleIngInsertarVista()
        {
            InitializeComponent();
        }

        public static int IdProductoSeleccionado = 0;
        private void button4_Click(object sender, EventArgs e)
        {
            ProductoBss bss = new ProductoBss();
            ProductoListarVista fr = new ProductoListarVista();

            if (fr.ShowDialog() == DialogResult.OK)
            {
                Producto producto = bss.ObtenerIdBss(IdProductoSeleccionado);
                textBox2.Text = producto.Nombre;
            }
        }

        public static int IdIngresoSeleccionado = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            IngresoBss bss = new IngresoBss();
            IngresoListarVista fr = new IngresoListarVista();

            if (fr.ShowDialog() == DialogResult.OK)
            {
                Ingreso ingreso = bss.ObtenerIdBss(IdIngresoSeleccionado);
                textBox1.Text = ingreso.FechaIngreso.ToString();
            }
        }
         
        private void button1_Click(object sender, EventArgs e)
        {
            DetalleIngBss bss = new DetalleIngBss();
            DetalleIng di = new DetalleIng();
            di.IdIngreso = Convert.ToInt32(textBox1.Text);
            di.IdProducto = Convert.ToInt32(textBox2.Text);
            di.FechaVenc = dateTimePicker1.Value;
            di.Cantidad = Convert.ToInt32(textBox4.Text);
            di.PrecioCosto = Convert.ToDecimal(textBox5.Text);
            di.PrecioVenta = Convert.ToDecimal(textBox6.Text);
            di.Subtotal = Convert.ToDecimal(textBox7.Text);

            bss.InsertarDetalleIngBss(di);
            MessageBox.Show("se guardo correctamente DetalleIng");
        }
       
    }
}
