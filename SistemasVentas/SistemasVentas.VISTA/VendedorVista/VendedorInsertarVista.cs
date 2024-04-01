using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemasVentas.VISTA.TipoProdVista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.VendedorVista
{
    public partial class VendedorInsertarVista : Form
    {
        public VendedorInsertarVista()
        {
            InitializeComponent();
        }
        public static int IdClienteSeleccionado = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            PersonaBss bss = new PersonaBss();
            VendedorClienteListarVista fr = new VendedorClienteListarVista();

            if (fr.ShowDialog() == DialogResult.OK)
            {
                Persona persona = bss.ObtenerIdBss(IdClienteSeleccionado);
                textBox1.Text = persona.Nombre + ' ' + persona.Apellido;
            }

        }
        public static int IdProductoSeleccionado = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            ProductoBss bss = new ProductoBss();
            VendedorProductoListarVista fr = new VendedorProductoListarVista();

            if (fr.ShowDialog() == DialogResult.OK)
            {
                Producto producto = bss.ObtenerIdBss(IdProductoSeleccionado);
                textBox2.Text = producto.Nombre;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

          
        }
    }
}
