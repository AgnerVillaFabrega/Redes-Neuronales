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
            this.DGV_Principal = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Text_Simular = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Principal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Principal
            // 
            this.DGV_Principal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Principal.Location = new System.Drawing.Point(12, 108);
            this.DGV_Principal.Name = "DGV_Principal";
            this.DGV_Principal.RowHeadersWidth = 51;
            this.DGV_Principal.RowTemplate.Height = 24;
            this.DGV_Principal.Size = new System.Drawing.Size(592, 445);
            this.DGV_Principal.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(772, 108);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(592, 445);
            this.dataGridView2.TabIndex = 1;
            // 
            // Text_Simular
            // 
            this.Text_Simular.AutoSize = true;
            this.Text_Simular.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_Simular.Location = new System.Drawing.Point(613, 9);
            this.Text_Simular.Name = "Text_Simular";
            this.Text_Simular.Size = new System.Drawing.Size(162, 46);
            this.Text_Simular.TabIndex = 2;
            this.Text_Simular.Text = "Simular";
            // 
            // FrmSimulacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 717);
            this.Controls.Add(this.Text_Simular);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.DGV_Principal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmSimulacion";
            this.Text = "FrmSimulacion";
            this.Load += new System.EventHandler(this.FrmSimulacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Principal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Principal;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label Text_Simular;
    }
}