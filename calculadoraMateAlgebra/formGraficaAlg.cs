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
    public partial class formGraficaAlg : Form
    {
        public formGraficaAlg()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txta1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txtb1.Focus();
            }
        }

        private void txtb1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txtc1.Focus();
            }
        }

        private void txtc1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txta2.Focus();
            }
        }

        private void txta2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txtb2.Focus();
            }
        }

        private void txtb2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txtc2.Focus();
            }
        }

        private void txtc2_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                btnResolver.PerformClick();
            }
        }

        private void btnResolver_Click(object sender, EventArgs e)
        {
            if (txta1.Text == " ")
            {
                MessageBox.Show("NO SE PUEDE ^0^");
            }
            else
            {
                float a1 = Convert.ToSingle(txta1.Text);
                float b1 = Convert.ToSingle(txtb1.Text);
                float a2 = Convert.ToSingle(txta2.Text); //txtb2.Text
                float b2 = Convert.ToSingle(txtb2.Text);
                //terminos independientes
                float c1 = Convert.ToSingle(txtc1.Text);
                float c2 = Convert.ToSingle(txtc2.Text);

                float y1 = (c1 * a2 - a1 * c2) / (a2 * b1 - a1 * b2);
                float x1 = (c1 - b1 * y1) / a1;

                string procesus = $"Resolver y\n";
                procesus += $"y1 = ("+c1+" * "+a2+" - "+a1+" * "+c2+")\n / ("+a2+" * "+b1+" - "+a1+" * "+b2+") \n";
                procesus += $"\nResolver x\n";
                procesus += "x1 = (" + c1 + " - " + b1 + " * " + y1 + ") / " + a1 + "\n";

                lblProcess.Text = procesus;
                label6.Visible = true;
                lblSolucX.Text = x1.ToString();
                label7.Visible = true;
                lblSolucY.Text = y1.ToString();
             }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txta1.Clear(); txtb1.Clear(); txtc1.Clear();
            txta2.Clear(); txtb2.Clear(); txtc2.Clear();
        }
    }
}
