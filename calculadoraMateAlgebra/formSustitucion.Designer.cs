
namespace calculadoraMateAlgebra
{
    partial class formSustitucion
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
            this.label1 = new System.Windows.Forms.Label();
            this.txta1 = new System.Windows.Forms.TextBox();
            this.txtc1 = new System.Windows.Forms.TextBox();
            this.txtb1 = new System.Windows.Forms.TextBox();
            this.txtc2 = new System.Windows.Forms.TextBox();
            this.txtb2 = new System.Windows.Forms.TextBox();
            this.txta2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnResolver = new FontAwesome.Sharp.IconButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.lblProcesoX = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblResulX = new System.Windows.Forms.Label();
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
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(233, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sustitucion";
            // 
            // txta1
            // 
            this.txta1.Location = new System.Drawing.Point(118, 64);
            this.txta1.Name = "txta1";
            this.txta1.Size = new System.Drawing.Size(38, 20);
            this.txta1.TabIndex = 3;
            this.txta1.TextChanged += new System.EventHandler(this.txta1_TextChanged);
            this.txta1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txta1_KeyPress);
            // 
            // txtc1
            // 
            this.txtc1.Location = new System.Drawing.Point(256, 63);
            this.txtc1.Name = "txtc1";
            this.txtc1.Size = new System.Drawing.Size(31, 20);
            this.txtc1.TabIndex = 4;
            this.txtc1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtc1_KeyPress);
            // 
            // txtb1
            // 
            this.txtb1.Location = new System.Drawing.Point(189, 64);
            this.txtb1.Name = "txtb1";
            this.txtb1.Size = new System.Drawing.Size(37, 20);
            this.txtb1.TabIndex = 5;
            this.txtb1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtb1_KeyPress);
            // 
            // txtc2
            // 
            this.txtc2.Location = new System.Drawing.Point(256, 114);
            this.txtc2.Name = "txtc2";
            this.txtc2.Size = new System.Drawing.Size(31, 20);
            this.txtc2.TabIndex = 6;
            this.txtc2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtc2_KeyDown);
            // 
            // txtb2
            // 
            this.txtb2.Location = new System.Drawing.Point(189, 112);
            this.txtb2.Name = "txtb2";
            this.txtb2.Size = new System.Drawing.Size(37, 20);
            this.txtb2.TabIndex = 7;
            this.txtb2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtb2_KeyPress);
            // 
            // txta2
            // 
            this.txta2.Location = new System.Drawing.Point(118, 112);
            this.txta2.Name = "txta2";
            this.txta2.Size = new System.Drawing.Size(38, 20);
            this.txta2.TabIndex = 8;
            this.txta2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txta2_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(232, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(232, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "=";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(165, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "+";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(165, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "+";
            // 
            // btnResolver
            // 
            this.btnResolver.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnResolver.FlatAppearance.BorderSize = 0;
            this.btnResolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResolver.IconChar = FontAwesome.Sharp.IconChar.Equals;
            this.btnResolver.IconColor = System.Drawing.Color.Black;
            this.btnResolver.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnResolver.IconSize = 35;
            this.btnResolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResolver.Location = new System.Drawing.Point(337, 84);
            this.btnResolver.Name = "btnResolver";
            this.btnResolver.Size = new System.Drawing.Size(88, 36);
            this.btnResolver.TabIndex = 13;
            this.btnResolver.Text = "Resolver";
            this.btnResolver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnResolver.UseVisualStyleBackColor = false;
            this.btnResolver.Click += new System.EventHandler(this.btnResolver_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(205, 412);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 31);
            this.label6.TabIndex = 14;
            this.label6.Text = "solucion de x: ";
            this.label6.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(205, 468);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(187, 31);
            this.label8.TabIndex = 16;
            this.label8.Text = "solucion de y: ";
            this.label8.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(425, 412);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 31);
            this.label7.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(425, 468);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 31);
            this.label9.TabIndex = 18;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Bath;
            this.btnLimpiar.IconColor = System.Drawing.Color.Black;
            this.btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiar.IconSize = 35;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(459, 84);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(88, 36);
            this.btnLimpiar.TabIndex = 19;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblProcesoX
            // 
            this.lblProcesoX.AutoSize = true;
            this.lblProcesoX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcesoX.Location = new System.Drawing.Point(206, 186);
            this.lblProcesoX.Name = "lblProcesoX";
            this.lblProcesoX.Size = new System.Drawing.Size(0, 25);
            this.lblProcesoX.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(115, 155);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Procesos de X";
            this.label11.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(115, 263);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Proceso de Y";
            this.label12.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(206, 298);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 25);
            this.label13.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(209, 336);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 25);
            this.label14.TabIndex = 25;
            // 
            // lblResulX
            // 
            this.lblResulX.AutoSize = true;
            this.lblResulX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResulX.Location = new System.Drawing.Point(206, 221);
            this.lblResulX.Name = "lblResulX";
            this.lblResulX.Size = new System.Drawing.Size(0, 25);
            this.lblResulX.TabIndex = 21;
            // 
            // formSustitucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 521);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblResulX);
            this.Controls.Add(this.lblProcesoX);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
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
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formSustitucion";
            this.Text = "v";
            this.Load += new System.EventHandler(this.formSustitucion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txta1;
        private System.Windows.Forms.TextBox txtc1;
        private System.Windows.Forms.TextBox txtb1;
        private System.Windows.Forms.TextBox txtc2;
        private System.Windows.Forms.TextBox txtb2;
        private System.Windows.Forms.TextBox txta2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton btnResolver;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private System.Windows.Forms.Label lblProcesoX;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblResulX;
    }
}