using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Redes_Neuronales
{
    public class Variables
    {
        public static List<string[]> Patrones = new List<string[]>();
        public static List<int[]> Entradas = new List<int[]>();
        public static List<int[]> Salidas = new List<int[]>();

        public static int _entradas { get; set; }
        public static int _salidas { get; set; }
        public static int _patrones { get; set; }

        static Random _R = new Random();
        static double _Dec;
        static double _Num;
        static double _Res;

        public static string ValorCbTipo { get; set; }

        public double NumerosAleatorios()
        {
            _Dec = _R.NextDouble();
            _Num = _R.Next(-1, 1);
            if (_Num == 0)
            {
                _Res = _Dec * -1;
                return _Res;
            }
            else
            {
                _Res = _Dec;
                return _Res;
            }

        }

        public void GenerarVector( double[] VectorUmbral, int columnas)
        {
            for (int x = 0; x < columnas; x++)
            {
                VectorUmbral[x] = Math.Round(NumerosAleatorios(), 6);
            }
        }

        public void GenerarMatriz(double[,] MatrizPeso,int filas, int columnas)
        {
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    MatrizPeso[i, j] = Math.Round(NumerosAleatorios(), 6);
                }
            }
        }
        
        public void Mostrarmatriz(double[,] matrizPeso,DataGridView dataGridView,int filas, int columnas)
        {
            Console.WriteLine("filas: " + filas);
            Console.WriteLine("columnas: " + columnas);
            dataGridView.RowCount = filas;
            dataGridView.ColumnCount = columnas;

            for (int f = 0; f < filas; f++)
            {
                for (int c = 0; c < columnas; c++)
                {
                    dataGridView.Rows[f].Cells[c].Value = matrizPeso[f, c].ToString();
                    //lsw.Items.Add(matrizPeso[f, c].ToString());
                    //label.Text = matrizPeso[f, c].ToString();
                    Console.Write(matrizPeso[f, c] + " ");
                }
                Console.WriteLine();
            }
        }
        public void MostrarVector(double[] VectorUmbral, ListBox listBox, int columnas)
        {
            for (int c = 0; c < columnas; c++)
            {
                //listView.Items.Add(VectorUmbral[c].ToString());
                listBox.Items.Add(VectorUmbral[c]);
                Console.WriteLine(VectorUmbral[c]);
            }
            Console.WriteLine();
        }

        #region Funcion limpiar campos
        public void Limpiar(Control control)
        {
            foreach (var txt in control.Controls)
            {
                if (txt is TextBox)
                {
                    ((TextBox)txt).Clear();
                }
                else if (txt is ComboBox)
                {

                    ((ComboBox)txt).SelectedIndex = -1;
                }
            }
        }

        public void Limpiar2(GroupBox control)
        {
            foreach (var txt in control.Controls)
            {
                if (txt is TextBox)
                {
                    ((TextBox)txt).Clear();
                }
                else if (txt is ComboBox)
                {
                    ((ComboBox)txt).SelectedIndex = -1;
                }
            }
        }
        #endregion

    }
}
