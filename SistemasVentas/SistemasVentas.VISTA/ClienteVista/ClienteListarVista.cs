using SistemasVentas.BSS;
using SistemasVentas.VISTA.ClienteVista;
using SistemasVentas.VISTA.IngresoVista;
using SistemasVentas.VISTA.UsuarioRolVista;
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

namespace SistemasVentas.VISTA.ClienteVista
{
    public partial class ClienteListarVista : Form
    {
        public ClienteListarVista()
        {
            InitializeComponent();
        }
        ClienteBss bss = new ClienteBss();
        private void ClienteListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ClienteDatosBss();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VentaInsertarVista.IdClienteSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            VentaEditarVista.IdClienteSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClienteInsertarVista fr = new ClienteInsertarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ClienteDatosBss();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int IdClienteSelecionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            ClienteEditarVista fr = new ClienteEditarVista(IdClienteSelecionado);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ClienteDatosBss();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int IdClienteSelecionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("Esta seguro de elimar este cliente", "Eliminando", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarClienteBss(IdClienteSelecionado);
                dataGridView1.DataSource = bss.ClienteDatosBss();
            }
        }
    }
}
