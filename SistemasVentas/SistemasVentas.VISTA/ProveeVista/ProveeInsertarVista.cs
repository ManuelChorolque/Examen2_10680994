using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemasVentas.VISTA.ProductoVista;
using SistemasVentas.VISTA.ProveedorVista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.ProveeVista
{
    public partial class ProveeInsertarVista : Form
    {
        public ProveeInsertarVista()
        {
            InitializeComponent();
        }
        public static int IdProductoSeleccionado = 0;
        private void button3_Click(object sender, EventArgs e)
        {

            ProductoBss bss = new ProductoBss();
            ProductoListarVista fr = new ProductoListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Producto producto = bss.ObtenerIdBss(IdProductoSeleccionado);
                textBox1.Text = producto.Nombre;
            }
        }
        public static int IdProveedorSeleccionado = 0;
        private void button4_Click(object sender, EventArgs e)
        {
            ProveedorBss bss = new ProveedorBss();
            ProveedorListarVista fr = new ProveedorListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Proveedor proveedor = bss.ObtenerIdBss(IdProveedorSeleccionado);
                textBox2.Text = proveedor.Nombre;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ProveeBss bss = new ProveeBss();
            Provee p = new Provee();
            p.IdProducto = IdProductoSeleccionado;
            p.IdProveedor = IdProveedorSeleccionado;
            p.Fecha = dateTimePicker1.Value;
            p.Precio = Convert.ToDecimal(textBox4.Text);

            bss.InsertarProveeBss(p);
            MessageBox.Show("se guardo correctamente provee");
        }
        
    }
}
