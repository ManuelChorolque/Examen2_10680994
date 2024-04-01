using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemasVentas.VISTA.MarcaVista;
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

namespace SistemasVentas.VISTA.ProductoVista
{
    public partial class ProductoInsertarVista : Form
    {
        public ProductoInsertarVista()
        {
            InitializeComponent();
        }
        public static int IdTipoProdSeleccionado = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            TipoProdBss bss = new TipoProdBss();
            TipoProdListarVista fr = new TipoProdListarVista();

            if (fr.ShowDialog() == DialogResult.OK)
            {
                TipoProd tipoProd = bss.ObtenerIdBss(IdTipoProdSeleccionado);
                textBox1.Text = tipoProd.Nombre;
            }
        }
        public static int IdMarcaSeleccionado = 0;
        private void button4_Click(object sender, EventArgs e)
        {
            MarcaBss bss = new MarcaBss();
            MarcaListarVista fr = new MarcaListarVista();

            if (fr.ShowDialog() == DialogResult.OK)
            {
                Marca marca = bss.ObtenerIdBss(IdMarcaSeleccionado);
                textBox2.Text = marca.Nombre;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ProductoBss bss = new ProductoBss();
            Producto p = new Producto();
            p.IdTipoProd = IdTipoProdSeleccionado;
            p.IdMarca = IdMarcaSeleccionado;
            p.Nombre = textBox3.Text;
            p.CodigoBarra = textBox4.Text;
            p.Unidad = Convert.ToInt32(textBox5.Text);
            p.Descripcion = textBox6.Text;

            bss.InsertarProductoBss(p);
            MessageBox.Show("se guardo correctamente producto");
        }
       
    }
}
