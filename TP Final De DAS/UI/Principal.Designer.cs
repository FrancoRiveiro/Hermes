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
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.loginBTN = new System.Windows.Forms.Button();
            this.usuarioBTN = new System.Windows.Forms.Button();
            this.viajesBTN = new System.Windows.Forms.Button();
            this.empresaBTN = new System.Windows.Forms.Button();
            this.catalogoBTN = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgLogo
            // 
            this.imgLogo.Image = global::UI.Properties.Resources.imgLogo;
            this.imgLogo.ImageLocation = "";
            this.imgLogo.Location = new System.Drawing.Point(0, -1);
            this.imgLogo.MaximumSize = new System.Drawing.Size(500, 500);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(97, 93);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogo.TabIndex = 2;
            this.imgLogo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel1.Controls.Add(this.loginBTN);
            this.panel1.Controls.Add(this.usuarioBTN);
            this.panel1.Controls.Add(this.viajesBTN);
            this.panel1.Controls.Add(this.empresaBTN);
            this.panel1.Controls.Add(this.catalogoBTN);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 749);
            this.panel1.TabIndex = 4;
            // 
            // loginBTN
            // 
            this.loginBTN.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.loginBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBTN.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBTN.Location = new System.Drawing.Point(0, 704);
            this.loginBTN.Name = "loginBTN";
            this.loginBTN.Size = new System.Drawing.Size(200, 45);
            this.loginBTN.TabIndex = 9;
            this.loginBTN.Text = "Login";
            this.loginBTN.UseVisualStyleBackColor = true;
            // 
            // usuarioBTN
            // 
            this.usuarioBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.usuarioBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usuarioBTN.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioBTN.Location = new System.Drawing.Point(0, 227);
            this.usuarioBTN.Name = "usuarioBTN";
            this.usuarioBTN.Size = new System.Drawing.Size(200, 45);
            this.usuarioBTN.TabIndex = 8;
            this.usuarioBTN.Text = "Usuarios";
            this.usuarioBTN.UseVisualStyleBackColor = true;
            // 
            // viajesBTN
            // 
            this.viajesBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.viajesBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viajesBTN.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viajesBTN.Location = new System.Drawing.Point(0, 182);
            this.viajesBTN.Name = "viajesBTN";
            this.viajesBTN.Size = new System.Drawing.Size(200, 45);
            this.viajesBTN.TabIndex = 7;
            this.viajesBTN.Text = "Viajes";
            this.viajesBTN.UseVisualStyleBackColor = true;
            // 
            // empresaBTN
            // 
            this.empresaBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.empresaBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.empresaBTN.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empresaBTN.Location = new System.Drawing.Point(0, 137);
            this.empresaBTN.Name = "empresaBTN";
            this.empresaBTN.Size = new System.Drawing.Size(200, 45);
            this.empresaBTN.TabIndex = 6;
            this.empresaBTN.Text = "Empresa";
            this.empresaBTN.UseVisualStyleBackColor = true;
            // 
            // catalogoBTN
            // 
            this.catalogoBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.catalogoBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.catalogoBTN.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catalogoBTN.Location = new System.Drawing.Point(0, 92);
            this.catalogoBTN.Name = "catalogoBTN";
            this.catalogoBTN.Size = new System.Drawing.Size(200, 45);
            this.catalogoBTN.TabIndex = 5;
            this.catalogoBTN.Text = "Catalogo";
            this.catalogoBTN.UseVisualStyleBackColor = true;
            this.catalogoBTN.Click += new System.EventHandler(this.catalogoBTN_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel2.Controls.Add(this.imgLogo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 92);
            this.panel2.TabIndex = 5;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 749);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "Principal";
            this.Text = "Transportes Hermes";
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button catalogoBTN;
        private System.Windows.Forms.Button loginBTN;
        private System.Windows.Forms.Button usuarioBTN;
        private System.Windows.Forms.Button viajesBTN;
        private System.Windows.Forms.Button empresaBTN;
    }
}

