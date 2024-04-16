using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xeon.Repositories;

namespace Xeon.Views
{
    public partial class Inicio : Form, IVInicio
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void AssociateAndRaiseViewEvents()
        {
            //GetAllUserControl?.Invoke(this.flowLayAlbumes, EventArgs.Empty);
            FlowEvent?.Invoke(this.flowLayAlbumes, EventArgs.Empty);
            //SkillEvent?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler FlowEvent;
        public event EventHandler SkillEvent;
        public string IDAlbum { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Titulo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        private static Inicio instance;
        public static Inicio GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new Inicio();
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

        private void Inicio_Load(object sender, EventArgs e)
        {
            AssociateAndRaiseViewEvents();
        }
    }
}
