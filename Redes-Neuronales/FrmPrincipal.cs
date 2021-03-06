using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Redes_Neuronales {
    public partial class FrmPrincipal : Form {
        FrmUnicapa unicapa = new FrmUnicapa();
        OpenFileDialog ruta = new OpenFileDialog();

        public FrmPrincipal() {

            InitializeComponent();
            cbTipoRed.SelectedIndex = 0;
            cbSeleccionCapa.SelectedIndex = 0;
            
        }

        private void AbrirFrm2(object frmHija) {
            if (panelContenedorTipo.Controls.Count > 0)
                panelContenedorTipo.Controls.RemoveAt(0);
            Form frmAux = frmHija as Form;
            frmAux.TopLevel = false;
            frmAux.Dock = DockStyle.Fill;
            panelContenedorTipo.Controls.Add(frmAux);
            panelContenedorTipo.Tag = frmAux;
            frmAux.Show();
        }

        private void BtmCargar_Click_1(object sender, EventArgs e) {
            try {

                ruta.Title = "Seleccione un archivo";
                ruta.Filter = "Arhivo de texto|*.txt";
                

                if (ruta.ShowDialog() == DialogResult.OK) {
                    txtRuta.Text = ruta.FileName;
                    StreamReader sr = new StreamReader(ruta.FileName);
                    Variables.Patrones = new List<string[]>();
                    Variables.Entradas = new List<int[]>();
                    Variables.Salidas = new List<int[]>();
                    string linea = sr.ReadLine();
                    while (linea != null) {
                        var temp = linea.Split(';');
                        var tempIn = temp[0].Split(' ');
                        var _in = tempIn.Select(x => Convert.ToInt32(x)).ToArray();

                        var tempout = temp[1].Split(' ');
                        var _out = tempout.Select(x => Convert.ToInt32(x)).ToArray();

                        Variables.Entradas.Add(_in);
                        Variables.Salidas.Add(_out);
                        Variables.Patrones.Add(temp);
                        linea = sr.ReadLine();
                    }
                    sr.Close();

                    Variables._entradas = Variables.Entradas[0].Count();
                    Variables._salidas = Variables.Salidas[0].Count();
                    Variables._patrones = Variables.Patrones.Count();

                    lb_entradas.Text = Variables._entradas.ToString();
                    lb_salidas.Text = Variables._salidas.ToString();
                    lb_patrones.Text = Variables._patrones.ToString();
                    cbTipoRed.Enabled = true;
                }
            }
            catch (Exception) {
                txtRuta.Text = "Ruta";

                MessageBox.Show("ERROR");
            }
        }

        private void cbTipoRed_SelectedIndexChanged_1(object sender, EventArgs e) {
            if (cbTipoRed.Text.Equals("Perceptron") || cbTipoRed.Text.Equals("Adaline") || cbTipoRed.Text.Equals("Backpropagation")) {
                cbSeleccionCapa.Enabled = true;
                Variables.ValorCbTipo = cbTipoRed.Text;
            }
            else {
                cbSeleccionCapa.Enabled = false;
            }
        }


        private void cbSeleccionCapa_SelectedIndexChanged(object sender, EventArgs e) {

            

            if (cbSeleccionCapa.Text.Equals("Unicapa")) {
                panelPaso3.Enabled = true;
                AbrirFrm2(new FrmUnicapa());
                
            }
            else if (cbSeleccionCapa.Text.Equals("Multicapa")) {
                panelPaso3.Enabled = true;
                AbrirFrm2(new FrmMulticapa());
            }
            else if (cbSeleccionCapa.Text.Equals("Seleccione tipo de capas")) {
                panelPaso3.Enabled = false;
                panelContenedorTipo.Controls.Clear();
            }
        }

        private void nudNumeroIteraciones_ValueChanged(object sender, EventArgs e) {
            Variables.numIteraciones = (int)nudNumeroIteraciones.Value;
        }

        private void nudRataAprendizaje_ValueChanged(object sender, EventArgs e) {
            Variables.rataAprendizaje = (double)nudRataAprendizaje.Value;
        }

        private void nudErrorMaximo_ValueChanged(object sender, EventArgs e) {
            Variables.errorMaximo = (double)nudErrorMaximo.Value;
        }

        private void panelContenedorTipo_Paint(object sender, PaintEventArgs e) {

        }
    }
}
