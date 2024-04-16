using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Xeon.Design;
using Xeon.Presenters;

namespace Xeon.Views
{
    public partial class FormPrincipal : Form, IVMain
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        public delegate void ShowUserViewHandler(object sender, Form formToShow);
        public delegate void ShowUserBViewHandler(object sender, Form formToShow);
        public delegate void ShowReproducirViewHandler(object sender, Form formToShow);
        public delegate void ShowListasBViewHandler(object sender, Form formToShow);
        public delegate void ShowListasViewHandler(object sender, Form formToShow);
        public delegate void ShowListaCancionViewHandler(object sender, Form formToShow);
        public delegate void ShowAlbumCancionViewHandler(object sender, Form formToShow);

        public delegate void ShowProfileViewHandler(object sender, Form formToShow);
        public delegate void ShowGenreViewHandler(object sender, Form formToShow);
        public delegate void ShowArtistViewHandler(object sender, Form formToShow);
        public delegate void ShowArtistGenreViewHandler(object sender, Form formToShow);
        public delegate void ShowAlbumHandler(object sender, Form formToShow);
        public delegate void ShowAlbumArtistViewHandler(object sender, Form formToShow);
        public delegate void ShowAlbumGenreViewHandler(object sender, Form formToShow);
        public delegate void ShowSongViewHandler(object sender, Form formToShow);
        public delegate void ShowBeginningViewHandler(object sender, Form formToShow);
        public event EventHandler ShowUserView;
        public event EventHandler ShowUserBView;
        public event EventHandler ShowListasBView;
        public event EventHandler ShowReproducirView;
        public event EventHandler ShowProfileView;
        public event EventHandler ShowGenreView;
        public event EventHandler ShowArtistView;
        public event EventHandler ShowArtistGenreView;
        public event EventHandler ShowAlbumView;
        public event EventHandler ShowAlbumArtistView;
        public event EventHandler ShowAlbumGenreView;
        public event EventHandler ShowSongView;
        public event EventHandler ShowListasView;
        public event EventHandler ShowListaCancionView;
        public event EventHandler ShowAlbumCancionView;
        public event EventHandler ShowOwnerView;
        public event EventHandler ShowVetsView;

        public event EventHandler ShowUserViewInPanel;
        
        
        
        public event EventHandler ShowBeginningView;

        ListasB listasB = new ListasB();
        UCListasB ucListasB = new UCListasB();
        
