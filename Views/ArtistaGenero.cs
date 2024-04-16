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
    public partial class ArtistaGenero : Form, IVArtistaGenero
    {
        //Fields
        private string message;
        private bool isSuccessful;
        private bool isEdit;

        public ArtistaGenero()
        {
            InitializeComponent();
        }

        private void AssociateAndRaiseViewEvents()
        {
            cboIDArtista.Click += delegate
            {
                ForaignEvent?.Invoke(this.cboIDArtista, EventArgs.Empty);
            };
            cboIDGenero.Click += delegate
            {
                ForaignEvent?.Invoke(this.cboIDGenero, EventArgs.Empty);
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
        public string IDArtistaGenero
        {
            get { return txtIDArtistaGenero.Text; }
            set { txtIDArtistaGenero.Text = value; }
        }
        public string IDArtista
        {
            get { return cboIDArtista.Text; }
            set { cboIDArtista.Text = value; }
        }
        public string IDGenero
        {
            get { return cboIDGenero.Text; }
            set { cboIDGenero.Text = value; }
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

        public void SetArtistGenreListBindingSource(BindingSource ArtistaGeneroList)
        {
            dataGridView.DataSource = ArtistaGeneroList;
        }

        // Single pattern
        private static ArtistaGenero instance;
        public static ArtistaGenero GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ArtistaGenero();
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

        private void ArtistaGenero_Load(object sender, EventArgs e)
        {
            AssociateAndRaiseViewEvents();
            AppearanceManager.tablaClaro(tabCtrl);
            tabCtrl.TabPages.Remove(tableDetail);
        }
    }

}
