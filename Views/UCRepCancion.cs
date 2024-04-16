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
    public partial class UCRepCancion : UserControl
    {
        private int _IDCancion = 0;
        public int IDCancion
        {
            get { return _IDCancion; }
            set { _IDCancion = value; }
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
        public UCRepCancion()
        {
            InitializeComponent();
        }

        private void rjbtnEscuchar_Click(object sender, EventArgs e)
        {

        }
    }
}
