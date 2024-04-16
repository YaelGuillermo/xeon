
namespace Xeon.Views
{
    partial class Perfiles
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
            this.tabLayFinales = new System.Windows.Forms.TableLayoutPanel();
            this.txtIDPerfil = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.tabLayEdicion = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.userList = new System.Windows.Forms.TabPage();
            this.tabLayData = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.tabLaySearch = new System.Windows.Forms.TableLayoutPanel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.tabLayBotones = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.btnData = new FontAwesome.Sharp.IconButton();
            this.btnEdit = new FontAwesome.Sharp.IconButton();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.tabCtrl.SuspendLayout();
            this.userDetail.SuspendLayout();
            this.tabLayFinales.SuspendLayout();
            this.tabLayEdicion.SuspendLayout();
            this.userList.SuspendLayout();
            this.tabLayData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.tabLaySearch.SuspendLayout();
            this.tabLayBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCtrl
            // 
            this.tabCtrl.Controls.Add(this.userDetail);
            this.tabCtrl.Controls.Add(this.userList);
            this.tabCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCtrl.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCtrl.Location = new System.Drawing.Point(0, 0);
            this.tabCtrl.Name = "tabCtrl";
            this.tabCtrl.SelectedIndex = 0;
            this.tabCtrl.Size = new System.Drawing.Size(556, 389);
            this.tabCtrl.TabIndex = 3;
            // 
            // userDetail
            // 
            this.userDetail.Controls.Add(this.tabLayFinales);
            this.userDetail.Controls.Add(this.tabLayEdicion);
            this.userDetail.Location = new System.Drawing.Point(4, 29);
            this.userDetail.Name = "userDetail";
            this.userDetail.Padding = new System.Windows.Forms.Padding(3);
            this.userDetail.Size = new System.Drawing.Size(548, 356);
            this.userDetail.TabIndex = 0;
            this.userDetail.Text = "Insertar";
            this.userDetail.UseVisualStyleBackColor = true;
            // 
            // tabLayFinales
            // 
            this.tabLayFinales.ColumnCount = 2;
            this.tabLayFinales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tabLayFinales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tabLayFinales.Controls.Add(this.txtIDPerfil, 0, 0);
            this.tabLayFinales.Controls.Add(this.txtNombre, 1, 0);
            this.tabLayFinales.Controls.Add(this.txtDescripcion, 0, 1);
            this.tabLayFinales.Controls.Add(this.cboEstado, 1, 1);
            this.tabLayFinales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabLayFinales.Location = new System.Drawing.Point(3, 3);
            this.tabLayFinales.Name = "tabLayFinales";
            this.tabLayFinales.RowCount = 4;
            this.tabLayFinales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tabLayFinales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tabLayFinales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tabLayFinales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tabLayFinales.Size = new System.Drawing.Size(444, 350);
            this.tabLayFinales.TabIndex = 23;
            // 
            // txtIDPerfil
            // 
            this.txtIDPerfil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtIDPerfil.Location = new System.Drawing.Point(3, 3);
            this.txtIDPerfil.Name = "txtIDPerfil";
            this.txtIDPerfil.Size = new System.Drawing.Size(216, 27);
            this.txtIDPerfil.TabIndex = 8;
            this.txtIDPerfil.Tag = "ID Perfil";
            this.txtIDPerfil.Text = "ID Perfil";
            // 
            // txtNombre
            // 
            this.txtNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNombre.Location = new System.Drawing.Point(225, 3);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(216, 27);
            this.txtNombre.TabIndex = 11;
            this.txtNombre.Tag = "Nombre";
            this.txtNombre.Text = "Nombre";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescripcion.Location = new System.Drawing.Point(3, 90);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(216, 27);
            this.txtDescripcion.TabIndex = 12;
            this.txtDescripcion.Tag = "Descripción";
            this.txtDescripcion.Text = "Descripción";
            // 
            // cboEstado
            // 
            this.cboEstado.AutoCompleteCustomSource.AddRange(new string[] {
            "0",
            "1"});
            this.cboEstado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cboEstado.Location = new System.Drawing.Point(225, 90);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(216, 28);
            this.cboEstado.TabIndex = 20;
            this.cboEstado.Tag = "Estado";
            this.cboEstado.Text = "Estado";
            // 
            // tabLayEdicion
            // 
            this.tabLayEdicion.ColumnCount = 1;
            this.tabLayEdicion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tabLayEdicion.Controls.Add(this.btnCancel, 0, 1);
            this.tabLayEdicion.Controls.Add(this.btnSave, 0, 0);
            this.tabLayEdicion.Dock = System.Windows.Forms.DockStyle.Right;
            this.tabLayEdicion.Location = new System.Drawing.Point(447, 3);
            this.tabLayEdicion.Name = "tabLayEdicion";
            this.tabLayEdicion.RowCount = 4;
            this.tabLayEdicion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tabLayEdicion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tabLayEdicion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tabLayEdicion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tabLayEdicion.Size = new System.Drawing.Size(98, 350);
            this.tabLayEdicion.TabIndex = 22;
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
            // userList
            // 
            this.userList.BackColor = System.Drawing.Color.Transparent;
            this.userList.Controls.Add(this.tabLayData);
            this.userList.Controls.Add(this.tabLaySearch);
            this.userList.Controls.Add(this.tabLayBotones);
            this.userList.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userList.ForeColor = System.Drawing.Color.Transparent;
            this.userList.Location = new System.Drawing.Point(4, 29);
            this.userList.Name = "userList";
            this.userList.Padding = new System.Windows.Forms.Padding(3);
            this.userList.Size = new System.Drawing.Size(548, 356);
            this.userList.TabIndex = 1;
            this.userList.Text = "Base de datos";
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
            // Perfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 389);
            this.Controls.Add(this.tabCtrl);
            this.Name = "Perfiles";
            this.Text = "Perfiles";
            this.Load += new System.EventHandler(this.Perfiles_Load);
            this.tabCtrl.ResumeLayout(false);
            this.userDetail.ResumeLayout(false);
            this.tabLayFinales.ResumeLayout(false);
            this.tabLayFinales.PerformLayout();
            this.tabLayEdicion.ResumeLayout(false);
            this.userList.ResumeLayout(false);
            this.tabLayData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.tabLaySearch.ResumeLayout(false);
            this.tabLaySearch.PerformLayout();
            this.tabLayBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCtrl;
        private System.Windows.Forms.TabPage userDetail;
        private System.Windows.Forms.TableLayoutPanel tabLayFinales;
        private System.Windows.Forms.TextBox txtIDPerfil;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TableLayoutPanel tabLayEdicion;
        private FontAwesome.Sharp.IconButton btnCancel;
        private FontAwesome.Sharp.IconButton btnSave;
        private System.Windows.Forms.TabPage userList;
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
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.ComboBox cboEstado;
    }
}