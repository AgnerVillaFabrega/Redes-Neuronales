using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Redes_Neuronales
{
    public partial class FrmUnicapa : Form
    {
        Variables variables = new Variables();
        public double[,] MatrizPesoUnicapa;
        public double[] VectorUmbralUnicapa;
        public FrmUnicapa()
        {
            InitializeComponent();
            BtmCargar.Enabled = true;
            
        }
        public void _Generar()
        {
            MatrizPesoUnicapa = new double[Variables._entradas, Variables._salidas];
            VectorUmbralUnicapa = new double[Variables._salidas];

            variables.GenerarMatriz(MatrizPesoUnicapa,Variables._entradas,Variables._salidas);
            variables.GuardarMatriz(MatrizPesoUnicapa, Variables._entradas, Variables._salidas,"Matriz de peso unicapa.txt");
            variables.Mostrarmatriz(MatrizPesoUnicapa, dgvMatrizPesos,Variables._entradas,Variables._salidas);

            variables.GenerarVector(VectorUmbralUnicapa,Variables._salidas);
            variables.GuardarVector(VectorUmbralUnicapa, Variables._salidas, "Vector de umbrales unicapa.txt");
            variables.MostrarVector(VectorUmbralUnicapa, lsbVectorUmbrales,Variables._salidas);
        }
        public void LlenarComboBox()
        {
            if (Variables.ValorCbTipo.Equals("Perceptron"))
            {
                cbFA_unicapa.Items.Add("Escalon");

                cbAE_unicapa.Items.Add("Regla delta");
            }
            else if (Variables.ValorCbTipo.Equals("Adaline"))
            {
                cbFA_unicapa.Items.Add("Lineal");

                cbAE_unicapa.Items.Add("Regla delta");
            }
            else if (Variables.ValorCbTipo.Equals("Backpropagation"))
            {
                cbFA_unicapa.Items.Add("Sigmoide");
                cbFA_unicapa.Items.Add("Tangente");
                cbFA_unicapa.Items.Add("Hiperbolica");

                
                cbAE_unicapa.Items.Add("Propagacion inversa");
            }

        }
        private void BtmCargar_Click(object sender, EventArgs e)
        {
            variables.BorrarArchivos("Matriz de peso unicapa.txt");
            variables.BorrarArchivos("Matriz de peso unicapa.txt");

            lsbVectorUmbrales.Items.Clear();
            dgvMatrizPesos.Rows.Clear();
            cbAE_unicapa.Items.Clear();
            cbFA_unicapa.Items.Clear();
            LlenarComboBox();

            gbMatriz.Enabled = true;
            gbVector.Enabled = true;
            gbFA_unicapa.Enabled = true;    
            gbAE_unicapa.Enabled=true;

            _Generar();
            
            

        }
    }
}
