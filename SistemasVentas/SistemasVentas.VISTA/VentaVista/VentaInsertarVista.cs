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

namespace SistemasVentas.VISTA.VentaVista
{
    public partial class VentaInsertarVista : Form
    {
        public VentaInsertarVista()
        {
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
        private void button1_Click(object sender, EventArgs e)
        {
            VentaBss bss = new VentaBss();
            Venta v = new Venta();
            v.IdCliente = IdClienteSeleccionado;
            v.IdVendedor = IdVendedorSeleccionado;
            v.Fecha = dateTimePicker1.Value;
            v.Total = Convert.ToDecimal(textBox4.Text);

            bss.InsertarVentaBss(v);
            MessageBox.Show("se guardo correctamente venta");
        }
        
    }
}
