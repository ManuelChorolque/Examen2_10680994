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

namespace SistemasVentas.VISTA.VentaVista
{
    public partial class VentaEditarVista : Form
    {
        int idx = 0;
        Venta v = new Venta();
        VentaBss bss = new VentaBss();
        public VentaEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }
        public static int IdClienteSeleccionado = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            ClienteBss bss = new ClienteBss();
            ClienteListarVista fr = new ClienteListarVista();

            if (fr.ShowDialog() == DialogResult.OK)
            {
                Cliente cliente = bss.ObtenerIdBss(IdClienteSeleccionado);
                textBox1.Text = cliente.TipoCliente;
            }
        }
        public static int IdVendedorSeleccionado = 0;
        private void button4_Click(object sender, EventArgs e)
        {
            UsuarioBss bss = new UsuarioBss();
            UsuarioListarVista fr = new UsuarioListarVista();

            if (fr.ShowDialog() == DialogResult.OK)
            {
                Usuario usuario = bss.ObtenerIdBss(IdVendedorSeleccionado);
                textBox2.Text = usuario.NombreUser;
            }
        }

        private void VentaEditarVista_Load(object sender, EventArgs e)
        {
            v = bss.ObtenerIdBss(idx);
            textBox1.Text = v.IdCliente.ToString();
            textBox2.Text = v.IdVendedor.ToString();
            dateTimePicker1.Value = v.Fecha;
            textBox4.Text = v.Total.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            v.IdCliente = IdClienteSeleccionado;
            v.IdVendedor = IdVendedorSeleccionado;
            v.Fecha = dateTimePicker1.Value;
            v.Total = Convert.ToDecimal(textBox4.Text);
            
            bss.EditarVentaBss(v);
            MessageBox.Show("Datos actualizados");
        }
    }
}
