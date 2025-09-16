using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using BLL;
namespace UI
{
    public partial class frGestionUsuario : Form
    {
        private readonly BLL_Usuario bLL_Usuario = new BLL_Usuario();
        public frGestionUsuario()
        {
            InitializeComponent();
        }

        private void frGestionUsuario_Load(object sender, EventArgs e)
        {
            CargarFiltro();
            CargarUsuarios(null);
        }


        private void CargarFiltro()
        {
            // Configura el ComboBox para filtrar por rol
            cmbUsuarios.Items.Clear();
            cmbUsuarios.Items.Add("Todos");
            cmbUsuarios.Items.Add("Administradores");
            cmbUsuarios.Items.Add("Clientes");
            cmbUsuarios.SelectedIndex = 0; // Selecciona "Todos" por defecto
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Lógica para gestionar usuarios
            MessageBox.Show("Funcionalidad de gestión de usuarios en desarrollo.");
        }


        private void CargarUsuarios(bool? esAdmin) 
        {
            try 
            {
                var usuarios = bLL_Usuario.ObtenerTodos();

                if (esAdmin.HasValue) 
                {

                    usuarios = usuarios.Where(x => x.Rol == esAdmin.Value).ToList();

                }

                dgvUsuario.DataSource = usuarios.ToList();
            }
            catch (Exception ex) 
            { 
                MessageBox.Show("Error al cargar usuarios: " + ex.Message);
            }


        }

        private void cmbUsuarios_SelectedIndexChanged(object sender, EventArgs e) 
        {
        string opcionSeleccionada = cmbUsuarios.SelectedItem.ToString();
            switch (opcionSeleccionada) 
            {
                case "Todos":
                    CargarUsuarios(null);
                    break;
                case "Administradores":
                    CargarUsuarios(true);
                    break;
                case "Clientes":
                    CargarUsuarios(false);
                    break;
            }


        }
      
    }
}
