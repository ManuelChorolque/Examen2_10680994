using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemasVentas.VISTA.RolVista;
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

namespace SistemasVentas.VISTA.UsuarioRolVista
{
    public partial class UsuarioRolInsertarVista : Form
    {
        public UsuarioRolInsertarVista()
        {
            InitializeComponent();
        }
        public static int IdUsuarioSeleccionado = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            UsuarioBss bss = new UsuarioBss();
            UsuarioListarVista fr = new UsuarioListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Usuario usuario = bss.ObtenerIdBss(IdUsuarioSeleccionado);
                textBox1.Text = usuario.NombreUser;
            }
        }
        public static int IdRolSeleccionado = 0;
        private void button4_Click(object sender, EventArgs e)
        {
            RolBss bss = new RolBss();
            RolListarVista fr = new RolListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Rol rol = bss.ObtenerIdBss(IdRolSeleccionado);
                textBox2.Text = rol.Nombre;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            UsuarioRolBss bss = new UsuarioRolBss();
            UsuarioRol ur = new UsuarioRol();
            ur.IdUsuario = IdUsuarioSeleccionado;
            ur.IdRol = IdRolSeleccionado;
            ur.FechaAsigna = dateTimePicker1.Value;

            bss.InsertarUsuarioRolBss(ur);
            MessageBox.Show("se guardo correctamente UsuarioRol");
        }
       
    }
}
