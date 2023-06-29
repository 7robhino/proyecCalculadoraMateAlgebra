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
    public partial class formMatrices : Form
    {
        public formMatrices()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnResolver_Click(object sender, EventArgs e)
        {
            if (txta1.Text == "")
            {
                MessageBox.Show("No se puede");
            }
            else
            {
                float a = Convert.ToSingle(txta1.Text);
                float b = Convert.ToSingle(txtb1.Text);
                float c = Convert.ToSingle(txta2.Text); //txtb2.Text
                float d = Convert.ToSingle(txtb2.Text);
                float e2 = Convert.ToSingle(txtc1.Text);
                float f = Convert.ToSingle(txtc2.Text);

                // Crear las matrices de coeficientes y términos independientes
                float[,] matrizCoeficientes = { { a, b }, { c, d } };
                float[,] matrizIndependientes = { { e2 }, { f } };

                // Calcular la inversa de la matriz de coeficientes
                float determinante = (a * d) - (b * c);
                float[,] matrizInversa = { { d / determinante, -b / determinante }, { -c / determinante, a / determinante } };

                // Multiplicar la matriz inversa por la matriz de términos independientes
                float[,] solucion = MatrizMultiplicacion(matrizInversa, matrizIndependientes);

                // Obtener los valores de las variables
                float x = solucion[0, 0];
                float y = solucion[1, 0];

                //Procedimientos
                label6.Visible = true;
                lblCoeficiente.Text = " matriz Coeficientes = { { " + a + ", " + b + " }, { " + c + ", " + d + " } }";
                lbl7.Visible = true;
                lblIndependiente.Text = "matriz Independientes = { { "+e2+" }, { "+f+" } }";
                

                //Mostrar respuesta
                lblMostrarSoluc.Visible = true;
                lblRptX.Text = x.ToString();

                lblMostrarSoluY.Visible = true;
                lblRptY.Text = y.ToString();


            }

        }
        static float[,] MatrizMultiplicacion(float[,] matriz1, float[,] matriz2)
        {
            int filasMatriz1 = matriz1.GetLength(0);
            int columnasMatriz1 = matriz1.GetLength(1);
            int filasMatriz2 = matriz2.GetLength(0);
            int columnasMatriz2 = matriz2.GetLength(1);

            if (columnasMatriz1 != filasMatriz2)
            {
                throw new ArgumentException("Las dimensiones de las matrices no son válidas para la multiplicación.");
            }

            float[,] resultado = new float[filasMatriz1, columnasMatriz2];

            for (int i = 0; i < filasMatriz1; i++)
            {
                for (int j = 0; j < columnasMatriz2; j++)
                {
                    for (int k = 0; k < columnasMatriz1; k++)
                    {
                        resultado[i, j] += matriz1[i, k] * matriz2[k, j];
                    }
                }
            }

            return resultado;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }
    }
}

