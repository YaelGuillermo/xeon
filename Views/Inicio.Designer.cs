
namespace Xeon.Views
{
    partial class Inicio
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
            this.tabLayInicio = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayAlbumes = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabLayInicio.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabLayInicio
            // 
            this.tabLayInicio.ColumnCount = 1;
            this.tabLayInicio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tabLayInicio.Controls.Add(this.flowLayAlbumes, 0, 1);
            this.tabLayInicio.Controls.Add(this.label1, 0, 0);
            this.tabLayInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabLayInicio.Location = new System.Drawing.Point(0, 0);
            this.tabLayInicio.Name = "tabLayInicio";
            this.tabLayInicio.RowCount = 2;
            this.tabLayInicio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tabLayInicio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tabLayInicio.Size = new System.Drawing.Size(556, 389);
            this.tabLayInicio.TabIndex = 0;
            // 
            // flowLayAlbumes
            // 
            this.flowLayAlbumes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayAlbumes.Location = new System.Drawing.Point(3, 41);
            this.flowLayAlbumes.Name = "flowLayAlbumes";
            this.flowLayAlbumes.Size = new System.Drawing.Size(550, 345);
            this.flowLayAlbumes.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(3, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(550, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hola";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 389);
            this.Controls.Add(this.tabLayInicio);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.tabLayInicio.ResumeLayout(false);
            this.tabLayInicio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tabLayInicio;
        private System.Windows.Forms.FlowLayoutPanel flowLayAlbumes;
        private System.Windows.Forms.Label label1;
    }
}