
namespace Xeon.Views
{
    partial class AlbumInfo
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
            this.panTitulo = new System.Windows.Forms.Panel();
            this.panDescripcion = new System.Windows.Forms.Panel();
            this.picAlbum = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblArtista = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblAño = new System.Windows.Forms.Label();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.panTitulo.SuspendLayout();
            this.panDescripcion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAlbum)).BeginInit();
            this.SuspendLayout();
            // 
            // panTitulo
            // 
            this.panTitulo.Controls.Add(this.btnSalir);
            this.panTitulo.Controls.Add(this.lblTitulo);
            this.panTitulo.Location = new System.Drawing.Point(44, 12);
            this.panTitulo.Name = "panTitulo";
            this.panTitulo.Size = new System.Drawing.Size(325, 50);
            this.panTitulo.TabIndex = 1;
            // 
            // panDescripcion
            // 
            this.panDescripcion.Controls.Add(this.lblAño);
            this.panDescripcion.Controls.Add(this.lblGenero);
            this.panDescripcion.Controls.Add(this.lblArtista);
            this.panDescripcion.Location = new System.Drawing.Point(195, 83);
            this.panDescripcion.Name = "panDescripcion";
            this.panDescripcion.Size = new System.Drawing.Size(206, 209);
            this.panDescripcion.TabIndex = 2;
            // 
            // picAlbum
            // 
            this.picAlbum.Location = new System.Drawing.Point(12, 83);
            this.picAlbum.Name = "picAlbum";
            this.picAlbum.Size = new System.Drawing.Size(157, 209);
            this.picAlbum.TabIndex = 0;
            this.picAlbum.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(107, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(92, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Nombre del albúm";
            // 
            // lblArtista
            // 
            this.lblArtista.AutoSize = true;
            this.lblArtista.Location = new System.Drawing.Point(3, 12);
            this.lblArtista.Name = "lblArtista";
            this.lblArtista.Size = new System.Drawing.Size(92, 13);
            this.lblArtista.TabIndex = 1;
            this.lblArtista.Text = "Nombre del artista";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(3, 49);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(97, 13);
            this.lblGenero.TabIndex = 2;
            this.lblGenero.Text = "Nombre del género";
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Location = new System.Drawing.Point(3, 91);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(26, 13);
            this.lblAño.TabIndex = 3;
            this.lblAño.Text = "Año";
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnSalir.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnSalir.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            this.btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalir.IconSize = 24;
            this.btnSalir.Location = new System.Drawing.Point(299, 0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnSalir.Size = new System.Drawing.Size(26, 24);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // AlbumInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 321);
            this.Controls.Add(this.panDescripcion);
            this.Controls.Add(this.panTitulo);
            this.Controls.Add(this.picAlbum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(429, 321);
            this.MinimumSize = new System.Drawing.Size(429, 321);
            this.Name = "AlbumInfo";
            this.Text = "AlbumInfo";
            this.panTitulo.ResumeLayout(false);
            this.panTitulo.PerformLayout();
            this.panDescripcion.ResumeLayout(false);
            this.panDescripcion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAlbum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panTitulo;
        private System.Windows.Forms.Panel panDescripcion;
        private FontAwesome.Sharp.IconButton btnSalir;
        public System.Windows.Forms.PictureBox picAlbum;
        public System.Windows.Forms.Label lblTitulo;
        public System.Windows.Forms.Label lblAño;
        public System.Windows.Forms.Label lblGenero;
        public System.Windows.Forms.Label lblArtista;
    }
}