using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace calculadoraMateAlgebra
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            ocultarSubMenu();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }
        #region funcinalidades del formulario
        //RESIZE METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO EN TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);
            region.Exclude(sizeGripRectangle);
            this.panelContenedor.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);
            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }

      
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //caputrar paosicion y tama;o antes de maximizar pra restaurar
        int lx, ly;
        int ancho, alto;
        private void btnMaximizar_Click_1(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            ancho = this.Size.Width;
            alto = this.Size.Height;
            btnMaximizar.Visible = false;
            btnNormal.Visible = true;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;//Obtener tamanio de pantalla
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            btnMaximizar.Visible = true;
            btnNormal.Visible = false;
            this.Size = new Size(ancho, alto);
            this.Location = new Point(lx, ly);
        }

        private void pnlBarraTitulo_MouseMove(object sender, MouseEventArgs e) //Borrer el formulario
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

       

        //MeTODO PARA ARRASTRAR EL FORMULARIO
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion Funcionalidad de  funcionalidad de Interfaz Funcion del fomulario
        //METODO PARA ABIR FORMULARIOS DENTRODEL PANLE

        private void ocultarSubMenu()
        {
            pnlSubMenuMate.Visible = false;
            pnlSubMenuAlgebra.Visible = false;
        }

        private void btnMenuMatematica_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(pnlSubMenuMate);
        }

        private void btnMenuAlgebra_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(pnlSubMenuAlgebra);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new rectasMate());

            ocultarSubMenu();
        }

        private void btnCircuferencia_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new circuferencia());


            ocultarSubMenu();
        }

        private void btnParabola_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new formParabola());
            ocultarSubMenu();
        }

        private void btnEclipse_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new formEclipse());
            ocultarSubMenu();
        }

        private void btnHiperbola_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new formHiperbola());
            ocultarSubMenu();
        }

        private void btnSustitucion_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new formSustitucion());
            ocultarSubMenu();
        }

        private void btnIgualacion_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new formIgualacion());
            ocultarSubMenu();
        }

        private void btnEliminacion_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new formEliminacion());
            ocultarSubMenu();
        }

        private void btnFormGrafica_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new formGraficaAlg());
            ocultarSubMenu();
        }

        private void btnDeterminante_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new formDeterminante());
            ocultarSubMenu();
        }

        private void btnMatrices_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new formMatrices());
            ocultarSubMenu();
        }

        private void btnVectores_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new formVectores());
            ocultarSubMenu();
        }

        private void ocultarPanelMostrado()
        {
            if(pnlSubMenuMate.Visible == true)
            {
                pnlSubMenuMate.Visible = false;
            }
            if(pnlSubMenuAlgebra.Visible == true)
            {
                pnlSubMenuAlgebra.Visible = false;
            }
        }

        private void mostrarSubMenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                ocultarPanelMostrado();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new matriz_3());
            ocultarSubMenu();
        }

        private Form activeForm = null;
        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
