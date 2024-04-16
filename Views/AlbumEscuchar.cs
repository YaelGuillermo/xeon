using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Xeon.Models;
using Xeon.Views;
using CefSharp;
using CefSharp.WinForms;
using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using WindowsInput;
using WindowsInput.Native;
using System.Windows.Automation;
using Xeon.Models;
using Xeon.Views;
using Xeon.Design;

namespace Xeon.Views
{
    public partial class AlbumEscuchar : Form
    {
        public AlbumEscuchar()
        {
            InitializeComponent();
        }

        private async void AlbumEscuchar_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(local);Initial Catalog=XEON;Integrated Security=True";
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT ac.Orden AS 'No.', c.Titulo AS 'Canción', a.Apodo AS 'Artista', " +
                    "al.Titulo AS 'Album', CONCAT(FLOOR(c.Duracion / 60),':', RIGHT('0' + CAST(c.Duracion % 60 AS varchar(2)), 2)) AS 'Tiempo', " +
                    "c.Ruta AS 'Ruta' FROM AlbumCancion ac INNER JOIN Canciones c ON c.IDCancion = ac.IDCancion INNER JOIN AlbumArtista aa ON aa.IDAlbum = ac.IDAlbum" +
                    " INNER JOIN Artistas a ON a.IDArtista = aa.IDArtista INNER JOIN Albumes al ON al.IDAlbum = ac.IDAlbum WHERE ac.IDAlbum = 1 " +
                    "ORDER BY ac.Orden; ";
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable playlistTable = new DataTable();
                adapter.Fill(playlistTable);
                dataGridView.DataSource = playlistTable;
                connection.Close();
            }
            // Cargar el primer video
            string youtubeUrl = dataGridView.Rows[0].Cells[5].Value.ToString();
            chromiumWebBrowser1.Load(youtubeUrl);
        }

        /*private async void ChromiumWebBrowser_FrameLoadEnd(object sender, FrameLoadEndEventArgs e)
        {
            string script = "var video = document.querySelector('video'); video && video.currentTime;";
            if (e.Frame.IsMain)
            {
                // Verificar que el navegador haya finalizado su inicialización
                if (!e.Frame.IsDisposed && e.Frame.IsValid)
                {
                    var response = await chromiumWebBrowser1.GetMainFrame().EvaluateScriptAsync(script);

                    if (response.Success && response.Result != null && response.Result is double)
                    {
                        double currentTimeSeconds = (double)response.Result;
                        TimeSpan currentTime = TimeSpan.FromSeconds(currentTimeSeconds);
                        if (currentTimeSeconds >= 180)
                        {
                            MessageBox.Show("Ya van 3 minutos");
                        }
                        MessageBox.Show($"El video va en el minuto {currentTime.Minutes}:{currentTime.Seconds}");
                    }
                }
            }
        }*/

        bool isPageLoaded = false;
        bool pause = true;
        int currentRowIndex = 0;

        private async void chromiumWebBrowser1_FrameLoadEnd(object sender, FrameLoadEndEventArgs e)
        {
            if (e.Frame.IsMain)
            {
                isPageLoaded = true;
                Configuracion();
            }
            if (isPageLoaded)
            {
                while (true)
                {
                    rjButton1_Click(this.rjButton1, e);
                    await Task.Delay(1000);
                }
            }
        }

        private void SeleccionarVideo() 
        {
            
        }

        private async void Configuracion() 
        {
            string Script = "document.querySelector('video').requestFullscreen();";
            await chromiumWebBrowser1.GetMainFrame().EvaluateScriptAsync(Script);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si se hace clic en la columna deseada (quinta columna) y no en los encabezados de columna
            if (e.ColumnIndex == 5 && e.RowIndex >= 0)
            {
                // Obtener el valor de la celda seleccionada (URL del video de YouTube)
                string youtubeUrl = dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                // Verificar si la URL es válida antes de reproducir el video
                if (!string.IsNullOrEmpty(youtubeUrl))
                {
                    // Cargar la URL del video en el control ChromiumWebBrowser
                    chromiumWebBrowser1.Load(youtubeUrl);
                }
            }
        }

        /*private string GetYouTubeVideoId(string youtubeUrl)
        {
            var uri = new Uri(youtubeUrl);
            var query = System.Web.HttpUtility.ParseQueryString(uri.Query);
            return query["v"];
        }*/


        private void tabLayPan_Paint(object sender, PaintEventArgs e)
            {

            }

        private async void Play_Click(object sender, EventArgs e)
        {
            string Script;
            if (isPageLoaded && pause)
            {
                pause = false;
                Script = "document.querySelector('video').play();";
                await chromiumWebBrowser1.GetMainFrame().EvaluateScriptAsync(Script);
            }
            else
            {
                pause = true;
                Script = "document.querySelector('video').pause();";
                await chromiumWebBrowser1.GetMainFrame().EvaluateScriptAsync(Script);
            }
        }
        private async void Pause_Click(object sender, EventArgs e)
        {
            string Script;
            Script = "var video = document.querySelector('video'); video.currentTime = 0; video.play();";
            await chromiumWebBrowser1.GetMainFrame().EvaluateScriptAsync(Script);
        }

        private bool isProcessing = false;
        private bool isMessageShown = false;
        private async void rjButton1_Click(object sender, EventArgs e)
        {
            if (isProcessing)
            {
                return; // Si ya se está procesando, no hacer nada
            }

            isProcessing = true; // Marcar que se está procesando

            string script1 = "var video = document.querySelector('video'); video && video.currentTime;";
            var response1 = await chromiumWebBrowser1.GetMainFrame().EvaluateScriptAsync(script1);
            string script2 = "var video = document.querySelector('video'); video && video.duration;";
            var response2 = await chromiumWebBrowser1.GetMainFrame().EvaluateScriptAsync(script2);

            if (response1.Success && response1.Result != null && response1.Result is double)
            {
                double currentTimeSeconds = (double)response1.Result;
                double videoTimeSeconds = (double)response2.Result;

                if (videoTimeSeconds >= 100 && currentTimeSeconds >= Math.Floor(videoTimeSeconds) - 2)
                {
                    isMessageShown = true; // Marcar que se mostró el mensaje
                    // Detener el procesamiento
                    isProcessing = false;
                    Pause_Click(sender, e);
                    // Realizar la acción deseada, como cargar el siguiente video
                    string youtubeUrl = dataGridView.Rows[1].Cells[5].Value.ToString();
                    chromiumWebBrowser1.Load(youtubeUrl);

                    return; // Salir del método para evitar que se siga ejecutando el código
                }
            }

            isProcessing = false; // Marcar que se ha terminado el procesamiento
        }


        /*private async void rjButton1_Click(object sender, EventArgs e)
        {
            string script1 = "var video = document.querySelector('video'); video && video.currentTime;";
            var response1 = await chromiumWebBrowser1.GetMainFrame().EvaluateScriptAsync(script1);
            string script2 = "var video = document.querySelector('video'); video && video.duration;";
            var response2 = await chromiumWebBrowser1.GetMainFrame().EvaluateScriptAsync(script2);
            bool flag = false;
            if (response1.Success && response1.Result != null && response1.Result is double)
            {
                double currentTimeSeconds = (double)response1.Result;
                double videoTimeSeconds = (double)response2.Result;
                //TimeSpan currentTime = TimeSpan.FromSeconds(currentTimeSeconds);
                if (videoTimeSeconds >= 100 && currentTimeSeconds >= Math.Floor(videoTimeSeconds) - 1)
                {
                    //string youtubeUrl = dataGridView.Rows[8].Cells[5].Value.ToString();
                    //chromiumWebBrowser1.Load(youtubeUrl);
                }
            }
        }*/
    }
}
