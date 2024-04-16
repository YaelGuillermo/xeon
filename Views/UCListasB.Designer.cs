
namespace Xeon.Views
{
    partial class UCListasB
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.rjpicAlbum = new CustomControls.RJControls.RJPictureBox();
            this.rjbtnAgregar = new CustomControls.RJControls.RJButton();
            this.lblCancion = new System.Windows.Forms.Label();
            this.lblArtista = new System.Windows.Forms.Label();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.lblAlbum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rjpicAlbum)).BeginInit();
            this.SuspendLayout();
            // 
            // rjpicAlbum
            // 
            this.rjpicAlbum.BackColor = System.Drawing.Color.Lavender;
            this.rjpicAlbum.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Triangle;
            this.rjpicAlbum.BorderColor = System.Drawing.Color.RoyalBlue;
            this.rjpicAlbum.BorderColor2 = System.Drawing.Color.HotPink;
            this.rjpicAlbum.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.rjpicAlbum.BorderSize = 4;
            this.rjpicAlbum.GradientAngle = 50F;
            this.rjpicAlbum.Location = new System.Drawing.Point(79, -9);
            this.rjpicAlbum.Name = "rjpicAlbum";
            this.rjpicAlbum.Size = new System.Drawing.Size(62, 62);
            this.rjpicAlbum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rjpicAlbum.TabIndex = 1;
            this.rjpicAlbum.TabStop = false;
            // 
            // rjbtnAgregar
            // 
            this.rjbtnAgregar.BackColor = System.Drawing.Color.MediumVioletRed;
            this.rjbtnAgregar.BackgroundColor = System.Drawing.Color.MediumVioletRed;
            this.rjbtnAgregar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjbtnAgregar.BorderRadius = 12;
            this.rjbtnAgregar.BorderSize = 0;
            this.rjbtnAgregar.FlatAppearance.BorderSize = 0;
            this.rjbtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjbtnAgregar.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjbtnAgregar.ForeColor = System.Drawing.Color.White;
            this.rjbtnAgregar.Location = new System.Drawing.Point(47, 40);
            this.rjbtnAgregar.Name = "rjbtnAgregar";
            this.rjbtnAgregar.Size = new System.Drawing.Size(40, 17);
            this.rjbtnAgregar.TabIndex = 3;
            this.rjbtnAgregar.Text = "Añadir";
            this.rjbtnAgregar.TextColor = System.Drawing.Color.White;
            this.rjbtnAgregar.UseVisualStyleBackColor = false;
            this.rjbtnAgregar.Click += new System.EventHandler(this.rjbtnAgregar_Click);
            // 
            // lblCancion
            // 
            this.lblCancion.AutoSize = true;
            this.lblCancion.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancion.ForeColor = System.Drawing.Color.White;
            this.lblCancion.Location = new System.Drawing.Point(3, 0);
            this.lblCancion.Name = "lblCancion";
            this.lblCancion.Size = new System.Drawing.Size(137, 16);
            this.lblCancion.TabIndex = 4;
            this.lblCancion.Text = "Nombre de la canción";
            // 
            // lblArtista
            // 
            this.lblArtista.AutoSize = true;
            this.lblArtista.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtista.ForeColor = System.Drawing.Color.White;
            this.lblArtista.Location = new System.Drawing.Point(3, 15);
            this.lblArtista.Name = "lblArtista";
            this.lblArtista.Size = new System.Drawing.Size(121, 16);
            this.lblArtista.TabIndex = 5;
            this.lblArtista.Text = "Nombre del artista";
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuracion.ForeColor = System.Drawing.Color.White;
            this.lblDuracion.Location = new System.Drawing.Point(3, 44);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(63, 16);
            this.lblDuracion.TabIndex = 6;
            this.lblDuracion.Text = "Duración";
            // 
            // lblAlbum
            // 
            this.lblAlbum.AutoSize = true;
            this.lblAlbum.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlbum.ForeColor = System.Drawing.Color.White;
            this.lblAlbum.Location = new System.Drawing.Point(3, 30);
            this.lblAlbum.Name = "lblAlbum";
            this.lblAlbum.Size = new System.Drawing.Size(119, 16);
            this.lblAlbum.TabIndex = 7;
            this.lblAlbum.Text = "Nombre del albúm";
            // 
            // UCListasB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumOrchid;
            this.Controls.Add(this.lblAlbum);
            this.Controls.Add(this.lblDuracion);
            this.Controls.Add(this.lblArtista);
            this.Controls.Add(this.lblCancion);
            this.Controls.Add(this.rjbtnAgregar);
            this.Controls.Add(this.rjpicAlbum);
            this.Name = "UCListasB";
            this.Size = new System.Drawing.Size(128, 60);
            ((System.ComponentModel.ISupportInitialize)(this.rjpicAlbum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RJControls.RJPictureBox rjpicAlbum;
        private CustomControls.RJControls.RJButton rjbtnAgregar;
        private System.Windows.Forms.Label lblCancion;
        private System.Windows.Forms.Label lblArtista;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.Label lblAlbum;
    }
}
