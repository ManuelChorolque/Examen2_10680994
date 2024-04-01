using SistemasVentas.BSS;
using SistemasVentas.VISTA.IngresoVista;
using SistemasVentas.VISTA.ProveeVista;
using SistemasVentas.VISTA.RolVista;
using SistemasVentas.VISTA.UsuarioRolVista;
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
    public partial class ProveedorListarVista : Form
    {
        public ProveedorListarVista()
        {
            InitializeComponent();
        }
        ProveedorBss bss = new ProveedorBss();
        private void ProveedorListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ProveedorDatosBss();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProveeInsertarVista.IdProveedorSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            IngresoInsertarVista.IdProveedorSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            IngresoEditarVista.IdProveedorSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProveedorInsertarVista fr = new ProveedorInsertarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarProveedorBss();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int IdProveedorSelecionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            ProveedorEditarVista fr = new ProveedorEditarVista(IdProveedorSelecionado);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarProveedorBss();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int IdProveedorSelecionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("Esta seguro de elimar este proveedor", "Eliminando", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarProveedorBss(IdProveedorSelecionado);
                dataGridView1.DataSource = bss.ListarProveedorBss();
            }
        }
    }
}
