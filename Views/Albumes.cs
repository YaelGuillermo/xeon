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
    public partial class Albumes : Form, IVAlbum
    {
        private string message;
        private bool isSuccessful;
        private bool isEdit;

        public Albumes()
        {
            InitializeComponent();
        }

        private void AssociateAndRaiseViewEvents()
        {
            cboEstado.Click += delegate
            {
                cboEstado.Items.Clear();
                cboEstado.Items.Add(0);
                cboEstado.Items.Add(1);
            };
            btnImage.Click += delegate
            {
                ImageEvent?.Invoke(picImagen, EventArgs.Empty);
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
                var result = MessageBox.Show("Are you sure you want to delete the selected Artist?", "Warning",
                      MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };
        }

        public string IDAlbum
        {
            get { return txtIDAlbum.Text; }
            set { txtIDAlbum.Text = value; }
        }
        public string Titulo
        {
            get { return txtTitulo.Text; }
            set { txtTitulo.Text = value; }
        }
        public string fechaLanzamiento
        {
            get { return datefechaLanzamiento.Text; }
            set { datefechaLanzamiento.Text = value; }
        }
        public byte[] Imagen
        {
            get { return ConvertirImagen(); }
            set { picImagen.Image = value != null ? Image.FromStream(new System.IO.MemoryStream(value)) : null; }
        }
        public string Estado
        {
            get { return cboEstado.Text; }
            set { cboEstado.Text = value; }
        }

        private Image ObtenerImagen()
        {
            return picImagen.Image;
        }

        private byte[] ConvertirImagen()
        {
            var imagen = ObtenerImagen();
            if (imagen == null) return null;

            using (var ms = new System.IO.MemoryStream())
            {
                imagen.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
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
        public event EventHandler ImageEvent;

        public void SetAlbumListBindingSource(BindingSource AlbumesList)
        {
            dataGridView.DataSource = AlbumesList;
        }

        // Single pattern
        private static Albumes instance;
        public static Albumes GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new Albumes();
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

        private void Albumes_Load(object sender, EventArgs e)
        {
            AssociateAndRaiseViewEvents();
            AppearanceManager.tablaClaro(tabCtrl);
            tabCtrl.TabPages.Remove(tableDetail);
        }
    }
}

