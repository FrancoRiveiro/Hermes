using BE;
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
    public partial class frLogin : Form
    {
        public frRegistro registrar;
        public BE_Usuario usuarioLog { get; private set; }
        public frLogin()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Email = this.textEmail.Text;

            string Contraseña = this.textContra.Text;

            try
            {
            
                BLL_Usuario bLL_Usuario = new BLL_Usuario();
                BE_Usuario usuario = bLL_Usuario.Login(Email, Contraseña);

                MessageBox.Show("Inicio de sesión exitoso \r Bienvenido" + usuario.Nombre);

                this.DialogResult = DialogResult.OK;
                this.Close();



            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar sesión: " + ex.Message);
                return;
            }
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textContra.Text = string.Empty;
            textEmail.Text = string.Empty;
        }
        
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (frRegistro registrar = new frRegistro())
            {
                if (registrar.ShowDialog() == DialogResult.OK)
                {
                    var usuario = new BLL_Usuario().UsuarioActual();
                    MessageBox.Show("Registro completado, puede iniciar sesión.");
                }
            }
        }
    }
}
