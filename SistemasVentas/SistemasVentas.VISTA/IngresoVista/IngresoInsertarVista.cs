using SistemasVentas.BSS;
using SistemasVentas.Modelos;
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

namespace SistemasVentas.VISTA.IngresoVista
{
    public partial class IngresoInsertarVista : Form
    {
        public IngresoInsertarVista()
        {
            InitializeComponent();
        }

        public static int IdProveedorSeleccionado = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            ProveedorBss bss = new ProveedorBss();
            ProveedorListarVista fr = new ProveedorListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Proveedor proveedor = bss.ObtenerIdBss(IdProveedorSeleccionado);
                textBox1.Text = proveedor.Nombre;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IngresoBss bss = new IngresoBss();
            Ingreso i = new Ingreso();
            i.IdProveedor = IdProveedorSeleccionado;
            i.FechaIngreso = dateTimePicker1.Value;
            i.Total = Convert.ToDecimal(textBox3.Text);

            bss.InsertarIngresoBss(i);
            MessageBox.Show("se guardo correctamente ingreso");
        }
       
    }
}
