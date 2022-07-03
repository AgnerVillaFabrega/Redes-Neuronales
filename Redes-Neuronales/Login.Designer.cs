namespace Redes_Neuronales
{
    partial class Login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtmLogin = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(194)))), ((int)(((byte)(211)))));
            this.panel1.Controls.Add(this.txtPass);
            this.panel1.Controls.Add(this.txtUser);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.BtmLogin);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Location = new System.Drawing.Point(75, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 305);
            this.panel1.TabIndex = 0;
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(207)))), ((int)(((byte)(224)))));
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            this.txtPass.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtPass.Location = new System.Drawing.Point(69, 202);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(177, 16);
            this.txtPass.TabIndex = 3;
            this.txtPass.Text = "Contraseña";
            this.txtPass.Enter += new System.EventHandler(this.txtPass_Enter);
            this.txtPass.Leave += new System.EventHandler(this.txtPass_Leave);
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(207)))), ((int)(((byte)(224)))));
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            this.txtUser.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtUser.Location = new System.Drawing.Point(69, 162);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(177, 16);
            this.txtUser.TabIndex = 2;
            this.txtUser.Text = "Usuario";
            this.txtUser.Enter += new System.EventHandler(this.txtUser_Enter);
            this.txtUser.Leave += new System.EventHandler(this.txtUser_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Redes_Neuronales.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(69, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // BtmLogin
            // 
            this.BtmLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            this.BtmLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtmLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtmLogin.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtmLogin.ForeColor = System.Drawing.Color.White;
            this.BtmLogin.Location = new System.Drawing.Point(69, 246);
            this.BtmLogin.Name = "BtmLogin";
            this.BtmLogin.Size = new System.Drawing.Size(177, 37);
            this.BtmLogin.TabIndex = 0;
            this.BtmLogin.Text = "Iniciar Sesion";
            this.BtmLogin.UseVisualStyleBackColor = false;
            this.BtmLogin.Click += new System.EventHandler(this.BtmLogin_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Redes_Neuronales.Properties.Resources.menos_linea_recta_horizontal;
            this.pictureBox2.Location = new System.Drawing.Point(69, 171);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(177, 19);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Redes_Neuronales.Properties.Resources.menos_linea_recta_horizontal;
            this.pictureBox3.Location = new System.Drawing.Point(69, 213);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(177, 17);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            this.ClientSize = new System.Drawing.Size(458, 381);
            this.Controls.Add(this.panel1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtmLogin;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}