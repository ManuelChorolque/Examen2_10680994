using SistemasVentas.BSS;
using SistemasVentas.VISTA.PersonaVista;
using SistemasVentas.VISTA.UsuarioRolVista;
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
using SistemasVentas.VISTA.VentaVista;

namespace SistemasVentas.VISTA.UsuarioVista
{
    public partial class UsuarioListarVista : Form
    {
        public UsuarioListarVista()
        {
            InitializeComponent();
        }
        UsuarioBss bss = new UsuarioBss();
        private void UsuarioListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.UsuarioDatosBss();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsuarioRolInsertarVista.IdUsuarioSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            VentaInsertarVista.IdVendedorSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            VentaEditarVista.IdVendedorSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            UsuarioRolEditarVista.IdUsuarioSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            UsuarioRolEditarVista.IdRolSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            UsuarioInsertarVista fr = new UsuarioInsertarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.UsuarioDatosBss();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int IdUsuarioSelecionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            UsuarioEditarVista fr = new UsuarioEditarVista(IdUsuarioSelecionada);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource=bss.UsuarioDatosBss();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int IdUsuarioSelecionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("Esta seguro de eliminar esta usuario", "Eliminando", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarUsuarioBss(IdUsuarioSelecionado);
                dataGridView1.DataSource = bss.UsuarioDatosBss();
            }
        }
    }
}
