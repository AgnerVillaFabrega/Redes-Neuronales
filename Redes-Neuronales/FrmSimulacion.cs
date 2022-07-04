using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Redes_Neuronales {
    public partial class FrmSimulacion : Form {
        public FrmSimulacion() {
            InitializeComponent();
        }
        public List<int[]> newEntradas = new List<int[]>();
        public List<int[]> newSalida = new List<int[]>();
        private void FrmSimulacion_Load(object sender, EventArgs e)
        {
            MostrarEntradas();
            MostrarSalidas();
        }
        private void MostrarEntradas()
        {
            dgvEntradas.ColumnCount = Variables.Entradas[0].Count();
            dgvEntradas.RowCount = Variables.Entradas.Count();

            for (int i = 0; i < Variables.Entradas.Count(); i++)
            {
                for (int j = 0; j < Variables.Entradas[0].Count(); j++)
                {
                    dgvEntradas.Rows[i].Cells[j].Value = Variables.Entradas[i][j].ToString();
                }
            }
        }
        private void MostrarSalidas()
        {
            dgvSalidas.ColumnCount = Variables.Salidas[0].Count();
            dgvSalidas.RowCount = Variables.Salidas.Count();

            for (int i = 0; i < Variables.Salidas.Count(); i++)
            {
                for (int j = 0; j < Variables.Salidas[0].Count(); j++)
                {
                    dgvSalidas.Rows[i].Cells[j].Value = Variables.Salidas[i][j].ToString();
                }
            }
        }

        private void btmAñadir_Click(object sender, EventArgs e)
        {
            aniadirEntradas();
            //buttonSimular.Enabled = true;
            
        }
        int con;
        private void aniadirEntradas()
        {
            con++;
            dgvSimEntradas.ColumnCount = Variables.Entradas[0].Count();
            dgvSimEntradas.Rows.Add();
            for (int i = 0; i < dgvSimEntradas.ColumnCount; i++)
            {
                dgvSimEntradas.Rows[dgvSimEntradas.RowCount - 1].Cells[i].Value = 0;
            }
           
        }

        private void dgvSimEntradas_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int tempValorCelda;
            try
            {
                tempValorCelda = Convert.ToInt32(dgvSimEntradas.SelectedCells[0].Value);
                if ((tempValorCelda != 0 && tempValorCelda != 1) || dgvSimEntradas.SelectedCells[0].Value == null)
                {
                    dgvSimEntradas.SelectedCells[0].Value = 0;
                }
            }
            catch (Exception)
            {
                dgvSimEntradas.SelectedCells[0].Value = 0;
            }
        }


       
        private void dgvSimEntradas_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 1) // 1 should be your column index
            {
                int i;

                if (!int.TryParse(Convert.ToString(e.FormattedValue), out i))
                {
                    e.Cancel = true;
                    //label1.Text = "please enter numeric";
                }
                else
                {
                    // the input is numeric 
                }
            }
        }

        private void dgvSimEntradas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dgvSimEntradas_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            try
            {
                e.Control.KeyPress +=
                new KeyPressEventHandler(dgvSimEntradas_KeyPress);

            }catch (Exception)
            {

            }
        }
        
        private void cargarPatronesDataGridEnLista()
        {
            int[] temp = new int[dgvSimEntradas.ColumnCount];
            for (int i = 0; i < dgvSimEntradas.RowCount; i++)
            {
                for (int j = 0; j < dgvSimEntradas.ColumnCount; j++)
                {
                    temp[j]= Convert.ToInt32(dgvSimEntradas.Rows[i].Cells[j].Value);
                }
                newEntradas.Add(temp);
            }
        }
        private void btmSimular_Click(object sender, EventArgs e)
        {
            cargarPatronesDataGridEnLista();
            double[] yR = new double[Variables._salidas];
            if (Variables.numIteraciones > 0)
            {

                dgvSimSalidas.ColumnCount = Variables.Salidas[0].Count();
                dgvSimSalidas.RowCount = newEntradas.Count();
                foreach (var patron in newEntradas)
                {
                    //Hacer un vector por todas las salidas en el primer patron
                    for (int i = 0; i < Variables._salidas; i++)
                    {
                        for (int j = 0; j < Variables._entradas; j++)
                        {
                            yR[i] += patron[j] * Variables.MatrizPesoUnicapa[j, i];
                        }
                        yR[i] -= Variables.VectorUmbralUnicapa[i];
                        if (Variables.ValorCbTipo.ToUpper().Equals("PERCEPTRON"))
                        {
                            if (yR[i] >= 0) yR[i] = 1;
                            if (yR[i] < 0) yR[i] = 0;
                        }
                        dgvSimSalidas.Rows[newEntradas.IndexOf(patron)].Cells[i].Value = yR[i];
                    }
                }
            }
        }
    }
}