        public FormPrincipal()
        {
            InitializeComponent();
            //listasB.SuscribirseAlEvento(ucListasB);
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 30);
            panelMenu.Controls.Add(leftBorderBtn);
            // Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            //
            AppearanceManager.principalClaro(this);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Actualiza el texto del Label con la hora y la fecha actual
            
        }

        public void Visibilidad(int idPerfil) 
        {
            if (idPerfil == 1)
            {
                btnReproduccion.Visible = true;
                btnCrear.Visible = true;
                btnSesion.Visible = false;
                btnCantantes.Visible = false;
                btnGeneros.Visible = false;
                btnDiscos.Visible = false;
                btnSencillos.Visible = false;
                btnMixtape.Visible = false;
            }
            else if (idPerfil == 2)
            {
                btnReproduccion.Visible = true;
                btnCrear.Visible = true;
                btnSesion.Visible = true;
                btnCantantes.Visible = true;
                btnGeneros.Visible = true;
                btnDiscos.Visible = true;
                btnSencillos.Visible = true;
                btnMixtape.Visible = true;
            }
        }

        private struct RGBColors 
        {
            public static Color c1 = Color.FromArgb(172, 126, 241);
            public static Color c2 = Color.FromArgb(249, 118, 176);
            public static Color c3 = Color.FromArgb(253, 138, 114);
            public static Color c4 = Color.FromArgb(95, 77, 221);
            public static Color c5 = Color.FromArgb(249, 88, 155);
            public static Color c6 = Color.FromArgb(24, 161, 251);

        }

        private void ActivateButton(object senderBtn, Color color) 
        {
            if (senderBtn != null)
            {
                DisableButton();
                // Botón personalizado
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                // Alineación del botón
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                // Ícono child form
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }

        private void DisableButton() 
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(1, 38, 38);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.FromArgb(2, 115, 104);
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        public void OpenChildForm(Form childForm) 
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }

        private void CloseAnyChildForm()
        {
            foreach (Form childForm in this.MdiChildren)
                childForm.Close();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {

        }

        private void btnArtistas_Click(object sender, EventArgs e)
        {

        }

        private void btnGeneros_Click(object sender, EventArgs e)
        {

        }

        private void btnArtistaGenero_Click(object sender, EventArgs e)
        {

        }

        private void btnAlbumes_Click(object sender, EventArgs e)
        {

        }

        private void btnCanciones_Click(object sender, EventArgs e)
        {

        }

        private void btnListas_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.c6);
        }

        private void btnCancionLista_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.c6);
        }

        private void btnLogo_Click(object sender, EventArgs e)
        {
            //currentChildForm.Close();
            Reset();
        }

        private void Reset() 
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.FromArgb(4, 191, 173);
            lblTitleChildForm.Text = "Inicio";
        }
        //[DllImport("user32.dll", EntryPoint = "ReleaseCaptura")]
        //private extern static void ReleaseCaptura();
        //[DllImport("user32.dll", EntryPoint = "SendMessage")]
        //private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private bool mouseDown;
        private Point lastLocation;

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void panelTitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                int deltaX = e.Location.X - lastLocation.X;
                int deltaY = e.Location.Y - lastLocation.Y;
                this.Location = new Point(this.Location.X + deltaX, this.Location.Y + deltaY);
            }
        }

        private void panelTitleBar_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaxi_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(800, 450);
            //timer1 = new Timer();
            //timer1.Interval = 1000; // Intervalo de 1 segundo
            //timer1.Tick += Timer_Tick;
            //timer1.Start();
            //lblDateTime.Text = DateTime.Now.ToString("HH:mm tt\nMMM dd, yyyy");
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.c2);
            ShowBeginningView?.Invoke(this, EventArgs.Empty);
        }

        private void btnSesion_Click(object sender, EventArgs e)
        {
            rjDropdownSesion.Show(btnSesion, btnSesion.Width, 0);
            ActivateButton(sender, RGBColors.c1);
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAnyChildForm();
            ShowUserView?.Invoke(this, EventArgs.Empty);
        }

        private void perfilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAnyChildForm();
            ShowProfileView?.Invoke(this, EventArgs.Empty);
        }

        private void btnCantantes_Click(object sender, EventArgs e)
        {
            rjDropdownCantantes.Show(btnCantantes, btnCantantes.Width, 0);
            ActivateButton(sender, RGBColors.c2);
        }

        private void artistaToolStripMenu_Click(object sender, EventArgs e)
        {
            CloseAnyChildForm();
            ShowArtistView?.Invoke(this, EventArgs.Empty);
        }

        private void artistageneroToolStripMenu_Click(object sender, EventArgs e)
        {
            CloseAnyChildForm();
            ShowArtistGenreView?.Invoke(this, EventArgs.Empty);
        }

        private void btnDiscos_Click(object sender, EventArgs e)
        {
            rjDropdownDiscos.Show(btnDiscos, btnDiscos.Width, 0);
            ActivateButton(sender, RGBColors.c3);
        }

        private void btnSencillos_Click(object sender, EventArgs e)
        {
            CloseAnyChildForm();
            ShowSongView?.Invoke(this, EventArgs.Empty);
        }

        private void btnMixtape_Click(object sender, EventArgs e)
        {
            rjDropdownListas.Show(btnMixtape, btnMixtape.Width, 0);
            ActivateButton(sender, RGBColors.c5);
        }

        private void albumToolStripMenu_Click(object sender, EventArgs e)
        {
            CloseAnyChildForm();
            ShowAlbumView?.Invoke(this, EventArgs.Empty);
        }

        private void albumartistaToolStripMenu_Click(object sender, EventArgs e)
        {
            CloseAnyChildForm();
            ShowAlbumArtistView?.Invoke(this, EventArgs.Empty);
        }

        private void albumgeneroToolStripMenu_Click(object sender, EventArgs e)
        {
            CloseAnyChildForm();
            ShowAlbumGenreView?.Invoke(this, EventArgs.Empty);
        }

        private void albumcancionToolStripMenu_Click(object sender, EventArgs e)
        {
            CloseAnyChildForm();
            ShowAlbumCancionView?.Invoke(this, EventArgs.Empty);
        }

        private void cancionesToolStripMenu_Click(object sender, EventArgs e)
        {
            CloseAnyChildForm();
            ShowSongView?.Invoke(this, EventArgs.Empty);
        }

        private void cancionartistaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CloseAnyChildForm();
        }

        private void canciongeneroToolStripMenu_Click(object sender, EventArgs e)
        {
            CloseAnyChildForm();
        }

        private void listasToolStripMenu_Click(object sender, EventArgs e)
        {
            CloseAnyChildForm();
            ShowListasView?.Invoke(this, EventArgs.Empty);
        }

        private void listacancionToolStripMenu_Click(object sender, EventArgs e)
        {
            CloseAnyChildForm();
            ShowListaCancionView?.Invoke(this, EventArgs.Empty);
        }

        private void btnGeneros_Click_1(object sender, EventArgs e)
        {
            CloseAnyChildForm();
            ShowGenreView?.Invoke(this, EventArgs.Empty);
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            CloseAnyChildForm();
            ShowUserBView?.Invoke(this, EventArgs.Empty);
            UsuariosB formB = Application.OpenForms.OfType<UsuariosB>().FirstOrDefault();
            if (formB != null)
                formB.Pagina(true);
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            CloseAnyChildForm();
            ShowUserBView?.Invoke(this, EventArgs.Empty);
            UsuariosB formB = Application.OpenForms.OfType<UsuariosB>().FirstOrDefault();
            if (formB != null)
                formB.Pagina(false);
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            CloseAnyChildForm();
            ShowListasBView?.Invoke(this, EventArgs.Empty);
        }

        private void btnReproduccion_Click(object sender, EventArgs e)
        {
            CloseAnyChildForm();
            ShowReproducirView?.Invoke(this, EventArgs.Empty);
        }
    }

    public static class GlobalVariables
    {
        public static int IDUsuario { get; set; }
        public static int IDPerfil { get; set; }
        public static int IDLista { get; set; }
    }

}
