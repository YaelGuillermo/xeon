
namespace Xeon.Views
{
    partial class UCRepCancion
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
            this.rjbtnEscuchar = new CustomControls.RJControls.RJButton();
            this.lblCancion = new System.Windows.Forms.Label();
            this.lblArtista = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rjbtnEscuchar
            // 
            this.rjbtnEscuchar.BackColor = System.Drawing.SystemColors.Control;
            this.rjbtnEscuchar.BackgroundColor = System.Drawing.SystemColors.Control;
            this.rjbtnEscuchar.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjbtnEscuchar.BorderRadius = 20;
            this.rjbtnEscuchar.BorderSize = 1;
            this.rjbtnEscuchar.FlatAppearance.BorderSize = 0;
            this.rjbtnEscuchar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjbtnEscuchar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjbtnEscuchar.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.rjbtnEscuchar.Location = new System.Drawing.Point(-1, 4);
            this.rjbtnEscuchar.Name = "rjbtnEscuchar";
            this.rjbtnEscuchar.Size = new System.Drawing.Size(74, 33);
            this.rjbtnEscuchar.TabIndex = 4;
            this.rjbtnEscuchar.Text = "Escuchar";
            this.rjbtnEscuchar.TextColor = System.Drawing.Color.MediumSlateBlue;
            this.rjbtnEscuchar.UseVisualStyleBackColor = false;
            this.rjbtnEscuchar.Click += new System.EventHandler(this.rjbtnEscuchar_Click);
            // 
            // lblCancion
            // 
            this.lblCancion.AutoSize = true;
            this.lblCancion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancion.Location = new System.Drawing.Point(73, 0);
            this.lblCancion.Name = "lblCancion";
            this.lblCancion.Size = new System.Drawing.Size(142, 17);
            this.lblCancion.TabIndex = 5;
            this.lblCancion.Text = "Nombre de Canción";
            // 
            // lblArtista
            // 
            this.lblArtista.AutoSize = true;
            this.lblArtista.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtista.Location = new System.Drawing.Point(73, 21);
            this.lblArtista.Name = "lblArtista";
            this.lblArtista.Size = new System.Drawing.Size(126, 17);
            this.lblArtista.TabIndex = 6;
            this.lblArtista.Text = "Nombre de Artista";
            // 
            // UCRepCancion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.Controls.Add(this.lblArtista);
            this.Controls.Add(this.lblCancion);
            this.Controls.Add(this.rjbtnEscuchar);
            this.Name = "UCRepCancion";
            this.Size = new System.Drawing.Size(175, 39);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RJControls.RJButton rjbtnEscuchar;
        private System.Windows.Forms.Label lblCancion;
        private System.Windows.Forms.Label lblArtista;
    }
}
