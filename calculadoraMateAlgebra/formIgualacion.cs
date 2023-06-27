﻿using System;
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
    public partial class formIgualacion : Form
    {
        public formIgualacion()
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
                MessageBox.Show("no se puede ");
            }
            else
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

                float x = (c * e2 - b * f) / (a * e2 - b * d);
                float y = (a * f - c * d) / (a * e2 - b * d);

                lblTituloX.Visible = true;
                lblX.Text = " x = (" + c + " * " + e2 + " - " + b + " * " + f + ") / (" + a + " * " + e2 + " - " + b + " * " + d + "";
                lblX.Visible = true;

                lblTituloY.Visible = true;
                lblY.Text = "y = ("+a+" * "+f+" - "+c+" * "+d+") / ("+a+" * "+e2+" - "+b+" * "+d+")";
                lblY.Visible = true;

                label7.Text = x.ToString();
                label9.Text = y.ToString();
            }

        }

        private void formIgualacion_Load(object sender, EventArgs e)
        {

        }

        private void lblX_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txta1.Clear(); txtb1.Clear(); txtc1.Clear();
            txta2.Clear(); txtb2.Clear(); txtc2.Clear();
        }
    }
}
