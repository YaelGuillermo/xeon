using CustomControls.RJControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xeon.Models;

namespace Xeon.Views
{
    public partial class UCListasB : UserControl
    {
        private int _IDCancion = 0;
        private int _IDAlbum = 0;
        public UCListasB()
        {
            InitializeComponent();
        }
        public int IDCancion
        {
            get { return _IDCancion; }
            set { _IDCancion = value; }
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
        public string Album 
        {
            get { return lblAlbum.Text; }
            set { lblAlbum.Text = value; }
        }
        public string Titulo
        {
            get { return lblCancion.Text; }
            set { lblCancion.Text = value; }
        }
        public string Artista
        {
            get { return lblArtista.Text; }
            set { lblArtista.Text = value; }
        }
        public string Duracion
        {
            get { return lblDuracion.Text; }
            set { lblDuracion.Text = value; }
        }
        ListasB listasB = new ListasB();
        //CListasB selectedItem = new CListasB();
        public void rjbtnAgregar_Click(object sender, EventArgs e)
        {
            listasB.Insercion(IDCancion);
        }
    }
}
