using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.ProveedorVista
{
    public partial class ProveedorEditarVista : Form
    {
        int idx = 0;
        Proveedor p = new Proveedor();
        ProveedorBss bss = new ProveedorBss();
        public ProveedorEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void ProveedorEditarVista_Load(object sender, EventArgs e)
        {
            p = bss.ObtenerIdBss(idx);
            textBox1.Text = p.Nombre;
            textBox2.Text = p.Telefono;
            textBox3.Text = p.Direccion;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p.Nombre = textBox1.Text;

            bss.EditarProveedorBss(p);
            MessageBox.Show("Datos actualizados");
        }
    }
}
