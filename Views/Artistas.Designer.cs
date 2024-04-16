
namespace Xeon.Views
{
    partial class Artistas
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
            this.tableDetail = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.txtIDArtista = new System.Windows.Forms.TextBox();
            this.txtApodo = new System.Windows.Forms.TextBox();
            this.txtapellidoPaterno = new System.Windows.Forms.TextBox();
            this.txtapellidoMaterno = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.dateNacimiento = new System.Windows.Forms.DateTimePicker();
            this.cboNacionalidad = new CustomControls.RJControls.RJComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableList = new System.Windows.Forms.TabPage();
            this.tabLayData = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.tabLaySearch = new System.Windows.Forms.TableLayoutPanel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.tabLayBotones = new System.Windows.Forms.TableLayoutPanel();
            this.picImagen = new System.Windows.Forms.PictureBox();
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.btnImage = new FontAwesome.Sharp.IconButton();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.btnData = new FontAwesome.Sharp.IconButton();
            this.btnEdit = new FontAwesome.Sharp.IconButton();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.tabCtrl.SuspendLayout();
            this.tableDetail.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableList.SuspendLayout();
            this.tabLayData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.tabLaySearch.SuspendLayout();
            this.tabLayBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // tabCtrl
            // 
            this.tabCtrl.Controls.Add(this.tableDetail);
            this.tabCtrl.Controls.Add(this.tableList);
            this.tabCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCtrl.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCtrl.Location = new System.Drawing.Point(0, 0);
            this.tabCtrl.Name = "tabCtrl";
            this.tabCtrl.SelectedIndex = 0;
            this.tabCtrl.Size = new System.Drawing.Size(556, 389);
            this.tabCtrl.TabIndex = 3;
            // 
            // tableDetail
            // 
            this.tableDetail.Controls.Add(this.tableLayoutPanel2);
            this.tableDetail.Controls.Add(this.tableLayoutPanel1);
            this.tableDetail.Location = new System.Drawing.Point(4, 29);
            this.tableDetail.Name = "tableDetail";
            this.tableDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tableDetail.Size = new System.Drawing.Size(548, 356);
            this.tableDetail.TabIndex = 0;
            this.tableDetail.Text = "Insertar";
            this.tableDetail.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.cboEstado, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.txtIDArtista, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtApodo, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.picImagen, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtapellidoPaterno, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtapellidoMaterno, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtNombre, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.dateNacimiento, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.cboNacionalidad, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(444, 350);
            this.tableLayoutPanel2.TabIndex = 23;
            // 
            // cboEstado
            // 
            this.cboEstado.AutoCompleteCustomSource.AddRange(new string[] {
            "0",
            "1"});
            this.cboEstado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(3, 283);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(216, 28);
            this.cboEstado.TabIndex = 21;
            this.cboEstado.Tag = "Estado";
            this.cboEstado.Text = "Estado";
            // 
            // txtIDArtista
            // 
            this.txtIDArtista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtIDArtista.Enabled = false;
            this.txtIDArtista.Location = new System.Drawing.Point(3, 3);
            this.txtIDArtista.Name = "txtIDArtista";
            this.txtIDArtista.Size = new System.Drawing.Size(216, 27);
            this.txtIDArtista.TabIndex = 7;
            this.txtIDArtista.Tag = "";
            this.txtIDArtista.Text = "1";
            // 
            // txtApodo
            // 
            this.txtApodo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtApodo.Location = new System.Drawing.Point(3, 143);
            this.txtApodo.Name = "txtApodo";
            this.txtApodo.Size = new System.Drawing.Size(216, 27);
            this.txtApodo.TabIndex = 12;
            this.txtApodo.Tag = "Apodo";
            this.txtApodo.Text = "Apodo";
            // 
            // txtapellidoPaterno
            // 
            this.txtapellidoPaterno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtapellidoPaterno.Location = new System.Drawing.Point(225, 3);
            this.txtapellidoPaterno.Name = "txtapellidoPaterno";
            this.txtapellidoPaterno.Size = new System.Drawing.Size(216, 27);
            this.txtapellidoPaterno.TabIndex = 9;
            this.txtapellidoPaterno.Tag = "Apellido Paterno";
            this.txtapellidoPaterno.Text = "Apellido Paterno";
            // 
            // txtapellidoMaterno
            // 
            this.txtapellidoMaterno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtapellidoMaterno.Location = new System.Drawing.Point(3, 73);
            this.txtapellidoMaterno.Name = "txtapellidoMaterno";
            this.txtapellidoMaterno.Size = new System.Drawing.Size(216, 27);
            this.txtapellidoMaterno.TabIndex = 10;
            this.txtapellidoMaterno.Tag = "Apellido Materno";
            this.txtapellidoMaterno.Text = "Apellido Materno";
            // 
            // txtNombre
            // 
            this.txtNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNombre.Location = new System.Drawing.Point(225, 73);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(216, 27);
            this.txtNombre.TabIndex = 11;
            this.txtNombre.Tag = "Nombre";
            this.txtNombre.Text = "Nombre";
            // 
            // dateNacimiento
            // 
            this.dateNacimiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNacimiento.Location = new System.Drawing.Point(225, 143);
            this.dateNacimiento.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.dateNacimiento.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.dateNacimiento.Name = "dateNacimiento";
            this.dateNacimiento.Size = new System.Drawing.Size(216, 27);
            this.dateNacimiento.TabIndex = 19;
            this.dateNacimiento.Value = new System.DateTime(2023, 4, 12, 16, 42, 48, 0);
            this.dateNacimiento.ValueChanged += new System.EventHandler(this.dateNacimiento_ValueChanged);
            // 
            // cboNacionalidad
            // 
            this.cboNacionalidad.AutoCompleteCustomSource.AddRange(new string[] {
            "Afganistán",
            "Alemania",
            "Arabia Saudita",
            "Argentina",
            "Australia",
            "Austria",
            "Bangladés",
            "Bélgica",
            "Bolivia",
            "Brasil",
            "Camboya",
            "Canadá",
            "Chile",
            "China",
            "Colombia",
            "Corea del Norte",
            "Corea del Sur",
            "Costa Rica",
            "Cuba",
            "Dinamarca",
            "Ecuador",
            "Egipto",
            "El Salvador",
            "Emiratos Árabes Unidos",
            "España",
            "Estados Unidos",
            "Filipinas",
            "Finlandia",
            "Francia",
            "Grecia",
            "Guatemala",
            "Honduras",
            "Hungría",
            "India",
            "Indonesia",
            "Irak",
            "Irán",
            "Irlanda",
            "Islandia",
            "Israel",
            "Italia",
            "Jamaica",
            "Japón",
            "Jordania",
            "Kazajistán",
            "Kenia",
            "Kirguistán",
            "Kuwait",
            "Laos",
            "Líbano",
            "Malasia",
            "México",
            "Mongolia",
            "Marruecos",
            "Myanmar (Birmania)",
            "Nepal",
            "Nicaragua",
            "Nigeria",
            "Noruega",
            "Nueva Zelanda",
            "Omán",
            "Países Bajos",
            "Pakistán",
            "Panamá",
            "Paraguay",
            "Perú",
            "Polonia",
            "Portugal",
            "Puerto Rico",
            "Qatar",
            "Reino Unido",
            "República Checa",
            "República Dominicana",
            "Rumania",
            "Rusia",
            "Senegal",
            "Singapur",
            "Siria",
            "Sudáfrica",
            "Suecia",
            "Suiza",
            "Tailandia",
            "Taiwán",
            "Tanzania",
            "Turquía",
            "Ucrania",
            "Uganda",
            "Uruguay",
            "Uzbekistán",
            "Venezuela",
            "Vietnam",
            "Yemen",
            "Resto del mundo"});
            this.cboNacionalidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboNacionalidad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cboNacionalidad.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboNacionalidad.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cboNacionalidad.BorderSize = 1;
            this.cboNacionalidad.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboNacionalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboNacionalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cboNacionalidad.ForeColor = System.Drawing.Color.DimGray;
            this.cboNacionalidad.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cboNacionalidad.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboNacionalidad.ListTextColor = System.Drawing.Color.DimGray;
            this.cboNacionalidad.Location = new System.Drawing.Point(3, 213);
            this.cboNacionalidad.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboNacionalidad.Name = "cboNacionalidad";
            this.cboNacionalidad.Padding = new System.Windows.Forms.Padding(1);
            this.cboNacionalidad.Size = new System.Drawing.Size(216, 30);
            this.cboNacionalidad.TabIndex = 23;
            this.cboNacionalidad.Tag = "Nacionalidad";
            this.cboNacionalidad.Texts = "Nacionalidad";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSave, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnImage, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(447, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(98, 350);
            this.tableLayoutPanel1.TabIndex = 22;
            // 
            // tableList
            // 
            this.tableList.BackColor = System.Drawing.Color.Transparent;
            this.tableList.Controls.Add(this.tabLayData);
            this.tableList.Controls.Add(this.tabLaySearch);
            this.tableList.Controls.Add(this.tabLayBotones);
            this.tableList.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableList.ForeColor = System.Drawing.Color.Transparent;
            this.tableList.Location = new System.Drawing.Point(4, 29);
            this.tableList.Name = "tableList";
            this.tableList.Padding = new System.Windows.Forms.Padding(3);
            this.tableList.Size = new System.Drawing.Size(548, 356);
            this.tableList.TabIndex = 1;
            this.tableList.Text = "Base de datos";
            // 
            // tabLayData
            // 
            this.tabLayData.BackColor = System.Drawing.Color.Transparent;
            this.tabLayData.ColumnCount = 1;
            this.tabLayData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tabLayData.Controls.Add(this.dataGridView, 0, 0);
            this.tabLayData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabLayData.ForeColor = System.Drawing.Color.Transparent;
            this.tabLayData.Location = new System.Drawing.Point(3, 42);
            this.tabLayData.Name = "tabLayData";
            this.tabLayData.RowCount = 1;
            this.tabLayData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tabLayData.Size = new System.Drawing.Size(444, 311);
            this.tabLayData.TabIndex = 23;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(3, 3);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(438, 305);
            this.dataGridView.TabIndex = 1;
            // 
            // tabLaySearch
            // 
            this.tabLaySearch.BackColor = System.Drawing.Color.Transparent;
            this.tabLaySearch.ColumnCount = 2;
            this.tabLaySearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81F));
            this.tabLaySearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19F));
            this.tabLaySearch.Controls.Add(this.txtSearch, 0, 0);
            this.tabLaySearch.Controls.Add(this.btnSearch, 1, 0);
            this.tabLaySearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabLaySearch.ForeColor = System.Drawing.Color.Transparent;
            this.tabLaySearch.Location = new System.Drawing.Point(3, 3);
            this.tabLaySearch.Name = "tabLaySearch";
            this.tabLaySearch.RowCount = 1;
            this.tabLaySearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tabLaySearch.Size = new System.Drawing.Size(444, 39);
            this.tabLaySearch.TabIndex = 22;
            // 
            // txtSearch
            // 
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtSearch.Location = new System.Drawing.Point(3, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(353, 29);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.Tag = "";
            this.txtSearch.Text = "Search";
            // 
            // tabLayBotones
            // 
            this.tabLayBotones.BackColor = System.Drawing.Color.Transparent;
            this.tabLayBotones.ColumnCount = 1;
            this.tabLayBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tabLayBotones.Controls.Add(this.btnAdd, 0, 0);
            this.tabLayBotones.Controls.Add(this.btnData, 0, 3);
            this.tabLayBotones.Controls.Add(this.btnEdit, 0, 1);
            this.tabLayBotones.Controls.Add(this.btnDelete, 0, 2);
            this.tabLayBotones.Dock = System.Windows.Forms.DockStyle.Right;
            this.tabLayBotones.ForeColor = System.Drawing.Color.Transparent;
            this.tabLayBotones.Location = new System.Drawing.Point(447, 3);
            this.tabLayBotones.Name = "tabLayBotones";
            this.tabLayBotones.RowCount = 4;
            this.tabLayBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tabLayBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tabLayBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tabLayBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tabLayBotones.Size = new System.Drawing.Size(98, 350);
            this.tabLayBotones.TabIndex = 21;
            // 
            // picImagen
            // 
            this.picImagen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picImagen.Location = new System.Drawing.Point(225, 213);
            this.picImagen.Name = "picImagen";
            this.picImagen.Size = new System.Drawing.Size(216, 64);
            this.picImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImagen.TabIndex = 13;
            this.picImagen.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            this.btnCancel.IconColor = System.Drawing.Color.Black;
            this.btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancel.Location = new System.Drawing.Point(3, 90);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 81);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnSave.IconColor = System.Drawing.Color.Black;
            this.btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSave.Location = new System.Drawing.Point(3, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 81);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnImage
            // 
            this.btnImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnImage.IconChar = FontAwesome.Sharp.IconChar.Image;
            this.btnImage.IconColor = System.Drawing.Color.Black;
            this.btnImage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnImage.Location = new System.Drawing.Point(3, 177);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(92, 81);
            this.btnImage.TabIndex = 16;
            this.btnImage.Text = "Foto";
            this.btnImage.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnSearch.IconColor = System.Drawing.Color.Black;
            this.btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearch.IconSize = 24;
            this.btnSearch.Location = new System.Drawing.Point(362, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(79, 33);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.btnAdd.IconColor = System.Drawing.Color.Black;
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdd.Location = new System.Drawing.Point(3, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 81);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnData
            // 
            this.btnData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnData.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.btnData.IconColor = System.Drawing.Color.Black;
            this.btnData.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnData.Location = new System.Drawing.Point(3, 264);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(92, 83);
            this.btnData.TabIndex = 20;
            this.btnData.Text = "Tablas";
            this.btnData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnData.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEdit.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.btnEdit.IconColor = System.Drawing.Color.Black;
            this.btnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEdit.Location = new System.Drawing.Point(3, 90);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(92, 81);
            this.btnEdit.TabIndex = 17;
            this.btnEdit.Text = "Editar";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.SquareMinus;
            this.btnDelete.IconColor = System.Drawing.Color.Black;
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelete.Location = new System.Drawing.Point(3, 177);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 81);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Borrar";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // Artistas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 389);
            this.Controls.Add(this.tabCtrl);
            this.Name = "Artistas";
            this.Text = "Artistas";
            this.Load += new System.EventHandler(this.Artistas_Load);
            this.tabCtrl.ResumeLayout(false);
            this.tableDetail.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableList.ResumeLayout(false);
            this.tabLayData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.tabLaySearch.ResumeLayout(false);
            this.tabLaySearch.PerformLayout();
            this.tabLayBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCtrl;
        private System.Windows.Forms.TabPage tableDetail;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtIDArtista;
        private System.Windows.Forms.TextBox txtapellidoPaterno;
        private System.Windows.Forms.TextBox txtapellidoMaterno;
        private System.Windows.Forms.TextBox txtApodo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private FontAwesome.Sharp.IconButton btnCancel;
        private FontAwesome.Sharp.IconButton btnSave;
        private System.Windows.Forms.TabPage tableList;
        private System.Windows.Forms.TableLayoutPanel tabLayData;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TableLayoutPanel tabLaySearch;
        private System.Windows.Forms.TextBox txtSearch;
        private FontAwesome.Sharp.IconButton btnSearch;
        private System.Windows.Forms.TableLayoutPanel tabLayBotones;
        private FontAwesome.Sharp.IconButton btnAdd;
        private FontAwesome.Sharp.IconButton btnData;
        private FontAwesome.Sharp.IconButton btnEdit;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnImage;
        private System.Windows.Forms.PictureBox picImagen;
        private System.Windows.Forms.DateTimePicker dateNacimiento;
        private System.Windows.Forms.ComboBox cboEstado;
        private CustomControls.RJControls.RJComboBox cboNacionalidad;
    }
}