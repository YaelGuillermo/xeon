using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xeon.Design;

namespace Xeon.Views
{
    public partial class ListaCancion : Form, IVListaCancion
    {
        //Fields
        private string message;
        private bool isSuccessful;
        private bool isEdit;

        public ListaCancion()
        {
            InitializeComponent();
        }

        private void AssociateAndRaiseViewEvents()
        {
            cboIDLista.Click += delegate
            {
                ForaignEvent?.Invoke(this.cboIDLista, EventArgs.Empty);
            };
            cboIDCancion.Click += delegate
            {
                ForaignEvent?.Invoke(this.cboIDCancion, EventArgs.Empty);
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
                tabCtrl.TabPages.Remove(tableList);
                tabCtrl.TabPages.Add(tableDetail);
                tableDetail.Text = "Agregar";
            };
            //Edit
            btnEdit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabCtrl.TabPages.Remove(tableList);
                tabCtrl.TabPages.Add(tableDetail);
                tableDetail.Text = "Editar";
            };
            //Save changes
            btnSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessful)
                {
                    tabCtrl.TabPages.Remove(tableDetail);
                    tabCtrl.TabPages.Add(tableList);
                }
                MessageBox.Show(Message);
            };
            //Cancel
            btnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabCtrl.TabPages.Remove(tableDetail);
                tabCtrl.TabPages.Add(tableList);
            };
            //Delete
            btnDelete.Click += delegate
            {
                var result = MessageBox.Show("Are you sure you want to delete the selected c?", "Warning",
                      MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };
        }
        public string IDListaCancion
        {
            get { return txtIDListaCancion.Text; }
            set { txtIDListaCancion.Text = value; }
        }
        public string IDLista
        {
            get { return cboIDLista.Text; }
            set { cboIDLista.Text = value; }
        }
        public string IDCancion
        {
            get { return cboIDCancion.Text; }
            set { cboIDCancion.Text = value; }
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
        public event EventHandler ForaignEvent;

        public void SetArtistGenreListBindingSource(BindingSource ListaCancionList)
        {
            dataGridView.DataSource = ListaCancionList;
        }

        // Single pattern
        private static ListaCancion instance;
        public static ListaCancion GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ListaCancion();
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

        private void ListaCancion_Load(object sender, EventArgs e)
        {
            AssociateAndRaiseViewEvents();
            AppearanceManager.tablaClaro(tabCtrl);
            tabCtrl.TabPages.Remove(tableDetail);
        }
    }
}
