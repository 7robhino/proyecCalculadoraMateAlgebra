
namespace calculadoraMateAlgebra
{
    partial class formEclipse
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.btnResolver = new FontAwesome.Sharp.IconButton();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.lblProcedure = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 49);
            this.label1.TabIndex = 2;
            this.label1.Text = "Eclipse";
            // 
            // chart1
            // 
            this.chart1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(362, 51);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(370, 430);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Bath;
            this.btnLimpiar.IconColor = System.Drawing.Color.Black;
            this.btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiar.IconSize = 35;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(161, 134);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(88, 36);
            this.btnLimpiar.TabIndex = 28;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnResolver
            // 
            this.btnResolver.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnResolver.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnResolver.FlatAppearance.BorderSize = 0;
            this.btnResolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResolver.IconChar = FontAwesome.Sharp.IconChar.Equals;
            this.btnResolver.IconColor = System.Drawing.Color.Black;
            this.btnResolver.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnResolver.IconSize = 35;
            this.btnResolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResolver.Location = new System.Drawing.Point(45, 134);
            this.btnResolver.Name = "btnResolver";
            this.btnResolver.Size = new System.Drawing.Size(88, 36);
            this.btnResolver.TabIndex = 27;
            this.btnResolver.Text = "Resolver";
            this.btnResolver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnResolver.UseVisualStyleBackColor = false;
            this.btnResolver.Click += new System.EventHandler(this.btnResolver_Click);
            // 
            // txt3
            // 
            this.txt3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt3.Location = new System.Drawing.Point(161, 65);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(39, 20);
            this.txt3.TabIndex = 25;
            this.txt3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt3_KeyDown);
            this.txt3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt3_KeyPress);
            // 
            // txt2
            // 
            this.txt2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt2.Location = new System.Drawing.Point(94, 65);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(39, 20);
            this.txt2.TabIndex = 24;
            this.txt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt2_KeyPress);
            // 
            // txt1
            // 
            this.txt1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt1.Location = new System.Drawing.Point(34, 64);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(39, 20);
            this.txt1.TabIndex = 23;
            this.txt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt1_KeyPress);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(94, 65);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(0, 0);
            this.button2.TabIndex = 22;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txt4
            // 
            this.txt4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt4.Location = new System.Drawing.Point(222, 65);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(39, 20);
            this.txt4.TabIndex = 29;
            this.txt4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt4_KeyDown);
            // 
            // lblProcedure
            // 
            this.lblProcedure.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProcedure.AutoSize = true;
            this.lblProcedure.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcedure.Location = new System.Drawing.Point(30, 210);
            this.lblProcedure.Name = "lblProcedure";
            this.lblProcedure.Size = new System.Drawing.Size(0, 15);
            this.lblProcedure.TabIndex = 30;
            // 
            // formEclipse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 521);
            this.Controls.Add(this.lblProcedure);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnResolver);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formEclipse";
            this.Text = "formEclipse";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private FontAwesome.Sharp.IconButton btnResolver;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.Label lblProcedure;
    }
}