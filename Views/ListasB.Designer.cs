
namespace Xeon.Views
{
    partial class ListasB
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitulo = new CustomControls.RJControls.RJTextBox();
            this.btnEdit = new CustomControls.RJControls.RJButton();
            this.btnGuardar = new CustomControls.RJControls.RJButton();
            this.btnSalir = new CustomControls.RJControls.RJButton();
            this.txtDescripcion = new CustomControls.RJControls.RJTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.userEntry = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayAlbumes = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.rjDeshacer = new CustomControls.RJControls.RJButton();
            this.rjBorrar = new CustomControls.RJControls.RJButton();
            this.rjRegresar = new CustomControls.RJControls.RJButton();
            this.rjSalir = new CustomControls.RJControls.RJButton();
            this.rjReiniciar = new CustomControls.RJControls.RJButton();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.cboLista = new CustomControls.RJControls.RJComboBox();
            this.rjFiltro = new CustomControls.RJControls.RJTextBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabCtrl.SuspendLayout();
            this.userDetail.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.userEntry.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
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
            this.tabCtrl.Size = new System.Drawing.Size(556, 389);
            this.tabCtrl.TabIndex = 4;
            // 
            // userDetail
            // 
            this.userDetail.Controls.Add(this.tableLayoutPanel2);
            this.userDetail.Location = new System.Drawing.Point(4, 29);
            this.userDetail.Name = "userDetail";
            this.userDetail.Padding = new System.Windows.Forms.Padding(3);
            this.userDetail.Size = new System.Drawing.Size(548, 356);
            this.userDetail.TabIndex = 0;
            this.userDetail.Text = "Creación";
            this.userDetail.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtTitulo, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnEdit, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.btnGuardar, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.btnSalir, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.txtDescripcion, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(542, 350);
            this.tableLayoutPanel2.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(138, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Ponle un nombre";
            // 
            // txtTitulo
            // 
            this.txtTitulo.BackColor = System.Drawing.SystemColors.Window;
            this.txtTitulo.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtTitulo.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTitulo.BorderRadius = 0;
            this.txtTitulo.BorderSize = 2;
            this.txtTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtTitulo.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.ForeColor = System.Drawing.Color.DimGray;
            this.txtTitulo.Location = new System.Drawing.Point(139, 56);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitulo.Multiline = false;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Padding = new System.Windows.Forms.Padding(7);
            this.txtTitulo.PasswordChar = false;
            this.txtTitulo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTitulo.PlaceholderText = "";
            this.txtTitulo.Size = new System.Drawing.Size(263, 35);
            this.txtTitulo.TabIndex = 23;
            this.txtTitulo.Tag = "Nombre de la lista";
            this.txtTitulo.Texts = "Nombre de la lista";
            this.txtTitulo.UnderlinedStyle = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnEdit.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnEdit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEdit.BorderRadius = 20;
            this.btnEdit.BorderSize = 0;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(3, 282);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(129, 64);
            this.btnEdit.TabIndex = 36;
            this.btnEdit.Text = "¿Ya creaste una? Edítala";
            this.btnEdit.TextColor = System.Drawing.Color.White;
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnGuardar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnGuardar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnGuardar.BorderRadius = 20;
            this.btnGuardar.BorderSize = 0;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(138, 282);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(265, 64);
            this.btnGuardar.TabIndex = 34;
            this.btnGuardar.Text = "Crear";
            this.btnGuardar.TextColor = System.Drawing.Color.White;
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSalir.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSalir.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSalir.BorderRadius = 14;
            this.btnSalir.BorderSize = 0;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(409, 282);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(130, 64);
            this.btnSalir.TabIndex = 35;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextColor = System.Drawing.Color.White;
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.SystemColors.Window;
            this.txtDescripcion.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtDescripcion.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtDescripcion.BorderRadius = 0;
            this.txtDescripcion.BorderSize = 2;
            this.txtDescripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.Color.DimGray;
            this.txtDescripcion.Location = new System.Drawing.Point(139, 178);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Padding = new System.Windows.Forms.Padding(7);
            this.txtDescripcion.PasswordChar = false;
            this.txtDescripcion.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDescripcion.PlaceholderText = "";
            this.txtDescripcion.Size = new System.Drawing.Size(263, 97);
            this.txtDescripcion.TabIndex = 37;
            this.txtDescripcion.Tag = "Agrega una descripción";
            this.txtDescripcion.Texts = "Agrega una descripción";
            this.txtDescripcion.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Location = new System.Drawing.Point(138, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "Descripción";
            // 
            // userEntry
            // 
            this.userEntry.Controls.Add(this.tableLayoutPanel1);
            this.userEntry.Location = new System.Drawing.Point(4, 29);
            this.userEntry.Name = "userEntry";
            this.userEntry.Padding = new System.Windows.Forms.Padding(3);
            this.userEntry.Size = new System.Drawing.Size(548, 356);
            this.userEntry.TabIndex = 1;
            this.userEntry.Text = "Agregar";
            this.userEntry.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayAlbumes, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(542, 350);
            this.tableLayoutPanel1.TabIndex = 24;
            // 
            // flowLayAlbumes
            // 
            this.flowLayAlbumes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayAlbumes.Location = new System.Drawing.Point(46, 59);
            this.flowLayAlbumes.Name = "flowLayAlbumes";
            this.flowLayAlbumes.Size = new System.Drawing.Size(449, 165);
            this.flowLayAlbumes.TabIndex = 39;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(46, 230);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(449, 81);
            this.dataGridView.TabIndex = 40;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Controls.Add(this.rjDeshacer, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.rjBorrar, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.rjRegresar, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.rjSalir, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.rjReiniciar, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(46, 317);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(449, 30);
            this.tableLayoutPanel3.TabIndex = 41;
            // 
            // rjDeshacer
            // 
            this.rjDeshacer.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjDeshacer.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjDeshacer.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjDeshacer.BorderRadius = 20;
            this.rjDeshacer.BorderSize = 0;
            this.rjDeshacer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rjDeshacer.FlatAppearance.BorderSize = 0;
            this.rjDeshacer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjDeshacer.ForeColor = System.Drawing.Color.White;
            this.rjDeshacer.Location = new System.Drawing.Point(181, 3);
            this.rjDeshacer.Name = "rjDeshacer";
            this.rjDeshacer.Size = new System.Drawing.Size(83, 24);
            this.rjDeshacer.TabIndex = 44;
            this.rjDeshacer.Text = "Deshacer";
            this.rjDeshacer.TextColor = System.Drawing.Color.White;
            this.rjDeshacer.UseVisualStyleBackColor = false;
            // 
            // rjBorrar
            // 
            this.rjBorrar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjBorrar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjBorrar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjBorrar.BorderRadius = 20;
            this.rjBorrar.BorderSize = 0;
            this.rjBorrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rjBorrar.FlatAppearance.BorderSize = 0;
            this.rjBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjBorrar.ForeColor = System.Drawing.Color.White;
            this.rjBorrar.Location = new System.Drawing.Point(270, 3);
            this.rjBorrar.Name = "rjBorrar";
            this.rjBorrar.Size = new System.Drawing.Size(83, 24);
            this.rjBorrar.TabIndex = 38;
            this.rjBorrar.Text = "Borrar";
            this.rjBorrar.TextColor = System.Drawing.Color.White;
            this.rjBorrar.UseVisualStyleBackColor = false;
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
            this.rjRegresar.Size = new System.Drawing.Size(83, 24);
            this.rjRegresar.TabIndex = 37;
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
            this.rjSalir.Location = new System.Drawing.Point(359, 3);
            this.rjSalir.Name = "rjSalir";
            this.rjSalir.Size = new System.Drawing.Size(87, 24);
            this.rjSalir.TabIndex = 35;
            this.rjSalir.Text = "Salir";
            this.rjSalir.TextColor = System.Drawing.Color.White;
            this.rjSalir.UseVisualStyleBackColor = false;
            // 
            // rjReiniciar
            // 
            this.rjReiniciar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjReiniciar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjReiniciar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjReiniciar.BorderRadius = 20;
            this.rjReiniciar.BorderSize = 0;
            this.rjReiniciar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rjReiniciar.FlatAppearance.BorderSize = 0;
            this.rjReiniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjReiniciar.ForeColor = System.Drawing.Color.White;
            this.rjReiniciar.Location = new System.Drawing.Point(92, 3);
            this.rjReiniciar.Name = "rjReiniciar";
            this.rjReiniciar.Size = new System.Drawing.Size(83, 24);
            this.rjReiniciar.TabIndex = 34;
            this.rjReiniciar.Text = "Reiniciar";
            this.rjReiniciar.TextColor = System.Drawing.Color.White;
            this.rjReiniciar.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.cboLista, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.rjFiltro, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(46, 31);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(449, 22);
            this.tableLayoutPanel4.TabIndex = 42;
            // 
            // cboLista
            // 
            this.cboLista.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboLista.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cboLista.BorderSize = 1;
            this.cboLista.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboLista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cboLista.ForeColor = System.Drawing.Color.DimGray;
            this.cboLista.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cboLista.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboLista.ListTextColor = System.Drawing.Color.DimGray;
            this.cboLista.Location = new System.Drawing.Point(3, 3);
            this.cboLista.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboLista.Name = "cboLista";
            this.cboLista.Padding = new System.Windows.Forms.Padding(1);
            this.cboLista.Size = new System.Drawing.Size(218, 30);
            this.cboLista.TabIndex = 38;
            this.cboLista.Tag = "Nombre de la lista";
            this.cboLista.Texts = "Nombre de la lista";
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
            this.rjFiltro.Location = new System.Drawing.Point(228, 4);
            this.rjFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.rjFiltro.Multiline = false;
            this.rjFiltro.Name = "rjFiltro";
            this.rjFiltro.Padding = new System.Windows.Forms.Padding(7);
            this.rjFiltro.PasswordChar = false;
            this.rjFiltro.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjFiltro.PlaceholderText = "";
            this.rjFiltro.Size = new System.Drawing.Size(217, 31);
            this.rjFiltro.TabIndex = 39;
            this.rjFiltro.Tag = "Canción / Artista / Álbum";
            this.rjFiltro.Texts = "Canción / Artista / Álbum";
            this.rjFiltro.UnderlinedStyle = false;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(46, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(449, 22);
            this.tableLayoutPanel5.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Location = new System.Drawing.Point(227, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "Busca tu canción";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label10.Location = new System.Drawing.Point(3, 2);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(218, 20);
            this.label10.TabIndex = 36;
            this.label10.Text = "Escoge tu lista";
            // 
            // ListasB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 389);
            this.Controls.Add(this.tabCtrl);
            this.Name = "ListasB";
            this.Text = "ListasB";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            this.tabCtrl.ResumeLayout(false);
            this.userDetail.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.userEntry.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCtrl;
        private System.Windows.Forms.TabPage userDetail;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private CustomControls.RJControls.RJButton btnEdit;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJTextBox txtTitulo;
        private CustomControls.RJControls.RJButton btnGuardar;
        private CustomControls.RJControls.RJButton btnSalir;
        private System.Windows.Forms.TabPage userEntry;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private CustomControls.RJControls.RJButton rjRegresar;
        private CustomControls.RJControls.RJButton rjReiniciar;
        private CustomControls.RJControls.RJButton rjSalir;
        private System.Windows.Forms.Label label10;
        private CustomControls.RJControls.RJTextBox txtDescripcion;
        private System.Windows.Forms.Label label2;
        private CustomControls.RJControls.RJComboBox cboLista;
        private System.Windows.Forms.FlowLayoutPanel flowLayAlbumes;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private CustomControls.RJControls.RJButton rjBorrar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private CustomControls.RJControls.RJTextBox rjFiltro;
        private System.Windows.Forms.Label label3;
        private CustomControls.RJControls.RJButton rjDeshacer;
    }
}