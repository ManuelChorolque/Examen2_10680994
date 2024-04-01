using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemasVentas.VISTA.PersonaVista;
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
    public partial class ClienteEditarVista : Form
    {
        int idx = 0;
        Cliente c = new Cliente();
        ClienteBss bss = new ClienteBss();
        public ClienteEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }
        public static int IdPersonaSeleccionada = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            PersonaBss bss = new PersonaBss();

            PersonaListarVista fr = new PersonaListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Persona persona = bss.ObtenerIdBss(IdPersonaSeleccionada);
                textBox1.Text = persona.Nombre + " " + persona.Apellido;
            }
        }

        private void ClienteEditarVista_Load(object sender, EventArgs e)
        {
            c = bss.ObtenerIdBss(idx);
            textBox1.Text = c.IdPersona.ToString();
            textBox2.Text = c.TipoCliente;
            textBox3.Text = c.CodigoCliente;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c.IdPersona = IdPersonaSeleccionada;
            c.TipoCliente = textBox2.Text;
            c.CodigoCliente = textBox3.Text;

            bss.EditarClienteBss(c);
            MessageBox.Show("Datos actualizados");
        }
    }
}
