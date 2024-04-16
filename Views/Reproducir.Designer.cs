
namespace Xeon.Views
{
    partial class Reproducir
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
            this.tabCtrl = new System.Windows.Forms.TabControl();
            this.userDetail = new System.Windows.Forms.TabPage();
            this.tabLayPan = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.rjButton1 = new CustomControls.RJControls.RJButton();
            this.Pause = new CustomControls.RJControls.RJButton();
            this.chromiumWebBrowser1 = new CefSharp.WinForms.ChromiumWebBrowser();
            this.userEntry = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.rjRegresar = new CustomControls.RJControls.RJButton();
            this.rjSalir = new CustomControls.RJControls.RJButton();
            this.label3 = new System.Windows.Forms.Label();
            this.rjFiltro = new CustomControls.RJControls.RJTextBox();
            this.flowLayCanciones = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayListas = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.rjEscuchar = new CustomControls.RJControls.RJButton();
            this.rjButton2 = new CustomControls.RJControls.RJButton();
            this.tabCtrl.SuspendLayout();
            this.userDetail.SuspendLayout();
            this.tabLayPan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.userEntry.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCtrl
            // 
            this.tabCtrl.Controls.Add(this.userDetail);
            this.tabCtrl.Controls.Add(this.userEntry);
            this.tabCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCtrl.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCtrl.Location = new System.Drawing.Point(0, 0);
            this.tabCtrl.Name = "tabCtrl";
            this.tabCtrl.SelectedIndex = 0;
            this.tabCtrl.Size = new System.Drawing.Size(800, 450);
            this.tabCtrl.TabIndex = 5;
            // 
            // userDetail
            // 
            this.userDetail.Controls.Add(this.tabLayPan);
            this.userDetail.Location = new System.Drawing.Point(4, 29);
            this.userDetail.Name = "userDetail";
            this.userDetail.Padding = new System.Windows.Forms.Padding(3);
            this.userDetail.Size = new System.Drawing.Size(792, 417);
            this.userDetail.TabIndex = 0;
            this.userDetail.Text = "Creación";
            this.userDetail.UseVisualStyleBackColor = true;
            // 
            // tabLayPan
            // 
            this.tabLayPan.ColumnCount = 1;
            this.tabLayPan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tabLayPan.Controls.Add(this.dataGridView, 0, 1);
            this.tabLayPan.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tabLayPan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabLayPan.Location = new System.Drawing.Point(3, 3);
            this.tabLayPan.Name = "tabLayPan";
            this.tabLayPan.RowCount = 2;
            this.tabLayPan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tabLayPan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tabLayPan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabLayPan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabLayPan.Size = new System.Drawing.Size(786, 411);
            this.tabLayPan.TabIndex = 1;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(3, 290);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(780, 118);
            this.dataGridView.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.63636F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.36364F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.chromiumWebBrowser1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(780, 281);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.rjButton2, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.rjButton1, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.Pause, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(686, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(91, 275);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 14;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(3, 257);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(57, 14);
            this.rjButton1.TabIndex = 2;
            this.rjButton1.Text = "Next";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // Pause
            // 
            this.Pause.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Pause.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.Pause.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Pause.BorderRadius = 14;
            this.Pause.BorderSize = 0;
            this.Pause.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pause.FlatAppearance.BorderSize = 0;
            this.Pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pause.ForeColor = System.Drawing.Color.White;
            this.Pause.Location = new System.Drawing.Point(3, 120);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(57, 40);
            this.Pause.TabIndex = 1;
            this.Pause.Text = "Restart";
            this.Pause.TextColor = System.Drawing.Color.White;
            this.Pause.UseVisualStyleBackColor = false;
            this.Pause.Click += new System.EventHandler(this.Pause_Click);
            // 
            // chromiumWebBrowser1
            // 
            this.chromiumWebBrowser1.ActivateBrowserOnCreation = false;
            this.chromiumWebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chromiumWebBrowser1.Location = new System.Drawing.Point(3, 3);
            this.chromiumWebBrowser1.Name = "chromiumWebBrowser1";
            this.chromiumWebBrowser1.Size = new System.Drawing.Size(677, 275);
            this.chromiumWebBrowser1.TabIndex = 1;
            // 
            // userEntry
            // 
            this.userEntry.Controls.Add(this.tableLayoutPanel1);
            this.userEntry.Location = new System.Drawing.Point(4, 29);
            this.userEntry.Name = "userEntry";
            this.userEntry.Padding = new System.Windows.Forms.Padding(3);
            this.userEntry.Size = new System.Drawing.Size(792, 417);
            this.userEntry.TabIndex = 1;
            this.userEntry.Text = "Buscador";
            this.userEntry.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.rjFiltro, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.flowLayCanciones, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.flowLayListas, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(786, 411);
            this.tableLayoutPanel1.TabIndex = 24;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Controls.Add(this.rjEscuchar, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.rjRegresar, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.rjSalir, 4, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(65, 373);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(654, 35);
            this.tableLayoutPanel3.TabIndex = 41;
            // 
            // rjRegresar
            // 
            this.rjRegresar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjRegresar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjRegresar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjRegresar.BorderRadius = 20;
            this.rjRegresar.BorderSize = 0;
            this.rjRegresar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rjRegresar.FlatAppearance.BorderSize = 0;
            this.rjRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjRegresar.ForeColor = System.Drawing.Color.White;
            this.rjRegresar.Location = new System.Drawing.Point(3, 3);
            this.rjRegresar.Name = "rjRegresar";
            this.rjRegresar.Size = new System.Drawing.Size(124, 29);
            this.rjRegresar.TabIndex = 38;
            this.rjRegresar.Text = "¿No tienes listas? Crea una ahora mismo";
            this.rjRegresar.TextColor = System.Drawing.Color.White;
            this.rjRegresar.UseVisualStyleBackColor = false;
            // 
            // rjSalir
            // 
            this.rjSalir.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjSalir.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjSalir.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjSalir.BorderRadius = 15;
            this.rjSalir.BorderSize = 0;
            this.rjSalir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rjSalir.FlatAppearance.BorderSize = 0;
            this.rjSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjSalir.ForeColor = System.Drawing.Color.White;
            this.rjSalir.Location = new System.Drawing.Point(523, 3);
            this.rjSalir.Name = "rjSalir";
            this.rjSalir.Size = new System.Drawing.Size(128, 29);
            this.rjSalir.TabIndex = 35;
            this.rjSalir.Text = "Salir";
            this.rjSalir.TextColor = System.Drawing.Color.White;
            this.rjSalir.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Location = new System.Drawing.Point(65, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(654, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "Busca tu canción";
            // 
            // rjFiltro
            // 
            this.rjFiltro.BackColor = System.Drawing.SystemColors.Window;
            this.rjFiltro.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjFiltro.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjFiltro.BorderRadius = 0;
            this.rjFiltro.BorderSize = 2;
            this.rjFiltro.Dock = System.Windows.Forms.DockStyle.Top;
            this.rjFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjFiltro.ForeColor = System.Drawing.Color.DimGray;
            this.rjFiltro.Location = new System.Drawing.Point(66, 207);
            this.rjFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.rjFiltro.Multiline = false;
            this.rjFiltro.Name = "rjFiltro";
            this.rjFiltro.Padding = new System.Windows.Forms.Padding(7);
            this.rjFiltro.PasswordChar = false;
            this.rjFiltro.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjFiltro.PlaceholderText = "";
            this.rjFiltro.Size = new System.Drawing.Size(652, 31);
            this.rjFiltro.TabIndex = 39;
            this.rjFiltro.Tag = "Canción / Artista / Álbum";
            this.rjFiltro.Texts = "Canción / Artista / Álbum";
            this.rjFiltro.UnderlinedStyle = false;
            // 
            // flowLayCanciones
            // 
            this.flowLayCanciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayCanciones.Location = new System.Drawing.Point(65, 242);
            this.flowLayCanciones.Name = "flowLayCanciones";
            this.flowLayCanciones.Size = new System.Drawing.Size(654, 125);
            this.flowLayCanciones.TabIndex = 42;
            // 
            // flowLayListas
            // 
            this.flowLayListas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayListas.Location = new System.Drawing.Point(65, 39);
            this.flowLayListas.Name = "flowLayListas";
            this.flowLayListas.Size = new System.Drawing.Size(654, 125);
            this.flowLayListas.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label4.Location = new System.Drawing.Point(65, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(654, 20);
            this.label4.TabIndex = 44;
            this.label4.Text = "Tus listas de reproducción:";
            // 
            // rjEscuchar
            // 
            this.rjEscuchar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjEscuchar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjEscuchar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjEscuchar.BorderRadius = 15;
            this.rjEscuchar.BorderSize = 0;
            this.rjEscuchar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rjEscuchar.FlatAppearance.BorderSize = 0;
            this.rjEscuchar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjEscuchar.ForeColor = System.Drawing.Color.White;
            this.rjEscuchar.Location = new System.Drawing.Point(133, 3);
            this.rjEscuchar.Name = "rjEscuchar";
            this.rjEscuchar.Size = new System.Drawing.Size(124, 29);
            this.rjEscuchar.TabIndex = 39;
            this.rjEscuchar.Text = "Escuchar";
            this.rjEscuchar.TextColor = System.Drawing.Color.White;
            this.rjEscuchar.UseVisualStyleBackColor = false;
            // 
            // rjButton2
            // 
            this.rjButton2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton2.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton2.BorderRadius = 14;
            this.rjButton2.BorderSize = 0;
            this.rjButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.ForeColor = System.Drawing.Color.White;
            this.rjButton2.Location = new System.Drawing.Point(17, 130);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(57, 14);
            this.rjButton2.TabIndex = 3;
            this.rjButton2.Text = "Previous";
            this.rjButton2.TextColor = System.Drawing.Color.White;
            this.rjButton2.UseVisualStyleBackColor = false;
            this.rjButton2.Click += new System.EventHandler(this.rjButton2_Click);
            // 
            // Reproducir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabCtrl);
            this.Name = "Reproducir";
            this.Text = "Reproducir";
            this.Load += new System.EventHandler(this.Reproducir_Load);
            this.tabCtrl.ResumeLayout(false);
            this.userDetail.ResumeLayout(false);
            this.tabLayPan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.userEntry.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCtrl;
        private System.Windows.Forms.TabPage userDetail;
        private System.Windows.Forms.TabPage userEntry;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private CustomControls.RJControls.RJButton rjSalir;
        private System.Windows.Forms.Label label3;
        private CustomControls.RJControls.RJTextBox rjFiltro;
        private System.Windows.Forms.FlowLayoutPanel flowLayCanciones;
        private System.Windows.Forms.FlowLayoutPanel flowLayListas;
        private System.Windows.Forms.Label label4;
        private CustomControls.RJControls.RJButton rjRegresar;
        private System.Windows.Forms.TableLayoutPanel tabLayPan;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private CustomControls.RJControls.RJButton rjButton1;
        private CustomControls.RJControls.RJButton Pause;
        private CefSharp.WinForms.ChromiumWebBrowser chromiumWebBrowser1;
        private CustomControls.RJControls.RJButton rjEscuchar;
        private CustomControls.RJControls.RJButton rjButton2;
    }
}