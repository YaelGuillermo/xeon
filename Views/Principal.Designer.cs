
namespace Xeon.Views
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnMixtape = new FontAwesome.Sharp.IconButton();
            this.btnSencillos = new FontAwesome.Sharp.IconButton();
            this.btnDiscos = new FontAwesome.Sharp.IconButton();
            this.btnGeneros = new FontAwesome.Sharp.IconButton();
            this.btnCantantes = new FontAwesome.Sharp.IconButton();
            this.btnSesion = new FontAwesome.Sharp.IconButton();
            this.btnCrear = new FontAwesome.Sharp.IconButton();
            this.btnReproduccion = new FontAwesome.Sharp.IconButton();
            this.btnInicio = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnLogo = new FontAwesome.Sharp.IconButton();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnRegistro = new FontAwesome.Sharp.IconButton();
            this.btnIniciarSesion = new FontAwesome.Sharp.IconButton();
            this.btnMini = new FontAwesome.Sharp.IconButton();
            this.btnMaxi = new FontAwesome.Sharp.IconButton();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.rjDropdownSesion = new CustomControls.RJControls.RJDropdownMenu(this.components);
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rjDropdownCantantes = new CustomControls.RJControls.RJDropdownMenu(this.components);
            this.artistaToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.artistageneroToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.rjDropdownDiscos = new CustomControls.RJControls.RJDropdownMenu(this.components);
            this.albumToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.albumartistaToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.albumgeneroToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.albumcancionToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.rjDropdownListas = new CustomControls.RJControls.RJDropdownMenu(this.components);
            this.listasToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.listacancionToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.rjDropdownSesion.SuspendLayout();
            this.rjDropdownCantantes.SuspendLayout();
            this.rjDropdownDiscos.SuspendLayout();
            this.rjDropdownListas.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panelMenu.Controls.Add(this.btnMixtape);
            this.panelMenu.Controls.Add(this.btnSencillos);
            this.panelMenu.Controls.Add(this.btnDiscos);
            this.panelMenu.Controls.Add(this.btnGeneros);
            this.panelMenu.Controls.Add(this.btnCantantes);
            this.panelMenu.Controls.Add(this.btnSesion);
            this.panelMenu.Controls.Add(this.btnCrear);
            this.panelMenu.Controls.Add(this.btnReproduccion);
            this.panelMenu.Controls.Add(this.btnInicio);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 411);
            this.panelMenu.TabIndex = 0;
            // 
            // btnMixtape
            // 
            this.btnMixtape.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMixtape.FlatAppearance.BorderSize = 0;
            this.btnMixtape.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMixtape.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnMixtape.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMixtape.IconChar = FontAwesome.Sharp.IconChar.List;
            this.btnMixtape.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(115)))), ((int)(((byte)(104)))));
            this.btnMixtape.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMixtape.IconSize = 36;
            this.btnMixtape.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMixtape.Location = new System.Drawing.Point(0, 290);
            this.btnMixtape.Name = "btnMixtape";
            this.btnMixtape.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnMixtape.Size = new System.Drawing.Size(220, 25);
            this.btnMixtape.TabIndex = 10;
            this.btnMixtape.Text = "Mixtape";
            this.btnMixtape.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMixtape.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMixtape.UseVisualStyleBackColor = true;
            this.btnMixtape.Visible = false;
            this.btnMixtape.Click += new System.EventHandler(this.btnMixtape_Click);
            // 
            // btnSencillos
            // 
            this.btnSencillos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSencillos.FlatAppearance.BorderSize = 0;
            this.btnSencillos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSencillos.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnSencillos.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSencillos.IconChar = FontAwesome.Sharp.IconChar.Guitar;
            this.btnSencillos.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(115)))), ((int)(((byte)(104)))));
            this.btnSencillos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSencillos.IconSize = 36;
            this.btnSencillos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSencillos.Location = new System.Drawing.Point(0, 265);
            this.btnSencillos.Name = "btnSencillos";
            this.btnSencillos.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnSencillos.Size = new System.Drawing.Size(220, 25);
            this.btnSencillos.TabIndex = 9;
            this.btnSencillos.Text = "Sencillos";
            this.btnSencillos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSencillos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSencillos.UseVisualStyleBackColor = true;
            this.btnSencillos.Visible = false;
            this.btnSencillos.Click += new System.EventHandler(this.btnSencillos_Click);
            // 
            // btnDiscos
            // 
            this.btnDiscos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDiscos.FlatAppearance.BorderSize = 0;
            this.btnDiscos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiscos.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnDiscos.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDiscos.IconChar = FontAwesome.Sharp.IconChar.CompactDisc;
            this.btnDiscos.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(115)))), ((int)(((byte)(104)))));
            this.btnDiscos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDiscos.IconSize = 36;
            this.btnDiscos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDiscos.Location = new System.Drawing.Point(0, 240);
            this.btnDiscos.Name = "btnDiscos";
            this.btnDiscos.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnDiscos.Size = new System.Drawing.Size(220, 25);
            this.btnDiscos.TabIndex = 8;
            this.btnDiscos.Text = "Discos";
            this.btnDiscos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDiscos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDiscos.UseVisualStyleBackColor = true;
            this.btnDiscos.Visible = false;
            this.btnDiscos.Click += new System.EventHandler(this.btnDiscos_Click);
            // 
            // btnGeneros
            // 
            this.btnGeneros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGeneros.FlatAppearance.BorderSize = 0;
            this.btnGeneros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeneros.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnGeneros.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnGeneros.IconChar = FontAwesome.Sharp.IconChar.Headphones;
            this.btnGeneros.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(115)))), ((int)(((byte)(104)))));
            this.btnGeneros.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGeneros.IconSize = 36;
            this.btnGeneros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGeneros.Location = new System.Drawing.Point(0, 215);
            this.btnGeneros.Name = "btnGeneros";
            this.btnGeneros.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnGeneros.Size = new System.Drawing.Size(220, 25);
            this.btnGeneros.TabIndex = 5;
            this.btnGeneros.Text = "Géneros";
            this.btnGeneros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGeneros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGeneros.UseVisualStyleBackColor = true;
            this.btnGeneros.Visible = false;
            this.btnGeneros.Click += new System.EventHandler(this.btnGeneros_Click_1);
            // 
            // btnCantantes
            // 
            this.btnCantantes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCantantes.FlatAppearance.BorderSize = 0;
            this.btnCantantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCantantes.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnCantantes.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCantantes.IconChar = FontAwesome.Sharp.IconChar.Palette;
            this.btnCantantes.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(115)))), ((int)(((byte)(104)))));
            this.btnCantantes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCantantes.IconSize = 36;
            this.btnCantantes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCantantes.Location = new System.Drawing.Point(0, 190);
            this.btnCantantes.Name = "btnCantantes";
            this.btnCantantes.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCantantes.Size = new System.Drawing.Size(220, 25);
            this.btnCantantes.TabIndex = 6;
            this.btnCantantes.Text = "Cantantes";
            this.btnCantantes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCantantes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCantantes.UseVisualStyleBackColor = true;
            this.btnCantantes.Visible = false;
            this.btnCantantes.Click += new System.EventHandler(this.btnCantantes_Click);
            // 
            // btnSesion
            // 
            this.btnSesion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSesion.FlatAppearance.BorderSize = 0;
            this.btnSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSesion.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnSesion.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSesion.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnSesion.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(115)))), ((int)(((byte)(104)))));
            this.btnSesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSesion.IconSize = 36;
            this.btnSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSesion.Location = new System.Drawing.Point(0, 165);
            this.btnSesion.Name = "btnSesion";
            this.btnSesion.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnSesion.Size = new System.Drawing.Size(220, 25);
            this.btnSesion.TabIndex = 4;
            this.btnSesion.Text = "Sesión";
            this.btnSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSesion.UseVisualStyleBackColor = true;
            this.btnSesion.Visible = false;
            this.btnSesion.Click += new System.EventHandler(this.btnSesion_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCrear.FlatAppearance.BorderSize = 0;
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrear.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnCrear.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCrear.IconChar = FontAwesome.Sharp.IconChar.HeartMusicCameraBolt;
            this.btnCrear.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(115)))), ((int)(((byte)(104)))));
            this.btnCrear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCrear.IconSize = 36;
            this.btnCrear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrear.Location = new System.Drawing.Point(0, 140);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCrear.Size = new System.Drawing.Size(220, 25);
            this.btnCrear.TabIndex = 3;
            this.btnCrear.Text = "Crear lista";
            this.btnCrear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Visible = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnReproduccion
            // 
            this.btnReproduccion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReproduccion.FlatAppearance.BorderSize = 0;
            this.btnReproduccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReproduccion.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnReproduccion.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnReproduccion.IconChar = FontAwesome.Sharp.IconChar.Play;
            this.btnReproduccion.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(115)))), ((int)(((byte)(104)))));
            this.btnReproduccion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReproduccion.IconSize = 36;
            this.btnReproduccion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReproduccion.Location = new System.Drawing.Point(0, 115);
            this.btnReproduccion.Name = "btnReproduccion";
            this.btnReproduccion.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnReproduccion.Size = new System.Drawing.Size(220, 25);
            this.btnReproduccion.TabIndex = 2;
            this.btnReproduccion.Text = "Reproducir música";
            this.btnReproduccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReproduccion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReproduccion.UseVisualStyleBackColor = true;
            this.btnReproduccion.Visible = false;
            this.btnReproduccion.Click += new System.EventHandler(this.btnReproduccion_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnInicio.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnInicio.IconChar = FontAwesome.Sharp.IconChar.Music;
            this.btnInicio.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(115)))), ((int)(((byte)(104)))));
            this.btnInicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInicio.IconSize = 36;
            this.btnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.Location = new System.Drawing.Point(0, 90);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnInicio.Size = new System.Drawing.Size(220, 25);
            this.btnInicio.TabIndex = 1;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 90);
            this.panelLogo.TabIndex = 0;
            // 
            // btnLogo
            // 
            this.btnLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLogo.FlatAppearance.BorderSize = 0;
            this.btnLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogo.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.btnLogo.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLogo.IconChar = FontAwesome.Sharp.IconChar.MicrophoneAlt;
            this.btnLogo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(115)))), ((int)(((byte)(104)))));
            this.btnLogo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogo.IconSize = 40;
            this.btnLogo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogo.Location = new System.Drawing.Point(0, 0);
            this.btnLogo.Name = "btnLogo";
            this.btnLogo.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnLogo.Size = new System.Drawing.Size(220, 90);
            this.btnLogo.TabIndex = 2;
            this.btnLogo.Text = "Xeon\r\nMúsica, poesía del aire";
            this.btnLogo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLogo.UseVisualStyleBackColor = true;
            this.btnLogo.Click += new System.EventHandler(this.btnLogo_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(62)))), ((int)(((byte)(54)))));
            this.panelTitleBar.Controls.Add(this.btnRegistro);
            this.panelTitleBar.Controls.Add(this.btnIniciarSesion);
            this.panelTitleBar.Controls.Add(this.btnMini);
            this.panelTitleBar.Controls.Add(this.btnMaxi);
            this.panelTitleBar.Controls.Add(this.btnSalir);
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(564, 46);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            this.panelTitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseMove);
            this.panelTitleBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseUp);
            // 
            // btnRegistro
            // 
            this.btnRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(62)))), ((int)(((byte)(54)))));
            this.btnRegistro.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRegistro.FlatAppearance.BorderSize = 0;
            this.btnRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistro.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnRegistro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            this.btnRegistro.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnRegistro.IconColor = System.Drawing.Color.Gainsboro;
            this.btnRegistro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegistro.IconSize = 36;
            this.btnRegistro.Location = new System.Drawing.Point(256, 0);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnRegistro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnRegistro.Size = new System.Drawing.Size(110, 46);
            this.btnRegistro.TabIndex = 6;
            this.btnRegistro.Text = "Regístrate";
            this.btnRegistro.UseVisualStyleBackColor = false;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(105)))));
            this.btnIniciarSesion.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnIniciarSesion.FlatAppearance.BorderSize = 0;
            this.btnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarSesion.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnIniciarSesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnIniciarSesion.IconChar = FontAwesome.Sharp.IconChar.Nimblr;
            this.btnIniciarSesion.IconColor = System.Drawing.Color.Gainsboro;
            this.btnIniciarSesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIniciarSesion.IconSize = 36;
            this.btnIniciarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIniciarSesion.Location = new System.Drawing.Point(366, 0);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnIniciarSesion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnIniciarSesion.Size = new System.Drawing.Size(120, 46);
            this.btnIniciarSesion.TabIndex = 5;
            this.btnIniciarSesion.Text = "Iniciar sesión";
            this.btnIniciarSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIniciarSesion.UseVisualStyleBackColor = false;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // btnMini
            // 
            this.btnMini.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMini.FlatAppearance.BorderSize = 0;
            this.btnMini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMini.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnMini.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMini.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnMini.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            this.btnMini.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMini.IconSize = 24;
            this.btnMini.Location = new System.Drawing.Point(486, 0);
            this.btnMini.Name = "btnMini";
            this.btnMini.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnMini.Size = new System.Drawing.Size(26, 46);
            this.btnMini.TabIndex = 4;
            this.btnMini.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMini.UseVisualStyleBackColor = true;
            this.btnMini.Click += new System.EventHandler(this.btnMini_Click);
            // 
            // btnMaxi
            // 
            this.btnMaxi.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaxi.FlatAppearance.BorderSize = 0;
            this.btnMaxi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaxi.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnMaxi.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMaxi.IconChar = FontAwesome.Sharp.IconChar.Maximize;
            this.btnMaxi.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            this.btnMaxi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaxi.IconSize = 24;
            this.btnMaxi.Location = new System.Drawing.Point(512, 0);
            this.btnMaxi.Name = "btnMaxi";
            this.btnMaxi.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnMaxi.Size = new System.Drawing.Size(26, 46);
            this.btnMaxi.TabIndex = 3;
            this.btnMaxi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMaxi.UseVisualStyleBackColor = true;
            this.btnMaxi.Click += new System.EventHandler(this.btnMaxi_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnSalir.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnSalir.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            this.btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalir.IconSize = 24;
            this.btnSalir.Location = new System.Drawing.Point(538, 0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnSalir.Size = new System.Drawing.Size(26, 46);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            this.lblTitleChildForm.Location = new System.Drawing.Point(45, 9);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(45, 19);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Inicio";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(62)))), ((int)(((byte)(54)))));
            this.iconCurrentChildForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Music;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(0, 0);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 46);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // rjDropdownSesion
            // 
            this.rjDropdownSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(174)))), ((int)(((byte)(187)))));
            this.rjDropdownSesion.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjDropdownSesion.IsMainMenu = false;
            this.rjDropdownSesion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.perfilesToolStripMenuItem});
            this.rjDropdownSesion.MenuItemHeight = 25;
            this.rjDropdownSesion.MenuItemTextColor = System.Drawing.Color.Empty;
            this.rjDropdownSesion.Name = "rjDropdownSesion";
            this.rjDropdownSesion.PrimaryColor = System.Drawing.Color.Empty;
            this.rjDropdownSesion.Size = new System.Drawing.Size(145, 52);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(150)))), ((int)(((byte)(162)))));
            this.usuariosToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(36)))), ((int)(((byte)(47)))));
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // perfilesToolStripMenuItem
            // 
            this.perfilesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(150)))), ((int)(((byte)(162)))));
            this.perfilesToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(36)))), ((int)(((byte)(47)))));
            this.perfilesToolStripMenuItem.Name = "perfilesToolStripMenuItem";
            this.perfilesToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.perfilesToolStripMenuItem.Text = "Perfiles";
            this.perfilesToolStripMenuItem.Click += new System.EventHandler(this.perfilesToolStripMenuItem_Click);
            // 
            // rjDropdownCantantes
            // 
            this.rjDropdownCantantes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(174)))), ((int)(((byte)(187)))));
            this.rjDropdownCantantes.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjDropdownCantantes.IsMainMenu = false;
            this.rjDropdownCantantes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.artistaToolStripMenu,
            this.artistageneroToolStripMenu});
            this.rjDropdownCantantes.MenuItemHeight = 25;
            this.rjDropdownCantantes.MenuItemTextColor = System.Drawing.Color.Empty;
            this.rjDropdownCantantes.Name = "rjDropdownSesion";
            this.rjDropdownCantantes.PrimaryColor = System.Drawing.Color.Empty;
            this.rjDropdownCantantes.Size = new System.Drawing.Size(184, 52);
            // 
            // artistaToolStripMenu
            // 
            this.artistaToolStripMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(150)))), ((int)(((byte)(162)))));
            this.artistaToolStripMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(36)))), ((int)(((byte)(47)))));
            this.artistaToolStripMenu.Name = "artistaToolStripMenu";
            this.artistaToolStripMenu.Size = new System.Drawing.Size(183, 24);
            this.artistaToolStripMenu.Text = "Artistas";
            this.artistaToolStripMenu.Click += new System.EventHandler(this.artistaToolStripMenu_Click);
            // 
            // artistageneroToolStripMenu
            // 
            this.artistageneroToolStripMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(150)))), ((int)(((byte)(162)))));
            this.artistageneroToolStripMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(36)))), ((int)(((byte)(47)))));
            this.artistageneroToolStripMenu.Name = "artistageneroToolStripMenu";
            this.artistageneroToolStripMenu.Size = new System.Drawing.Size(183, 24);
            this.artistageneroToolStripMenu.Text = "ArtistaGenero";
            this.artistageneroToolStripMenu.Click += new System.EventHandler(this.artistageneroToolStripMenu_Click);
            // 
            // rjDropdownDiscos
            // 
            this.rjDropdownDiscos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(174)))), ((int)(((byte)(187)))));
            this.rjDropdownDiscos.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjDropdownDiscos.IsMainMenu = false;
            this.rjDropdownDiscos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.albumToolStripMenu,
            this.albumartistaToolStripMenu,
            this.albumgeneroToolStripMenu,
            this.albumcancionToolStripMenu});
            this.rjDropdownDiscos.MenuItemHeight = 25;
            this.rjDropdownDiscos.MenuItemTextColor = System.Drawing.Color.Empty;
            this.rjDropdownDiscos.Name = "rjDropdownSesion";
            this.rjDropdownDiscos.PrimaryColor = System.Drawing.Color.Empty;
            this.rjDropdownDiscos.Size = new System.Drawing.Size(190, 100);
            // 
            // albumToolStripMenu
            // 
            this.albumToolStripMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(150)))), ((int)(((byte)(162)))));
            this.albumToolStripMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(36)))), ((int)(((byte)(47)))));
            this.albumToolStripMenu.Name = "albumToolStripMenu";
            this.albumToolStripMenu.Size = new System.Drawing.Size(189, 24);
            this.albumToolStripMenu.Text = "Álbumes";
            this.albumToolStripMenu.Click += new System.EventHandler(this.albumToolStripMenu_Click);
            // 
            // albumartistaToolStripMenu
            // 
            this.albumartistaToolStripMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(150)))), ((int)(((byte)(162)))));
            this.albumartistaToolStripMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(36)))), ((int)(((byte)(47)))));
            this.albumartistaToolStripMenu.Name = "albumartistaToolStripMenu";
            this.albumartistaToolStripMenu.Size = new System.Drawing.Size(189, 24);
            this.albumartistaToolStripMenu.Text = "ÁlbumArtista";
            this.albumartistaToolStripMenu.Click += new System.EventHandler(this.albumartistaToolStripMenu_Click);
            // 
            // albumgeneroToolStripMenu
            // 
            this.albumgeneroToolStripMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(150)))), ((int)(((byte)(162)))));
            this.albumgeneroToolStripMenu.Name = "albumgeneroToolStripMenu";
            this.albumgeneroToolStripMenu.Size = new System.Drawing.Size(189, 24);
            this.albumgeneroToolStripMenu.Text = "ÁlbumGénero";
            this.albumgeneroToolStripMenu.Click += new System.EventHandler(this.albumgeneroToolStripMenu_Click);
            // 
            // albumcancionToolStripMenu
            // 
            this.albumcancionToolStripMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(150)))), ((int)(((byte)(162)))));
            this.albumcancionToolStripMenu.Name = "albumcancionToolStripMenu";
            this.albumcancionToolStripMenu.Size = new System.Drawing.Size(189, 24);
            this.albumcancionToolStripMenu.Text = "ÁlbumCanción";
            this.albumcancionToolStripMenu.Click += new System.EventHandler(this.albumcancionToolStripMenu_Click);
            // 
            // rjDropdownListas
            // 
            this.rjDropdownListas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(174)))), ((int)(((byte)(187)))));
            this.rjDropdownListas.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjDropdownListas.IsMainMenu = false;
            this.rjDropdownListas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listasToolStripMenu,
            this.listacancionToolStripMenu});
            this.rjDropdownListas.MenuItemHeight = 25;
            this.rjDropdownListas.MenuItemTextColor = System.Drawing.Color.Empty;
            this.rjDropdownListas.Name = "rjDropdownSesion";
            this.rjDropdownListas.PrimaryColor = System.Drawing.Color.Empty;
            this.rjDropdownListas.Size = new System.Drawing.Size(178, 52);
            // 
            // listasToolStripMenu
            // 
            this.listasToolStripMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(150)))), ((int)(((byte)(162)))));
            this.listasToolStripMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(36)))), ((int)(((byte)(47)))));
            this.listasToolStripMenu.Name = "listasToolStripMenu";
            this.listasToolStripMenu.Size = new System.Drawing.Size(177, 24);
            this.listasToolStripMenu.Text = "Listas";
            this.listasToolStripMenu.Click += new System.EventHandler(this.listasToolStripMenu_Click);
            // 
            // listacancionToolStripMenu
            // 
            this.listacancionToolStripMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(150)))), ((int)(((byte)(162)))));
            this.listacancionToolStripMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(36)))), ((int)(((byte)(47)))));
            this.listacancionToolStripMenu.Name = "listacancionToolStripMenu";
            this.listacancionToolStripMenu.Size = new System.Drawing.Size(177, 24);
            this.listacancionToolStripMenu.Text = "ListaCanción";
            this.listacancionToolStripMenu.Click += new System.EventHandler(this.listacancionToolStripMenu_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(36)))), ((int)(((byte)(47)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FormPrincipal";
            this.Text = "FormPrincipal";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.rjDropdownSesion.ResumeLayout(false);
            this.rjDropdownCantantes.ResumeLayout(false);
            this.rjDropdownDiscos.ResumeLayout(false);
            this.rjDropdownListas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnInicio;
        private FontAwesome.Sharp.IconButton btnSencillos;
        private FontAwesome.Sharp.IconButton btnDiscos;
        private FontAwesome.Sharp.IconButton btnCantantes;
        private FontAwesome.Sharp.IconButton btnSesion;
        private FontAwesome.Sharp.IconButton btnCrear;
        private FontAwesome.Sharp.IconButton btnReproduccion;
        private FontAwesome.Sharp.IconButton btnMixtape;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitleChildForm;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private FontAwesome.Sharp.IconButton btnMini;
        private FontAwesome.Sharp.IconButton btnMaxi;
        private FontAwesome.Sharp.IconButton btnSalir;
        private FontAwesome.Sharp.IconButton btnIniciarSesion;
        private FontAwesome.Sharp.IconButton btnRegistro;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnLogo;
        private CustomControls.RJControls.RJDropdownMenu rjDropdownSesion;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perfilesToolStripMenuItem;
        private CustomControls.RJControls.RJDropdownMenu rjDropdownCantantes;
        private System.Windows.Forms.ToolStripMenuItem artistaToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem artistageneroToolStripMenu;
        private CustomControls.RJControls.RJDropdownMenu rjDropdownDiscos;
        private System.Windows.Forms.ToolStripMenuItem albumToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem albumartistaToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem albumgeneroToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem albumcancionToolStripMenu;
        private CustomControls.RJControls.RJDropdownMenu rjDropdownListas;
        private System.Windows.Forms.ToolStripMenuItem listasToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem listacancionToolStripMenu;
        private FontAwesome.Sharp.IconButton btnGeneros;
        private System.Windows.Forms.Timer timer1;
    }
}

