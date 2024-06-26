﻿using SistemasVentas.BSS;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemasVentas.VISTA.UsuarioVista
{
    public partial class UsuarioEditarVista : Form
    {
        int idx = 0;
        Usuario u = new Usuario();
        UsuarioBss bss = new UsuarioBss();
        public UsuarioEditarVista(int id)
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
        private void UsuarioEditarVista_Load(object sender, EventArgs e)
        {
            u = bss.ObtenerIdBss(idx);
            textBox1.Text = u.IdPersona.ToString();
            textBox2.Text = u.NombreUser;
            textBox3.Text = u.Contraseña;
            dateTimePicker1.Value = u.FechaReg;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            u.IdPersona = IdPersonaSeleccionada;
            u.NombreUser = textBox2.Text;
            u.Contraseña = textBox3.Text;
            u.FechaReg = dateTimePicker1.Value;

            bss.EditarUsuarioBss(u);
            MessageBox.Show("Datos actualizados");
        }
       
    }
}
