namespace Redes_Neuronales {
    partial class FrmSimulacion {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvEntradas = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvSalidas = new System.Windows.Forms.DataGridView();
            this.dgvSimSalidas = new System.Windows.Forms.DataGridView();
            this.dgvSimEntradas = new System.Windows.Forms.DataGridView();
            this.btmAñadir = new System.Windows.Forms.Button();
            this.btmSimular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntradas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSimSalidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSimEntradas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEntradas
            // 
            this.dgvEntradas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(194)))), ((int)(((byte)(211)))));
            this.dgvEntradas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvEntradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntradas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(194)))), ((int)(((byte)(211)))));
            this.dgvEntradas.Location = new System.Drawing.Point(45, 150);
            this.dgvEntradas.Margin = new System.Windows.Forms.Padding(2);
            this.dgvEntradas.Name = "dgvEntradas";
            this.dgvEntradas.RowHeadersVisible = false;
            this.dgvEntradas.RowHeadersWidth = 51;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            this.dgvEntradas.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEntradas.RowTemplate.Height = 24;
            this.dgvEntradas.Size = new System.Drawing.Size(257, 300);
            this.dgvEntradas.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            this.label10.Location = new System.Drawing.Point(41, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 24);
            this.label10.TabIndex = 19;
            this.label10.Text = "Simulacion";
            // 
            // dgvSalidas
            // 
            this.dgvSalidas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(194)))), ((int)(((byte)(211)))));
            this.dgvSalidas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSalidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalidas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(194)))), ((int)(((byte)(211)))));
            this.dgvSalidas.Location = new System.Drawing.Point(317, 150);
            this.dgvSalidas.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSalidas.Name = "dgvSalidas";
            this.dgvSalidas.RowHeadersVisible = false;
            this.dgvSalidas.RowHeadersWidth = 51;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            this.dgvSalidas.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSalidas.RowTemplate.Height = 24;
            this.dgvSalidas.Size = new System.Drawing.Size(257, 300);
            this.dgvSalidas.TabIndex = 20;
            // 
            // dgvSimSalidas
            // 
            this.dgvSimSalidas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(194)))), ((int)(((byte)(211)))));
            this.dgvSimSalidas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSimSalidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSimSalidas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(194)))), ((int)(((byte)(211)))));
            this.dgvSimSalidas.Location = new System.Drawing.Point(958, 150);
            this.dgvSimSalidas.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSimSalidas.Name = "dgvSimSalidas";
            this.dgvSimSalidas.RowHeadersVisible = false;
            this.dgvSimSalidas.RowHeadersWidth = 51;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            this.dgvSimSalidas.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSimSalidas.RowTemplate.Height = 24;
            this.dgvSimSalidas.Size = new System.Drawing.Size(257, 300);
            this.dgvSimSalidas.TabIndex = 34;
            // 
            // dgvSimEntradas
            // 
            this.dgvSimEntradas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(194)))), ((int)(((byte)(211)))));
            this.dgvSimEntradas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSimEntradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSimEntradas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(194)))), ((int)(((byte)(211)))));
            this.dgvSimEntradas.Location = new System.Drawing.Point(686, 150);
            this.dgvSimEntradas.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSimEntradas.Name = "dgvSimEntradas";
            this.dgvSimEntradas.RowHeadersVisible = false;
            this.dgvSimEntradas.RowHeadersWidth = 51;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            this.dgvSimEntradas.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSimEntradas.RowTemplate.Height = 24;
            this.dgvSimEntradas.Size = new System.Drawing.Size(257, 300);
            this.dgvSimEntradas.TabIndex = 33;
            this.dgvSimEntradas.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSimEntradas_CellEndEdit);
            this.dgvSimEntradas.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvSimEntradas_CellValidating);
            this.dgvSimEntradas.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvSimEntradas_EditingControlShowing);
            this.dgvSimEntradas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvSimEntradas_KeyPress);
            // 
            // btmAñadir
            // 
            this.btmAñadir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            this.btmAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmAñadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold);
            this.btmAñadir.Location = new System.Drawing.Point(686, 100);
            this.btmAñadir.Name = "btmAñadir";
            this.btmAñadir.Size = new System.Drawing.Size(95, 34);
            this.btmAñadir.TabIndex = 35;
            this.btmAñadir.Text = "Añadir";
            this.btmAñadir.UseVisualStyleBackColor = false;
            this.btmAñadir.Click += new System.EventHandler(this.btmAñadir_Click);
            // 
            // btmSimular
            // 
            this.btmSimular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            this.btmSimular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmSimular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold);
            this.btmSimular.Location = new System.Drawing.Point(595, 150);
            this.btmSimular.Name = "btmSimular";
            this.btmSimular.Size = new System.Drawing.Size(71, 300);
            this.btmSimular.TabIndex = 36;
            this.btmSimular.Text = "Simular";
            this.btmSimular.UseVisualStyleBackColor = false;
            this.btmSimular.Click += new System.EventHandler(this.btmSimular_Click);
            // 
            // FrmSimulacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(194)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(1286, 661);
            this.Controls.Add(this.btmSimular);
            this.Controls.Add(this.btmAñadir);
            this.Controls.Add(this.dgvSimSalidas);
            this.Controls.Add(this.dgvSimEntradas);
            this.Controls.Add(this.dgvSalidas);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgvEntradas);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmSimulacion";
            this.Text = "FrmSimulacion";
            this.Load += new System.EventHandler(this.FrmSimulacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntradas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSimSalidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSimEntradas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEntradas;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvSalidas;
        private System.Windows.Forms.DataGridView dgvSimSalidas;
        private System.Windows.Forms.DataGridView dgvSimEntradas;
        private System.Windows.Forms.Button btmAñadir;
        private System.Windows.Forms.Button btmSimular;
    }
}