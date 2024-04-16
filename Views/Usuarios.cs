using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xeon.Views;
using Xeon.Design;

namespace Xeon
{
    public partial class Usuarios : Form, IVUsuarios
    {
        //Fields
        private string message;
        private bool isSuccessful;
        private bool isEdit;

        public Usuarios()
        {
            InitializeComponent();
        }

        private void AssociateAndRaiseViewEvents()
        {
            cboIDPerfil.Click += delegate
            {
                ForaignEvent?.Invoke(this.cboIDPerfil, EventArgs.Empty);
            };
            cboEstado.Click += delegate
            {
                ForaignEvent?.Invoke(this.cboEstado, EventArgs.Empty);
            };
            //Search
            btnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            txtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    SearchEvent?.Invoke(this, EventArgs.Empty);
            };
            //Add new
            btnAdd.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                tabCtrl.TabPages.Remove(userList);
                tabCtrl.TabPages.Add(userDetail);
                userDetail.Text = "Agregar";
            };
            //Edit
            btnEdit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabCtrl.TabPages.Remove(userList);
                tabCtrl.TabPages.Add(userDetail);
                userDetail.Text = "Editar";
            };
            //Save changes
            btnSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessful)
                {
                    tabCtrl.TabPages.Remove(userDetail);
                    tabCtrl.TabPages.Add(userList);
                }
                MessageBox.Show(Message);
            };
            //Cancel
            btnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabCtrl.TabPages.Remove(userDetail);
                tabCtrl.TabPages.Add(userList);
            };
            //Delete
            btnDelete.Click += delegate
            {
                var result = MessageBox.Show("Are you sure you want to delete the selected user?", "Warning",
                      MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };
        }

        public string IDUsuario {
            get { return txtIDUsuario.Text; }
            set { txtIDUsuario.Text = value; }
        }
        public string IDPerfil {
            get { return cboIDPerfil.Text; }
            set { cboIDPerfil.Text = value; }
        }
        public string apellidoPaterno {
            get { return txtapellidoPaterno.Text; }
            set { txtapellidoPaterno.Text = value; }
        }
        public string apellidoMaterno {
            get { return txtapellidoMaterno.Text; }
            set { txtapellidoMaterno.Text = value; }
        }
        public string Nombre {
            get { return txtNombre.Text; }
            set { txtNombre.Text = value; }
        }
        public string Apodo{
            get { return txtApodo.Text; }
            set { txtApodo.Text = value; }
        }
        public string correoElectronico {
            get { return txtcorreoElectronico.Text; }
            set { txtcorreoElectronico.Text = value; }
        }
        public string Contraseña {
            get { return txtContraseña.Text; }
            set { txtContraseña.Text = value; }
        }
        public string Nacimiento{
            get { return dateNacimiento.Text; }
            set { dateNacimiento.Text = value; }
        }
        public string Estado {
            get { return cboEstado.Text; }
            set { cboEstado.Text = value; }
        }
        public string fechaRegistro { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }
        public string SearchValue {
            get { return txtSearch.Text; }
            set { txtSearch.Text = value; }
        }
        public bool IsEdit {
            get { return isEdit; }
            set { isEdit = value; }
        }
        public bool IsSuccessful {
            get { return isSuccessful; }
            set { isSuccessful = value; }
        }
        public string Message {
            get { return message; }
            set { message = value; }
        }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;
        public event EventHandler ForaignEvent;

        public void SetUserListBindingSource(BindingSource usuariosList)
        {
            dataGridView.DataSource = usuariosList;
        }

        // Single pattern
        private static Usuarios instance;
        public static Usuarios GetInstance(Form parentContainer) 
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new Usuarios();
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else 
            {
                if (instance.WindowState == FormWindowState.Minimized)
                {
                    instance.WindowState = FormWindowState.Normal;
                }
                instance.BringToFront();
            }
            return instance;
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            AssociateAndRaiseViewEvents();
            //btnClose.Click += delegate { this.Close(); };
            AppearanceManager.tablaClaro(tabCtrl);
            // Aplicar ToolBox a la página de pestañas inicialmente seleccionada
            tabCtrl.TabPages.Remove(userDetail);
            // Asignar evento SelectedIndexChanged
            //tabCtrl.SelectedIndexChanged += new EventHandler(tabCtrl_SelectedIndexChanged);
        }
    }
}
