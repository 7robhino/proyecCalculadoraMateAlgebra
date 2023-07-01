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
    public partial class formEclipse : Form
    {
        public formEclipse()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txt2.Focus();
            }
        }

        private void txt2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txt3.Focus();
            }
        }

        private void txt3_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void btnResolver_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "")
            {
                MessageBox.Show("es un caso muy en particular");
            }
            else
            {
                // Obtener los valores ingresados en los TextBoxes
                float centerX = Convert.ToSingle(txt1.Text);
                float centerY = Convert.ToSingle(txt2.Text);
                float semiMajorAxis = Convert.ToSingle(txt3.Text);
                float semiMinorAxis = Convert.ToSingle(txt4.Text);

                string procedure = "Procedimiento para obtener la ecuación de la elipse:\n";
                procedure += $"Obtener los valores ingresados.\n";
                procedure += $"El centro de la elipse es ({centerX}, {centerY}).\n";
                procedure += $"El semieje mayor tiene longitud {semiMajorAxis}.\n";
                procedure += $"El semieje menor tiene longitud {semiMinorAxis}.\n";
                procedure += $"Aplicar la fórmula de la elipse.\n";
                procedure += $"La ecuación de la elipse es: ((x - {centerX})^2 / {semiMajorAxis}^2) + ((y - {centerY})^2 / {semiMinorAxis}^2) = 1";

                // Mostrar el procedimiento en el Label
                lblProcedure.Text = procedure;


                // Limpiar la gráfica
                chart1.Series.Clear();

                // Crear una nueva serie para la elipse
                Series series = new Series();
                series.ChartType = SeriesChartType.Point;
                series.Color = Color.Blue;

                // Calcular los puntos de la elipse y agregarlos a la serie
                int numPoints = 100;
                for (int i = 0; i < numPoints; i++)
                {
                    double angle = 2 * Math.PI * i / numPoints;
                    double x = centerX + semiMajorAxis * Math.Cos(angle);
                    double y = centerY + semiMinorAxis * Math.Sin(angle);
                    series.Points.AddXY(x, y);


                }

                // Marcar el centro de la elipse en la gráfica
                Series centerSeries = new Series();
                centerSeries.ChartType = SeriesChartType.Point;
                centerSeries.Color = Color.Red;
                centerSeries.Points.AddXY(centerX, centerY);
                chart1.Series.Add(centerSeries);

                // Dibujar una línea vertical desde el centro de la elipse hasta el círculo superior
                Series lineVerticalSeries = new Series();
                lineVerticalSeries.ChartType = SeriesChartType.Line;
                lineVerticalSeries.Color = Color.Green;
                lineVerticalSeries.Points.AddXY(centerX, centerY - semiMinorAxis);
                lineVerticalSeries.Points.AddXY(centerX, centerY - semiMajorAxis);
                lineVerticalSeries.Points.AddXY(centerX, centerY);
                chart1.Series.Add(lineVerticalSeries);


                // Dibujar una línea horizontal desde el centro de la elipse hasta el círculo derecho
                Series lineHorizontalSeries = new Series();
                lineHorizontalSeries.ChartType = SeriesChartType.Line;
                lineHorizontalSeries.Color = Color.Orange;
                lineHorizontalSeries.Points.AddXY(centerX, centerY);
                lineHorizontalSeries.Points.AddXY(centerX + semiMajorAxis, centerY);
                chart1.Series.Add(lineHorizontalSeries);

                // Agregar la serie a la gráfica
                chart1.Series.Add(series);

                // Configurar los ejes
                chart1.ChartAreas[0].AxisX.Minimum = centerX - semiMajorAxis;
                chart1.ChartAreas[0].AxisX.Maximum = centerX + semiMajorAxis;
                chart1.ChartAreas[0].AxisX.Interval = .25;

                chart1.ChartAreas[0].AxisY.Minimum = centerY - semiMinorAxis;
                chart1.ChartAreas[0].AxisY.Maximum = centerY + semiMinorAxis;
                chart1.ChartAreas[0].AxisY.Interval = .25;
            }
        }

        private void txt3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txt4.Focus();
            }
        }

        private void txt4_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                btnResolver.PerformClick();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txt1.Clear(); txt2.Clear(); txt3.Clear(); txt4.Clear();
        }
    }
}
