using SistemasVentas.BSS;
using SistemasVentas.VISTA.DetalleVentaVista;
using SistemasVentas.VISTA.UsuarioVista;
using SistemasVentas.VISTA.VentaVista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.VentaVista
{
    public partial class VentaListarVista : Form
    {
        public VentaListarVista()
        {
            InitializeComponent();
        }
        VentaBss bss = new VentaBss();
        private void VentaListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.VentaDatosBss();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DetalleVentaInsertarVista.IdVentaSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VentaInsertarVista fr = new VentaInsertarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.VentaDatosBss();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int IdVentaSelecionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            VentaEditarVista fr = new VentaEditarVista(IdVentaSelecionado);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.VentaDatosBss();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int IdVentaSelecionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("Esta seguro de eliminar esta venta", "Eliminando", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarVentaBss(IdVentaSelecionado);
                dataGridView1.DataSource = bss.VentaDatosBss();
            }
        }
    }
}
