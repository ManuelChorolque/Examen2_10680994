using SistemasVentas.BSS;
using SistemasVentas.VISTA.ProductoVista;
using SistemasVentas.VISTA.RolVista;
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

namespace SistemasVentas.VISTA.MarcaVista
{
    public partial class MarcaListarVista : Form
    {
        public MarcaListarVista()
        {
            InitializeComponent();
        }
        MarcaBss bss = new MarcaBss();
        private void MarcaListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.MarcaDatosBss();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductoInsertarVista.IdMarcaSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MarcaInsertarVista fr = new MarcaInsertarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarMarcaBss();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int IdMarcaSelecionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            MarcaEditarVista fr = new MarcaEditarVista(IdMarcaSelecionado);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarMarcaBss();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int IdMarcaSelecionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("Esta seguro de elimar esta marca", "Eliminando", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarMarcaBss(IdMarcaSelecionado);
                dataGridView1.DataSource = bss.ListarMarcaBss();
            }
        }
    }
}
