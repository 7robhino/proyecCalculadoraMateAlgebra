using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace calculadoraMateAlgebra
{
    public partial class formHiperbola : Form
    {
        public formHiperbola()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txt1.Clear(); txt2.Clear();
        }

        private void btnResolver_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los TextBox
            float vertices = Convert.ToSingle(txt1.Text);
            float focos = Convert.ToSingle(txt2.Text);

            // Calcular "a" y "b" usando los valores proporcionados
            double a = focos / 2;
            double b = Math.Sqrt(vertices * vertices - a * a);

            // Generar la ecuación de la hiperbola
            string ecuacion = $"(x² / {a * a}) - (y² / {b * b}) = 1";

            // Generar el procedimiento paso a paso
            string procedimiento = "Procedimiento:\n\n";
            procedimiento += $"Dado que los vértices están a una \n distancia de {vertices}\n unidades del centro en el eje y, tenemos 'b = {vertices}'.\n\n";
            procedimiento += $"Dado que los focos están a una\n distancia de {focos} unidades del centro, tenemos 'a = {focos / 2}'.\n\n";
            procedimiento += $"Usando la fórmula de la hiperbola, la ecuación es:\n";
            procedimiento += $"\t(x² / {a * a}) - (y² / {b * b}) = 1";

            // Mostrar el resultado en los Labels
            lblResultado.Text = ecuacion;
            lblProcedimiento.Text = procedimiento;

            // Limpiar la gráfica antes de dibujar la nueva hiperbola
            chart.Series.Clear();

            // Crear una nueva serie para la hiperbola
            Series hiperbolaSerie = new Series();
            hiperbolaSerie.ChartType = SeriesChartType.Spline;
            hiperbolaSerie.BorderWidth = 2;
            hiperbolaSerie.Color = System.Drawing.Color.Blue;

            // Agregar puntos a la serie para dibujar la hiperbola
            for (double x = -a * 3; x <= a * 3; x += 0.1)
            {
                double y = Math.Sqrt(b * b * (1 + x * x / (a * a)));
                hiperbolaSerie.Points.AddXY(x, y);
                hiperbolaSerie.Points.AddXY(x, -y);
            }
            // Agregar la serie a la gráfica
            chart.Series.Add(hiperbolaSerie);

            // Agregar el punto del centro de la hiperbola
            Series centroSerie = new Series();
            centroSerie.ChartType = SeriesChartType.Point;
            centroSerie.MarkerSize = 10;
            centroSerie.Color = System.Drawing.Color.Red;
            centroSerie.Points.AddXY(0, 0); // Coordenadas del centro
            chart.Series.Add(centroSerie);
        }

        private void txt1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txt2.Focus();
            }
        }

        private void txt2_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                btnResolver.PerformClick();
            }
        }
    }
}
