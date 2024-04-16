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
    public partial class UCRepLista : UserControl
    {
        private int _IDLista = 0;
        private int _IDUsuario = 0;
        public UCRepLista()
        {
            InitializeComponent();
        }
        public int IDLista
        {
            get { return _IDLista; }
            set { _IDLista = value; }
        }
        public int IDUsuario
        {
            get { return _IDUsuario; }
            set { _IDUsuario = value; }
        }
        public string Lista
        {
            get { return lblLista.Text; }
            set { lblLista.Text = value; }
        }
        public string Descripcion
        {
            get { return lblDescripcion.Text; }
            set { lblDescripcion.Text = value; }
        }
        public string Usuario
        {
            get { return lblUsuario.Text; }
            set { lblUsuario.Text = value; }
        }
        public string Fecha
        {
            get { return lblFecha.Text; }
            set { lblFecha.Text = value; }
        }

        Reproducir rep = new Reproducir();
        private void rjbtnEscuchar_Click(object sender, EventArgs e)
        {
            rep.Play(IDLista);
        }
    }
}
