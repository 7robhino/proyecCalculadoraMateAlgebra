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
    public partial class formEliminacion : Form
    {
        public formEliminacion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txta1.Clear(); txtb1.Clear(); txtc1.Clear();
            txta2.Clear(); txtb2.Clear(); txtc2.Clear();
        }

        private void btnResolver_Click(object sender, EventArgs e)
        {
            //mostrar Resultados
            lblMostrarSoluc.Visible = true;
            lblMostrarSoluY.Visible = true;

            float a = Convert.ToSingle(txta1.Text);
            float b = Convert.ToSingle(txtb1.Text);
            float c = Convert.ToSingle(txtc1.Text);
            float d = Convert.ToSingle(txta2.Text);
            float e2 = Convert.ToSingle(txtb2.Text);
            float f = Convert.ToSingle(txtc2.Text);

            // Realizar la eliminación
            float factor = d / a;
            d -= factor * a;
            e2 -= factor * b;
            f -= factor * c;

            // Calcular los valores de x e y
            float y = f / e2;
            float x = (c - b * y) / a;

            label10.Text = d+"/"+a;
            label12.Text = factor.ToString();

            lblTituloProc.Visible = true;
            lblX.Text = ""+d+" -= "+factor+" * " + a;
            lblResulq1.Text = d.ToString();
            lblX.Visible = true;

            label11.Text = "  "+e2+" -= "+factor+" * "+b+"";
            lblResulQ2.Text = e2.ToString();

            label13.Text = " " + f + " -= " + factor + " * " + c + "";
            lblResulQ3.Text = f.ToString();

            lblResul.Text = "y = "+f+" / "+e2+"";
            lblTituloValores.Visible = true;
            lblXX.Text = "x = ("+c+" - "+b+" * "+y+") / "+a+"";
            lblXX.Visible = true;

            label7.Text = x.ToString();
            label9.Text = y.ToString();

            label8.Visible = true;
        }

        private void formEliminacion_Load(object sender, EventArgs e)
        {

        }
    }
}
