namespace Redes_Neuronales
{
    partial class FrmMulticapa
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
            this.label9 = new System.Windows.Forms.Label();
            this.cbFA_capa1 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtmCargar = new System.Windows.Forms.Button();
            this.gbCapa1 = new System.Windows.Forms.GroupBox();
            this.nudCap1NumNeur = new System.Windows.Forms.NumericUpDown();
            this.cbNumCapas = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.cbAE_multicapa = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cbFA_capaSalida = new System.Windows.Forms.ComboBox();
            this.txtNumNeuronas_Salida = new System.Windows.Forms.TextBox();
            this.gbCapaSalida = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btmGenerar = new System.Windows.Forms.Button();
            this.panelMVCapa2 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lsbU2 = new System.Windows.Forms.ListBox();
            this.gbW12 = new System.Windows.Forms.GroupBox();
            this.dgvW12 = new System.Windows.Forms.DataGridView();
            this.panelMVCapa1 = new System.Windows.Forms.Panel();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.lsbU1 = new System.Windows.Forms.ListBox();
            this.gbWE = new System.Windows.Forms.GroupBox();
            this.dgvWE = new System.Windows.Forms.DataGridView();
            this.panelMVCapaSalida = new System.Windows.Forms.Panel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lsbUS = new System.Windows.Forms.ListBox();
            this.gbW3S = new System.Windows.Forms.GroupBox();
            this.dgvW3S = new System.Windows.Forms.DataGridView();
            this.panelMVCapa3 = new System.Windows.Forms.Panel();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.lsbU3 = new System.Windows.Forms.ListBox();
            this.gbW23 = new System.Windows.Forms.GroupBox();
            this.dgvW23 = new System.Windows.Forms.DataGridView();
            this.gbCapa2 = new System.Windows.Forms.GroupBox();
            this.nudCap2NumNeur = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFA_capa2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbCapa3 = new System.Windows.Forms.GroupBox();
            this.nudCap3NumNeur = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.cbFA_capa3 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gbCapa1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCap1NumNeur)).BeginInit();
            this.gbCapaSalida.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.panelMVCapa2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.gbW12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvW12)).BeginInit();
            this.panelMVCapa1.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.gbWE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWE)).BeginInit();
            this.panelMVCapaSalida.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.gbW3S.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvW3S)).BeginInit();
            this.panelMVCapa3.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.gbW23.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvW23)).BeginInit();
            this.gbCapa2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCap2NumNeur)).BeginInit();
            this.gbCapa3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCap3NumNeur)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("JetBrains Mono NL", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            this.label9.Location = new System.Drawing.Point(93, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 25);
            this.label9.TabIndex = 16;
            this.label9.Text = "Multicapa";
            // 
            // cbFA_capa1
            // 
            this.cbFA_capa1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.cbFA_capa1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFA_capa1.Font = new System.Drawing.Font("JetBrains Mono Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFA_capa1.FormattingEnabled = true;
            this.cbFA_capa1.Items.AddRange(new object[] {
            "Sigmoide",
            "Gausiana",
            "Tangente hiperbolica",
            "Seno",
            "Coseno"});
            this.cbFA_capa1.Location = new System.Drawing.Point(636, 32);
            this.cbFA_capa1.Name = "cbFA_capa1";
            this.cbFA_capa1.Size = new System.Drawing.Size(139, 22);
            this.cbFA_capa1.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 8.999999F, System.Drawing.FontStyle.Italic);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            this.label12.Location = new System.Drawing.Point(154, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 16);
            this.label12.TabIndex = 14;
            this.label12.Text = "Numero de neuronas";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 8.999999F, System.Drawing.FontStyle.Italic);
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            this.label16.Location = new System.Drawing.Point(469, 35);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(161, 16);
            this.label16.TabIndex = 22;
            this.label16.Text = "Funcion de activacion ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("JetBrains Mono NL", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            this.label1.Location = new System.Drawing.Point(143, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "Inicializacion de pesos y umbrales";
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
            this.BtmCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtmCargar.Font = new System.Drawing.Font("JetBrains Mono NL SemiBold", 8.999999F, System.Drawing.FontStyle.Bold);
            this.BtmCargar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.BtmCargar.Location = new System.Drawing.Point(455, 87);
            this.BtmCargar.Name = "BtmCargar";
            this.BtmCargar.Size = new System.Drawing.Size(93, 27);
            this.BtmCargar.TabIndex = 33;
            this.BtmCargar.Text = "Inicializar";
            this.BtmCargar.UseVisualStyleBackColor = false;
            this.BtmCargar.Click += new System.EventHandler(this.BtmCargar_Click);
            // 
            // gbCapa1
            // 
            this.gbCapa1.Controls.Add(this.nudCap1NumNeur);
            this.gbCapa1.Controls.Add(this.label16);
            this.gbCapa1.Controls.Add(this.cbFA_capa1);
            this.gbCapa1.Controls.Add(this.label12);
            this.gbCapa1.Enabled = false;
            this.gbCapa1.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 8.999999F, System.Drawing.FontStyle.Italic);
            this.gbCapa1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            this.gbCapa1.Location = new System.Drawing.Point(164, 153);
            this.gbCapa1.Name = "gbCapa1";
            this.gbCapa1.Size = new System.Drawing.Size(870, 74);
            this.gbCapa1.TabIndex = 34;
            this.gbCapa1.TabStop = false;
            this.gbCapa1.Text = "Capa #1";
            // 
            // nudCap1NumNeur
            // 
            this.nudCap1NumNeur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            this.nudCap1NumNeur.Location = new System.Drawing.Point(304, 32);
            this.nudCap1NumNeur.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudCap1NumNeur.Name = "nudCap1NumNeur";
            this.nudCap1NumNeur.Size = new System.Drawing.Size(43, 23);
            this.nudCap1NumNeur.TabIndex = 41;
            // 
            // cbNumCapas
            // 
            this.cbNumCapas.BackColor = System.Drawing.Color.LightSteelBlue;
            this.cbNumCapas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNumCapas.Enabled = false;
            this.cbNumCapas.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNumCapas.FormattingEnabled = true;
            this.cbNumCapas.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbNumCapas.Location = new System.Drawing.Point(342, 128);
            this.cbNumCapas.Name = "cbNumCapas";
            this.cbNumCapas.Size = new System.Drawing.Size(59, 24);
            this.cbNumCapas.TabIndex = 13;
            this.cbNumCapas.SelectedIndexChanged += new System.EventHandler(this.cbNumCapas_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 8.999999F, System.Drawing.FontStyle.Italic);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            this.label11.Location = new System.Drawing.Point(161, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(175, 16);
            this.label11.TabIndex = 12;
            this.label11.Text = "Numero de capas ocultas:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 8.999999F, System.Drawing.FontStyle.Italic);
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            this.label20.Location = new System.Drawing.Point(452, 132);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(189, 16);
            this.label20.TabIndex = 30;
            this.label20.Text = "Algoritmo de entrenamiento";
            // 
            // cbAE_multicapa
            // 
            this.cbAE_multicapa.BackColor = System.Drawing.Color.LightSteelBlue;
            this.cbAE_multicapa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAE_multicapa.Enabled = false;
            this.cbAE_multicapa.Font = new System.Drawing.Font("JetBrains Mono Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAE_multicapa.FormattingEnabled = true;
            this.cbAE_multicapa.Location = new System.Drawing.Point(647, 129);
            this.cbAE_multicapa.Name = "cbAE_multicapa";
            this.cbAE_multicapa.Size = new System.Drawing.Size(206, 22);
            this.cbAE_multicapa.TabIndex = 31;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 8.999999F, System.Drawing.FontStyle.Italic);
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            this.label19.Location = new System.Drawing.Point(411, 37);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(210, 16);
            this.label19.TabIndex = 28;
            this.label19.Text = "Funcion de activacion salidas";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 8.999999F, System.Drawing.FontStyle.Italic);
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            this.label15.Location = new System.Drawing.Point(112, 37);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(175, 16);
            this.label15.TabIndex = 20;
            this.label15.Text = "Neuronas capa de salida:";
            // 
            // cbFA_capaSalida
            // 
            this.cbFA_capaSalida.BackColor = System.Drawing.Color.LightSteelBlue;
            this.cbFA_capaSalida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFA_capaSalida.Font = new System.Drawing.Font("JetBrains Mono Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFA_capaSalida.FormattingEnabled = true;
            this.cbFA_capaSalida.Items.AddRange(new object[] {
            "Sigmoide",
            "Gausiana",
            "Tangente hiperbolica",
            "Seno",
            "Coseno",
            "Lineal"});
            this.cbFA_capaSalida.Location = new System.Drawing.Point(636, 34);
            this.cbFA_capaSalida.Name = "cbFA_capaSalida";
            this.cbFA_capaSalida.Size = new System.Drawing.Size(139, 22);
            this.cbFA_capaSalida.TabIndex = 29;
            // 
            // txtNumNeuronas_Salida
            // 
            this.txtNumNeuronas_Salida.Enabled = false;
            this.txtNumNeuronas_Salida.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumNeuronas_Salida.Location = new System.Drawing.Point(304, 34);
            this.txtNumNeuronas_Salida.Name = "txtNumNeuronas_Salida";
            this.txtNumNeuronas_Salida.Size = new System.Drawing.Size(43, 23);
            this.txtNumNeuronas_Salida.TabIndex = 21;
            // 
            // gbCapaSalida
            // 
            this.gbCapaSalida.Controls.Add(this.label19);
            this.gbCapaSalida.Controls.Add(this.label15);
            this.gbCapaSalida.Controls.Add(this.cbFA_capaSalida);
            this.gbCapaSalida.Controls.Add(this.txtNumNeuronas_Salida);
            this.gbCapaSalida.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 8.999999F, System.Drawing.FontStyle.Italic);
            this.gbCapaSalida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            this.gbCapaSalida.Location = new System.Drawing.Point(164, 393);
            this.gbCapaSalida.Name = "gbCapaSalida";
            this.gbCapaSalida.Size = new System.Drawing.Size(870, 74);
            this.gbCapaSalida.TabIndex = 37;
            this.gbCapaSalida.TabStop = false;
            this.gbCapaSalida.Text = "Capa de salida";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btmGenerar);
            this.groupBox7.Controls.Add(this.panelMVCapa2);
            this.groupBox7.Controls.Add(this.panelMVCapa1);
            this.groupBox7.Controls.Add(this.panelMVCapaSalida);
            this.groupBox7.Controls.Add(this.panelMVCapa3);
            this.groupBox7.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 8.999999F, System.Drawing.FontStyle.Italic);
            this.groupBox7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            this.groupBox7.Location = new System.Drawing.Point(164, 491);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(870, 453);
            this.groupBox7.TabIndex = 38;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Matrices de peso y vectores de umbrales";
            // 
            // btmGenerar
            // 
            this.btmGenerar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btmGenerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            this.btmGenerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btmGenerar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.btmGenerar.FlatAppearance.BorderSize = 0;
            this.btmGenerar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(77)))));
            this.btmGenerar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.btmGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmGenerar.Font = new System.Drawing.Font("JetBrains Mono NL", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmGenerar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.btmGenerar.Location = new System.Drawing.Point(31, 26);
            this.btmGenerar.Name = "btmGenerar";
            this.btmGenerar.Size = new System.Drawing.Size(216, 28);
            this.btmGenerar.TabIndex = 41;
            this.btmGenerar.Text = "Generar matrices y vectores";
            this.btmGenerar.UseVisualStyleBackColor = false;
            this.btmGenerar.Click += new System.EventHandler(this.btmGenerar_Click);
            // 
            // panelMVCapa2
            // 
            this.panelMVCapa2.Controls.Add(this.groupBox4);
            this.panelMVCapa2.Controls.Add(this.gbW12);
            this.panelMVCapa2.Location = new System.Drawing.Point(445, 67);
            this.panelMVCapa2.Name = "panelMVCapa2";
            this.panelMVCapa2.Size = new System.Drawing.Size(398, 181);
            this.panelMVCapa2.TabIndex = 41;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lsbU2);
            this.groupBox4.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 8.999999F, System.Drawing.FontStyle.Italic);
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            this.groupBox4.Location = new System.Drawing.Point(294, 9);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(99, 164);
            this.groupBox4.TabIndex = 37;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "U2";
            // 
            // lsbU2
            // 
            this.lsbU2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(194)))), ((int)(((byte)(211)))));
            this.lsbU2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lsbU2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            this.lsbU2.FormattingEnabled = true;
            this.lsbU2.ItemHeight = 16;
            this.lsbU2.Location = new System.Drawing.Point(6, 30);
            this.lsbU2.Name = "lsbU2";
            this.lsbU2.Size = new System.Drawing.Size(87, 128);
            this.lsbU2.TabIndex = 0;
            // 
            // gbW12
            // 
            this.gbW12.Controls.Add(this.dgvW12);
            this.gbW12.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 8.999999F, System.Drawing.FontStyle.Italic);
            this.gbW12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            this.gbW12.Location = new System.Drawing.Point(6, 9);
            this.gbW12.Name = "gbW12";
            this.gbW12.Size = new System.Drawing.Size(282, 164);
            this.gbW12.TabIndex = 36;
            this.gbW12.TabStop = false;
            this.gbW12.Text = "W12";
            // 
            // dgvW12
            // 
            this.dgvW12.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(194)))), ((int)(((byte)(211)))));
            this.dgvW12.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvW12.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvW12.ColumnHeadersVisible = false;
            this.dgvW12.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(194)))), ((int)(((byte)(211)))));
            this.dgvW12.Location = new System.Drawing.Point(6, 22);
            this.dgvW12.Name = "dgvW12";
            this.dgvW12.ReadOnly = true;
            this.dgvW12.RowHeadersVisible = false;
            this.dgvW12.Size = new System.Drawing.Size(268, 136);
            this.dgvW12.TabIndex = 28;
            // 
            // panelMVCapa1
            // 
            this.panelMVCapa1.Controls.Add(this.groupBox8);
            this.panelMVCapa1.Controls.Add(this.gbWE);
            this.panelMVCapa1.Location = new System.Drawing.Point(16, 67);
            this.panelMVCapa1.Name = "panelMVCapa1";
            this.panelMVCapa1.Size = new System.Drawing.Size(410, 182);
            this.panelMVCapa1.TabIndex = 40;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.lsbU1);
            this.groupBox8.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 8.999999F, System.Drawing.FontStyle.Italic);
            this.groupBox8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            this.groupBox8.Location = new System.Drawing.Point(303, 7);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(99, 164);
            this.groupBox8.TabIndex = 35;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "U1";
            // 
            // lsbU1
            // 
            this.lsbU1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(194)))), ((int)(((byte)(211)))));
            this.lsbU1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lsbU1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            this.lsbU1.FormattingEnabled = true;
            this.lsbU1.ItemHeight = 16;
            this.lsbU1.Location = new System.Drawing.Point(6, 30);
            this.lsbU1.Name = "lsbU1";
            this.lsbU1.Size = new System.Drawing.Size(87, 128);
            this.lsbU1.TabIndex = 0;
            // 
            // gbWE
            // 
            this.gbWE.Controls.Add(this.dgvWE);
            this.gbWE.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 8.999999F, System.Drawing.FontStyle.Italic);
            this.gbWE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            this.gbWE.Location = new System.Drawing.Point(15, 7);
            this.gbWE.Name = "gbWE";
            this.gbWE.Size = new System.Drawing.Size(282, 164);
            this.gbWE.TabIndex = 34;
            this.gbWE.TabStop = false;
            this.gbWE.Text = "WE";
            // 
            // dgvWE
            // 
            this.dgvWE.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(194)))), ((int)(((byte)(211)))));
            this.dgvWE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvWE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWE.ColumnHeadersVisible = false;
            this.dgvWE.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(194)))), ((int)(((byte)(211)))));
            this.dgvWE.Location = new System.Drawing.Point(6, 22);
            this.dgvWE.Name = "dgvWE";
            this.dgvWE.ReadOnly = true;
            this.dgvWE.RowHeadersVisible = false;
            this.dgvWE.Size = new System.Drawing.Size(268, 136);
            this.dgvWE.TabIndex = 28;
            // 
            // panelMVCapaSalida
            // 
            this.panelMVCapaSalida.Controls.Add(this.groupBox6);
            this.panelMVCapaSalida.Controls.Add(this.gbW3S);
            this.panelMVCapaSalida.Location = new System.Drawing.Point(436, 265);
            this.panelMVCapaSalida.Name = "panelMVCapaSalida";
            this.panelMVCapaSalida.Size = new System.Drawing.Size(416, 176);
            this.panelMVCapaSalida.TabIndex = 39;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lsbUS);
            this.groupBox6.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 8.999999F, System.Drawing.FontStyle.Italic);
            this.groupBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            this.groupBox6.Location = new System.Drawing.Point(308, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(99, 164);
            this.groupBox6.TabIndex = 37;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "US";
            // 
            // lsbUS
            // 
            this.lsbUS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(194)))), ((int)(((byte)(211)))));
            this.lsbUS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lsbUS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            this.lsbUS.FormattingEnabled = true;
            this.lsbUS.ItemHeight = 16;
            this.lsbUS.Location = new System.Drawing.Point(6, 30);
            this.lsbUS.Name = "lsbUS";
            this.lsbUS.Size = new System.Drawing.Size(87, 128);
            this.lsbUS.TabIndex = 0;
            // 
            // gbW3S
            // 
            this.gbW3S.Controls.Add(this.dgvW3S);
            this.gbW3S.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 8.999999F, System.Drawing.FontStyle.Italic);
            this.gbW3S.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            this.gbW3S.Location = new System.Drawing.Point(20, 3);
            this.gbW3S.Name = "gbW3S";
            this.gbW3S.Size = new System.Drawing.Size(282, 164);
            this.gbW3S.TabIndex = 36;
            this.gbW3S.TabStop = false;
            this.gbW3S.Text = "W3S";
            // 
            // dgvW3S
            // 
            this.dgvW3S.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(194)))), ((int)(((byte)(211)))));
            this.dgvW3S.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvW3S.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvW3S.ColumnHeadersVisible = false;
            this.dgvW3S.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(194)))), ((int)(((byte)(211)))));
            this.dgvW3S.Location = new System.Drawing.Point(6, 22);
            this.dgvW3S.Name = "dgvW3S";
            this.dgvW3S.ReadOnly = true;
            this.dgvW3S.RowHeadersVisible = false;
            this.dgvW3S.Size = new System.Drawing.Size(268, 136);
            this.dgvW3S.TabIndex = 28;
            // 
            // panelMVCapa3
            // 
            this.panelMVCapa3.Controls.Add(this.groupBox11);
            this.panelMVCapa3.Controls.Add(this.gbW23);
            this.panelMVCapa3.Location = new System.Drawing.Point(16, 265);
            this.panelMVCapa3.Name = "panelMVCapa3";
            this.panelMVCapa3.Size = new System.Drawing.Size(410, 181);
            this.panelMVCapa3.TabIndex = 38;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.lsbU3);
            this.groupBox11.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 8.999999F, System.Drawing.FontStyle.Italic);
            this.groupBox11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            this.groupBox11.Location = new System.Drawing.Point(301, 7);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(99, 164);
            this.groupBox11.TabIndex = 37;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "U3";
            // 
            // lsbU3
            // 
            this.lsbU3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(194)))), ((int)(((byte)(211)))));
            this.lsbU3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lsbU3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            this.lsbU3.FormattingEnabled = true;
            this.lsbU3.ItemHeight = 16;
            this.lsbU3.Location = new System.Drawing.Point(6, 30);
            this.lsbU3.Name = "lsbU3";
            this.lsbU3.Size = new System.Drawing.Size(87, 128);
            this.lsbU3.TabIndex = 1;
            // 
            // gbW23
            // 
            this.gbW23.Controls.Add(this.dgvW23);
            this.gbW23.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 8.999999F, System.Drawing.FontStyle.Italic);
            this.gbW23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            this.gbW23.Location = new System.Drawing.Point(13, 3);
            this.gbW23.Name = "gbW23";
            this.gbW23.Size = new System.Drawing.Size(282, 164);
            this.gbW23.TabIndex = 36;
            this.gbW23.TabStop = false;
            this.gbW23.Text = "W23";
            // 
            // dgvW23
            // 
            this.dgvW23.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(194)))), ((int)(((byte)(211)))));
            this.dgvW23.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvW23.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvW23.ColumnHeadersVisible = false;
            this.dgvW23.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(194)))), ((int)(((byte)(211)))));
            this.dgvW23.Location = new System.Drawing.Point(6, 22);
            this.dgvW23.Name = "dgvW23";
            this.dgvW23.ReadOnly = true;
            this.dgvW23.RowHeadersVisible = false;
            this.dgvW23.Size = new System.Drawing.Size(268, 136);
            this.dgvW23.TabIndex = 28;
            // 
            // gbCapa2
            // 
            this.gbCapa2.Controls.Add(this.nudCap2NumNeur);
            this.gbCapa2.Controls.Add(this.label2);
            this.gbCapa2.Controls.Add(this.cbFA_capa2);
            this.gbCapa2.Controls.Add(this.label3);
            this.gbCapa2.Enabled = false;
            this.gbCapa2.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 8.999999F, System.Drawing.FontStyle.Italic);
            this.gbCapa2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            this.gbCapa2.Location = new System.Drawing.Point(164, 233);
            this.gbCapa2.Name = "gbCapa2";
            this.gbCapa2.Size = new System.Drawing.Size(870, 74);
            this.gbCapa2.TabIndex = 39;
            this.gbCapa2.TabStop = false;
            this.gbCapa2.Text = "Capa #2";
            // 
            // nudCap2NumNeur
            // 
            this.nudCap2NumNeur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            this.nudCap2NumNeur.Location = new System.Drawing.Point(304, 34);
            this.nudCap2NumNeur.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudCap2NumNeur.Name = "nudCap2NumNeur";
            this.nudCap2NumNeur.Size = new System.Drawing.Size(43, 23);
            this.nudCap2NumNeur.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 8.999999F, System.Drawing.FontStyle.Italic);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            this.label2.Location = new System.Drawing.Point(469, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Funcion de activacion ";
            // 
            // cbFA_capa2
            // 
            this.cbFA_capa2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.cbFA_capa2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFA_capa2.Font = new System.Drawing.Font("JetBrains Mono Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFA_capa2.FormattingEnabled = true;
            this.cbFA_capa2.Items.AddRange(new object[] {
            "Sigmoide",
            "Gausiana",
            "Tangente hiperbolica",
            "Seno",
            "Coseno"});
            this.cbFA_capa2.Location = new System.Drawing.Point(636, 34);
            this.cbFA_capa2.Name = "cbFA_capa2";
            this.cbFA_capa2.Size = new System.Drawing.Size(139, 22);
            this.cbFA_capa2.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 8.999999F, System.Drawing.FontStyle.Italic);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            this.label3.Location = new System.Drawing.Point(154, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Numero de neuronas";
            // 
            // gbCapa3
            // 
            this.gbCapa3.Controls.Add(this.nudCap3NumNeur);
            this.gbCapa3.Controls.Add(this.label4);
            this.gbCapa3.Controls.Add(this.cbFA_capa3);
            this.gbCapa3.Controls.Add(this.label5);
            this.gbCapa3.Enabled = false;
            this.gbCapa3.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 8.999999F, System.Drawing.FontStyle.Italic);
            this.gbCapa3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            this.gbCapa3.Location = new System.Drawing.Point(164, 313);
            this.gbCapa3.Name = "gbCapa3";
            this.gbCapa3.Size = new System.Drawing.Size(870, 74);
            this.gbCapa3.TabIndex = 40;
            this.gbCapa3.TabStop = false;
            this.gbCapa3.Text = "Capa #3";
            // 
            // nudCap3NumNeur
            // 
            this.nudCap3NumNeur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            this.nudCap3NumNeur.Location = new System.Drawing.Point(304, 29);
            this.nudCap3NumNeur.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudCap3NumNeur.Name = "nudCap3NumNeur";
            this.nudCap3NumNeur.Size = new System.Drawing.Size(43, 23);
            this.nudCap3NumNeur.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 8.999999F, System.Drawing.FontStyle.Italic);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            this.label4.Location = new System.Drawing.Point(469, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Funcion de activacion ";
            // 
            // cbFA_capa3
            // 
            this.cbFA_capa3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.cbFA_capa3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFA_capa3.Font = new System.Drawing.Font("JetBrains Mono Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFA_capa3.FormattingEnabled = true;
            this.cbFA_capa3.Items.AddRange(new object[] {
            "Sigmoide",
            "Gausiana",
            "Tangente hiperbolica",
            "Seno",
            "Coseno"});
            this.cbFA_capa3.Location = new System.Drawing.Point(636, 26);
            this.cbFA_capa3.Name = "cbFA_capa3";
            this.cbFA_capa3.Size = new System.Drawing.Size(139, 22);
            this.cbFA_capa3.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 8.999999F, System.Drawing.FontStyle.Italic);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            this.label5.Location = new System.Drawing.Point(154, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Numero de neuronas";
            // 
            // FrmMulticapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(194)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(1175, 969);
            this.Controls.Add(this.gbCapa3);
            this.Controls.Add(this.gbCapa2);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.gbCapaSalida);
            this.Controls.Add(this.gbCapa1);
            this.Controls.Add(this.BtmCargar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbAE_multicapa);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbNumCapas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmMulticapa";
            this.Text = "FrmMulticapa";
            this.gbCapa1.ResumeLayout(false);
            this.gbCapa1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCap1NumNeur)).EndInit();
            this.gbCapaSalida.ResumeLayout(false);
            this.gbCapaSalida.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.panelMVCapa2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.gbW12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvW12)).EndInit();
            this.panelMVCapa1.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.gbWE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWE)).EndInit();
            this.panelMVCapaSalida.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.gbW3S.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvW3S)).EndInit();
            this.panelMVCapa3.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.gbW23.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvW23)).EndInit();
            this.gbCapa2.ResumeLayout(false);
            this.gbCapa2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCap2NumNeur)).EndInit();
            this.gbCapa3.ResumeLayout(false);
            this.gbCapa3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCap3NumNeur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbFA_capa1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtmCargar;
        private System.Windows.Forms.GroupBox gbCapa1;
        private System.Windows.Forms.ComboBox cbNumCapas;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cbAE_multicapa;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbFA_capaSalida;
        private System.Windows.Forms.TextBox txtNumNeuronas_Salida;
        private System.Windows.Forms.GroupBox gbCapaSalida;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.ListBox lsbU1;
        private System.Windows.Forms.GroupBox gbWE;
        private System.Windows.Forms.DataGridView dgvWE;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ListBox lsbUS;
        private System.Windows.Forms.GroupBox gbW23;
        private System.Windows.Forms.DataGridView dgvW23;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox lsbU2;
        private System.Windows.Forms.GroupBox gbW3S;
        private System.Windows.Forms.DataGridView dgvW3S;
        private System.Windows.Forms.GroupBox gbW12;
        private System.Windows.Forms.DataGridView dgvW12;
        private System.Windows.Forms.GroupBox gbCapa2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFA_capa2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbCapa3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbFA_capa3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lsbU3;
        private System.Windows.Forms.Panel panelMVCapa2;
        private System.Windows.Forms.Panel panelMVCapa1;
        private System.Windows.Forms.Panel panelMVCapaSalida;
        private System.Windows.Forms.Panel panelMVCapa3;
        private System.Windows.Forms.Button btmGenerar;
        private System.Windows.Forms.NumericUpDown nudCap1NumNeur;
        private System.Windows.Forms.NumericUpDown nudCap2NumNeur;
        private System.Windows.Forms.NumericUpDown nudCap3NumNeur;
    }
}