using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Xeon.Views
{
    public partial class UCInicio : UserControl, IVInicio
    {
        private int _IDAlbum;
        private string _Artista = "Null";
        private string _Genero = "Null";
        private string _Año = "Null";
        public UCInicio()
        {
            InitializeComponent();
        }
        public int IDAlbum 
        {
            get { return _IDAlbum; }
            set { _IDAlbum = value; }
        }
        public Image Imagen
        {
            get { return rjpicAlbum.Image; }
            set { rjpicAlbum.Image = value; }
        }
        public string Titulo
        {
            get { return lblAlbum.Text; }
            set { lblAlbum.Text = value; }
        }
        public string Artista
        {
            get { return _Artista; }
            set { _Artista = value; }
        }
        public string Genero
        {
            get { return _Genero; }
            set { _Genero = value; }
        }
        public string Año
        {
            get { return _Año; }
            set { _Año = value; }
        }
        private static AlbumEscuchar moment;
        private void rjbtnEscuchar_Click(object sender, EventArgs e)
        {
            if (moment == null || moment.IsDisposed)
            {
                moment = new AlbumEscuchar();
                moment.Show();
            }
            else
            {
                moment.Close();
            }
            FormPrincipal p = new FormPrincipal();
        }

        private void rjbtnInformacion_Click(object sender, EventArgs e)
        {
            DisplayInformation();
            MessageBox.Show(this.IDAlbum.ToString());
        }

        private void rjpicAlbum_Click(object sender, EventArgs e)
        {
            DisplayInformation();
        }

        public event EventHandler SkillEvent;
        public event EventHandler FlowEvent;
        private static AlbumInfo instance;
        private void DisplayInformation() 
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new AlbumInfo();
                instance.picAlbum.Image = this.Imagen;
                instance.lblTitulo.Text = this.Titulo;
                instance.lblArtista.Text = Artista;
                instance.lblGenero.Text = Genero;
                instance.lblAño.Text = Año;
                instance.Show();
            }
            else
            {
                instance.Close();
                DisplayInformation();
            }
        }
    }
}
