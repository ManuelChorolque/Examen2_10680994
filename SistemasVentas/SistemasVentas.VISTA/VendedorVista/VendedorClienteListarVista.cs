using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemasVentas.VISTA.ClienteVista;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemasVentas.VISTA.VendedorVista
{
    public partial class VendedorClienteListarVista : Form
    {
        public VendedorClienteListarVista()
        {
            InitializeComponent();
        }
        private void VendedorClienteListarVista_Load(object sender, EventArgs e)
        {
            PersonaBss bss = new PersonaBss();
            dataGridView1.DataSource = bss.ListarPersonasBss();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VendedorInsertarVista.IdClienteSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }
    }
}
