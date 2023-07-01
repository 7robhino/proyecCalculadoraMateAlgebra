using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadoraMateAlgebra
{
    public partial class matriz_3 : Form
    {
        public matriz_3()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txta1.Clear(); txta2.Clear(); txta3.Clear(); txtInd1.Clear();
            txtb1.Clear(); txtb2.Clear(); txtb3.Clear(); txtInd2.Clear();
            txtc1.Clear(); txtc2.Clear(); txtc3.Clear(); txtInd3.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnResolver_Click(object sender, EventArgs e)
        {
            if (txta1.Text == "")
            {
                MessageBox.Show("Es caso muy en particular");
            }
            else
            {


                float a1 = Convert.ToSingle(txta1.Text);
                float a2 = Convert.ToSingle(txta2.Text);
                float a3 = Convert.ToSingle(txta3.Text);
                float b1 = Convert.ToSingle(txtb1.Text);
                float b2 = Convert.ToSingle(txtb2.Text);
                float b3 = Convert.ToSingle(txtb3.Text);
                float c1 = Convert.ToSingle(txtc1.Text);
                float c2 = Convert.ToSingle(txtc2.Text);
                float c3 = Convert.ToSingle(txtc3.Text);
                float ind1 = Convert.ToSingle(txtInd1.Text);
                float ind2 = Convert.ToSingle(txtInd2.Text);
                float ind3 = Convert.ToSingle(txtInd3.Text);


                // Resolver el sistema de ecuaciones
                double[,] coeficientes = {
                { a1, a2, a3 },
                { b1, b2, b3 },
                { c1, c2, c3 }
                 };

                double[] terminosIndependientes = { ind1, ind2, ind3 };
                double[] solucion = SolveSystemOfEquations(coeficientes, terminosIndependientes);

                //tiutlos de las respuesta
                lblMostrarSoluc.Visible = true;
                lblMostrarSoluY.Visible = true;
                lblMostrarSoluZ.Visible = true;

                //mostrando las respuesta
                lblRespX.Text = solucion[0].ToString();
                lblRespY.Text = solucion[1].ToString();
                lblRespZ.Text = solucion[2].ToString();
            }
        }
        private double[] SolveSystemOfEquations(double[,] coeficientes, double[] terminosIndependientes)
        {
            // Crear una matriz ampliada con los coeficientes y términos independientes
            double[,] matrizAmpliada = new double[coeficientes.GetLength(0), coeficientes.GetLength(1) + 1];

            for (int i = 0; i < coeficientes.GetLength(0); i++)
            {
                for (int j = 0; j < coeficientes.GetLength(1); j++)
                {
                    matrizAmpliada[i, j] = coeficientes[i, j];
                }

                matrizAmpliada[i, coeficientes.GetLength(1)] = terminosIndependientes[i];
            }

            // Resolver el sistema de ecuaciones utilizando eliminación de Gauss-Jordan
            int rowCount = matrizAmpliada.GetLength(0);
            int columnCount = matrizAmpliada.GetLength(1);

            for (int pivotRow = 0; pivotRow < rowCount; pivotRow++)
            {
                // Buscar el elemento pivote (el más grande en valor absoluto)
                double pivotElement = Math.Abs(matrizAmpliada[pivotRow, pivotRow]);
                int pivotRowIdx = pivotRow;

                for (int row = pivotRow + 1; row < rowCount; row++)
                {
                    double element = Math.Abs(matrizAmpliada[row, pivotRow]);

                    if (element > pivotElement)
                    {
                        pivotElement = element;
                        pivotRowIdx = row;
                    }
                }

                // Intercambiar filas para tener el elemento pivote en la diagonal principal
                if (pivotRowIdx != pivotRow)
                {
                    for (int col = 0; col < columnCount; col++)
                    {
                        double temp = matrizAmpliada[pivotRow, col];
                        matrizAmpliada[pivotRow, col] = matrizAmpliada[pivotRowIdx, col];
                        matrizAmpliada[pivotRowIdx, col] = temp;
                    }
                }

                // Hacer el elemento pivote igual a 1
                double pivotValue = matrizAmpliada[pivotRow, pivotRow];

                for (int col = pivotRow; col < columnCount; col++)
                {
                    matrizAmpliada[pivotRow, col] /= pivotValue;
                }

                // Hacer ceros en los demás elementos de la columna
                for (int row = 0; row < rowCount; row++)
                {
                    if (row != pivotRow)
                    {
                        double factor = matrizAmpliada[row, pivotRow];

                        for (int col = pivotRow; col < columnCount; col++)
                        {
                            matrizAmpliada[row, col] -= factor * matrizAmpliada[pivotRow, col];
                        }
                    }
                }
            }

            // Obtener la solución del sistema de ecuaciones
            double[] solucion = new double[rowCount];

            for (int row = 0; row < rowCount; row++)
            {
                solucion[row] = matrizAmpliada[row, columnCount - 1];
            }

            return solucion;
        }

        private void txta1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Evita que el TextBox1 procese el carácter Enter

                txta2.Focus(); // Establece el foco en TextBox2
            }
        }

        private void txta2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Evita que el TextBox1 procese el carácter Enter

                txta3.Focus(); // Establece el foco en TextBox2
            }
        }

        private void txta3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Evita que el TextBox1 procese el carácter Enter

                txtInd1.Focus(); // Establece el foco en TextBox2
            }
        }

        private void txtInd1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Evita que el TextBox1 procese el carácter Enter

                txtb1.Focus(); // Establece el foco en TextBox2
            }
        }

        private void txtb1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Evita que el TextBox1 procese el carácter Enter

                txtb2.Focus(); // Establece el foco en TextBox2
            }
        }

        private void txtb2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Evita que el TextBox1 procese el carácter Enter

                txtb3.Focus(); // Establece el foco en TextBox2
            }
        }

        private void txtb3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Evita que el TextBox1 procese el carácter Enter

                txtInd2.Focus(); // Establece el foco en TextBox2
            }
        }

        private void txtInd2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Evita que el TextBox1 procese el carácter Enter

                txtc1.Focus(); // Establece el foco en TextBox2
            }
        }

        private void txtc1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Evita que el TextBox1 procese el carácter Enter

                txtc2.Focus(); // Establece el foco en TextBox2
            }
        }

        private void txtc2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Evita que el TextBox1 procese el carácter Enter

                txtc3.Focus(); // Establece el foco en TextBox2
            }
        }

        private void txtc3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Evita que el TextBox1 procese el carácter Enter

                txtInd3.Focus(); // Establece el foco en TextBox2
            }
        }

        private void txtInd3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtInd3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true; // Evita que el TextBox1 procese la tecla Enter

                btnResolver.PerformClick(); // Activa el evento Click del Button1
            }
        }

        private void matriz_3_Load(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
    

