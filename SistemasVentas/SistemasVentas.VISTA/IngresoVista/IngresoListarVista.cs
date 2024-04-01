using SistemasVentas.BSS;
using SistemasVentas.VISTA.DetalleIngVista;
using SistemasVentas.VISTA.ProveeVista;
using SistemasVentas.VISTA.UsuarioVista;
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
    public partial class IngresoListarVista : Form
    {
        public IngresoListarVista()
        {
            InitializeComponent();
        }
        IngresoBss bss = new IngresoBss();
        private void IngresoListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.IngresoDatosBss();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DetalleIngInsertarVista.IdIngresoSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IngresoInsertarVista fr = new IngresoInsertarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.IngresoDatosBss();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int IdIngresoSelecionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            IngresoEditarVista fr = new IngresoEditarVista(IdIngresoSelecionado);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.IngresoDatosBss();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int IdIngresoSelecionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("Esta seguro de elimar este ingreso", "Eliminando", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarIngresoBss(IdIngresoSelecionado);
                dataGridView1.DataSource = bss.IngresoDatosBss();
            }
        }
    }
}
