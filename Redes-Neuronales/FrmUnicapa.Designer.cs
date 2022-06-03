namespace Redes_Neuronales
{
    partial class FrmUnicapa
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.label10 = new System.Windows.Forms.Label();
            this.gbAE_unicapa = new System.Windows.Forms.GroupBox();
            this.cbAE_unicapa = new System.Windows.Forms.ComboBox();
            this.gbFA_unicapa = new System.Windows.Forms.GroupBox();
            this.cbFA_unicapa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtmCargar = new System.Windows.Forms.Button();
            this.gbMatriz = new System.Windows.Forms.GroupBox();
            this.GraficaEi = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gbVector = new System.Windows.Forms.GroupBox();
            this.BtmEntrenar = new System.Windows.Forms.Button();
            this.lsbVectorUmbrales = new System.Windows.Forms.ListBox();
            this.dgvMatrizPesos = new System.Windows.Forms.DataGridView();
            this.GraficaYdYR = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gbAE_unicapa.SuspendLayout();
            this.gbFA_unicapa.SuspendLayout();
            this.gbMatriz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GraficaEi)).BeginInit();
            this.gbVector.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrizPesos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GraficaYdYR)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            this.label10.Location = new System.Drawing.Point(184, 32);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 29);
            this.label10.TabIndex = 18;
            this.label10.Text = "Unicapa";
            // 
            // gbAE_unicapa
            // 
            this.gbAE_unicapa.Controls.Add(this.cbAE_unicapa);
            this.gbAE_unicapa.Enabled = false;
            this.gbAE_unicapa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Italic);
            this.gbAE_unicapa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            this.gbAE_unicapa.Location = new System.Drawing.Point(884, 154);
            this.gbAE_unicapa.Margin = new System.Windows.Forms.Padding(4);
            this.gbAE_unicapa.Name = "gbAE_unicapa";
            this.gbAE_unicapa.Padding = new System.Windows.Forms.Padding(4);
            this.gbAE_unicapa.Size = new System.Drawing.Size(489, 81);
            this.gbAE_unicapa.TabIndex = 21;
            this.gbAE_unicapa.TabStop = false;
            this.gbAE_unicapa.Text = "Algoritmo de entrenamiento";
            // 
            // cbAE_unicapa
            // 
            this.cbAE_unicapa.BackColor = System.Drawing.Color.LightSteelBlue;
            this.cbAE_unicapa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAE_unicapa.Enabled = false;
            this.cbAE_unicapa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAE_unicapa.FormattingEnabled = true;
            this.cbAE_unicapa.Location = new System.Drawing.Point(77, 33);
            this.cbAE_unicapa.Margin = new System.Windows.Forms.Padding(4);
            this.cbAE_unicapa.Name = "cbAE_unicapa";
            this.cbAE_unicapa.Size = new System.Drawing.Size(351, 26);
            this.cbAE_unicapa.TabIndex = 0;
            this.cbAE_unicapa.SelectedIndexChanged += new System.EventHandler(this.cbAE_unicapa_SelectedIndexChanged);
            // 
            // gbFA_unicapa
            // 
            this.gbFA_unicapa.Controls.Add(this.cbFA_unicapa);
            this.gbFA_unicapa.Enabled = false;
            this.gbFA_unicapa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Italic);
            this.gbFA_unicapa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            this.gbFA_unicapa.Location = new System.Drawing.Point(189, 150);
            this.gbFA_unicapa.Margin = new System.Windows.Forms.Padding(4);
            this.gbFA_unicapa.Name = "gbFA_unicapa";
            this.gbFA_unicapa.Padding = new System.Windows.Forms.Padding(4);
            this.gbFA_unicapa.Size = new System.Drawing.Size(489, 90);
            this.gbFA_unicapa.TabIndex = 20;
            this.gbFA_unicapa.TabStop = false;
            this.gbFA_unicapa.Text = "Funcion de activacion";
            // 
            // cbFA_unicapa
            // 
            this.cbFA_unicapa.BackColor = System.Drawing.Color.LightSteelBlue;
            this.cbFA_unicapa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFA_unicapa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFA_unicapa.FormattingEnabled = true;
            this.cbFA_unicapa.Location = new System.Drawing.Point(77, 33);
            this.cbFA_unicapa.Margin = new System.Windows.Forms.Padding(4);
            this.cbFA_unicapa.Name = "cbFA_unicapa";
            this.cbFA_unicapa.Size = new System.Drawing.Size(351, 26);
            this.cbFA_unicapa.TabIndex = 0;
            this.cbFA_unicapa.SelectedIndexChanged += new System.EventHandler(this.cbFA_unicapa_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            this.label1.Location = new System.Drawing.Point(185, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 20);
            this.label1.TabIndex = 22;
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
            this.BtmCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold);
            this.BtmCargar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.BtmCargar.Location = new System.Drawing.Point(577, 76);
            this.BtmCargar.Margin = new System.Windows.Forms.Padding(4);
            this.BtmCargar.Name = "BtmCargar";
            this.BtmCargar.Size = new System.Drawing.Size(124, 33);
            this.BtmCargar.TabIndex = 31;
            this.BtmCargar.Text = "Inicializar";
            this.BtmCargar.UseVisualStyleBackColor = false;
            this.BtmCargar.Click += new System.EventHandler(this.BtmCargar_Click);
            // 
            // gbMatriz
            // 
            this.gbMatriz.Controls.Add(this.GraficaEi);
            this.gbMatriz.Enabled = false;
            this.gbMatriz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Italic);
            this.gbMatriz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            this.gbMatriz.Location = new System.Drawing.Point(189, 286);
            this.gbMatriz.Margin = new System.Windows.Forms.Padding(4);
            this.gbMatriz.Name = "gbMatriz";
            this.gbMatriz.Padding = new System.Windows.Forms.Padding(4);
            this.gbMatriz.Size = new System.Drawing.Size(489, 295);
            this.gbMatriz.TabIndex = 32;
            this.gbMatriz.TabStop = false;
            this.gbMatriz.Text = "Grafica de error de iteracion";
            // 
            // GraficaEi
            // 
            this.GraficaEi.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.GraficaEi.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.GraficaEi.Legends.Add(legend1);
            this.GraficaEi.Location = new System.Drawing.Point(7, 24);
            this.GraficaEi.Name = "GraficaEi";
            this.GraficaEi.Size = new System.Drawing.Size(475, 264);
            this.GraficaEi.TabIndex = 29;
            this.GraficaEi.Text = "chart1";
            // 
            // gbVector
            // 
            this.gbVector.Controls.Add(this.GraficaYdYR);
            this.gbVector.Enabled = false;
            this.gbVector.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Italic);
            this.gbVector.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            this.gbVector.Location = new System.Drawing.Point(884, 286);
            this.gbVector.Margin = new System.Windows.Forms.Padding(4);
            this.gbVector.Name = "gbVector";
            this.gbVector.Padding = new System.Windows.Forms.Padding(4);
            this.gbVector.Size = new System.Drawing.Size(489, 295);
            this.gbVector.TabIndex = 33;
            this.gbVector.TabStop = false;
            this.gbVector.Text = "Grafica YD vs YR";
            // 
            // BtmEntrenar
            // 
            this.BtmEntrenar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtmEntrenar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            this.BtmEntrenar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtmEntrenar.Enabled = false;
            this.BtmEntrenar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.BtmEntrenar.FlatAppearance.BorderSize = 0;
            this.BtmEntrenar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(77)))));
            this.BtmEntrenar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.BtmEntrenar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtmEntrenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold);
            this.BtmEntrenar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.BtmEntrenar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtmEntrenar.Location = new System.Drawing.Point(677, 608);
            this.BtmEntrenar.Margin = new System.Windows.Forms.Padding(4);
            this.BtmEntrenar.Name = "BtmEntrenar";
            this.BtmEntrenar.Size = new System.Drawing.Size(205, 66);
            this.BtmEntrenar.TabIndex = 34;
            this.BtmEntrenar.Text = "Comenzar Entrenamiento";
            this.BtmEntrenar.UseVisualStyleBackColor = false;
            this.BtmEntrenar.Click += new System.EventHandler(this.BtmEntrenar_Click);
            // 
            // lsbVectorUmbrales
            // 
            this.lsbVectorUmbrales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(194)))), ((int)(((byte)(211)))));
            this.lsbVectorUmbrales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lsbVectorUmbrales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            this.lsbVectorUmbrales.FormattingEnabled = true;
            this.lsbVectorUmbrales.ItemHeight = 16;
            this.lsbVectorUmbrales.Location = new System.Drawing.Point(1113, 26);
            this.lsbVectorUmbrales.Margin = new System.Windows.Forms.Padding(4);
            this.lsbVectorUmbrales.Name = "lsbVectorUmbrales";
            this.lsbVectorUmbrales.Size = new System.Drawing.Size(126, 48);
            this.lsbVectorUmbrales.TabIndex = 0;
            this.lsbVectorUmbrales.Visible = false;
            // 
            // dgvMatrizPesos
            // 
            this.dgvMatrizPesos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(194)))), ((int)(((byte)(211)))));
            this.dgvMatrizPesos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMatrizPesos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatrizPesos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(194)))), ((int)(((byte)(211)))));
            this.dgvMatrizPesos.Location = new System.Drawing.Point(860, 26);
            this.dgvMatrizPesos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMatrizPesos.Name = "dgvMatrizPesos";
            this.dgvMatrizPesos.RowHeadersWidth = 51;
            this.dgvMatrizPesos.Size = new System.Drawing.Size(111, 76);
            this.dgvMatrizPesos.TabIndex = 28;
            this.dgvMatrizPesos.Visible = false;
            // 
            // GraficaYdYR
            // 
            this.GraficaYdYR.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.GraficaYdYR.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.GraficaYdYR.Legends.Add(legend2);
            this.GraficaYdYR.Location = new System.Drawing.Point(7, 24);
            this.GraficaYdYR.Name = "GraficaYdYR";
            this.GraficaYdYR.Size = new System.Drawing.Size(475, 264);
            this.GraficaYdYR.TabIndex = 30;
            this.GraficaYdYR.Text = "chart1";
            // 
            // FrmUnicapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(194)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(1567, 716);
            this.Controls.Add(this.lsbVectorUmbrales);
            this.Controls.Add(this.BtmEntrenar);
            this.Controls.Add(this.dgvMatrizPesos);
            this.Controls.Add(this.gbVector);
            this.Controls.Add(this.gbMatriz);
            this.Controls.Add(this.BtmCargar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbAE_unicapa);
            this.Controls.Add(this.gbFA_unicapa);
            this.Controls.Add(this.label10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmUnicapa";
            this.Text = "FrmUnicapa";
            this.gbAE_unicapa.ResumeLayout(false);
            this.gbFA_unicapa.ResumeLayout(false);
            this.gbMatriz.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GraficaEi)).EndInit();
            this.gbVector.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrizPesos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GraficaYdYR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox gbAE_unicapa;
        private System.Windows.Forms.ComboBox cbAE_unicapa;
        private System.Windows.Forms.GroupBox gbFA_unicapa;
        private System.Windows.Forms.ComboBox cbFA_unicapa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtmCargar;
        private System.Windows.Forms.GroupBox gbMatriz;
        private System.Windows.Forms.GroupBox gbVector;
        private System.Windows.Forms.Button BtmEntrenar;
        private System.Windows.Forms.DataVisualization.Charting.Chart GraficaEi;
        private System.Windows.Forms.ListBox lsbVectorUmbrales;
        private System.Windows.Forms.DataGridView dgvMatrizPesos;
        private System.Windows.Forms.DataVisualization.Charting.Chart GraficaYdYR;
    }
}