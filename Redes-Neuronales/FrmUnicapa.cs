using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Redes_Neuronales {
    public partial class FrmUnicapa : Form {

        public double[,] MatrizPesoUnicapa;
        public double[] VectorUmbralUnicapa;


        public FrmUnicapa() {

            InitializeComponent();
            BtmInicializar.Enabled = true;
        }

        public void _Generar() {

            MatrizPesoUnicapa = new double[Variables._entradas, Variables._salidas];
            VectorUmbralUnicapa = new double[Variables._salidas];

            Variables.GenerarMatriz(MatrizPesoUnicapa, Variables._entradas, Variables._salidas);
            Variables.GuardarMatriz(MatrizPesoUnicapa, Variables._entradas, Variables._salidas, "../../../Assets/Matriz de peso unicapa.txt");
            Variables.Mostrarmatriz(MatrizPesoUnicapa, dgvMatrizPesos, Variables._entradas, Variables._salidas);

            Variables.GenerarVector(VectorUmbralUnicapa, Variables._salidas);
            Variables.GuardarVector(VectorUmbralUnicapa, Variables._salidas, "../../../Assets/Vector de umbrales unicapa.txt");
            Variables.MostrarVector(VectorUmbralUnicapa, lsbVectorUmbrales, Variables._salidas);
        }

        public void LlenarComboBox() {



            if (Variables.ValorCbTipo.Equals("Perceptron")) {

                cbFA_unicapa.Items.Add("Escalon");
                cbAE_unicapa.Items.Add("Regla delta");

            }
            else if (Variables.ValorCbTipo.Equals("Adaline")) {

                cbFA_unicapa.Items.Add("Lineal");
                cbAE_unicapa.Items.Add("Regla delta");

            }
            else if (Variables.ValorCbTipo.Equals("Backpropagation")) {

                cbFA_unicapa.Items.Add("Sigmoide");
                cbFA_unicapa.Items.Add("Tangente");
                cbFA_unicapa.Items.Add("Hiperbolica");
                cbAE_unicapa.Items.Add("Propagacion inversa");
            }

        }

        private void BtmInicializar_Click(object sender, EventArgs e) {

            GraficaEi.Series.Clear();
            GraficaYdYR.Series.Clear();

            MatrizPesoUnicapa = new double[Variables._entradas, Variables._salidas];
            VectorUmbralUnicapa = new double[Variables._salidas];

            DialogResult resultado = MessageBox.Show("¿Desea seguir entrenado con pesos y umbrales anteriores?", "", MessageBoxButtons.YesNoCancel);

            if (resultado == DialogResult.Yes ) {

                Variables.CargarMatrizExistente(MatrizPesoUnicapa, Variables._entradas, Variables._salidas, "../../../Assets/Matriz de peso unicapa.txt");
                Variables.CargarVectorExistente(VectorUmbralUnicapa, Variables._salidas, "../../../Assets/Vector de umbrales unicapa.txt");

            }else if (resultado == DialogResult.No) {

                _Generar();
            }

            lsbVectorUmbrales.Items.Clear();
            dgvMatrizPesos.Rows.Clear();
            cbAE_unicapa.Items.Clear();
            cbFA_unicapa.Items.Clear();
            LlenarComboBox();

            gbMatriz.Enabled = true;
            gbVector.Enabled = true;
            gbFA_unicapa.Enabled = true;
            gbAE_unicapa.Enabled = true;
        }

        private async void BtmEntrenar_Click(object sender, EventArgs e) {

            GraficaEi.Series.Clear();
            GraficaYdYR.Series.Clear();

            #region Algoritmo Entrenamiento
            /*
             * i = Num Salidas existentes
             * j = Num Entradas existentes
             *
             * 1. Realizar la funcion Soma Si = E[(Xj * Wji) - Ui]
             * 2. Comparar resultado con la función de activación.
             *      Perceptron(Escalón)     Yr >= 0 => 1
             *                              Yr <  0 => 0
             *      
             *      Adaline(Lineal)         Y = X
             *      
             * 3. Calcular error lineal Eli = Yd - Yr
             * 4. Modificar matriz de peso.
             *      Wji (Nuevo) = Wji (Viejo) + RtApr * Eli * Xj
             *      
             * 5. Modificar Umbral
             *      
             *      Xo Siempre es igual a 1.
             *      
             *      Ui (Nuevo) = Ui (Viejo) + RtApr * Eli * Xo
             *      
             * 6. Calcular el error por patrón
             *      
             *      Ep = E[|E_l|] / Num salidas
             *      
             * 7. Realizar desde el paso 1 hasta que se realice el proceso
             *    con cada patrón.
             *    
             * 8. Calcular el error de iteración
             *      
             *      E_it = E[E_p|] / Num patrones
             *      
             * 9. Preguntar si se llegó al error maximo permitido o se ha llegado
             *    al limite de iteraciones. De ser así, se debe detener el entrenamiento.
             *    
             * 10. Mostrar los resultados en las graficas correspondientes.
             *      
             *      
             */

            #endregion

            double[] yR = new double[Variables._salidas];
            double[] El = new double[Variables._salidas];
            double[] Ep = new double[Variables._patrones];
            double[] Eit = new double[Variables.numIteraciones];
           

            if (Variables.numIteraciones > 0) {

                GraficaYdYR.Series.Add("yd").ChartType = SeriesChartType.FastPoint;
                GraficaYdYR.Series.Add("yR").ChartType = SeriesChartType.Line;
                GraficaEi.Series.Add("Eit").ChartType = SeriesChartType.Line;

                //Para graficar solo con una entrada y una salida.
                if (Variables._salidas == 1) {

                    for (int i = 0; i < Variables._patrones; i++) {

                        GraficaYdYR.Series["yd"].Points.AddXY(Variables.Entradas[i][0], Variables.Salidas[i][0]);
                        
                    }
                        
                }
                

                for (int iteraciones = 0; iteraciones < Variables.numIteraciones; iteraciones++) {

                    GraficaYdYR.Series["yR"].Points.Clear();

                    foreach (var patron in Variables.Entradas) {


                        
                        for (int i = 0; i < Variables._salidas; i++) {

                            for (int j = 0; j < Variables._entradas; j++) {

                                yR[i] += patron[j] * MatrizPesoUnicapa[j, i];

                            }

                            yR[i] -= VectorUmbralUnicapa[i];

                            

                            if (Variables.ValorCbTipo.ToUpper().Equals("PERCEPTRON")) {

                                if (yR[i] >= 0) yR[i] = 1;
                                if (yR[i] < 0) yR[i] = 0;
                            }

                            GraficaYdYR.Series["yR"].Points.AddXY(Variables.Entradas[Variables.Entradas.IndexOf(patron)][0], yR[i]);

                            El[i] = Variables.Salidas[Variables.Entradas.IndexOf(patron)][i] - yR[i];

                            for (int j = 0; j < Variables._entradas; j++) {

                                MatrizPesoUnicapa[j, i] = MatrizPesoUnicapa[j, i] + Variables.rataAprendizaje * El[i] * patron[j];

                            }

                            VectorUmbralUnicapa[i] = VectorUmbralUnicapa[i] + Variables.rataAprendizaje * El[i];

                            Ep[Variables.Entradas.IndexOf(patron)] += Math.Abs(El[i]);

                        }

                        Ep[Variables.Entradas.IndexOf(patron)] /= Variables._salidas;

                        Eit[iteraciones] += Math.Abs(Ep[Variables.Entradas.IndexOf(patron)]);

                        
                    }

                    Eit[iteraciones] /= Variables._patrones;

                    GraficaEi.Series["Eit"].Points.AddXY(iteraciones, Eit[iteraciones]);
                    await Task.Delay(32);
                    if (Eit[iteraciones] <= Variables.errorMaximo) {
                        iteraciones = Variables.numIteraciones;
                    }

                }

                

               

            }
        }

        private void cbFA_unicapa_SelectedIndexChanged(object sender, EventArgs e) {
            cbAE_unicapa.Enabled = true;
        }

        private void cbAE_unicapa_SelectedIndexChanged(object sender, EventArgs e) {
            BtmEntrenar.Enabled = true;
        }

        private void FrmUnicapa_Load(object sender, EventArgs e) {

        }
    }
}
