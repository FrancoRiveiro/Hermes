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
                inicioToolStripMenuItem.Visible = true;
                empresaToolStripMenuItem.Visible = false;
                usuariosToolStripMenuItem.Visible = false;
                viajesToolStripMenuItem.Visible = false;

            }

            private void loginToolStripMenuItem_Click(object sender, EventArgs e)
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


                    inicioToolStripMenuItem.Visible = true;
                    empresaToolStripMenuItem.Visible = usuario.Rol;
                    usuariosToolStripMenuItem.Visible = usuario.Rol;
                    viajesToolStripMenuItem.Visible = usuario.Rol;

                    MessageBox.Show("Bienvenido, " + usuario.Nombre, "Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
          
                login =null; // Liberar el recurso del formulario de login
            }

        

            private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
            {
                catalogo = new frCatalogo(bllUsuario.UsuarioActual());
                catalogo.FormClosed += new FormClosedEventHandler(cerrarForms);
                catalogo.MdiParent = this;
                catalogo.WindowState = FormWindowState.Maximized;
                catalogo.Show(); 
            }
            void cerrarForms(object sender, FormClosedEventArgs e)
            {
                login = null;
                catalogo = null;
            }

        

        //gestionarCliente = new frGestionUsuario();
        //gestionarCliente.MdiParent = this;
        //        gestionarCliente.Show();

            private void viajesToolStripMenuItem_Click(object sender, EventArgs e)
            {
                gestionViajes = new frGestionViajes();
                gestionViajes.MdiParent = this;
                gestionViajes.WindowState = FormWindowState.Maximized;
                gestionViajes.Show();
            }

            private void gestionarEmpresaToolStripMenuItem1_Click(object sender, EventArgs e)
            {
                gestionEmpresa = new frGestionEmpresa();
                gestionEmpresa.MdiParent = this;
                gestionEmpresa.WindowState = FormWindowState.Maximized;
                gestionEmpresa.Show();
            }

        private void gestionarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gestionarCliente = new frGestionUsuario();
            gestionarCliente.MdiParent = this;
            gestionarCliente.WindowState = FormWindowState.Maximized;
            gestionarCliente.Show();
        }
    }
    }
