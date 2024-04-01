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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemasVentas.VISTA.IngresoVista
{
    public partial class IngresoEditarVista : Form
    {
        int idx = 0;
        Ingreso i = new Ingreso();
        IngresoBss bss = new IngresoBss();
        public IngresoEditarVista(int id)
        {
            idx = id;
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
        private void IngresoEditarVista_Load(object sender, EventArgs e)
        {
            i = bss.ObtenerIdBss(idx);
            textBox1.Text = i.IdProveedor.ToString();
            dateTimePicker1.Value = i.FechaIngreso;
            textBox3.Text = i.Total.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            i.IdProveedor = IdProveedorSeleccionado;
            i.FechaIngreso = dateTimePicker1.Value;
            i.Total = Convert.ToDecimal(textBox3.Text);
           

            bss.EditarIngresoBss(i);
            MessageBox.Show("Datos actualizados");
        }
    }
}
