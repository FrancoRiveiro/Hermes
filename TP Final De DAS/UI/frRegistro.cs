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
    public partial class frRegistro : Form
    {
        //private GestorUsuario<Cliente> gestor = new GestorUsuario<Cliente>();
        public frRegistro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                // Intenta crear el cliente con los datos de los textbox
                try {
            
                string nombre = this.textBox1.Text;
                    
                string apellido = this.textBox2.Text;
            
                string email = this.textBox3.Text;
            
                int telefono = Convert.ToInt32(this.textBox4.Text);
           
                int dni = Convert.ToInt32(this.textBox5.Text);
            
                string contraseña = this.textBox6.Text;
            
                BE_Usuario cliente = new BE_Cliente(nombre, apellido, dni, contraseña,email,false,telefono);

                BLL_Usuario bllusuaio = new BLL_Usuario();

                bllusuaio.Registrar(cliente);
                
                MessageBox.Show("Cliente registrado con éxito");


                bllusuaio.Login(email, contraseña); // Inicia sesión automáticamente después del registro

                this.DialogResult = DialogResult.OK;
           
                this.Close(); // Cierra el formulario después de registrar al cliente


            }//Atrapa un error si hay un campo nulo
            catch (ArgumentNullException)
                {
                    MessageBox.Show("Debe completar todos los campos");
                }
            
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
