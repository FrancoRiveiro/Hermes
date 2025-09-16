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
namespace UI
{
    public partial class frCatalogo : Form
    {
        public frCatalogo(BE_Usuario actual)
        {
            InitializeComponent();

            if (actual != null)
            {

                btnReservar.Enabled = false;
            }
            else 
            { 
            
                btnReservar.Enabled = true;
            }
        }

        //funcion para cargar la grilla
        /*void CargarGrilla()
        {

            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = oLoc.CargarListaCatalogo();
            //propiedad de la grilla para autosize de columnas
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            //cambio color alternando las filas de la grilla
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.DarkOrange;
        }
        */


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
