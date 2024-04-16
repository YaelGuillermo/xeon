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

namespace Xeon.Views
{
    public partial class Perfiles : Form, IVPerfiles
    {
        //Fields
        private string message;
        private bool isSuccessful;
        private bool isEdit;

        public Perfiles()
        {
            InitializeComponent();
        }

        private void ApplyToolBoxEvents(TabControl tabControl)
        {
            ToolBox TB = new ToolBox();
            foreach (TabPage page in tabControl.TabPages)
            {
                foreach (TableLayoutPanel tlp in page.Controls.OfType<TableLayoutPanel>())
                {
                    foreach (Control control in tlp.Controls)
                    {
                        if (control is TextBox)
                        {
                            control.Enter += new EventHandler(TB.textBox_Enter);
                            control.Leave += new EventHandler(TB.textBox_Leave);
                        }
                        else if (control is TabControl)
                        {
                            ApplyToolBoxEvents((TabControl)control);
                        }
                    }
                }
            }
        }

        private void AssociateAndRaiseViewEvents()
        {
            cboEstado.Click += delegate {
                cboEstado.Items.Clear();
                cboEstado.Items.Add(0);
                cboEstado.Items.Add(1);
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
                var result = MessageBox.Show("Are you sure you want to delete the selected profile?", "Warning",
                      MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };
        }

        public string IDPerfil
        {
            get { return txtIDPerfil.Text; }
            set { txtIDPerfil.Text = value; }
        }
        public string Nombre
        {
            get { return txtNombre.Text; }
            set { txtNombre.Text = value; }
        }
        public string Descripcion
        {
            get { return txtDescripcion.Text; }
            set { txtDescripcion.Text = value; }
        }
        public string Estado
        {
            get { return cboEstado.Text; }
            set { cboEstado.Text = value; }
        }
        public string SearchValue
        {
            get { return txtSearch.Text; }
            set { txtSearch.Text = value; }
        }
        public bool IsEdit
        {
            get { return isEdit; }
            set { isEdit = value; }
        }
        public bool IsSuccessful
        {
            get { return isSuccessful; }
            set { isSuccessful = value; }
        }
        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public void SetProfileListBindingSource(BindingSource perfilesList)
        {
            dataGridView.DataSource = perfilesList;
        }

        // Single pattern
        private static Perfiles instance;
        public static Perfiles GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new Perfiles();
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

        private void Perfiles_Load(object sender, EventArgs e)
        {
            AssociateAndRaiseViewEvents();
            AppearanceManager.tablaClaro(tabCtrl);
            tabCtrl.TabPages.Remove(userDetail);
        }
    }
}
