namespace Redes_Neuronales
{
    partial class FrmPrincipal
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelcontenedor = new System.Windows.Forms.Panel();
            this.panelPaso3 = new System.Windows.Forms.Panel();
            this.nudRataAprendizaje = new System.Windows.Forms.NumericUpDown();
            this.nudErrorMaximo = new System.Windows.Forms.NumericUpDown();
            this.nudNumeroIteraciones = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panelContenedorTipo = new System.Windows.Forms.Panel();
            this.panelPaso1 = new System.Windows.Forms.Panel();
            this.cbTipoRed = new System.Windows.Forms.ComboBox();
            this.cbSeleccionCapa = new System.Windows.Forms.ComboBox();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lb_patrones = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_salidas = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_entradas = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtmCargar = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panelcontenedor.SuspendLayout();
            this.panelPaso3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRataAprendizaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudErrorMaximo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroIteraciones)).BeginInit();
            this.panelPaso1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1175, 50);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(386, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Parametrizacion de una red";
            // 
            // panelcontenedor
            // 
            this.panelcontenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(194)))), ((int)(((byte)(211)))));
            this.panelcontenedor.Controls.Add(this.panelPaso3);
            this.panelcontenedor.Controls.Add(this.panelContenedorTipo);
            this.panelcontenedor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelcontenedor.Location = new System.Drawing.Point(0, 152);
            this.panelcontenedor.Name = "panelcontenedor";
            this.panelcontenedor.Size = new System.Drawing.Size(1175, 668);
            this.panelcontenedor.TabIndex = 1;
            // 
            // panelPaso3
            // 
            this.panelPaso3.Controls.Add(this.nudRataAprendizaje);
            this.panelPaso3.Controls.Add(this.nudErrorMaximo);
            this.panelPaso3.Controls.Add(this.nudNumeroIteraciones);
            this.panelPaso3.Controls.Add(this.label7);
            this.panelPaso3.Controls.Add(this.label6);
            this.panelPaso3.Controls.Add(this.label5);
            this.panelPaso3.Controls.Add(this.panel6);
            this.panelPaso3.Enabled = false;
            this.panelPaso3.Location = new System.Drawing.Point(0, 0);
            this.panelPaso3.Name = "panelPaso3";
            this.panelPaso3.Size = new System.Drawing.Size(1175, 100);
            this.panelPaso3.TabIndex = 0;
            // 
            // nudRataAprendizaje
            // 
            this.nudRataAprendizaje.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nudRataAprendizaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(194)))), ((int)(((byte)(211)))));
            this.nudRataAprendizaje.DecimalPlaces = 3;
            this.nudRataAprendizaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            this.nudRataAprendizaje.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.nudRataAprendizaje.Location = new System.Drawing.Point(521, 52);
            this.nudRataAprendizaje.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRataAprendizaje.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.nudRataAprendizaje.Name = "nudRataAprendizaje";
            this.nudRataAprendizaje.Size = new System.Drawing.Size(80, 20);
            this.nudRataAprendizaje.TabIndex = 9;
            this.nudRataAprendizaje.Value = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.nudRataAprendizaje.ValueChanged += new System.EventHandler(this.nudRataAprendizaje_ValueChanged);
            // 
            // nudErrorMaximo
            // 
            this.nudErrorMaximo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nudErrorMaximo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(194)))), ((int)(((byte)(211)))));
            this.nudErrorMaximo.DecimalPlaces = 3;
            this.nudErrorMaximo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            this.nudErrorMaximo.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.nudErrorMaximo.Location = new System.Drawing.Point(941, 52);
            this.nudErrorMaximo.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudErrorMaximo.Name = "nudErrorMaximo";
            this.nudErrorMaximo.Size = new System.Drawing.Size(80, 20);
            this.nudErrorMaximo.TabIndex = 8;
            this.nudErrorMaximo.ValueChanged += new System.EventHandler(this.nudErrorMaximo_ValueChanged);
            // 
            // nudNumeroIteraciones
            // 
            this.nudNumeroIteraciones.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nudNumeroIteraciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(194)))), ((int)(((byte)(211)))));
            this.nudNumeroIteraciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            this.nudNumeroIteraciones.Location = new System.Drawing.Point(107, 52);
            this.nudNumeroIteraciones.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudNumeroIteraciones.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumeroIteraciones.Name = "nudNumeroIteraciones";
            this.nudNumeroIteraciones.Size = new System.Drawing.Size(80, 20);
            this.nudNumeroIteraciones.TabIndex = 7;
            this.nudNumeroIteraciones.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumeroIteraciones.ValueChanged += new System.EventHandler(this.nudNumeroIteraciones_ValueChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            this.label7.Location = new System.Drawing.Point(914, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Error maximo permitido";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            this.label6.Location = new System.Drawing.Point(503, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Rata de aprendizaje ";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            this.label5.Location = new System.Drawing.Point(85, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Numero de iteraciones";
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(83)))), ((int)(((byte)(102)))));
            this.panel6.Location = new System.Drawing.Point(14, 90);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1145, 4);
            this.panel6.TabIndex = 0;
            // 
            // panelContenedorTipo
            // 
            this.panelContenedorTipo.Location = new System.Drawing.Point(0, 100);
            this.panelContenedorTipo.Name = "panelContenedorTipo";
            this.panelContenedorTipo.Size = new System.Drawing.Size(1175, 568);
            this.panelContenedorTipo.TabIndex = 1;
            // 
            // panelPaso1
            // 
            this.panelPaso1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(83)))), ((int)(((byte)(102)))));
            this.panelPaso1.Controls.Add(this.cbTipoRed);
            this.panelPaso1.Controls.Add(this.cbSeleccionCapa);
            this.panelPaso1.Controls.Add(this.txtRuta);
            this.panelPaso1.Controls.Add(this.groupBox4);
            this.panelPaso1.Controls.Add(this.BtmCargar);
            this.panelPaso1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPaso1.Location = new System.Drawing.Point(0, 50);
            this.panelPaso1.Name = "panelPaso1";
            this.panelPaso1.Size = new System.Drawing.Size(1175, 102);
            this.panelPaso1.TabIndex = 2;
            // 
            // cbTipoRed
            // 
            this.cbTipoRed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbTipoRed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(82)))), ((int)(((byte)(102)))));
            this.cbTipoRed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoRed.Enabled = false;
            this.cbTipoRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoRed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.cbTipoRed.FormattingEnabled = true;
            this.cbTipoRed.Items.AddRange(new object[] {
            "Seleccione tipo de red",
            "Perceptron",
            "Adaline",
            "Backpropagation"});
            this.cbTipoRed.Location = new System.Drawing.Point(941, 19);
            this.cbTipoRed.Name = "cbTipoRed";
            this.cbTipoRed.Size = new System.Drawing.Size(210, 23);
            this.cbTipoRed.TabIndex = 25;
            this.cbTipoRed.SelectedIndexChanged += new System.EventHandler(this.cbTipoRed_SelectedIndexChanged_1);
            // 
            // cbSeleccionCapa
            // 
            this.cbSeleccionCapa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbSeleccionCapa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(82)))), ((int)(((byte)(102)))));
            this.cbSeleccionCapa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSeleccionCapa.Enabled = false;
            this.cbSeleccionCapa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSeleccionCapa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.cbSeleccionCapa.FormattingEnabled = true;
            this.cbSeleccionCapa.Items.AddRange(new object[] {
            "Seleccione tipo de capas",
            "Unicapa",
            "Multicapa"});
            this.cbSeleccionCapa.Location = new System.Drawing.Point(941, 58);
            this.cbSeleccionCapa.Name = "cbSeleccionCapa";
            this.cbSeleccionCapa.Size = new System.Drawing.Size(210, 23);
            this.cbSeleccionCapa.TabIndex = 24;
            this.cbSeleccionCapa.SelectedIndexChanged += new System.EventHandler(this.cbSeleccionCapa_SelectedIndexChanged);
            // 
            // txtRuta
            // 
            this.txtRuta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRuta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(83)))), ((int)(((byte)(102)))));
            this.txtRuta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.txtRuta.Location = new System.Drawing.Point(14, 63);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.ReadOnly = true;
            this.txtRuta.Size = new System.Drawing.Size(207, 20);
            this.txtRuta.TabIndex = 23;
            this.txtRuta.Text = "Ruta";
            this.txtRuta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox4.Controls.Add(this.lb_patrones);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.lb_salidas);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.lb_entradas);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(241, 9);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(679, 74);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            // 
            // lb_patrones
            // 
            this.lb_patrones.AutoSize = true;
            this.lb_patrones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_patrones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.lb_patrones.Location = new System.Drawing.Point(569, 42);
            this.lb_patrones.Name = "lb_patrones";
            this.lb_patrones.Size = new System.Drawing.Size(59, 15);
            this.lb_patrones.TabIndex = 8;
            this.lb_patrones.Text = "patterns";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.label2.Location = new System.Drawing.Point(49, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Entradas: ";
            // 
            // lb_salidas
            // 
            this.lb_salidas.AutoSize = true;
            this.lb_salidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_salidas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.lb_salidas.Location = new System.Drawing.Point(317, 42);
            this.lb_salidas.Name = "lb_salidas";
            this.lb_salidas.Size = new System.Drawing.Size(27, 15);
            this.lb_salidas.TabIndex = 7;
            this.lb_salidas.Text = "out";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.label3.Location = new System.Drawing.Point(300, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Salidas: ";
            // 
            // lb_entradas
            // 
            this.lb_entradas.AutoSize = true;
            this.lb_entradas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_entradas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.lb_entradas.Location = new System.Drawing.Point(72, 42);
            this.lb_entradas.Name = "lb_entradas";
            this.lb_entradas.Size = new System.Drawing.Size(19, 15);
            this.lb_entradas.TabIndex = 6;
            this.lb_entradas.Text = "in";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.label4.Location = new System.Drawing.Point(543, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Patrones: ";
            // 
            // BtmCargar
            // 
            this.BtmCargar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtmCargar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            this.BtmCargar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtmCargar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.BtmCargar.FlatAppearance.BorderSize = 0;
            this.BtmCargar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(77)))));
            this.BtmCargar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.BtmCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold);
            this.BtmCargar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.BtmCargar.Location = new System.Drawing.Point(14, 19);
            this.BtmCargar.Name = "BtmCargar";
            this.BtmCargar.Size = new System.Drawing.Size(207, 36);
            this.BtmCargar.TabIndex = 21;
            this.BtmCargar.Text = "Cargar archivo";
            this.BtmCargar.UseVisualStyleBackColor = false;
            this.BtmCargar.Click += new System.EventHandler(this.BtmCargar_Click_1);
            // 
            // FrmPrincipal
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(194)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(1175, 820);
            this.Controls.Add(this.panelPaso1);
            this.Controls.Add(this.panelcontenedor);
            this.Controls.Add(this.panel3);
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelcontenedor.ResumeLayout(false);
            this.panelPaso3.ResumeLayout(false);
            this.panelPaso3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRataAprendizaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudErrorMaximo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroIteraciones)).EndInit();
            this.panelPaso1.ResumeLayout(false);
            this.panelPaso1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelcontenedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelPaso1;
        private System.Windows.Forms.ComboBox cbTipoRed;
        private System.Windows.Forms.ComboBox cbSeleccionCapa;
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lb_patrones;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_salidas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_entradas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtmCargar;
        private System.Windows.Forms.Panel panelContenedorTipo;
        private System.Windows.Forms.Panel panelPaso3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.NumericUpDown nudRataAprendizaje;
        private System.Windows.Forms.NumericUpDown nudErrorMaximo;
        private System.Windows.Forms.NumericUpDown nudNumeroIteraciones;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

