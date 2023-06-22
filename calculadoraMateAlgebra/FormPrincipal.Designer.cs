
namespace calculadoraMateAlgebra
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.pnlFormularios = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlLateral = new System.Windows.Forms.Panel();
            this.pnlSubMenuAlgebra = new System.Windows.Forms.Panel();
            this.btnMatrices = new System.Windows.Forms.Button();
            this.btnFormGrafica = new System.Windows.Forms.Button();
            this.btnEliminacion = new System.Windows.Forms.Button();
            this.btnIgualacion = new System.Windows.Forms.Button();
            this.btnSustitucion = new System.Windows.Forms.Button();
            this.btnMenuAlgebra = new System.Windows.Forms.Button();
            this.pnlSubMenuMate = new System.Windows.Forms.Panel();
            this.btnHiperbola = new System.Windows.Forms.Button();
            this.btnEclipse = new System.Windows.Forms.Button();
            this.btnParabola = new System.Windows.Forms.Button();
            this.btnCircuferencia = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnMenuMatematica = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlBarraTitulo = new System.Windows.Forms.Panel();
            this.btnNormal = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.btnVectores = new System.Windows.Forms.Button();
            this.btnDeterminante = new System.Windows.Forms.Button();
            this.panelContenedor.SuspendLayout();
            this.pnlFormularios.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlLateral.SuspendLayout();
            this.pnlSubMenuAlgebra.SuspendLayout();
            this.pnlSubMenuMate.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlBarraTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelContenedor.Controls.Add(this.pnlFormularios);
            this.panelContenedor.Controls.Add(this.pnlLateral);
            this.panelContenedor.Controls.Add(this.pnlBarraTitulo);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(950, 600);
            this.panelContenedor.TabIndex = 0;
            // 
            // pnlFormularios
            // 
            this.pnlFormularios.BackColor = System.Drawing.SystemColors.Control;
            this.pnlFormularios.Controls.Add(this.panelChildForm);
            this.pnlFormularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFormularios.Location = new System.Drawing.Point(200, 40);
            this.pnlFormularios.Name = "pnlFormularios";
            this.pnlFormularios.Size = new System.Drawing.Size(750, 560);
            this.pnlFormularios.TabIndex = 2;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelChildForm.Controls.Add(this.pictureBox2);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(0, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(750, 560);
            this.panelChildForm.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(216, 155);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(225, 225);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pnlLateral
            // 
            this.pnlLateral.AutoScroll = true;
            this.pnlLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.pnlLateral.Controls.Add(this.iconButton3);
            this.pnlLateral.Controls.Add(this.pnlSubMenuAlgebra);
            this.pnlLateral.Controls.Add(this.btnMenuAlgebra);
            this.pnlLateral.Controls.Add(this.pnlSubMenuMate);
            this.pnlLateral.Controls.Add(this.btnMenuMatematica);
            this.pnlLateral.Controls.Add(this.panel1);
            this.pnlLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLateral.Location = new System.Drawing.Point(0, 40);
            this.pnlLateral.Name = "pnlLateral";
            this.pnlLateral.Size = new System.Drawing.Size(200, 560);
            this.pnlLateral.TabIndex = 1;
            // 
            // pnlSubMenuAlgebra
            // 
            this.pnlSubMenuAlgebra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(85)))), ((int)(((byte)(107)))));
            this.pnlSubMenuAlgebra.Controls.Add(this.btnVectores);
            this.pnlSubMenuAlgebra.Controls.Add(this.btnMatrices);
            this.pnlSubMenuAlgebra.Controls.Add(this.btnDeterminante);
            this.pnlSubMenuAlgebra.Controls.Add(this.btnFormGrafica);
            this.pnlSubMenuAlgebra.Controls.Add(this.btnEliminacion);
            this.pnlSubMenuAlgebra.Controls.Add(this.btnIgualacion);
            this.pnlSubMenuAlgebra.Controls.Add(this.btnSustitucion);
            this.pnlSubMenuAlgebra.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenuAlgebra.Location = new System.Drawing.Point(0, 433);
            this.pnlSubMenuAlgebra.Name = "pnlSubMenuAlgebra";
            this.pnlSubMenuAlgebra.Size = new System.Drawing.Size(183, 299);
            this.pnlSubMenuAlgebra.TabIndex = 4;
            // 
            // btnMatrices
            // 
            this.btnMatrices.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMatrices.FlatAppearance.BorderSize = 0;
            this.btnMatrices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMatrices.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMatrices.Location = new System.Drawing.Point(0, 200);
            this.btnMatrices.Name = "btnMatrices";
            this.btnMatrices.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnMatrices.Size = new System.Drawing.Size(183, 40);
            this.btnMatrices.TabIndex = 5;
            this.btnMatrices.Text = "Matrices";
            this.btnMatrices.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMatrices.UseVisualStyleBackColor = true;
            this.btnMatrices.Click += new System.EventHandler(this.btnMatrices_Click);
            // 
            // btnFormGrafica
            // 
            this.btnFormGrafica.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFormGrafica.FlatAppearance.BorderSize = 0;
            this.btnFormGrafica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormGrafica.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFormGrafica.Location = new System.Drawing.Point(0, 120);
            this.btnFormGrafica.Name = "btnFormGrafica";
            this.btnFormGrafica.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnFormGrafica.Size = new System.Drawing.Size(183, 40);
            this.btnFormGrafica.TabIndex = 3;
            this.btnFormGrafica.Text = "Forma Grafica";
            this.btnFormGrafica.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFormGrafica.UseVisualStyleBackColor = true;
            this.btnFormGrafica.Click += new System.EventHandler(this.btnFormGrafica_Click);
            // 
            // btnEliminacion
            // 
            this.btnEliminacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEliminacion.FlatAppearance.BorderSize = 0;
            this.btnEliminacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminacion.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEliminacion.Location = new System.Drawing.Point(0, 80);
            this.btnEliminacion.Name = "btnEliminacion";
            this.btnEliminacion.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnEliminacion.Size = new System.Drawing.Size(183, 40);
            this.btnEliminacion.TabIndex = 2;
            this.btnEliminacion.Text = "Eliminacion";
            this.btnEliminacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminacion.UseVisualStyleBackColor = true;
            this.btnEliminacion.Click += new System.EventHandler(this.btnEliminacion_Click);
            // 
            // btnIgualacion
            // 
            this.btnIgualacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIgualacion.FlatAppearance.BorderSize = 0;
            this.btnIgualacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIgualacion.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnIgualacion.Location = new System.Drawing.Point(0, 40);
            this.btnIgualacion.Name = "btnIgualacion";
            this.btnIgualacion.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnIgualacion.Size = new System.Drawing.Size(183, 40);
            this.btnIgualacion.TabIndex = 1;
            this.btnIgualacion.Text = "Igualacion";
            this.btnIgualacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIgualacion.UseVisualStyleBackColor = true;
            this.btnIgualacion.Click += new System.EventHandler(this.btnIgualacion_Click);
            // 
            // btnSustitucion
            // 
            this.btnSustitucion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSustitucion.FlatAppearance.BorderSize = 0;
            this.btnSustitucion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSustitucion.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSustitucion.Location = new System.Drawing.Point(0, 0);
            this.btnSustitucion.Name = "btnSustitucion";
            this.btnSustitucion.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSustitucion.Size = new System.Drawing.Size(183, 40);
            this.btnSustitucion.TabIndex = 0;
            this.btnSustitucion.Text = "Sustitucion";
            this.btnSustitucion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSustitucion.UseVisualStyleBackColor = true;
            this.btnSustitucion.Click += new System.EventHandler(this.btnSustitucion_Click);
            // 
            // btnMenuAlgebra
            // 
            this.btnMenuAlgebra.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuAlgebra.FlatAppearance.BorderSize = 0;
            this.btnMenuAlgebra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuAlgebra.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMenuAlgebra.Location = new System.Drawing.Point(0, 388);
            this.btnMenuAlgebra.Name = "btnMenuAlgebra";
            this.btnMenuAlgebra.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnMenuAlgebra.Size = new System.Drawing.Size(183, 45);
            this.btnMenuAlgebra.TabIndex = 3;
            this.btnMenuAlgebra.Text = "ALGEBRA";
            this.btnMenuAlgebra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuAlgebra.UseVisualStyleBackColor = true;
            this.btnMenuAlgebra.Click += new System.EventHandler(this.btnMenuAlgebra_Click);
            // 
            // pnlSubMenuMate
            // 
            this.pnlSubMenuMate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(85)))), ((int)(((byte)(107)))));
            this.pnlSubMenuMate.Controls.Add(this.btnHiperbola);
            this.pnlSubMenuMate.Controls.Add(this.btnEclipse);
            this.pnlSubMenuMate.Controls.Add(this.btnParabola);
            this.pnlSubMenuMate.Controls.Add(this.btnCircuferencia);
            this.pnlSubMenuMate.Controls.Add(this.button3);
            this.pnlSubMenuMate.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenuMate.Location = new System.Drawing.Point(0, 180);
            this.pnlSubMenuMate.Name = "pnlSubMenuMate";
            this.pnlSubMenuMate.Size = new System.Drawing.Size(183, 208);
            this.pnlSubMenuMate.TabIndex = 2;
            // 
            // btnHiperbola
            // 
            this.btnHiperbola.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHiperbola.FlatAppearance.BorderSize = 0;
            this.btnHiperbola.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHiperbola.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHiperbola.Location = new System.Drawing.Point(0, 160);
            this.btnHiperbola.Name = "btnHiperbola";
            this.btnHiperbola.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnHiperbola.Size = new System.Drawing.Size(183, 40);
            this.btnHiperbola.TabIndex = 4;
            this.btnHiperbola.Text = "Hiperbola";
            this.btnHiperbola.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHiperbola.UseVisualStyleBackColor = true;
            this.btnHiperbola.Click += new System.EventHandler(this.btnHiperbola_Click);
            // 
            // btnEclipse
            // 
            this.btnEclipse.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEclipse.FlatAppearance.BorderSize = 0;
            this.btnEclipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEclipse.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEclipse.Location = new System.Drawing.Point(0, 120);
            this.btnEclipse.Name = "btnEclipse";
            this.btnEclipse.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnEclipse.Size = new System.Drawing.Size(183, 40);
            this.btnEclipse.TabIndex = 3;
            this.btnEclipse.Text = "Eclipse";
            this.btnEclipse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEclipse.UseVisualStyleBackColor = true;
            this.btnEclipse.Click += new System.EventHandler(this.btnEclipse_Click);
            // 
            // btnParabola
            // 
            this.btnParabola.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnParabola.FlatAppearance.BorderSize = 0;
            this.btnParabola.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParabola.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnParabola.Location = new System.Drawing.Point(0, 80);
            this.btnParabola.Name = "btnParabola";
            this.btnParabola.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnParabola.Size = new System.Drawing.Size(183, 40);
            this.btnParabola.TabIndex = 2;
            this.btnParabola.Text = "Parabola";
            this.btnParabola.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnParabola.UseVisualStyleBackColor = true;
            this.btnParabola.Click += new System.EventHandler(this.btnParabola_Click);
            // 
            // btnCircuferencia
            // 
            this.btnCircuferencia.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCircuferencia.FlatAppearance.BorderSize = 0;
            this.btnCircuferencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCircuferencia.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCircuferencia.Location = new System.Drawing.Point(0, 40);
            this.btnCircuferencia.Name = "btnCircuferencia";
            this.btnCircuferencia.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnCircuferencia.Size = new System.Drawing.Size(183, 40);
            this.btnCircuferencia.TabIndex = 1;
            this.btnCircuferencia.Text = "Circuferencia";
            this.btnCircuferencia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCircuferencia.UseVisualStyleBackColor = true;
            this.btnCircuferencia.Click += new System.EventHandler(this.btnCircuferencia_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Gainsboro;
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(183, 40);
            this.button3.TabIndex = 0;
            this.button3.Text = "Rectas";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnMenuMatematica
            // 
            this.btnMenuMatematica.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuMatematica.FlatAppearance.BorderSize = 0;
            this.btnMenuMatematica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuMatematica.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMenuMatematica.Location = new System.Drawing.Point(0, 135);
            this.btnMenuMatematica.Name = "btnMenuMatematica";
            this.btnMenuMatematica.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnMenuMatematica.Size = new System.Drawing.Size(183, 45);
            this.btnMenuMatematica.TabIndex = 1;
            this.btnMenuMatematica.Text = "MATEMATICA";
            this.btnMenuMatematica.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuMatematica.UseVisualStyleBackColor = true;
            this.btnMenuMatematica.Click += new System.EventHandler(this.btnMenuMatematica_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(183, 135);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlBarraTitulo
            // 
            this.pnlBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.pnlBarraTitulo.Controls.Add(this.btnNormal);
            this.pnlBarraTitulo.Controls.Add(this.btnMaximizar);
            this.pnlBarraTitulo.Controls.Add(this.btnMinimizar);
            this.pnlBarraTitulo.Controls.Add(this.button1);
            this.pnlBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraTitulo.Name = "pnlBarraTitulo";
            this.pnlBarraTitulo.Size = new System.Drawing.Size(950, 40);
            this.pnlBarraTitulo.TabIndex = 0;
            this.pnlBarraTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlBarraTitulo_MouseMove);
            // 
            // btnNormal
            // 
            this.btnNormal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNormal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.btnNormal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNormal.BackgroundImage")));
            this.btnNormal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNormal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNormal.FlatAppearance.BorderSize = 0;
            this.btnNormal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnNormal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNormal.Location = new System.Drawing.Point(891, 3);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(25, 25);
            this.btnNormal.TabIndex = 7;
            this.btnNormal.UseVisualStyleBackColor = false;
            this.btnNormal.Visible = false;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.btnMaximizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.BackgroundImage")));
            this.btnMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.Location = new System.Drawing.Point(891, 3);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(25, 25);
            this.btnMaximizar.TabIndex = 6;
            this.btnMaximizar.UseVisualStyleBackColor = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click_1);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.btnMinimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.BackgroundImage")));
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Location = new System.Drawing.Point(860, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(25, 25);
            this.btnMinimizar.TabIndex = 5;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(922, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // iconButton3
            // 
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.PlusMinus;
            this.iconButton3.IconColor = System.Drawing.Color.White;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.Location = new System.Drawing.Point(3, 141);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(36, 33);
            this.iconButton3.TabIndex = 6;
            this.iconButton3.UseVisualStyleBackColor = true;
            // 
            // btnVectores
            // 
            this.btnVectores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVectores.FlatAppearance.BorderSize = 0;
            this.btnVectores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVectores.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnVectores.Location = new System.Drawing.Point(0, 240);
            this.btnVectores.Name = "btnVectores";
            this.btnVectores.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnVectores.Size = new System.Drawing.Size(183, 40);
            this.btnVectores.TabIndex = 6;
            this.btnVectores.Text = "Vectores";
            this.btnVectores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVectores.UseVisualStyleBackColor = true;
            this.btnVectores.Click += new System.EventHandler(this.btnVectores_Click);
            // 
            // btnDeterminante
            // 
            this.btnDeterminante.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDeterminante.FlatAppearance.BorderSize = 0;
            this.btnDeterminante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeterminante.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDeterminante.Location = new System.Drawing.Point(0, 160);
            this.btnDeterminante.Name = "btnDeterminante";
            this.btnDeterminante.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnDeterminante.Size = new System.Drawing.Size(183, 40);
            this.btnDeterminante.TabIndex = 4;
            this.btnDeterminante.Text = "Determinante";
            this.btnDeterminante.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeterminante.UseVisualStyleBackColor = true;
            this.btnDeterminante.Click += new System.EventHandler(this.btnDeterminante_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 600);
            this.Controls.Add(this.panelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.panelContenedor.ResumeLayout(false);
            this.pnlFormularios.ResumeLayout(false);
            this.panelChildForm.ResumeLayout(false);
            this.panelChildForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlLateral.ResumeLayout(false);
            this.pnlSubMenuAlgebra.ResumeLayout(false);
            this.pnlSubMenuMate.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlBarraTitulo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel pnlFormularios;
        private System.Windows.Forms.Panel pnlLateral;
        private System.Windows.Forms.Panel pnlBarraTitulo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnNormal;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Panel pnlSubMenuMate;
        private System.Windows.Forms.Button btnHiperbola;
        private System.Windows.Forms.Button btnEclipse;
        private System.Windows.Forms.Button btnParabola;
        private System.Windows.Forms.Button btnCircuferencia;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnMenuMatematica;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlSubMenuAlgebra;
        private System.Windows.Forms.Button btnFormGrafica;
        private System.Windows.Forms.Button btnEliminacion;
        private System.Windows.Forms.Button btnIgualacion;
        private System.Windows.Forms.Button btnSustitucion;
        private System.Windows.Forms.Button btnMenuAlgebra;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMatrices;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.PictureBox pictureBox2;
        private FontAwesome.Sharp.IconButton iconButton3;
        private System.Windows.Forms.Button btnVectores;
        private System.Windows.Forms.Button btnDeterminante;
    }
}

