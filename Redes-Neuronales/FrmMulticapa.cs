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

            Variables.GenerarMatriz(WE,Variables._entradas,C1);
            Variables.GenerarMatriz(W3S,C1,Variables._salidas);

            Variables.GuardarMatriz(WE, Variables._entradas, Variables._salidas, "Matriz WE.txt");
            Variables.GuardarMatriz(W3S, Variables._entradas, Variables._salidas, "Matriz E3S.txt");

            Variables.GenerarVector(U1,C1);
            Variables.GenerarVector(US,Variables._salidas);


            Variables.GuardarVector(U1, C1, "Vector U1.txt");
            Variables.GuardarVector(US, Variables._salidas, "Vector US.txt");

            Variables.Mostrarmatriz(WE, dgvWE,Variables._entradas,C1);
            Variables.Mostrarmatriz(W3S, dgvW3S, C1, Variables._salidas);

            Variables.MostrarVector(U1, lsbU1, C1);
            Variables.MostrarVector(US, lsbUS,Variables._salidas);
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

            Variables.GenerarMatriz(WE,Variables._entradas,C1);
            Variables.GenerarMatriz(W12, C1, C2);
            Variables.GenerarMatriz(W3S, C2, Variables._salidas);

            Variables.GuardarMatriz(WE, Variables._entradas, C1, "Matriz WE.txt");
            Variables.GuardarMatriz(W12, C1, C2,"Matriz W12.txt");
            Variables.GuardarMatriz(W3S, C2, Variables._salidas,"Matriz W3S.txt");


            Variables.GenerarVector(U1,C1);
            Variables.GenerarVector(U2,C2);
            Variables.GenerarVector(US,Variables._salidas);

            Variables.GuardarVector(U1, C1, "Vector U1.txt");
            Variables.GuardarVector(U2, C2, "Vector U2.txt");
            Variables.GuardarVector(US, Variables._salidas,"Vector US.txt");

            Variables.Mostrarmatriz(WE, dgvWE,Variables._entradas,C1);
            Variables.Mostrarmatriz(W12, dgvW12,C1,C2);
            Variables.Mostrarmatriz(W3S, dgvW3S,C2,Variables._salidas);

            Variables.MostrarVector(U1, lsbU1,C1);
            Variables.MostrarVector(U2, lsbU2,C2);
            Variables.MostrarVector(US, lsbUS,Variables._salidas);
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

            Variables.GenerarMatriz(WE, Variables._entradas, C1);
            Variables.GenerarMatriz(W12, C1, C2);
            Variables.GenerarMatriz(W23, C2, C3);
            Variables.GenerarMatriz(W3S,C3, Variables._salidas);

            Variables.GuardarMatriz(WE, Variables._entradas, C1,"Matriz WE.txt");
            Variables.GuardarMatriz(W12, C1, C2, "Matriz W12.txt");
            Variables.GuardarMatriz(W23, C2, C3, "Matriz W23.txt");
            Variables.GuardarMatriz(W3S, C3, Variables._salidas, "Matriz W3S.txt");

            Variables.GenerarVector(U1, C1);
            Variables.GenerarVector(U2,C2);
            Variables.GenerarVector(U3,C3);
            Variables.GenerarVector(US,Variables._salidas);

            Variables.GuardarVector(U1, C1,"Vector U1.txt");
            Variables.GuardarVector(U2, C2, "Vector U2.txt");
            Variables.GuardarVector(U3, C3, "Vector U3.txt");
            Variables.GuardarVector(US, Variables._salidas, "Vector US.txt");

            Variables.Mostrarmatriz(WE, dgvWE,Variables._entradas,C1);
            Variables.Mostrarmatriz(W12, dgvW12,C1,C2);
            Variables.Mostrarmatriz(W23, dgvW23,C2,C3);
            Variables.Mostrarmatriz(W3S, dgvW3S,C3,Variables._salidas);

            Variables.MostrarVector(U1, lsbU1,C1);
            Variables.MostrarVector(U2, lsbU2,C2);
            Variables.MostrarVector(U3, lsbU3,C3);
            Variables.MostrarVector(US, lsbUS,Variables._salidas);
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
            Variables.BorrarArchivos("Matriz WE.txt");
            Variables.BorrarArchivos("Matriz W12.txt");
            Variables.BorrarArchivos("Matriz W23.txt");
            Variables.BorrarArchivos("Matriz W3S.txt");
            Variables.BorrarArchivos("Vector U1.txt");
            Variables.BorrarArchivos("Vector U2.txt");
            Variables.BorrarArchivos("Vector U3.txt");
            Variables.BorrarArchivos("Vector US.txt");

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
