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
    public partial class formDeterminante : Form
    {
        public formDeterminante()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formDeterminante_Load(object sender, EventArgs e)
        {

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
                float a = Convert.ToSingle(txta1.Text);
                float b = Convert.ToSingle(txtb1.Text);
                float c = Convert.ToSingle(txta2.Text); //txtb2.Text
                float d = Convert.ToSingle(txtb2.Text);
                float e2 = Convert.ToSingle(txtc1.Text);
                float f = Convert.ToSingle(txtc2.Text);


                // Calcular la determinante de la matriz de coeficientes
                float determinante = a * d - b * c;

                if (determinante == 0)
                {
                    MessageBox.Show("El sistema de ecuaciones no tiene solución única.");
                }
                else
                {
                    // Calcular las soluciones utilizando la fórmula de Cramer
                    float x = (e2 * d - b * f) / determinante;
                    float y = (a * f - c * e2) / determinante;

                    lblDeteminante.Text = "determinante = " + a + " * " + d + " - " + b + " * " + c + "";
                    lblResul1.Text = determinante.ToString();

                    lblX.Text = " x = (" + e2 + " * " + d + " - " + b + " * " + f + ") / " + determinante + "";
                    lblY.Text = " y = (" + a + " * " + f + " - " + c + " * " + e2 + ") / " + determinante + "";

                    //titulos los sectores
                    label7.Visible = true;
                    label8.Visible = true;

                    label11.Text = x.ToString();
                    lblMostrarSoluc.Visible = true;
                    label9.Text = y.ToString();
                    lblMostrarSoluY.Visible = true;
                }

               
            }
        }
    }
}
