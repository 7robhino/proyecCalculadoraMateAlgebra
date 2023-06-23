
namespace calculadoraMateAlgebra
{
    partial class circuferencia
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
            this.btnCerrarForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCerrarForm
            // 
            this.btnCerrarForm.FlatAppearance.BorderSize = 0;
            this.btnCerrarForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCerrarForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarForm.Location = new System.Drawing.Point(33, 51);
            this.btnCerrarForm.Name = "btnCerrarForm";
            this.btnCerrarForm.Size = new System.Drawing.Size(53, 43);
            this.btnCerrarForm.TabIndex = 0;
            this.btnCerrarForm.Text = "X";
            this.btnCerrarForm.UseVisualStyleBackColor = true;
            this.btnCerrarForm.Click += new System.EventHandler(this.btnCerrarForm_Click_1);
            // 
            // circuferencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 521);
            this.Controls.Add(this.btnCerrarForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "circuferencia";
            this.Text = "circuferencia";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCerrarForm;
    }
}