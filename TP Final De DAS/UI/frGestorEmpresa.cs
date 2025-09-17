using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using BE;
namespace UI
{
    public partial class frGestorEmpresa : Form
    {
        private readonly BLL_Empresa bll_empresa = new BLL_Empresa();
        public frGestorEmpresa()
        {
            InitializeComponent();
            textBox1.Enabled = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            try
            {
                BE_Empresa nuevaEmpresa = new BE_Empresa
                (
                    txtNombre.Text,
                    int.Parse(txtCodPos.Text),
                    txtDireccion.Text
                );

                bll_empresa.Agregar(nuevaEmpresa);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear la empresa: " + ex.Message);
                return;
            }

            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
