using System;
using System.Windows.Forms;

namespace Redes_Neuronales {
    public partial class FrmUnicapa : Form {

        public double[,] MatrizPesoUnicapa;
        public double[] VectorUmbralUnicapa;

        

        public FrmUnicapa() {

            InitializeComponent();
            BtmCargar.Enabled = true;

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

        private void BtmCargar_Click(object sender, EventArgs e) {

            lsbVectorUmbrales.Items.Clear();
            dgvMatrizPesos.Rows.Clear();
            cbAE_unicapa.Items.Clear();
            cbFA_unicapa.Items.Clear();
            LlenarComboBox();

            gbMatriz.Enabled = true;
            gbVector.Enabled = true;
            gbFA_unicapa.Enabled = true;
            gbAE_unicapa.Enabled = true;

            _Generar();

        }

        private void BtmEntrenar_Click(object sender, EventArgs e) {

            #region Algoritmo Entrenamiento
            /*
             * i = Num Salidas existentes
             * j = Num Entradas existentes
             *
             * 1. Realizar la funcion Soma Si = E[(Xi * Wji) - Ui]
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

            if (Variables.numIteraciones > 0 ) {




            }
        }
    }
}
