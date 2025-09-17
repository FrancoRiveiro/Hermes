using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace UI
{
    public partial class frGestionEmpresa : Form
    {
        private readonly BLL_Empresa bll_Empresa = new BLL_Empresa();
        public frGestionEmpresa()
        {
            InitializeComponent();
            ObtenerEmpresas();
        }

        private void ObtenerEmpresas() 
        {
            try 
            { 
                var empresas = bll_Empresa.ObtenerTodos();

                dgvEmpresas.DataSource = empresas.ToList();
                dgvEmpresas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            }

            catch (Exception ex)
            {
             throw new Exception( "Error al cargar las empresas: " + ex.Message);
            }
        
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            frGestorEmpresa alta =  new frGestorEmpresa();

            alta.ShowDialog();

            ObtenerEmpresas();
        }
    }
}
