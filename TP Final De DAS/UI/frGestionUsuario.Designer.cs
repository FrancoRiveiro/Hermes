namespace UI
{
    partial class frGestionUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbUsuarios = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvUsuario = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbUsuarios
            // 
            this.cmbUsuarios.FormattingEnabled = true;
            this.cmbUsuarios.Items.AddRange(new object[] {
            "Clientes",
            "Administradores"});
            this.cmbUsuarios.Location = new System.Drawing.Point(11, 49);
            this.cmbUsuarios.Margin = new System.Windows.Forms.Padding(2);
            this.cmbUsuarios.Name = "cmbUsuarios";
            this.cmbUsuarios.Size = new System.Drawing.Size(82, 21);
            this.cmbUsuarios.TabIndex = 5;
            this.cmbUsuarios.SelectedIndexChanged += new System.EventHandler(this.cmbUsuarios_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Rol";
            // 
            // dgvUsuario
            // 
            this.dgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuario.Location = new System.Drawing.Point(115, 34);
            this.dgvUsuario.Name = "dgvUsuario";
            this.dgvUsuario.RowHeadersWidth = 62;
            this.dgvUsuario.Size = new System.Drawing.Size(536, 313);
            this.dgvUsuario.TabIndex = 37;
            // 
            // button3
            // 
            this.button3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button3.Location = new System.Drawing.Point(141, 385);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 38;
            this.button3.Text = "Actualizar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(337, 385);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 39;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button2.Location = new System.Drawing.Point(576, 385);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 40;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frGestionUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dgvUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbUsuarios);
            this.Name = "frGestionUsuario";
            this.Text = "frGestionClientes";
            this.Load += new System.EventHandler(this.frGestionUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbUsuarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvUsuario;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}