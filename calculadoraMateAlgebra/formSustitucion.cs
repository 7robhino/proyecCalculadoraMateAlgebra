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
    public partial class formSustitucion : Form
    {
        public formSustitucion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void btnResolver_Click(object sender, EventArgs e)
        {
            if(txta1.Text == "")
            {
                MessageBox.Show("no se puede ");
            }
            else
            {
                label6.Visible = true;
                label8.Visible = true;
                label11.Visible = true;
                label12.Visible = true;

                double a1 = Convert.ToDouble(txta1.Text);
                double b1 = Convert.ToDouble(txtb1.Text);
                double c1 = Convert.ToDouble(txtc1.Text);
                double a2 = Convert.ToDouble(txta2.Text);
                double b2 = Convert.ToDouble(txtb2.Text);
                double c2 = Convert.ToDouble(txtc2.Text);

                // Resolución de la primera ecuación para x
                double x = (c1 - b1 * (c2 / b2)) / (a1 - b1 * (a2 / b2));

                // Sustitución del valor de x en la segunda ecuación
                double y = (c2 - a2 * x) / b2;
                lblProcesoX.Text = " x = (" + c1 + " - " + b1 + " * (" + c2 + " / " + b2 + ")) / (" + a1 + " - " + b1 + " * (" + a2 + " / " + b2 + "))";
                lblResulX.Text = x.ToString();
                label13.Text = "y = (" + c2 + " - " + a2 + " * " + x + ") / " + b2 + "";

                label7.Text = x.ToString();
                label9.Text = y.ToString();
            }
           

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txta1.Clear(); txtb1.Clear(); txtc1.Clear();
            txta2.Clear(); txtb2.Clear(); txtc2.Clear();
            
            
        }

        private void formSustitucion_Load(object sender, EventArgs e)
        {

        }

        private void txta1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Evita que el TextBox1 procese el carácter Enter

                txtb1.Focus(); // Establece el foco en TextBox2
            }
        }

        private void txta1_TextChanged(object sender, EventArgs e)
        {

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

        private void txtc2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true; // Evita que el TextBox1 procese la tecla Enter

                btnResolver.PerformClick(); // Activa el evento Click del Button1
            }
        }
    }
}
