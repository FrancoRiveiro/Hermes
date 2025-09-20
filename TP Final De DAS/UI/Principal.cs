using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Principal : Form
    {

        private frLogin login;
        private frCatalogo catalogo;
        private frGestionUsuario gestionarCliente;
        private frGestionViajes gestionViajes;
        private frGestionEmpresa gestionEmpresa;
        private BLL_Usuario bllUsuario = new BLL_Usuario();

        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            catalogoBTN.Visible = true;
            empresaBTN.Visible = false;
            usuarioBTN.Visible = false;
            viajesBTN.Visible = false;

        }

        //gestionarCliente = new frGestionUsuario();
        //gestionarCliente.MdiParent = this;
        //        gestionarCliente.Show();





        private void catalogoBTN_Click(object sender, EventArgs e)
        {
            catalogo = new frCatalogo(bllUsuario.UsuarioActual());
            catalogo.FormClosed += new FormClosedEventHandler(cerrarForms);
            catalogo.MdiParent = this;
            catalogo.WindowState = FormWindowState.Maximized;
            catalogo.MinimizeBox = false;
            catalogo.MaximizeBox = false;
            catalogo.Show();
            catalogo.ControlBox = false;
        }
        void cerrarForms(object sender, FormClosedEventArgs e)
        {
            login = null;
            catalogo = null;
        }

        private void loginBTN_Click(object sender, EventArgs e)
        {
            if (bllUsuario.SesionActiva())
            {
                var usuario = bllUsuario.UsuarioActual();

                MessageBox.Show("Ya existe una sesión activa para el usuario: " + usuario.Nombre, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            login = new frLogin();

            if (login.ShowDialog() == DialogResult.OK)
            {
                var usuario = bllUsuario.UsuarioActual();


                catalogoBTN.Visible = true;
                empresaBTN.Visible = usuario.Rol;
                usuarioBTN.Visible = usuario.Rol;
                viajesBTN.Visible = usuario.Rol;

                MessageBox.Show("Bienvenido, " + usuario.Nombre, "Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            login = null; // Liberar el recurso del formulario de login
        }

        private void empresaBTN_Click(object sender, EventArgs e)
        {
            gestionEmpresa = new frGestionEmpresa();
            gestionEmpresa.MdiParent = this;
            gestionEmpresa.WindowState = FormWindowState.Maximized;
            gestionEmpresa.Show();
            gestionEmpresa.ControlBox = false;
        }

        private void viajesBTN_Click(object sender, EventArgs e)
        {
            gestionViajes = new frGestionViajes();
            gestionViajes.MdiParent = this;
            gestionViajes.WindowState = FormWindowState.Maximized;
            gestionViajes.Show();
            gestionViajes.ControlBox = false;
        }

        private void usuarioBTN_Click(object sender, EventArgs e)
        {
            gestionarCliente = new frGestionUsuario();
            gestionarCliente.MdiParent = this;
            gestionarCliente.WindowState = FormWindowState.Maximized;
            gestionarCliente.Show();
            gestionarCliente.ControlBox = false;
        }
    }
}

