using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemasVentas.VISTA.PersonaVista;
using SistemasVentas.VISTA.ClienteVista;
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
    public partial class ClienteInsertarVista : Form
    {
        public ClienteInsertarVista()
        {
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
        private void button1_Click(object sender, EventArgs e)
        {
            ClienteBss bss = new ClienteBss();
            Cliente c = new Cliente();
            c.IdPersona = IdPersonaSeleccionada;
            c.TipoCliente = textBox2.Text;
            c.CodigoCliente = textBox3.Text;

            bss.InsertarClienteBss(c);
            MessageBox.Show("se guardo correctamente cliente");
        }
       
    }
}
