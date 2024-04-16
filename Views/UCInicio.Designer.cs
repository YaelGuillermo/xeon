
namespace Xeon.Views
{
    partial class UCInicio
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
            this.lblAlbum = new System.Windows.Forms.Label();
            this.rjbtnEscuchar = new CustomControls.RJControls.RJButton();
            this.rjbtnInformacion = new CustomControls.RJControls.RJButton();
            this.rjpicAlbum = new CustomControls.RJControls.RJPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.rjpicAlbum)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAlbum
            // 
            this.lblAlbum.AutoSize = true;
            this.lblAlbum.Location = new System.Drawing.Point(134, 9);
            this.lblAlbum.Name = "lblAlbum";
            this.lblAlbum.Size = new System.Drawing.Size(92, 13);
            this.lblAlbum.TabIndex = 1;
            this.lblAlbum.Text = "Nombre del albúm";
            // 
            // rjbtnEscuchar
            // 
            this.rjbtnEscuchar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjbtnEscuchar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjbtnEscuchar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjbtnEscuchar.BorderRadius = 20;
            this.rjbtnEscuchar.BorderSize = 0;
            this.rjbtnEscuchar.FlatAppearance.BorderSize = 0;
            this.rjbtnEscuchar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjbtnEscuchar.ForeColor = System.Drawing.Color.White;
            this.rjbtnEscuchar.Location = new System.Drawing.Point(134, 56);
            this.rjbtnEscuchar.Name = "rjbtnEscuchar";
            this.rjbtnEscuchar.Size = new System.Drawing.Size(122, 40);
            this.rjbtnEscuchar.TabIndex = 2;
            this.rjbtnEscuchar.Text = "Escuchar";
            this.rjbtnEscuchar.TextColor = System.Drawing.Color.White;
            this.rjbtnEscuchar.UseVisualStyleBackColor = false;
            this.rjbtnEscuchar.Click += new System.EventHandler(this.rjbtnEscuchar_Click);
            // 
            // rjbtnInformacion
            // 
            this.rjbtnInformacion.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjbtnInformacion.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjbtnInformacion.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjbtnInformacion.BorderRadius = 20;
            this.rjbtnInformacion.BorderSize = 0;
            this.rjbtnInformacion.FlatAppearance.BorderSize = 0;
            this.rjbtnInformacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjbtnInformacion.ForeColor = System.Drawing.Color.White;
            this.rjbtnInformacion.Location = new System.Drawing.Point(134, 97);
            this.rjbtnInformacion.Name = "rjbtnInformacion";
            this.rjbtnInformacion.Size = new System.Drawing.Size(122, 40);
            this.rjbtnInformacion.TabIndex = 3;
            this.rjbtnInformacion.Text = "Información";
            this.rjbtnInformacion.TextColor = System.Drawing.Color.White;
            this.rjbtnInformacion.UseVisualStyleBackColor = false;
            this.rjbtnInformacion.Click += new System.EventHandler(this.rjbtnInformacion_Click);
            // 
            // rjpicAlbum
            // 
            this.rjpicAlbum.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjpicAlbum.BorderColor = System.Drawing.Color.RoyalBlue;
            this.rjpicAlbum.BorderColor2 = System.Drawing.Color.HotPink;
            this.rjpicAlbum.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjpicAlbum.BorderSize = 2;
            this.rjpicAlbum.GradientAngle = 50F;
            this.rjpicAlbum.Location = new System.Drawing.Point(0, 9);
            this.rjpicAlbum.Name = "rjpicAlbum";
            this.rjpicAlbum.Size = new System.Drawing.Size(128, 128);
            this.rjpicAlbum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rjpicAlbum.TabIndex = 0;
            this.rjpicAlbum.TabStop = false;
            this.rjpicAlbum.Click += new System.EventHandler(this.rjpicAlbum_Click);
            // 
            // UCInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rjbtnInformacion);
            this.Controls.Add(this.rjbtnEscuchar);
            this.Controls.Add(this.lblAlbum);
            this.Controls.Add(this.rjpicAlbum);
            this.Name = "UCInicio";
            this.Size = new System.Drawing.Size(269, 150);
            ((System.ComponentModel.ISupportInitialize)(this.rjpicAlbum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RJControls.RJPictureBox rjpicAlbum;
        private System.Windows.Forms.Label lblAlbum;
        private CustomControls.RJControls.RJButton rjbtnEscuchar;
        private CustomControls.RJControls.RJButton rjbtnInformacion;
    }
}
