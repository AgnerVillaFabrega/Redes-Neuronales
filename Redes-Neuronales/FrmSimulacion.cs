using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Redes_Neuronales {
    public partial class FrmSimulacion : Form {
        public FrmSimulacion() {
            InitializeComponent();
        }


        private void FrmSimulacion_Load(object sender, EventArgs e) {

            DataGridViewRow dgv  = new DataGridViewRow();

            dgv.CreateCells(DGV_Principal);

            foreach (int[] linea in Variables.Entradas) {

                DGV_Principal.Rows.Add("",linea[0].ToString());
            }

        }

    }
}
