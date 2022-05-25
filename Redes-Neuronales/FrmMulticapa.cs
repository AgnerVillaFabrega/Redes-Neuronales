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
    public partial class FrmMulticapa : Form
    {
        Variables variables = new Variables();

        public double[,] WE;
        public double[,] W12;
        public double[,] W23;
        public double[,] W3S;

        public double[] U1;
        public double[] U2;
        public double[] U3;
        public double[] US;

        public int C1;
        public int C2;
        public int C3;
        public FrmMulticapa()
        {
            InitializeComponent();
        }
        public void LlenarComboBox()
        {
            if (Variables.ValorCbTipo.Equals("Perceptron"))
            {
                cbAE_multicapa.Items.Add("Regla delta");
            }
            else if (Variables.ValorCbTipo.Equals("Adaline"))
            {
                cbAE_multicapa.Items.Add("Regla delta");
            }
            else if (Variables.ValorCbTipo.Equals("Backpropagation"))
            {
                cbAE_multicapa.Items.Add("Propagacion inversa");
            }

        }
        public void Actuaizar1()
        {
            C1 = Convert.ToInt32(nudCap1NumNeur.Value);

            WE = new double[Variables._entradas, C1];
            W3S = new double[Convert.ToInt32(nudCap1NumNeur.Value), Variables._salidas];

            U1 = new double[C1];
            US = new double[Variables._salidas];

            variables.GenerarMatriz(WE,Variables._entradas,C1);
            variables.GenerarMatriz(W3S,C1,Variables._salidas);

            variables.GuardarMatriz(WE, Variables._entradas, Variables._salidas, "Matriz WE.txt");
            variables.GuardarMatriz(W3S, Variables._entradas, Variables._salidas, "Matriz E3S.txt");

            variables.GenerarVector(U1,C1);
            variables.GenerarVector(US,Variables._salidas);


            variables.GuardarVector(U1, C1, "Vector U1.txt");
            variables.GuardarVector(US, Variables._salidas, "Vector US.txt");

            variables.Mostrarmatriz(WE, dgvWE,Variables._entradas,C1);
            variables.Mostrarmatriz(W3S, dgvW3S, C1, Variables._salidas);

            variables.MostrarVector(U1, lsbU1, C1);
            variables.MostrarVector(US, lsbUS,Variables._salidas);
        }
        public void Actuaizar2()
        {
            C1 = Convert.ToInt32(nudCap1NumNeur.Value);
            C2 = Convert.ToInt32(nudCap2NumNeur.Value);

            WE = new double[Variables._entradas, C1]; ;
            W12 = new double[C1, C2];
            W3S = new double[C2, Variables._salidas];

            U1 = new double[C1];
            U2 = new double[C2];
            US = new double[Variables._salidas];

            variables.GenerarMatriz(WE,Variables._entradas,C1);
            variables.GenerarMatriz(W12, C1, C2);
            variables.GenerarMatriz(W3S, C2, Variables._salidas);

            variables.GuardarMatriz(WE, Variables._entradas, C1, "Matriz WE.txt");
            variables.GuardarMatriz(W12, C1, C2,"Matriz W12.txt");
            variables.GuardarMatriz(W3S, C2, Variables._salidas,"Matriz W3S.txt");


            variables.GenerarVector(U1,C1);
            variables.GenerarVector(U2,C2);
            variables.GenerarVector(US,Variables._salidas);

            variables.GuardarVector(U1, C1, "Vector U1.txt");
            variables.GuardarVector(U2, C2, "Vector U2.txt");
            variables.GuardarVector(US, Variables._salidas,"Vector US.txt");

            variables.Mostrarmatriz(WE, dgvWE,Variables._entradas,C1);
            variables.Mostrarmatriz(W12, dgvW12,C1,C2);
            variables.Mostrarmatriz(W3S, dgvW3S,C2,Variables._salidas);

            variables.MostrarVector(U1, lsbU1,C1);
            variables.MostrarVector(U2, lsbU2,C2);
            variables.MostrarVector(US, lsbUS,Variables._salidas);
        }
        public void Actuaizar3()
        {
            C1 = Convert.ToInt32(nudCap1NumNeur.Value);
            C2 = Convert.ToInt32(nudCap2NumNeur.Value);
            C3 = Convert.ToInt32(nudCap3NumNeur.Value);

            WE = new double[Variables._entradas, C1]; ;
            W12 = new double[C1, C2];
            W23 = new double[C2, C3];
            W3S = new double[C3, Variables._salidas];

            U1 = new double[C1];
            U2 = new double[C2];
            U3 = new double[C3];
            US = new double[Variables._salidas];

            variables.GenerarMatriz(WE, Variables._entradas, C1);
            variables.GenerarMatriz(W12, C1, C2);
            variables.GenerarMatriz(W23, C2, C3);
            variables.GenerarMatriz(W3S,C3, Variables._salidas);

            variables.GuardarMatriz(WE, Variables._entradas, C1,"Matriz WE.txt");
            variables.GuardarMatriz(W12, C1, C2, "Matriz W12.txt");
            variables.GuardarMatriz(W23, C2, C3, "Matriz W23.txt");
            variables.GuardarMatriz(W3S, C3, Variables._salidas, "Matriz W3S.txt");

            variables.GenerarVector(U1, C1);
            variables.GenerarVector(U2,C2);
            variables.GenerarVector(U3,C3);
            variables.GenerarVector(US,Variables._salidas);

            variables.GuardarVector(U1, C1,"Vector U1.txt");
            variables.GuardarVector(U2, C2, "Vector U2.txt");
            variables.GuardarVector(U3, C3, "Vector U3.txt");
            variables.GuardarVector(US, Variables._salidas, "Vector US.txt");

            variables.Mostrarmatriz(WE, dgvWE,Variables._entradas,C1);
            variables.Mostrarmatriz(W12, dgvW12,C1,C2);
            variables.Mostrarmatriz(W23, dgvW23,C2,C3);
            variables.Mostrarmatriz(W3S, dgvW3S,C3,Variables._salidas);

            variables.MostrarVector(U1, lsbU1,C1);
            variables.MostrarVector(U2, lsbU2,C2);
            variables.MostrarVector(U3, lsbU3,C3);
            variables.MostrarVector(US, lsbUS,Variables._salidas);
        }
        private void cbNumCapas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbNumCapas.Text.Equals("1"))
            {
                gbCapa1.Enabled = true;
                panelMVCapa1.Enabled=true;

                gbCapa2.Enabled = false;
                gbCapa3.Enabled = false;
                panelMVCapa2.Enabled = false;
                panelMVCapa3.Enabled = false;

            }
            else if (cbNumCapas.Text.Equals("2"))
            {
                gbCapa1.Enabled = true;
                gbCapa2.Enabled = true;

                panelMVCapa1.Enabled = true;
                panelMVCapa2.Enabled = true;
                gbCapa3.Enabled = false;
                panelMVCapa3.Enabled = false;
            }
            else if (cbNumCapas.Text.Equals("3"))
            {
                gbCapa1.Enabled = true;
                gbCapa2.Enabled = true;
                gbCapa3.Enabled = true;
                gbCapa1.Enabled = true;
                gbCapa2.Enabled = true;
                gbCapa3.Enabled = true;
            }
        }

        private void BtmCargar_Click(object sender, EventArgs e)
        {
            variables.BorrarArchivos("Matriz WE.txt");
            variables.BorrarArchivos("Matriz W12.txt");
            variables.BorrarArchivos("Matriz W23.txt");
            variables.BorrarArchivos("Matriz W3S.txt");
            variables.BorrarArchivos("Vector U1.txt");
            variables.BorrarArchivos("Vector U2.txt");
            variables.BorrarArchivos("Vector U3.txt");
            variables.BorrarArchivos("Vector US.txt");

            cbAE_multicapa.Items.Clear();
            txtNumNeuronas_Salida.Text = Variables._salidas.ToString();
            LlenarComboBox();

            cbNumCapas.Enabled = true;
            cbAE_multicapa.Enabled = true;
            
        }

        private void btmGenerar_Click(object sender, EventArgs e)
        {
            dgvWE.Rows.Clear();
            lsbU1.Items.Clear();

            dgvW12.Rows.Clear();
            lsbU2.Items.Clear();

            dgvW23.Rows.Clear();
            lsbU3.Items.Clear();

            dgvW3S.Rows.Clear();
            lsbUS.Items.Clear();
            try
            {
                if (cbNumCapas.Text.Equals("1"))
                {
                    Actuaizar1();
                }
                else if (cbNumCapas.Text.Equals("2"))
                {

                    Actuaizar2();
                }
                else if (cbNumCapas.Text.Equals("3"))
                {
                    Actuaizar3();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Debe asignarle un valor a la cantidad de neuronas que desea");
                
            }
            
            
            
        }

        
    }
}
