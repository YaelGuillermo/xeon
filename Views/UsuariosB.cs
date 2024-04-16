using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xeon.Design;

namespace Xeon.Views
{
    public partial class UsuariosB : Form, IVUsuariosB
    {
        //Fields
        private string message;
        private bool isSuccessful;
        private bool isEdit;

        public UsuariosB()
        {
            InitializeComponent();
        }

        private void AssociateAndRaiseViewEvents()
        {
            //Save changes
            btnGuardar.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessful)
                {
                    CancelEvent?.Invoke(this, EventArgs.Empty);
                    tabCtrl.TabPages.Remove(userDetail);
                    tabCtrl.TabPages.Add(userEntry);
                }
                MessageBox.Show(Message);
                this.Close();
            };
            rjButton1.Click += delegate
            {
                using (SqlConnection connection = new SqlConnection("Data Source=(local);Initial Catalog=XEON;Integrated Security=True"))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("ObtenerIDUsuario", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@Credencial", rjTextBox1.Texts);
                        command.Parameters.AddWithValue("@Contrasena", rjTextBox2.Texts);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                GlobalVariables.IDUsuario = reader.GetInt32(0);
                                GlobalVariables.IDPerfil = reader.GetInt32(1);
                                if (reader.GetInt32(0) > 0 && reader.GetInt32(0) > 0)
                                {
                                    MessageBox.Show("Bienvenid@ " + reader[2].ToString() + ".");
                                    this.Close();
                                }
                                else if (reader.GetInt32(0) == 0 && reader.GetInt32(0) == 0)
                                {
                                    MessageBox.Show("Credenciales incorrectas. ");
                                }
                            }
                        }
                    }
                }
                // Obtener la instancia del formulario principal
                FormPrincipal formPrincipal = Application.OpenForms.OfType<FormPrincipal>().FirstOrDefault();

                // Verificar si se encontró el formulario principal
                if (formPrincipal != null)
                {
                    // Llamar a la función "Visibilidad" en el formulario principal
                    formPrincipal.Visibilidad(GlobalVariables.IDPerfil);
                }
            };
            //Cancel
            btnSalir.Click += delegate
            {
                this.Close();
            };
            rjButton2.Click += delegate
            {
                this.Close();
            };
            btnSesion.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabCtrl.TabPages.Remove(userDetail);
                tabCtrl.TabPages.Add(userEntry);
            };
            rjButton3.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabCtrl.TabPages.Remove(userEntry);
                tabCtrl.TabPages.Add(userDetail);
            };
        }
        /*
        public string IDUsuario
        {
            get { return txIDUsuario.Text; }
            set { txIDUsuario.Text = value; }
        }
        public string IDPerfil
        {
            get { return cboIDPerfil.Text; }
            set { cboIDPerfil.Text = value; }
        }*/
        public string apellidoPaterno
        {
            get { return txapellidoPaterno.Texts; }
            set { txapellidoPaterno.Texts = value; }
        }
        public string apellidoMaterno
        {
            get { return txapellidoMaterno.Texts; }
            set { txapellidoMaterno.Texts = value; }
        }
        public string Nombre
        {
            get { return txNombre.Texts; }
            set { txNombre.Texts = value; }
        }
        public string Apodo
        {
            get { return txApodo.Texts; }
            set { txApodo.Texts = value; }
        }
        public string correoElectronico
        {
            get { return txcorreoElectronico.Texts; }
            set { txcorreoElectronico.Texts = value; }
        }
        public string Contraseña
        {
            get { return txContraseña.Texts; }
            set { txContraseña.Texts = value; }
        }
        public string Nacimiento
        {
            get { return datNacimiento.Text; }
            set { datNacimiento.Text= value; }
        }/*
        public string Estado
        {
            get { return 1; }
            set { 1 = value; }
        } */
        public string fechaRegistro
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
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

        // Single pattern
        private static UsuariosB instance;
        public static UsuariosB GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new UsuariosB();
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

        public void Pagina(bool flag) 
        {
            if (flag)
                tabCtrl.TabPages.Remove(userEntry);
            else
                tabCtrl.TabPages.Remove(userDetail);
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            AssociateAndRaiseViewEvents();
            AppearanceManager.RJtablaClaro(tabCtrl);
        }
    }
}
