using CefSharp;
using CefSharp.WinForms;
using CustomControls.RJControls;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xeon.Design;
using Xeon.Models;

namespace Xeon.Views
{
    public partial class Reproducir : Form, IVReproducir
    {
        private int id_lista;
        private int id_usuario;
        private string descripcion;
        private string fecha;
        private string tit_lista;
        private string nombre;
        private int id_cancion;
        private string tit_cancion;
        private string apodo;
        private string connectionString = "Data Source=(local);Initial Catalog=XEON;Integrated Security=True";

        public Reproducir()
        {
            InitializeComponent();
        }

        public int Id_lista { get => id_lista; set => id_lista = value; }
        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public string Tit_lista { get => tit_lista; set => tit_lista = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Id_cancion { get => id_cancion; set => id_cancion = value; }
        public string Tit_cancion { get => tit_cancion; set => tit_cancion = value; }
        public string Apodo { get => apodo; set => apodo = value; }
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
        private void LlenarCanciones(FlowLayoutPanel flp, string filtro)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "ArrojarCancionInfo @Filtro";
                command.Parameters.AddWithValue("@Filtro", filtro); // Pasar el filtro como parámetro

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Id_cancion = Convert.ToInt32(reader[0]);
                    Tit_cancion = reader[2].ToString();
                    Apodo = reader[4].ToString();
                    UCRepCancion uclb = new UCRepCancion();
                    uclb.IDCancion = Id_cancion;
                    uclb.Titulo = Tit_cancion;
                    uclb.Artista = Apodo;
                    flp.Controls.Add(uclb);
                }
                connection.Close();
                connection.Dispose();
            }
        }
        public void LlenarTabla() 
        {
            string connectionString = "Data Source=(local);Initial Catalog=XEON;Integrated Security=True";
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "ReproducirListaCancion";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@IDLista", GlobalVariables.IDLista);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable playlistTable = new DataTable();
                adapter.Fill(playlistTable);
                dataGridView.DataSource = playlistTable;
                connection.Close();
            }
        }

        private void LlenarListas(FlowLayoutPanel flp)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "ArrojarListasInfo";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@IDUsuario", GlobalVariables.IDUsuario);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Id_lista = Convert.ToInt32(reader[0]);
                    Id_usuario = Convert.ToInt32(reader[1]);
                    Tit_lista = reader[2].ToString();
                    Nombre = reader[3].ToString();
                    Descripcion = reader[4].ToString();
                    Fecha = reader[5].ToString();
                    UCRepLista uclb = new UCRepLista();
                    uclb.IDLista = Id_lista;
                    uclb.IDUsuario = Id_usuario;
                    uclb.Lista = Tit_lista;
                    uclb.Usuario = Nombre;
                    uclb.Descripcion = Descripcion;
                    uclb.Fecha = Fecha;
                    flp.Controls.Add(uclb);
                }
                connection.Close();
                connection.Dispose();
            }
        }
        public void Play(int IDLista)
        {
            GlobalVariables.IDLista = IDLista;
            LlenarTabla();
        }
        public void AssociateAndRaiseViewEvents()
        {
            LlenarListas(flowLayListas);
            LlenarTabla();
            //FlowEvent?.Invoke(this.flowLayListas, EventArgs.Empty);
            //cboLista.Click += delegate
            //{
            //    ForaignEvent?.Invoke(this.cboLista, EventArgs.Empty);
            //};
            rjFiltro._TextChanged += delegate
            {
                flowLayCanciones.Controls.Clear();
                LlenarCanciones(flowLayCanciones, rjFiltro.Texts);
                //int a = MostrarValorSeleccionado(cboLista);
                //GlobalVariables.IDLista = a;
            };
            //btnSalir.Click += delegate
            //{
            //    this.Close();
            //};
            rjEscuchar.Click += delegate
            {
                if (GlobalVariables.IDLista > 0)
                {
                    LlenarTabla();
                    CancelEvent?.Invoke(this, EventArgs.Empty);
                    tabCtrl.TabPages.Remove(userEntry);
                    tabCtrl.TabPages.Add(userDetail);
                    Pause_Click(this, EventArgs.Empty);
                }
                else
                {
                    MessageBox.Show("Seleccionar alguna lista de reproducción. ");
                }
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

        public event EventHandler FlowEvent;
        public event EventHandler CancelEvent;

        /*public void SetUserListBindingSource(BindingSource usuariosList)
        {
            dataGridView.DataSource = usuariosList;
        }*/

        // Single pattern
        private static Reproducir instance;
        public static Reproducir GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new Reproducir();
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

        private void Reproducir_Load(object sender, EventArgs e)
        {
            AssociateAndRaiseViewEvents();
            //tabCtrl.TabPages.Remove(userDetail);
            // Aplicar ToolBox a la página de pestañas inicialmente seleccionada
            AppearanceManager.RJtablaClaro(tabCtrl);
            tabCtrl.TabPages.Remove(userDetail);
            // Asignar evento SelectedIndexChanged
            //tabCtrl.SelectedIndexChanged += new EventHandler(tabCtrl_SelectedIndexChanged);
        }
        //private void Pause_Click(object sender, EventArgs e)
        //{
        //    string html = "<html><head>";
        //    html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'>";
        //    html += "</head><body style='margin:0'>";
        //    html += "<iframe id='video' src='https://www.youtube.com/embed/{0}' width='500' height='255' frameborder='0' allowfullscreen></iframe>";
        //    html += "</body></html>";
        //    string youtubeUrl = dataGridView.CurrentRow.Cells["Ruta"].Value.ToString();
        //    string videoId = GetYouTubeVideoId(youtubeUrl);
        //    if (!string.IsNullOrEmpty(videoId))
        //    {
        //        string embeddedHtml = string.Format(html, videoId);
        //        MessageBox.Show(embeddedHtml);
        //        chromiumWebBrowser1.LoadHtml(embeddedHtml);
        //    }
        //}

        //private void Pause_Click(object sender, EventArgs e)
        //{
        //    string html = "<html><head>";
        //    html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'>";
        //    html += "</head><body style='margin:0'>";
        //    html += "<iframe id='video' src='https://www.youtube.com/embed/{0}' width='500' height='255' frameborder='0' allowfullscreen></iframe>";
        //    html += "</body></html>";
        //    string youtubeUrl = dataGridView.CurrentRow.Cells["Ruta"].Value.ToString();
        //    string videoId = GetYouTubeVideoId(youtubeUrl);
        //    videoId = "bgLjVPetlqE";
        //    if (!string.IsNullOrEmpty(videoId))
        //    {
        //        string apiKey = "AIzaSyA_9Jxgo92NWqIITZn1jEtuOqyqEPnaMAI";
        //        bool isEmbeddable = IsVideoEmbeddable(videoId, apiKey);

        //        if (isEmbeddable)
        //        {
        //            string embeddedHtml = string.Format(html, videoId);
        //            MessageBox.Show("El video se puede reproducir.");
        //            chromiumWebBrowser1.LoadHtml(embeddedHtml);
        //        }
        //        else
        //        {
        //            MessageBox.Show("El video no se puede reproducir.");
        //        }
        //    }
        //}

        private int currentIndex = 0;
        private int browserWidth = 500;
        private int browserHeight = 255;
        private string html = "<html><head><meta content='IE=Edge' http-equiv='X-UA-Compatible'></head><body style='margin:0'><iframe id='video' src='https://www.youtube.com/embed/{0}' width='{1}' height='{2}' frameborder='0' allowfullscreen></iframe></body></html>";

        //private void PlayNextVideo()
        //{
        //    MessageBox.Show(currentIndex.ToString());
        //    MessageBox.Show(dataGridView.Rows.Count.ToString());
        //    if (currentIndex < dataGridView.Rows.Count - 1)
        //    {
        //        currentIndex++;
        //        string youtubeUrl = dataGridView.Rows[currentIndex].Cells["Ruta"].Value.ToString();
        //        string videoId = GetYouTubeVideoId(youtubeUrl);
        //        if (!string.IsNullOrEmpty(videoId))
        //        {
        //            string embeddedHtml = string.Format(html, videoId);
        //            chromiumWebBrowser1.LoadHtml(embeddedHtml);
        //        }
        //    }
        //    else if(currentIndex == dataGridView.Rows.Count - 2)
        //    {
        //        currentIndex = 0; // Vuelve al inicio de la lista de canciones
        //        string youtubeUrl = dataGridView.Rows[currentIndex].Cells["Ruta"].Value.ToString();
        //        string videoId = GetYouTubeVideoId(youtubeUrl);
        //        if (!string.IsNullOrEmpty(videoId))
        //        {
        //            string embeddedHtml = string.Format(html, videoId);
        //            chromiumWebBrowser1.LoadHtml(embeddedHtml);
        //        }
        //    }
        //}

        private void PlayPreviousVideo()
        {
            if (currentIndex > 0)
            {
                currentIndex--;
            }
            else
            {
                currentIndex = dataGridView.Rows.Count - 2; // Último video de la lista
            }

            ReproducirVideoActual();
        }

        private void ReproducirVideoActual()
        {
            browserHeight = chromiumWebBrowser1.Height;
            browserWidth = chromiumWebBrowser1.Width;
            string youtubeUrl = dataGridView.Rows[currentIndex].Cells["Ruta"].Value.ToString();
            string videoId = GetYouTubeVideoId(youtubeUrl);

            if (!string.IsNullOrEmpty(videoId))
            {
                string embeddedHtml = string.Format(html, videoId, browserWidth, browserHeight);
                chromiumWebBrowser1.LoadHtml(embeddedHtml);
            }
        }

        private void PlayNextVideo()
        {
            if (currentIndex < dataGridView.Rows.Count - 2)
            {
                currentIndex++;
            }
            else
            {
                currentIndex = 0; // Vuelve al inicio de la lista de canciones
            }
            //browserHeight = chromiumWebBrowser1.Height;
            //browserWidth = chromiumWebBrowser1.Width;
            //string youtubeUrl = dataGridView.Rows[currentIndex].Cells["Ruta"].Value.ToString();
            //string videoId = GetYouTubeVideoId(youtubeUrl);

            //if (!string.IsNullOrEmpty(videoId))
            //{
            //    string embeddedHtml = string.Format(html, videoId, browserWidth, browserHeight);
            //    chromiumWebBrowser1.LoadHtml(embeddedHtml);
            //}
            ReproducirVideoActual();
        }

        private void Pause_Click(object sender, EventArgs e)
        {
            browserHeight = chromiumWebBrowser1.Height;
            browserWidth = chromiumWebBrowser1.Width;
            string youtubeUrl = dataGridView.CurrentRow.Cells["Ruta"].Value.ToString();
            string videoId = GetYouTubeVideoId(youtubeUrl);
            if (!string.IsNullOrEmpty(videoId))
            {
                string embeddedHtml = string.Format(html, videoId, browserWidth, browserHeight);
                chromiumWebBrowser1.LoadHtml(embeddedHtml);
            }
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            PlayNextVideo();
        }
        private string GetYouTubeVideoId(string url)
        {
            // Extraer el ID del video de YouTube de la URL
            string videoId = string.Empty;
            if (!string.IsNullOrEmpty(url))
            {
                Uri uri = new Uri(url);
                string query = uri.Query;
                if (!string.IsNullOrEmpty(query))
                {
                    string[] queryParams = query.Substring(1).Split('&');
                    foreach (string param in queryParams)
                    {
                        string[] keyValue = param.Split('=');
                        if (keyValue.Length == 2 && keyValue[0] == "v")
                        {
                            videoId = keyValue[1];
                            break;
                        }
                    }
                }
            }
            return videoId;
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            PlayPreviousVideo();
        }
    }
}
