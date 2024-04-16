
namespace Xeon.Views
{
    partial class UCRepLista
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
            this.lblLista = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rjbtnEscuchar
            // 
            this.rjbtnEscuchar.BackColor = System.Drawing.SystemColors.Control;
            this.rjbtnEscuchar.BackgroundColor = System.Drawing.SystemColors.Control;
            this.rjbtnEscuchar.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjbtnEscuchar.BorderRadius = 13;
            this.rjbtnEscuchar.BorderSize = 1;
            this.rjbtnEscuchar.FlatAppearance.BorderSize = 0;
            this.rjbtnEscuchar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjbtnEscuchar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjbtnEscuchar.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.rjbtnEscuchar.Location = new System.Drawing.Point(1, 6);
            this.rjbtnEscuchar.Name = "rjbtnEscuchar";
            this.rjbtnEscuchar.Size = new System.Drawing.Size(50, 25);
            this.rjbtnEscuchar.TabIndex = 3;
            this.rjbtnEscuchar.Text = "Seleccionar";
            this.rjbtnEscuchar.TextColor = System.Drawing.Color.MediumSlateBlue;
            this.rjbtnEscuchar.UseVisualStyleBackColor = false;
            this.rjbtnEscuchar.Click += new System.EventHandler(this.rjbtnEscuchar_Click);
            // 
            // lblLista
            // 
            this.lblLista.AutoSize = true;
            this.lblLista.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLista.Location = new System.Drawing.Point(53, 2);
            this.lblLista.Name = "lblLista";
            this.lblLista.Size = new System.Drawing.Size(114, 17);
            this.lblLista.TabIndex = 4;
            this.lblLista.Text = "Nombre de Lista";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(111, 2);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(135, 17);
            this.lblUsuario.TabIndex = 5;
            this.lblUsuario.Text = "Nombre del usuario";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Century Gothic", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(56, 19);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(51, 12);
            this.lblDescripcion.TabIndex = 6;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(125, 18);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(47, 17);
            this.lblFecha.TabIndex = 7;
            this.lblFecha.Text = "Fecha";
            // 
            // UCRepLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblLista);
            this.Controls.Add(this.rjbtnEscuchar);
            this.Name = "UCRepLista";
            this.Size = new System.Drawing.Size(174, 37);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RJControls.RJButton rjbtnEscuchar;
        private System.Windows.Forms.Label lblLista;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblFecha;
    }
}
