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
    public partial class AlbumCancion : Form, IVAlbumCancion
    {
        //Fields
        private string message;
        private bool isSuccessful;
        private bool isEdit;

        public AlbumCancion()
        {
            InitializeComponent();
        }

        private void AssociateAndRaiseViewEvents()
        {
            cboIDAlbum.Click += delegate
            {
                ForaignEvent?.Invoke(this.cboIDAlbum, EventArgs.Empty);
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
        public string IDAlbumCancion
        {
            get { return txtIDAlbumCancion.Text; }
            set { txtIDAlbumCancion.Text = value; }
        }
        public string IDAlbum
        {
            get { return cboIDAlbum.Text; }
            set { cboIDAlbum.Text = value; }
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

        public void SetArtistGenreListBindingSource(BindingSource AlbumCancionList)
        {
            dataGridView.DataSource = AlbumCancionList;
        }

        // Single pattern
        private static AlbumCancion instance;
        public static AlbumCancion GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new AlbumCancion();
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

        private void AlbumCancion_Load(object sender, EventArgs e)
        {
            AssociateAndRaiseViewEvents();
            AppearanceManager.tablaClaro(tabCtrl);
            tabCtrl.TabPages.Remove(tableDetail);
        }
    }
}
