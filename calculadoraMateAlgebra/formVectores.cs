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
    public partial class formVectores : Form
    {
        public formVectores()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txta1.Clear(); txtb1.Clear(); txtc1.Clear();
            txta2.Clear(); txtb2.Clear(); txtc2.Clear();
        }

        private void btnResolver_Click(object sender, EventArgs e)
        {
            if (txta1.Text == "")
            {
                MessageBox.Show("No se puede");
            }
            else
            {
                float a1 = Convert.ToSingle(txta1.Text);
                float b1 = Convert.ToSingle(txtb1.Text);
                float a2 = Convert.ToSingle(txta2.Text); //txtb2.Text
                float b2 = Convert.ToSingle(txtb2.Text);
                float c1 = Convert.ToSingle(txtc1.Text);
                float c2 = Convert.ToSingle(txtc2.Text);

                // Construir las matrices A y B
                float[,] A = { { a1, b1 }, { a2, b2 } };
                float[,] B = { {c1 }, { c2 } };

                // Calcular la inversa de A
                float[,] A_inv = InverseMatrix(A);

                // Calcular la solución X
                float[,] X = MultiplyMatrices(A_inv, B);

                label7.Text = ("La solución del sistema de ecuaciones es:");
                label8.Text = ("x = " + X[0, 0]);
                label9.Text = ("y = " + X[1, 0]);
            }
        }
        // Función para calcular la inversa de una matriz 2x2
        static float[,] InverseMatrix(float[,] matrix)
        {
            float determinant = matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
            float[,] inverse = new float[2, 2];

            inverse[0, 0] = matrix[1, 1] / determinant;
            inverse[0, 1] = -matrix[0, 1] / determinant;
            inverse[1, 0] = -matrix[1, 0] / determinant;
            inverse[1, 1] = matrix[0, 0] / determinant;

            return inverse;
        }

        // Función para multiplicar dos matrices 2x2
        static float[,] MultiplyMatrices(float[,] matrix1, float[,] matrix2)
        {
            int rows1 = matrix1.GetLength(0);
            int columns1 = matrix1.GetLength(1);
            int rows2 = matrix2.GetLength(0);
            int columns2 = matrix2.GetLength(1);

            if (columns1 != rows2)
                throw new ArgumentException("Las dimensiones de las matrices no son válidas para la multiplicación.");

            float[,] result = new float[rows1, columns2];

            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < columns2; j++)
                {
                    for (int k = 0; k < columns1; k++)
                    {
                        result[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }

            return result;
        }

        private void txta1_KeyPress(object sender, KeyPressEventArgs e)
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

                txtc1.Focus(); // Establece el foco en TextBox2
            }
        }

        private void txtc1_KeyPress(object sender, KeyPressEventArgs e)
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

                txtb2.Focus(); // Establece el foco en TextBox2
            }
        }

        private void txtb2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Evita que el TextBox1 procese el carácter Enter

                txtc2.Focus(); // Establece el foco en TextBox2
            }
        }

        private void txtc2_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txtc2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true; // Evita que el TextBox1 procese la tecla Enter

                btnResolver.PerformClick(); // Activa el evento Click del Button1
            }
        }

        private void formVectores_Load(object sender, EventArgs e)
        {

        }
    }

   
 }

