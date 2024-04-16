using CustomControls.RJControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xeon.Design;
using Xeon.Models;

namespace Xeon.Views
{
    public partial class ListasB : Form, IVListasB
    {
        //Fields
        private string message;
        private bool isSuccessful;
        private bool isEdit;

        private int id_cancion;
        private int id_album;
        private byte[] imagen;
        private string tit_album;
        private string tit_cancion;
        private string apodo;
        private string duracion;
        public int Id_cancion { get => id_cancion; set => id_cancion = value; }
        public int Id_album { get => id_album; set => id_album = value; }
        public byte[] Imagen { get => imagen; set => imagen = value; }
        public string Tit_album { get => tit_album; set => tit_album = value; }
        public string Tit_cancion { get => tit_cancion; set => tit_cancion = value; }
        public string Apodo { get => apodo; set => apodo = value; }
        public string Duracion { get => duracion; set => duracion = value; }

        private string connectionString = "Data Source=(local);Initial Catalog=XEON;Integrated Security=True";
        public ListasB()
        {
            InitializeComponent();
        }

        public int MostrarValorSeleccionado(RJComboBox comboBox)
        {
            if (comboBox.SelectedItem != null)
            {
                CListasB selectedItem = comboBox.SelectedItem as CListasB;
                int selectedValue = selectedItem.IDLista;
                return selectedValue;
            }
            return 0;
        }

        public void Insercion(int IDCancion) 
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                // Código completo del procedimiento almacenado
                //command.CommandText = "Insert into ListaCancion (IDLista, IDCancion, Orden) values" +
                //" (@IDLista, @IDCancion, @Orden)";
                command.CommandText = "InsertarListaCancion";
                command.CommandType = CommandType.StoredProcedure;
                // Parámetros del procedimiento almacenado
                command.Parameters.AddWithValue("@IDLista", Convert.ToInt16(GlobalVariables.IDLista));
                command.Parameters.AddWithValue("@IDCancion", Convert.ToInt16(IDCancion));
                //command.Parameters.AddWithValue("@Orden", 1);
                // Ejecutar el procedimiento almacenado
                command.ExecuteNonQuery();
                MessageBox.Show("Canción agregada a la lista. ");
                connection.Close();
            }
            LlenarTabla();
        }

        public void Eliminar() 
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "EliminarLista";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@IDLista", Convert.ToInt16(GlobalVariables.IDLista));
                command.ExecuteNonQuery();
                MessageBox.Show("Lista de reproducción eliminada. ");
                connection.Close();
            }
            LlenarTabla();
        }

        public void Deshecho() 
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DeshacerListaCancion";
                command.CommandType = CommandType.StoredProcedure;
                command.ExecuteNonQuery();
                MessageBox.Show("Última inserción eliminada. ");
                connection.Close();
            }
            LlenarTabla();
        }

        public void Reinicio()
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "ReiniciarListaCancion";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@IDLista", Convert.ToInt16(GlobalVariables.IDLista));
                command.ExecuteNonQuery();
                MessageBox.Show("Lista de reproducción reiniciada. ");
                connection.Close();
            }
            LlenarTabla();
        }

        private void LlenarTabla() 
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "MostrarListaReproduccion";
                command.CommandType = CommandType.StoredProcedure; 
                command.Parameters.Add("@IDLista", SqlDbType.Int).Value = GlobalVariables.IDLista;
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable playlistTable = new DataTable();
                adapter.Fill(playlistTable);
                dataGridView.DataSource = playlistTable;
                connection.Close();
            }
        }

        private void LlenarCanciones(FlowLayoutPanel flp, string filtro)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "EXEC ArrojarCancionInfo @Filtro";
                command.Parameters.AddWithValue("@Filtro", filtro); // Pasar el filtro como parámetro

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Id_cancion = Convert.ToInt32(reader[0]);
                    Id_album = Convert.ToInt32(reader[1]);
                    Tit_cancion = reader[2].ToString();
                    Tit_album = reader[3].ToString();
                    Apodo = reader[4].ToString();
                    Duracion = reader[5].ToString();
                    Imagen = ((byte[])reader[6]);
                    UCListasB uclb = new UCListasB();
                    uclb.IDCancion = Id_cancion;
                    uclb.IDAlbum = Id_album;
                    uclb.Titulo = Tit_cancion;
                    uclb.Album = Tit_album;
                    uclb.Artista = Apodo;
                    uclb.Duracion = Duracion + " min.";
                    MemoryStream ms = new MemoryStream(Imagen);
                    uclb.Imagen = Image.FromStream(ms);
                    flp.Controls.Add(uclb);
                }
                connection.Close();
                connection.Dispose();
            }
        }


        public event EventHandler SkillEvent;
        public event EventHandler FlowEvent;
        public void AssociateAndRaiseViewEvents()
        {

            FlowEvent?.Invoke(this.flowLayAlbumes, EventArgs.Empty);
            cboLista.Click += delegate
            {
                ForaignEvent?.Invoke(this.cboLista, EventArgs.Empty);
            };
            rjFiltro._TextChanged += delegate 
            {
                flowLayAlbumes.Controls.Clear();
                LlenarCanciones(flowLayAlbumes, rjFiltro.Texts);
                int a = MostrarValorSeleccionado(cboLista);
                GlobalVariables.IDLista = a;
                LlenarTabla();
            };
            //Edit
            btnEdit.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabCtrl.TabPages.Remove(userDetail);
                tabCtrl.TabPages.Add(userEntry);
                //userDetail.Text = "Editar";
            };
            //Save changes
            btnGuardar.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessful)
                {
                    //CancelEvent?.Invoke(this, EventArgs.Empty);
                    tabCtrl.TabPages.Remove(userDetail);
                    tabCtrl.TabPages.Add(userEntry);
                }
                MessageBox.Show(Message);
            };
            rjBorrar.Click += delegate (object sender, EventArgs e)
            {
                Eliminar();
            };
            rjDeshacer.Click += delegate (object sender, EventArgs e)
            {
                Deshecho();
            };
            rjReiniciar.Click += delegate (object sender, EventArgs e)
            {
                Reinicio();
            };
            btnSalir.Click += delegate
            {
                this.Close();
            };
            rjSalir.Click += delegate
            {
                this.Close();
            };
            rjRegresar.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabCtrl.TabPages.Remove(userEntry);
                tabCtrl.TabPages.Add(userDetail);
            };
            //Cancel
            /*btnCancel.Click += delegate
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
            };*/
        }
        public string Titulo
        {
            get { return txtTitulo.Texts; }
            set { txtTitulo.Texts = value; }
        }
        public string Descripcion
        {
            get { return txtDescripcion.Texts; }
            set { txtDescripcion.Texts = value; }
        }
        public string fechaRegistro
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
        /*public string SearchValue
        {
            get { return txtSearch.Text; }
            set { txtSearch.Text = value; }
        }*/
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

        /*public void SetUserListBindingSource(BindingSource usuariosList)
        {
            dataGridView.DataSource = usuariosList;
        }*/

        // Single pattern
        private static ListasB instance;
        public static ListasB GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ListasB();
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
            AppearanceManager.RJtablaClaro(tabCtrl);
            tabCtrl.TabPages.Remove(userEntry);
            // Aplicar ToolBox a la página de pestañas inicialmente seleccionada
            //tabCtrl.TabPages.Remove(userDetail);
            // Asignar evento SelectedIndexChanged
            //tabCtrl.SelectedIndexChanged += new EventHandler(tabCtrl_SelectedIndexChanged);
        }
    }
}
