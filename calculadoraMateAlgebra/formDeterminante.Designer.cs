
namespace calculadoraMateAlgebra
{
    partial class formDeterminante
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
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.btnResolver = new FontAwesome.Sharp.IconButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txta2 = new System.Windows.Forms.TextBox();
            this.txtb2 = new System.Windows.Forms.TextBox();
            this.txtc2 = new System.Windows.Forms.TextBox();
            this.txtb1 = new System.Windows.Forms.TextBox();
            this.txtc1 = new System.Windows.Forms.TextBox();
            this.txta1 = new System.Windows.Forms.TextBox();
            this.lblDeteminante = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblResul1 = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblMostrarSoluY = new System.Windows.Forms.Label();
            this.lblMostrarSoluc = new System.Windows.Forms.Label();
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
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(76, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(230, 24);
            this.label6.TabIndex = 102;
            this.label6.Text = "Pasos De Procedimientos";
            this.label6.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(261, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 43);
            this.label1.TabIndex = 101;
            this.label1.Text = "Determinacion";
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
            this.btnLimpiar.Location = new System.Drawing.Point(510, 94);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(88, 36);
            this.btnLimpiar.TabIndex = 100;
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
            this.btnResolver.Location = new System.Drawing.Point(388, 94);
            this.btnResolver.Name = "btnResolver";
            this.btnResolver.Size = new System.Drawing.Size(88, 36);
            this.btnResolver.TabIndex = 95;
            this.btnResolver.Text = "Resolver";
            this.btnResolver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnResolver.UseVisualStyleBackColor = false;
            this.btnResolver.Click += new System.EventHandler(this.btnResolver_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(216, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 20);
            this.label5.TabIndex = 94;
            this.label5.Text = "+";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(216, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 20);
            this.label4.TabIndex = 93;
            this.label4.Text = "+";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(283, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 20);
            this.label3.TabIndex = 92;
            this.label3.Text = "=";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(283, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 91;
            this.label2.Text = "=";
            // 
            // txta2
            // 
            this.txta2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txta2.Location = new System.Drawing.Point(169, 122);
            this.txta2.Name = "txta2";
            this.txta2.Size = new System.Drawing.Size(38, 20);
            this.txta2.TabIndex = 90;
            this.txta2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txta2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txta2_KeyPress);
            // 
            // txtb2
            // 
            this.txtb2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtb2.Location = new System.Drawing.Point(240, 122);
            this.txtb2.Name = "txtb2";
            this.txtb2.Size = new System.Drawing.Size(37, 20);
            this.txtb2.TabIndex = 89;
            this.txtb2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtb2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtb2_KeyPress);
            // 
            // txtc2
            // 
            this.txtc2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtc2.Location = new System.Drawing.Point(307, 124);
            this.txtc2.Name = "txtc2";
            this.txtc2.Size = new System.Drawing.Size(31, 20);
            this.txtc2.TabIndex = 88;
            this.txtc2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtc2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtc2_KeyDown);
            // 
            // txtb1
            // 
            this.txtb1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtb1.Location = new System.Drawing.Point(240, 74);
            this.txtb1.Name = "txtb1";
            this.txtb1.Size = new System.Drawing.Size(37, 20);
            this.txtb1.TabIndex = 87;
            this.txtb1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtb1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtb1_KeyPress);
            // 
            // txtc1
            // 
            this.txtc1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtc1.Location = new System.Drawing.Point(307, 73);
            this.txtc1.Name = "txtc1";
            this.txtc1.Size = new System.Drawing.Size(31, 20);
            this.txtc1.TabIndex = 86;
            this.txtc1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtc1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtc1_KeyPress);
            // 
            // txta1
            // 
            this.txta1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txta1.Location = new System.Drawing.Point(169, 74);
            this.txta1.Name = "txta1";
            this.txta1.Size = new System.Drawing.Size(38, 20);
            this.txta1.TabIndex = 85;
            this.txta1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txta1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txta1_KeyPress);
            // 
            // lblDeteminante
            // 
            this.lblDeteminante.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDeteminante.AutoSize = true;
            this.lblDeteminante.Location = new System.Drawing.Point(190, 213);
            this.lblDeteminante.Name = "lblDeteminante";
            this.lblDeteminante.Size = new System.Drawing.Size(0, 13);
            this.lblDeteminante.TabIndex = 103;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(118, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(480, 24);
            this.label7.TabIndex = 104;
            this.label7.Text = "Calcular la determinante de la matriz de coeficientes";
            this.label7.Visible = false;
            // 
            // lblResul1
            // 
            this.lblResul1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblResul1.AutoSize = true;
            this.lblResul1.Location = new System.Drawing.Point(246, 242);
            this.lblResul1.Name = "lblResul1";
            this.lblResul1.Size = new System.Drawing.Size(0, 13);
            this.lblResul1.TabIndex = 105;
            // 
            // lblY
            // 
            this.lblY.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(190, 363);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(0, 13);
            this.lblY.TabIndex = 106;
            // 
            // lblX
            // 
            this.lblX.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(190, 323);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(0, 13);
            this.lblX.TabIndex = 108;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(118, 293);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(502, 24);
            this.label8.TabIndex = 109;
            this.label8.Text = "Calcular las soluciones utilizando la fórmula de Cramer";
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(483, 503);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 31);
            this.label9.TabIndex = 113;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(483, 447);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 31);
            this.label11.TabIndex = 112;
            // 
            // lblMostrarSoluY
            // 
            this.lblMostrarSoluY.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMostrarSoluY.AutoSize = true;
            this.lblMostrarSoluY.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarSoluY.Location = new System.Drawing.Point(263, 503);
            this.lblMostrarSoluY.Name = "lblMostrarSoluY";
            this.lblMostrarSoluY.Size = new System.Drawing.Size(187, 31);
            this.lblMostrarSoluY.TabIndex = 111;
            this.lblMostrarSoluY.Text = "solucion de y: ";
            this.lblMostrarSoluY.Visible = false;
            // 
            // lblMostrarSoluc
            // 
            this.lblMostrarSoluc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMostrarSoluc.AutoSize = true;
            this.lblMostrarSoluc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarSoluc.Location = new System.Drawing.Point(263, 447);
            this.lblMostrarSoluc.Name = "lblMostrarSoluc";
            this.lblMostrarSoluc.Size = new System.Drawing.Size(186, 31);
            this.lblMostrarSoluc.TabIndex = 110;
            this.lblMostrarSoluc.Text = "solucion de x: ";
            this.lblMostrarSoluc.Visible = false;
            // 
            // formDeterminante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 560);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblMostrarSoluY);
            this.Controls.Add(this.lblMostrarSoluc);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblResul1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblDeteminante);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnResolver);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txta2);
            this.Controls.Add(this.txtb2);
            this.Controls.Add(this.txtc2);
            this.Controls.Add(this.txtb1);
            this.Controls.Add(this.txtc1);
            this.Controls.Add(this.txta1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formDeterminante";
            this.Text = "formDeterminante";
            this.Load += new System.EventHandler(this.formDeterminante_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private FontAwesome.Sharp.IconButton btnResolver;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txta2;
        private System.Windows.Forms.TextBox txtb2;
        private System.Windows.Forms.TextBox txtc2;
        private System.Windows.Forms.TextBox txtb1;
        private System.Windows.Forms.TextBox txtc1;
        private System.Windows.Forms.TextBox txta1;
        private System.Windows.Forms.Label lblDeteminante;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblResul1;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblMostrarSoluY;
        private System.Windows.Forms.Label lblMostrarSoluc;
    }
}