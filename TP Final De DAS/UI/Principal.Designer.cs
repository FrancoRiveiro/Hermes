namespace UI
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarEmpresaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viajesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.empresaToolStripMenuItem,
            this.viajesToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.pToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.inicioToolStripMenuItem.Text = "Catalogo";
            this.inicioToolStripMenuItem.Click += new System.EventHandler(this.inicioToolStripMenuItem_Click);
            // 
            // empresaToolStripMenuItem
            // 
            this.empresaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarEmpresaToolStripMenuItem1});
            this.empresaToolStripMenuItem.Name = "empresaToolStripMenuItem";
            this.empresaToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.empresaToolStripMenuItem.Text = "Empresa";
            // 
            // gestionarEmpresaToolStripMenuItem1
            // 
            this.gestionarEmpresaToolStripMenuItem1.Name = "gestionarEmpresaToolStripMenuItem1";
            this.gestionarEmpresaToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.gestionarEmpresaToolStripMenuItem1.Text = "Gestionar";
            this.gestionarEmpresaToolStripMenuItem1.Click += new System.EventHandler(this.gestionarEmpresaToolStripMenuItem1_Click);
            // 
            // viajesToolStripMenuItem
            // 
            this.viajesToolStripMenuItem.Name = "viajesToolStripMenuItem";
            this.viajesToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.viajesToolStripMenuItem.Text = "Viajes";
            this.viajesToolStripMenuItem.Click += new System.EventHandler(this.viajesToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarUsuarioToolStripMenuItem});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // gestionarUsuarioToolStripMenuItem
            // 
            this.gestionarUsuarioToolStripMenuItem.Name = "gestionarUsuarioToolStripMenuItem";
            this.gestionarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gestionarUsuarioToolStripMenuItem.Text = "Gestionar";
            this.gestionarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.gestionarUsuarioToolStripMenuItem_Click);
            // 
            // pToolStripMenuItem
            // 
            this.pToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.pToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.pToolStripMenuItem.Name = "pToolStripMenuItem";
            this.pToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 0, 12, 0);
            this.pToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.pToolStripMenuItem.Text = "Perfil";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            // 
            // imgLogo
            // 
            this.imgLogo.Image = global::UI.Properties.Resources.imgLogo;
            this.imgLogo.ImageLocation = "";
            this.imgLogo.Location = new System.Drawing.Point(703, 358);
            this.imgLogo.MaximumSize = new System.Drawing.Size(500, 500);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(97, 93);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogo.TabIndex = 2;
            this.imgLogo.TabStop = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.imgLogo);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Transportes Hermes";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viajesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.ToolStripMenuItem gestionarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarEmpresaToolStripMenuItem1;
    }
}

