using CustomControls.RJControls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using Xeon.Models;
using Xeon.Views;

namespace Xeon.Presenters
{
    class PUsuario
    {
        //Fields
        private IVUsuarios view;
        private IUsuarios repository;
        private BindingSource usersBindingSource;
        private IEnumerable<CUsuarios> userList;
        private List<int> foraignList;

        //Constructor
        public PUsuario(IVUsuarios view, IUsuarios repository)
        {
            this.view = view;
            this.repository = repository;
            this.usersBindingSource = new BindingSource();
            this.foraignList = new List<int>();
            //Subscribe event handler methods to view events
            this.view.SearchEvent += SearchUser;
            this.view.AddNewEvent += AddNewUser;
            this.view.EditEvent += LoadSelectedUserToEdit;
            this.view.DeleteEvent += DeleteSelectedUser;
            this.view.SaveEvent += SaveUser;
            this.view.CancelEvent += CancelAction;
            this.view.ForaignEvent += Foraign;
            //Set users bindind source
            this.view.SetUserListBindingSource(usersBindingSource);
            //Load user list view
            LoadAllUserList();
            //Show view
            this.view.Show();
            //this.view.LoadAllProfileList();
        }

        //Methods
        private void LoadAllUserList()
        {
            userList = repository.GetAll();
            usersBindingSource.DataSource = userList;//Set data source.
        }

        private void Foraign(object sender, EventArgs e)
        {
            foraignList = repository.GetAllIDs();
            ComboBox control = sender as ComboBox;
            control.Items.Clear();
            if (control.Name == "cboEstado")
            {
                control.Items.Add(0); control.Items.Add(1);
            }
            else
            {
                for (int i = 0; i < foraignList.Count; i++)
                    control.Items.Add(foraignList[i]);
            }
        }

        private void SearchUser(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
                userList = repository.GetByValue(this.view.SearchValue);
            else userList = repository.GetAll();
            usersBindingSource.DataSource = userList;
            //System.Windows.MessageBox.Show(usersBindingSource.ToString());
        }
        private void CancelAction(object sender, EventArgs e)
        {
            CleanviewFields();
        }
        private void SaveUser(object sender, EventArgs e)
        {
            var model = new CUsuarios();
            model.IDUsuario = Convert.ToInt32(view.IDUsuario);
            model.IDPerfil = Convert.ToInt32(view.IDPerfil);
            model.apellidoPaterno = view.apellidoPaterno;
            model.apellidoMaterno = view.apellidoMaterno;
            model.Nombre = view.Nombre;
            model.Apodo = view.Apodo;
            model.correoElectronico = view.correoElectronico;
            model.Contraseña = view.Contraseña;
            model.Nacimiento = view.Nacimiento;
            model.Estado = Convert.ToInt32(view.Estado);
            //
            try
            {
                new Common.ModelDataValidation().Validate(model);
                if (view.IsEdit)//Edit model
                {
                    repository.Edit(model);
                    view.Message = "User edited successfuly";
                }
                else //Add new model
                {
                    repository.Add(model);
                    view.Message = "User added sucessfully";
                }
                view.IsSuccessful = true;
                LoadAllUserList();
                CleanviewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void CleanviewFields()
        {
            view.IDUsuario = "1";
            view.IDPerfil = "ID Perfil";
            view.apellidoPaterno = "Apellido Paterno";
            view.apellidoMaterno = "Apellido Materno";
            view.Nombre = "Nombre";
            view.Apodo = "Apodo";
            view.correoElectronico = "Correo electrónico";
            view.Contraseña = "Contraseña";
        }

        private void DeleteSelectedUser(object sender, EventArgs e)
        {
            try
            {
                var user = (CUsuarios)usersBindingSource.Current;
                repository.Delete(user.IDUsuario);
                view.IsSuccessful = true;
                view.Message = "User deleted successfully";
                LoadAllUserList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An error ocurred, could not delete pet";
            }
        }
        private void LoadSelectedUserToEdit(object sender, EventArgs e)
        {
            var user = (CUsuarios)usersBindingSource.Current;
            view.IDUsuario = user.IDUsuario.ToString();
            view.IDPerfil = user.IDPerfil.ToString();
            view.apellidoPaterno = user.apellidoPaterno;
            view.apellidoMaterno = user.apellidoMaterno;
            view.Nombre = user.Nombre;
            view.Apodo = user.Apodo;
            view.correoElectronico = user.correoElectronico;
            view.Contraseña = user.Contraseña;
            view.Nacimiento = user.Nacimiento;
            view.Estado = user.Estado.ToString();
            view.IsEdit = true;
        }
        private void AddNewUser(object sender, EventArgs e)
        {
            view.IsEdit = false;
        }
    }

    class PUsuarioB
    {
        //Fields
        private IVUsuariosB view;
        private IUsuariosB repository;
        private BindingSource usersBindingSource;
        private IEnumerable<CUsuarios> userList;
        private List<int> foraignList;

        //Constructor
        public PUsuarioB(IVUsuariosB view, IUsuariosB repository)
        {
            this.view = view;
            this.repository = repository;
            this.usersBindingSource = new BindingSource();
            this.foraignList = new List<int>();
            //Subscribe event handler methods to view events
            this.view.AddNewEvent += AddNewUser;
            this.view.SaveEvent += SaveUser;
            this.view.CancelEvent += CancelAction;
            //Show view
            this.view.Show();
            //this.view.LoadAllProfileList();
        }

        private void CancelAction(object sender, EventArgs e)
        {
            CleanviewFields();
        }
        private void SaveUser(object sender, EventArgs e)
        {
            var model = new CUsuariosB();
            model.apellidoPaterno = view.apellidoPaterno;
            model.apellidoMaterno = view.apellidoMaterno;
            model.Nombre = view.Nombre;
            model.Apodo = view.Apodo;
            model.correoElectronico = view.correoElectronico;
            model.Contraseña = view.Contraseña;
            model.Nacimiento = view.Nacimiento;
            //
            try
            {
                new Common.ModelDataValidation().Validate(model);
                if (view.IsEdit)//Edit model
                {
                    view.Message = "User edited successfuly";
                }
                else //Add new model
                {
                    repository.Add(model);
                    view.Message = "User added sucessfully";
                }
                view.IsSuccessful = true;
                CleanviewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void CleanviewFields()
        {
            //view.IDUsuario = "1";
            //view.IDPerfil = "ID Perfil";
            view.apellidoPaterno = "Apellido Paterno";
            view.apellidoMaterno = "Apellido Materno";
            view.Nombre = "Nombre";
            view.Apodo = "Apodo";
            view.correoElectronico = "Correo electrónico";
            view.Contraseña = "Contraseña";
        }
        private void AddNewUser(object sender, EventArgs e)
        {
            view.IsEdit = false;
        }
    }
    class PListasB
    {
        //Fields
        private IVListasB view;
        private IListasB repository;
        private BindingSource usersBindingSource;
        private IEnumerable<CListasB> userList;
        private List<CListasB> foraignList;

        //Constructor
        public PListasB(IVListasB view, IListasB repository)
        {
            this.view = view;
            this.repository = repository;
            this.usersBindingSource = new BindingSource();
            //this.foraignList = new List<int>();
            this.foraignList = repository.GetLists();
            //Subscribe event handler methods to view events
            //this.view.SearchEvent += SearchUser;
            this.view.AddNewEvent += AddNewUser;
            this.view.DeleteEvent += DeleteSelectedUser;
            this.view.SaveEvent += SaveUser;
            this.view.CancelEvent += CancelAction;
            this.view.ForaignEvent += Foraign;
            //Set users bindind source
            //this.view.SetUserListBindingSource(usersBindingSource);
            //Load user list view
            LoadAllUserList();
            //Show view
            this.view.Show();
            //this.view.LoadAllProfileList();
        }

        //Methods
        private void LoadAllUserList()
        {
            userList = repository.GetAll();
            usersBindingSource.DataSource = userList;//Set data source.
        }

        private void Foraign(object sender, EventArgs e)
        {
            RJComboBox rj = sender as RJComboBox;
            rj.DisplayMember = "Titulo"; // Configurar el DisplayMember
            rj.ValueMember = "IDLista"; // Configurar el ValueMember
            rj.Items.Clear();
            //List<CListasB> foraignList = GetLists(); // Obtener la lista de objetos CListasB
            for (int i = 0; i < foraignList.Count; i++)
            {
                // Agregar los elementos al control
                rj.Items.Add(foraignList[i]);
            }
        }

        /*private void SearchUser(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
                userList = repository.GetByValue(this.view.SearchValue);
            else userList = repository.GetAll();
            usersBindingSource.DataSource = userList;
            //System.Windows.MessageBox.Show(usersBindingSource.ToString());
        }*/
        private void CancelAction(object sender, EventArgs e)
        {
            CleanviewFields();
        }
        private void SaveUser(object sender, EventArgs e)
        {
            var model = new CListasB();
            model.Titulo = view.Titulo;
            model.Descripcion = view.Descripcion;
            //
            try
            {
                new Common.ModelDataValidation().Validate(model);
                if (view.IsEdit)//Edit model
                {
                    repository.Edit(model);
                    view.Message = "List edited successfuly";
                }
                else //Add new model
                {
                    repository.Add(model);
                    view.Message = "List added sucessfully";
                }
                view.IsSuccessful = true;
                LoadAllUserList();
                CleanviewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void CleanviewFields()
        {
            view.Descripcion = "Agrega una descripción";
            view.Titulo = "Nombre de la lista";
        }

        private void DeleteSelectedUser(object sender, EventArgs e)
        {
            try
            {
                var user = (CListasB)usersBindingSource.Current;
                repository.Delete(user.IDLista);
                view.IsSuccessful = true;
                view.Message = "List deleted successfully";
                LoadAllUserList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An error ocurred, could not delete pet";
            }
        }
        /*private void LoadSelectedUserToEdit(object sender, EventArgs e)
        {
            var user = (CUsuarios)usersBindingSource.Current;
            view.IDUsuario = user.IDUsuario.ToString();
            view.IDPerfil = user.IDPerfil.ToString();
            view.apellidoPaterno = user.apellidoPaterno;
            view.apellidoMaterno = user.apellidoMaterno;
            view.Nombre = user.Nombre;
            view.Apodo = user.Apodo;
            view.correoElectronico = user.correoElectronico;
            view.Contraseña = user.Contraseña;
            view.Nacimiento = user.Nacimiento;
            view.Estado = user.Estado.ToString();
            view.IsEdit = true;
        }*/
        private void AddNewUser(object sender, EventArgs e)
        {
            view.IsEdit = false;
        }
    }

    class PReproducir
    {
        //Fields
        private IVReproducir view;
        private IReproducir repository;
        private BindingSource usersBindingSource;
        private List<CListasB> foraignList;

        //Constructor
        public PReproducir(IVReproducir view, IReproducir repository)
        {
            this.view = view;
            this.repository = repository;
            this.usersBindingSource = new BindingSource();
            //this.foraignList = new List<int>();
            //this.foraignList = repository.GetLists();
            //Subscribe event handler methods to view events
            //this.view.SearchEvent += SearchUser;
            //this.view.AddNewEvent += AddNewUser;
            //this.view.DeleteEvent += DeleteSelectedUser;
            //this.view.SaveEvent += SaveUser;
            //this.view.CancelEvent += CancelAction;
            this.view.FlowEvent += Foraign;
            //Set users bindind source
            //this.view.SetUserListBindingSource(usersBindingSource);
            //Load user list view
            //LoadAllUserList();
            //Show view
            this.view.Show();
            //this.view.LoadAllProfileList();
        }

        private void Foraign(object sender, EventArgs e)
        {
            RJComboBox rj = sender as RJComboBox;
            rj.DisplayMember = "Titulo"; // Configurar el DisplayMember
            rj.ValueMember = "IDLista"; // Configurar el ValueMember
            rj.Items.Clear();
            //List<CListasB> foraignList = GetLists(); // Obtener la lista de objetos CListasB
            for (int i = 0; i < foraignList.Count; i++)
            {
                // Agregar los elementos al control
                rj.Items.Add(foraignList[i]);
            }
        }
    }

    class PPerfiles
    {
        //Fields
        private IVPerfiles view;
        private IPerfiles repository;
        private BindingSource profilesBindingSource;
        private IEnumerable<CPerfiles> profileList;

        //Constructor
        public PPerfiles(IVPerfiles view, IPerfiles repository)
        {
            this.view = view;
            this.repository = repository;
            this.profilesBindingSource = new BindingSource();
            //Subscribe event handler methods to view events
            this.view.SearchEvent += SearchProfile;
            this.view.AddNewEvent += AddNewProfile;
            this.view.EditEvent += LoadSelectedProfileToEdit;
            this.view.DeleteEvent += DeleteSelectedProfile;
            this.view.SaveEvent += SaveProfile;
            this.view.CancelEvent += CancelAction;
            //Set users bindind source
            this.view.SetProfileListBindingSource(profilesBindingSource);
            //Load user list view
            LoadAllProfileList();
            //Show view
            this.view.Show();
        }

        //Methods
        private void LoadAllProfileList()
        {
            profileList = repository.GetAll();
            profilesBindingSource.DataSource = profileList;//Set data source.
        }
        private void SearchProfile(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
                profileList = repository.GetByValue(this.view.SearchValue);
            else profileList = repository.GetAll();
            profilesBindingSource.DataSource = profileList;
        }
        private void CancelAction(object sender, EventArgs e)
        {
            CleanviewFields();
        }
        private void SaveProfile(object sender, EventArgs e)
        {
            var model = new CPerfiles();
            model.IDPerfil = Convert.ToInt32(view.IDPerfil);
            model.Nombre = view.Nombre;
            model.Descripcion = view.Descripcion;
            model.Estado = Convert.ToInt32(view.Estado);
            //
            try
            {
                new Common.ModelDataValidation().Validate(model);
                if (view.IsEdit)//Edit model
                {
                    repository.Edit(model);
                    view.Message = "Profile edited successfuly";
                }
                else //Add new model
                {
                    repository.Add(model);
                    view.Message = "Profile added sucessfully";
                }
                view.IsSuccessful = true;
                LoadAllProfileList();
                CleanviewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void CleanviewFields()
        {
            view.IDPerfil = "1";
            view.Nombre = "Nombre";
            view.Descripcion = "Descripción";
            view.Estado = "Estado";
        }

        private void DeleteSelectedProfile(object sender, EventArgs e)
        {
            try
            {
                var user = (CPerfiles)profilesBindingSource.Current;
                repository.Delete(user.IDPerfil);
                view.IsSuccessful = true;
                view.Message = "Profile deleted successfully";
                LoadAllProfileList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An error ocurred, could not delete pofile";
            }
        }
        private void LoadSelectedProfileToEdit(object sender, EventArgs e)
        {
            var user = (CPerfiles)profilesBindingSource.Current;
            view.IDPerfil = user.IDPerfil.ToString();
            view.Nombre = user.Nombre;
            view.Descripcion = user.Descripcion;
            view.Estado = user.Estado.ToString();
            view.IsEdit = true;
        }
        private void AddNewProfile(object sender, EventArgs e)
        {
            view.IsEdit = false;
        }
    }

    class PGeneros
    {
        //Fields
        private IVGeneros view;
        private IGeneros repository;
        private BindingSource GenresBindingSource;
        private IEnumerable<CGeneros> GenreList;

        //Constructor
        public PGeneros(IVGeneros view, IGeneros repository)
        {
            this.view = view;
            this.repository = repository;
            this.GenresBindingSource = new BindingSource();
            //Subscribe event handler methods to view events
            this.view.SearchEvent += SearchGenre;
            this.view.AddNewEvent += AddNewGenre;
            this.view.EditEvent += LoadSelectedGenreToEdit;
            this.view.DeleteEvent += DeleteSelectedGenre;
            this.view.SaveEvent += SaveGenre;
            this.view.CancelEvent += CancelAction;
            //Set users bindind source
            this.view.SetGenreListBindingSource(GenresBindingSource);
            //Load user list view
            LoadAllGenreList();
            //Show view
            this.view.Show();
        }

        //Methods
        private void LoadAllGenreList()
        {
            GenreList = repository.GetAll();
            GenresBindingSource.DataSource = GenreList;//Set data source.
        }
        private void SearchGenre(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
                GenreList = repository.GetByValue(this.view.SearchValue);
            else GenreList = repository.GetAll();
            GenresBindingSource.DataSource = GenreList;
        }
        private void CancelAction(object sender, EventArgs e)
        {
            CleanviewFields();
        }
        private void SaveGenre(object sender, EventArgs e)
        {
            var model = new CGeneros();
            model.IDGenero = Convert.ToInt32(view.IDGenero);
            model.Nombre = view.Nombre;
            model.Descripcion = view.Descripcion;
            model.Estado = Convert.ToInt32(view.Estado);
            //
            try
            {
                new Common.ModelDataValidation().Validate(model);
                if (view.IsEdit)//Edit model
                {
                    repository.Edit(model);
                    view.Message = "Genre edited successfuly";
                }
                else //Add new model
                {
                    repository.Add(model);
                    view.Message = "Genre added sucessfully";
                }
                view.IsSuccessful = true;
                LoadAllGenreList();
                CleanviewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void CleanviewFields()
        {
            view.IDGenero = "1";
            view.Nombre = "Nombre";
            view.Descripcion = "Descripción";
            view.Estado = "Estado";
        }

        private void DeleteSelectedGenre(object sender, EventArgs e)
        {
            try
            {
                var user = (CGeneros)GenresBindingSource.Current;
                repository.Delete(user.IDGenero);
                view.IsSuccessful = true;
                view.Message = "Genre deleted successfully";
                LoadAllGenreList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An error ocurred, could not delete pofile";
            }
        }
        private void LoadSelectedGenreToEdit(object sender, EventArgs e)
        {
            var user = (CGeneros)GenresBindingSource.Current;
            view.IDGenero = user.IDGenero.ToString();
            view.Nombre = user.Nombre;
            view.Descripcion = user.Descripcion;
            view.Estado = user.Estado.ToString();
            view.IsEdit = true;
        }
        private void AddNewGenre(object sender, EventArgs e)
        {
            view.IsEdit = false;
        }
    }
    class PArtistas
    {
        //Fields
        private IVArtistas view;
        private IArtistas repository;
        private BindingSource ArtistsBindingSource;
        private IEnumerable<CArtistas> ArtistList;

        //Constructor
        public PArtistas(IVArtistas view, IArtistas repository)
        {
            this.view = view;
            this.repository = repository;
            this.ArtistsBindingSource = new BindingSource();
            //Subscribe event handler methods to view events
            this.view.SearchEvent += SearchArtist;
            this.view.AddNewEvent += AddNewArtist;
            this.view.EditEvent += LoadSelectedArtistToEdit;
            this.view.DeleteEvent += DeleteSelectedArtist;
            this.view.SaveEvent += SaveArtist;
            this.view.CancelEvent += CancelAction;
            this.view.ImageEvent += FileImage;
            //Set users bindind source
            this.view.SetArtistListBindingSource(ArtistsBindingSource);
            //Load user list view
            LoadAllArtistList();
            //Show view
            this.view.Show();
        }

        private void FileImage(object sender, EventArgs e)
        {
            OpenFileDialog fo = new OpenFileDialog();
            DialogResult rs = fo.ShowDialog();
            if (rs == DialogResult.OK)
            {
                using (Image originalImage = Image.FromFile(fo.FileName))
                {
                    Image resizedImage = new Bitmap(originalImage, 200, 200);
                    PictureBox control = sender as PictureBox;
                    control.Image = resizedImage;
                }
            }
        }

        private byte[] ConvertirImg()
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            return ms.GetBuffer();
        }

        //Methods
        private void LoadAllArtistList()
        {
            ArtistList = repository.GetAll();
            ArtistsBindingSource.DataSource = ArtistList;//Set data source.
        }
        private void SearchArtist(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
                ArtistList = repository.GetByValue(this.view.SearchValue);
            else ArtistList = repository.GetAll();
            ArtistsBindingSource.DataSource = ArtistList;
        }
        private void CancelAction(object sender, EventArgs e)
        {
            CleanviewFields();
        }

        private void SaveArtist(object sender, EventArgs e)
        {
            var model = new CArtistas();
            model.IDArtista = Convert.ToInt32(view.IDArtista);
            model.apellidoPaterno = view.apellidoPaterno;
            model.apellidoMaterno = view.apellidoMaterno;
            model.Nombre = view.Nombre;
            model.Apodo = view.Apodo;
            model.Nacimiento = view.Nacimiento;
            model.Nacionalidad = view.Nacionalidad;
            model.Imagen = view.Imagen;
            model.Estado = Convert.ToInt32(view.Estado);
            //
            try
            {
                new Common.ModelDataValidation().Validate(model);
                if (view.IsEdit)//Edit model
                {
                    repository.Edit(model);
                    view.Message = "Artist edited successfuly";
                }
                else //Add new model
                {
                    repository.Add(model);
                    view.Message = "Artist added sucessfully";
                }
                view.IsSuccessful = true;
                LoadAllArtistList();
                CleanviewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void CleanviewFields()
        {
            view.IDArtista = "1";
            view.apellidoPaterno = "Apellido Paterno";
            view.apellidoMaterno = "Apellido Materno";
            view.Nombre = "Nombre";
            view.Apodo = "Apodo";
            view.Nacimiento = DateTime.Now.ToString();
            view.Nacionalidad = "Nacionalidad";
            view.Imagen = null;
            view.Estado = "Estado";
        }

        private void DeleteSelectedArtist(object sender, EventArgs e)
        {
            try
            {
                var user = (CArtistas)ArtistsBindingSource.Current;
                repository.Delete(user.IDArtista);
                view.IsSuccessful = true;
                view.Message = "Artist deleted successfully";
                LoadAllArtistList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An error ocurred, could not delete artist";
            }
        }
        private void LoadSelectedArtistToEdit(object sender, EventArgs e)
        {
            var user = (CArtistas)ArtistsBindingSource.Current;
            view.IDArtista = user.IDArtista.ToString();
            view.apellidoPaterno = user.apellidoPaterno;
            view.apellidoMaterno = user.apellidoMaterno;
            view.Nombre = user.Nombre;
            view.Apodo = user.Apodo;
            view.Nacimiento = user.Nacimiento;
            view.Nacionalidad = user.Nacionalidad;
            view.Imagen = user.Imagen;
            view.Estado = user.Estado.ToString();
            view.IsEdit = true;
        }
        private void AddNewArtist(object sender, EventArgs e)
        {
            view.IsEdit = false;
        }
    }

    class PArtistaGenero
    {
        //Fields
        private IVArtistaGenero view;
        private IArtistaGenero repository;
        private BindingSource ArtistsBindingSource;
        private IEnumerable<CArtistaGenero> ArtistList;
        private List<int> foraignArtist, foraignGenre;

        //Constructor
        public PArtistaGenero(IVArtistaGenero view, IArtistaGenero repository)
        {
            this.view = view;
            this.repository = repository;
            this.ArtistsBindingSource = new BindingSource();
            //Subscribe event handler methods to view events
            this.view.SearchEvent += SearchArtist;
            this.view.AddNewEvent += AddNewArtist;
            this.view.EditEvent += LoadSelectedArtistToEdit;
            this.view.DeleteEvent += DeleteSelectedArtist;
            this.view.SaveEvent += SaveArtist;
            this.view.CancelEvent += CancelAction;
            this.view.ForaignEvent += Foraign;
            //Set tables bindind source
            this.view.SetArtistGenreListBindingSource(ArtistsBindingSource);
            //Load table list view
            LoadAllArtistList();
            //Show view
            this.view.Show();
        }

        //Methods
        private void LoadAllArtistList()
        {
            ArtistList = repository.GetAll();
            ArtistsBindingSource.DataSource = ArtistList;//Set data source.
        }

        private void Foraign(object sender, EventArgs e)
        {
            (foraignArtist, foraignGenre) = repository.GetAllIDs();
            ComboBox control = sender as ComboBox;
            control.Items.Clear();
            if (control.Name == "cboIDArtista")
            {
                for (int i = 0; i < foraignArtist.Count; i++)
                    control.Items.Add(foraignArtist[i]);
            }
            else if (control.Name == "cboIDGenero")
            {
                for (int i = 0; i < foraignGenre.Count; i++)
                    control.Items.Add(foraignGenre[i]);
            }
        }

        private void SearchArtist(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
                ArtistList = repository.GetByValue(this.view.SearchValue);
            else ArtistList = repository.GetAll();
            ArtistsBindingSource.DataSource = ArtistList;
        }
        private void CancelAction(object sender, EventArgs e)
        {
            CleanviewFields();
        }
        private void SaveArtist(object sender, EventArgs e)
        {
            var model = new CArtistaGenero();
            model.IDArtistaGenero = Convert.ToInt32(view.IDArtistaGenero);
            model.IDArtista = Convert.ToInt32(view.IDArtista);
            model.IDGenero = Convert.ToInt32(view.IDGenero);
            //
            try
            {
                new Common.ModelDataValidation().Validate(model);
                if (view.IsEdit)//Edit model
                {
                    repository.Edit(model);
                    view.Message = "Artistgenre edited successfuly";
                }
                else //Add new model
                {
                    repository.Add(model);
                    view.Message = "ArtistGenre added sucessfully";
                }
                view.IsSuccessful = true;
                LoadAllArtistList();
                CleanviewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void CleanviewFields()
        {
            view.IDArtista = "1";
            view.IDGenero = "1";
        }

        private void DeleteSelectedArtist(object sender, EventArgs e)
        {
            try
            {
                var table = (CArtistaGenero)ArtistsBindingSource.Current;
                repository.Delete(table.IDArtistaGenero);
                view.IsSuccessful = true;
                view.Message = "ArtistGenre deleted successfully";
                LoadAllArtistList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An error ocurred, could not delete ArtistGenre";
            }
        }
        private void LoadSelectedArtistToEdit(object sender, EventArgs e)
        {
            var table = (CArtistaGenero)ArtistsBindingSource.Current;
            view.IDArtistaGenero = table.IDArtistaGenero.ToString();
            view.IDArtista = table.IDArtista.ToString();
            view.IDGenero = table.IDGenero.ToString();
            view.IsEdit = true;
        }
        private void AddNewArtist(object sender, EventArgs e)
        {
            view.IsEdit = false;
        }
    }

    class PAlbum
    {
        //Fields
        private IVAlbum view;
        private IAlbum repository;
        private BindingSource AlbumsBindingSource;
        private IEnumerable<CAlbumes> AlbumList;
        private List<int> foraignArtist, foraignGenre;

        //Constructor
        public PAlbum(IVAlbum view, IAlbum repository)
        {
            this.view = view;
            this.repository = repository;
            this.AlbumsBindingSource = new BindingSource();
            //Subscribe event handler methods to view events
            this.view.SearchEvent += SearchAlbum;
            this.view.AddNewEvent += AddNewAlbum;
            this.view.EditEvent += LoadSelectedAlbumToEdit;
            this.view.DeleteEvent += DeleteSelectedAlbum;
            this.view.SaveEvent += SaveAlbum;
            this.view.CancelEvent += CancelAction;
            //this.view.ForaignEvent += Foraign;
            this.view.ImageEvent += FileImage;
            //Set tables bindind source
            this.view.SetAlbumListBindingSource(AlbumsBindingSource);
            //Load table list view
            LoadAllAlbumList();
            //Show view
            this.view.Show();
        }

        //private void Foraign(object sender, EventArgs e)
        //{
        //    (foraignArtist, foraignGenre) = repository.GetAllIDs();
        //    ComboBox control = sender as ComboBox;
        //    control.Items.Clear();
        //    if (control.Name == "cboIDArtista")
        //    {
        //        for (int i = 0; i < foraignArtist.Count; i++)
        //            control.Items.Add(foraignArtist[i]);
        //    }
        //    else if (control.Name == "cboIDGenero")
        //    {
        //        for (int i = 0; i < foraignGenre.Count; i++)
        //            control.Items.Add(foraignGenre[i]);
        //    }
        //}

        private void FileImage(object sender, EventArgs e)
        {
            OpenFileDialog fo = new OpenFileDialog();
            DialogResult rs = fo.ShowDialog();
            if (rs == DialogResult.OK)
            {
                using (Image originalImage = Image.FromFile(fo.FileName))
                {
                    Image resizedImage = new Bitmap(originalImage, 200, 200);
                    PictureBox control = sender as PictureBox;
                    control.Image = resizedImage;
                }
            }
        }

        //Methods
        private void LoadAllAlbumList()
        {
            AlbumList = repository.GetAll();
            AlbumsBindingSource.DataSource = AlbumList;//Set data source.
        }
        private void SearchAlbum(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
                AlbumList = repository.GetByValue(this.view.SearchValue);
            else AlbumList = repository.GetAll();
            AlbumsBindingSource.DataSource = AlbumList;
        }
        private void CancelAction(object sender, EventArgs e)
        {
            CleanviewFields();
        }

        private void SaveAlbum(object sender, EventArgs e)
        {
            var model = new CAlbumes();
            model.IDAlbum = Convert.ToInt32(view.IDAlbum);
            model.Titulo = view.Titulo;
            model.fechaLanzamiento = view.fechaLanzamiento;
            model.Imagen = view.Imagen;
            model.Estado = Convert.ToInt32(view.Estado);
            //
            try
            {
                new Common.ModelDataValidation().Validate(model);
                if (view.IsEdit)//Edit model
                {
                    repository.Edit(model);
                    view.Message = "Album edited successfuly";
                }
                else //Add new model
                {
                    repository.Add(model);
                    view.Message = "Album added sucessfully";
                }
                view.IsSuccessful = true;
                LoadAllAlbumList();
                CleanviewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void CleanviewFields()
        {
            view.IDAlbum = "1";
            view.Titulo = "Título";
            view.fechaLanzamiento = null;
            view.Imagen = null;
            view.Estado = "Estado";
        }

        private void DeleteSelectedAlbum(object sender, EventArgs e)
        {
            try
            {
                var table = (CAlbumes)AlbumsBindingSource.Current;
                repository.Delete(table.IDAlbum);
                view.IsSuccessful = true;
                view.Message = "Album deleted successfully";
                LoadAllAlbumList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An error ocurred, could not delete Album";
            }
        }
        private void LoadSelectedAlbumToEdit(object sender, EventArgs e)
        {
            var table = (CAlbumes)AlbumsBindingSource.Current;
            view.IDAlbum = table.IDAlbum.ToString();
            view.Titulo = table.Titulo;
            view.fechaLanzamiento = table.fechaLanzamiento;
            view.Imagen = table.Imagen;
            view.Estado = table.Estado.ToString();
            view.IsEdit = true;
        }
        private void AddNewAlbum(object sender, EventArgs e)
        {
            view.IsEdit = false;
        }
    }

    class PAlbumArtista
    {
        //Fields
        private IVAlbumArtist view;
        private IAlbumArtista repository;
        private BindingSource ArtistsBindingSource;
        private IEnumerable<CAlbumArtista> ArtistList;
        private List<int> foraignArtist, foraignGenre;

        //Constructor
        public PAlbumArtista(IVAlbumArtist view, IAlbumArtista repository)
        {
            this.view = view;
            this.repository = repository;
            this.ArtistsBindingSource = new BindingSource();
            //Subscribe event handler methods to view events
            this.view.SearchEvent += SearchArtist;
            this.view.AddNewEvent += AddNewArtist;
            this.view.EditEvent += LoadSelectedArtistToEdit;
            this.view.DeleteEvent += DeleteSelectedArtist;
            this.view.SaveEvent += SaveArtist;
            this.view.CancelEvent += CancelAction;
            this.view.ForaignEvent += Foraign;
            //Set tables bindind source
            this.view.SetArtistGenreListBindingSource(ArtistsBindingSource);
            //Load table list view
            LoadAllArtistList();
            //Show view
            this.view.Show();
        }

        //Methods
        private void LoadAllArtistList()
        {
            ArtistList = repository.GetAll();
            ArtistsBindingSource.DataSource = ArtistList;//Set data source.
        }

        private void Foraign(object sender, EventArgs e)
        {
            (foraignArtist, foraignGenre) = repository.GetAllIDs();
            ComboBox control = sender as ComboBox;
            control.Items.Clear();
            if (control.Name == "cboIDArtista")
            {
                for (int i = 0; i < foraignArtist.Count; i++)
                    control.Items.Add(foraignArtist[i]);
            }
            else if (control.Name == "cboIDAlbum")
            {
                for (int i = 0; i < foraignGenre.Count; i++)
                    control.Items.Add(foraignGenre[i]);
            }
        }

        private void SearchArtist(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
                ArtistList = repository.GetByValue(this.view.SearchValue);
            else ArtistList = repository.GetAll();
            ArtistsBindingSource.DataSource = ArtistList;
        }
        private void CancelAction(object sender, EventArgs e)
        {
            CleanviewFields();
        }
        private void SaveArtist(object sender, EventArgs e)
        {
            var model = new CAlbumArtista();
            model.IDAlbumArtista = Convert.ToInt32(view.IDAlbumArtista);
            model.IDArtista = Convert.ToInt32(view.IDArtista);
            model.IDAlbum = Convert.ToInt32(view.IDAlbum);
            //
            try
            {
                new Common.ModelDataValidation().Validate(model);
                if (view.IsEdit)//Edit model
                {
                    repository.Edit(model);
                    view.Message = "Artistgenre edited successfuly";
                }
                else //Add new model
                {
                    repository.Add(model);
                    view.Message = "ArtistGenre added sucessfully";
                }
                view.IsSuccessful = true;
                LoadAllArtistList();
                CleanviewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void CleanviewFields()
        {
            view.IDArtista = "1";
            view.IDAlbum = "1";
        }

        private void DeleteSelectedArtist(object sender, EventArgs e)
        {
            try
            {
                var table = (CAlbumArtista)ArtistsBindingSource.Current;
                repository.Delete(table.IDAlbumArtista);
                view.IsSuccessful = true;
                view.Message = "ArtistGenre deleted successfully";
                LoadAllArtistList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An error ocurred, could not delete ArtistGenre";
            }
        }
        private void LoadSelectedArtistToEdit(object sender, EventArgs e)
        {
            var table = (CAlbumArtista)ArtistsBindingSource.Current;
            view.IDAlbumArtista = table.IDAlbumArtista.ToString();
            view.IDArtista = table.IDArtista.ToString();
            view.IDAlbum = table.IDAlbum.ToString();
            view.IsEdit = true;
        }
        private void AddNewArtist(object sender, EventArgs e)
        {
            view.IsEdit = false;
        }
    }

    class PAlbumGenero
    {
        //Fields
        private IVAlbumGenre view;
        private IAlbumGenero repository;
        private BindingSource ArtistsBindingSource;
        private IEnumerable<CAlbumGenero> ArtistList;
        private List<int> foraignArtist, foraignGenre;

        //Constructor
        public PAlbumGenero(IVAlbumGenre view, IAlbumGenero repository)
        {
            this.view = view;
            this.repository = repository;
            this.ArtistsBindingSource = new BindingSource();
            //Subscribe event handler methods to view events
            this.view.SearchEvent += SearchArtist;
            this.view.AddNewEvent += AddNewArtist;
            this.view.EditEvent += LoadSelectedArtistToEdit;
            this.view.DeleteEvent += DeleteSelectedArtist;
            this.view.SaveEvent += SaveArtist;
            this.view.CancelEvent += CancelAction;
            this.view.ForaignEvent += Foraign;
            //Set tables bindind source
            this.view.SetArtistGenreListBindingSource(ArtistsBindingSource);
            //Load table list view
            LoadAllArtistList();
            //Show view
            this.view.Show();
        }

        //Methods
        private void LoadAllArtistList()
        {
            ArtistList = repository.GetAll();
            ArtistsBindingSource.DataSource = ArtistList;//Set data source.
        }

        private void Foraign(object sender, EventArgs e)
        {
            (foraignArtist, foraignGenre) = repository.GetAllIDs();
            ComboBox control = sender as ComboBox;
            control.Items.Clear();
            if (control.Name == "cboIDGenero")
            {
                for (int i = 0; i < foraignArtist.Count; i++)
                    control.Items.Add(foraignArtist[i]);
            }
            else if (control.Name == "cboIDAlbum")
            {
                for (int i = 0; i < foraignGenre.Count; i++)
                    control.Items.Add(foraignGenre[i]);
            }
        }

        private void SearchArtist(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
                ArtistList = repository.GetByValue(this.view.SearchValue);
            else ArtistList = repository.GetAll();
            ArtistsBindingSource.DataSource = ArtistList;
        }
        private void CancelAction(object sender, EventArgs e)
        {
            CleanviewFields();
        }
        private void SaveArtist(object sender, EventArgs e)
        {
            var model = new CAlbumGenero();
            model.IDAlbumGenero = Convert.ToInt32(view.IDAlbumGenero);
            model.IDGenero = Convert.ToInt32(view.IDGenero);
            model.IDAlbum = Convert.ToInt32(view.IDAlbum);
            //
            try
            {
                new Common.ModelDataValidation().Validate(model);
                if (view.IsEdit)//Edit model
                {
                    repository.Edit(model);
                    view.Message = "Artistgenre edited successfuly";
                }
                else //Add new model
                {
                    repository.Add(model);
                    view.Message = "ArtistGenre added sucessfully";
                }
                view.IsSuccessful = true;
                LoadAllArtistList();
                CleanviewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void CleanviewFields()
        {
            view.IDGenero = "1";
            view.IDAlbum = "1";
        }

        private void DeleteSelectedArtist(object sender, EventArgs e)
        {
            try
            {
                var table = (CAlbumGenero)ArtistsBindingSource.Current;
                repository.Delete(table.IDAlbumGenero);
                view.IsSuccessful = true;
                view.Message = "ArtistGenre deleted successfully";
                LoadAllArtistList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An error ocurred, could not delete ArtistGenre";
            }
        }
        private void LoadSelectedArtistToEdit(object sender, EventArgs e)
        {
            var table = (CAlbumGenero)ArtistsBindingSource.Current;
            view.IDAlbumGenero = table.IDAlbumGenero.ToString();
            view.IDGenero = table.IDGenero.ToString();
            view.IDAlbum = table.IDAlbum.ToString();
            view.IsEdit = true;
        }
        private void AddNewArtist(object sender, EventArgs e)
        {
            view.IsEdit = false;
        }
    }

    class PCancion
    {
        //Fields
        private IVCanciones view;
        private ICanciones repository;
        private BindingSource usersBindingSource;
        private IEnumerable<CCanciones> userList;
        private List<int> foraignList;

        //Constructor
        public PCancion(IVCanciones view, ICanciones repository)
        {
            this.view = view;
            this.repository = repository;
            this.usersBindingSource = new BindingSource();
            this.foraignList = new List<int>();
            //Subscribe event handler methods to view events
            this.view.SearchEvent += SearchUser;
            this.view.AddNewEvent += AddNewUser;
            this.view.EditEvent += LoadSelectedUserToEdit;
            this.view.DeleteEvent += DeleteSelectedUser;
            this.view.SaveEvent += SaveUser;
            this.view.CancelEvent += CancelAction;
            this.view.ForaignEvent += Foraign;
            //Set users bindind source
            this.view.SetUserListBindingSource(usersBindingSource);
            //Load user list view
            LoadAllUserList();
            //Show view
            this.view.Show();
            //this.view.LoadAllProfileList();
        }

        //Methods
        private void LoadAllUserList()
        {
            userList = repository.GetAll();
            usersBindingSource.DataSource = userList;//Set data source.
        }

        private void Foraign(object sender, EventArgs e)
        {
            foraignList = repository.GetAllIDs();
            ComboBox control = sender as ComboBox;
            control.Items.Clear();
            if (control.Name == "cboEstado")
            {
                control.Items.Add(0); control.Items.Add(1);
            }
            else
            {
                for (int i = 0; i < foraignList.Count; i++)
                    control.Items.Add(foraignList[i]);
            }
        }

        private void SearchUser(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
                userList = repository.GetByValue(this.view.SearchValue);
            else userList = repository.GetAll();
            usersBindingSource.DataSource = userList;
            //System.Windows.MessageBox.Show(usersBindingSource.ToString());
        }
        private void CancelAction(object sender, EventArgs e)
        {
            CleanviewFields();
        }
        private void SaveUser(object sender, EventArgs e)
        {
            var model = new CCanciones();
            model.IDCancion = Convert.ToInt32(view.IDCancion);
            model.IDAlbum = Convert.ToInt32(view.IDAlbum);
            model.Titulo = view.Titulo;
            model.Duracion = Convert.ToInt32(view.Duracion);
            model.Ruta = view.Ruta;
            model.Estado = Convert.ToInt32(view.Estado);
            //
            try
            {
                new Common.ModelDataValidation().Validate(model);
                if (view.IsEdit)//Edit model
                {
                    repository.Edit(model);
                    view.Message = "Song edited successfuly";
                }
                else //Add new model
                {
                    repository.Add(model);
                    view.Message = "Song added sucessfully";
                }
                view.IsSuccessful = true;
                LoadAllUserList();
                CleanviewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void CleanviewFields()
        {
            view.IDCancion = "1";
            view.IDAlbum = "ID Álbum";
            view.Titulo = "Titulo";
            view.Duracion = "1";
            view.Ruta = "Nombre";
            view.Estado = "1";
        }

        private void DeleteSelectedUser(object sender, EventArgs e)
        {
            try
            {
                var user = (CUsuarios)usersBindingSource.Current;
                repository.Delete(user.IDUsuario);
                view.IsSuccessful = true;
                view.Message = "Song deleted successfully";
                LoadAllUserList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An error ocurred, could not delete song";
            }
        }
        private void LoadSelectedUserToEdit(object sender, EventArgs e)
        {
            var user = (CCanciones)usersBindingSource.Current;
            view.IDCancion = user.IDCancion.ToString();
            view.IDAlbum = user.IDAlbum.ToString();
            view.Titulo = user.Titulo;
            view.Duracion = user.Duracion.ToString();
            view.Ruta = user.Ruta;
            view.Estado = user.Estado.ToString();
            view.IsEdit = true;
        }
        private void AddNewUser(object sender, EventArgs e)
        {
            view.IsEdit = false;
        }
    }

    class PInicio
    {
        //Fields
        private IVInicio view;
        private IInicio repository;
        private IEnumerable<UCInicio> AlbumList;
        private IEnumerable<UCInicio> InfoList;
        //private IEnumerable<CAlbumes> AlbumList;

        //Constructor
        public PInicio(IVInicio view, IInicio repository)
        {
            this.view = view;
            this.repository = repository;
            this.view.FlowEvent += Flow;
            this.view.SkillEvent += Skill;
            this.view.Show();
        }

        private void Flow(object sender, EventArgs e)
        {
            AlbumList = repository.GetAllUserControl();
            FlowLayoutPanel control = sender as FlowLayoutPanel;
            foreach (var item in AlbumList)
            {
                UCInicio uci = new UCInicio();
                uci.IDAlbum = item.IDAlbum;
                uci.Titulo = item.Titulo;
                uci.Año = item.Año;
                //System.IO.MemoryStream ms = new System.IO.MemoryStream(item.Imagen);
                uci.Imagen = item.Imagen;
                uci.Genero = item.Genero;
                uci.Artista = item.Artista;
                control.Controls.Add(uci);
            }
        }
        private void Skill(object sender, EventArgs e)
        {
            InfoList = repository.GetAlbumInfo();
            AlbumInfo control = sender as AlbumInfo;
            foreach (var item in InfoList)
            {
                System.Windows.MessageBox.Show(item.IDAlbum.ToString());
                System.Windows.MessageBox.Show(item.Año.ToString());
                System.Windows.MessageBox.Show(item.Artista.ToString());
                System.Windows.MessageBox.Show(item.Genero.ToString());
            }
        }
    }
    class PCancionGenero
    {
        //Fields
        private IVCancionGenero view;
        private ICancionGenero repository;
        private BindingSource ArtistsBindingSource;
        private IEnumerable<CCancionGenero> ArtistList;
        private List<int> foraignArtist, foraignGenre;

        //Constructor
        public PCancionGenero(IVCancionGenero view, ICancionGenero repository)
        {
            this.view = view;
            this.repository = repository;
            this.ArtistsBindingSource = new BindingSource();
            //Subscribe event handler methods to view events
            this.view.SearchEvent += SearchArtist;
            this.view.AddNewEvent += AddNewArtist;
            this.view.EditEvent += LoadSelectedArtistToEdit;
            this.view.DeleteEvent += DeleteSelectedArtist;
            this.view.SaveEvent += SaveArtist;
            this.view.CancelEvent += CancelAction;
            this.view.ForaignEvent += Foraign;
            //Set tables bindind source
            this.view.SetArtistGenreListBindingSource(ArtistsBindingSource);
            //Load table list view
            LoadAllArtistList();
            //Show view
            this.view.Show();
        }

        //Methods
        private void LoadAllArtistList()
        {
            ArtistList = repository.GetAll();
            ArtistsBindingSource.DataSource = ArtistList;//Set data source.
        }

        private void Foraign(object sender, EventArgs e)
        {
            (foraignArtist, foraignGenre) = repository.GetAllIDs();
            ComboBox control = sender as ComboBox;
            control.Items.Clear();
            if (control.Name == "cboIDGenero")
            {
                for (int i = 0; i < foraignArtist.Count; i++)
                    control.Items.Add(foraignArtist[i]);
            }
            else if (control.Name == "cboIDCancion")
            {
                for (int i = 0; i < foraignGenre.Count; i++)
                    control.Items.Add(foraignGenre[i]);
            }
        }

        private void SearchArtist(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
                ArtistList = repository.GetByValue(this.view.SearchValue);
            else ArtistList = repository.GetAll();
            ArtistsBindingSource.DataSource = ArtistList;
        }
        private void CancelAction(object sender, EventArgs e)
        {
            CleanviewFields();
        }
        private void SaveArtist(object sender, EventArgs e)
        {
            var model = new CCancionGenero();
            model.IDCancionGenero = Convert.ToInt32(view.IDCancionGenero);
            model.IDGenero = Convert.ToInt32(view.IDGenero);
            model.IDCancion = Convert.ToInt32(view.IDCancion);
            //
            try
            {
                new Common.ModelDataValidation().Validate(model);
                if (view.IsEdit)//Edit model
                {
                    repository.Edit(model);
                    view.Message = "Artistgenre edited successfuly";
                }
                else //Add new model
                {
                    repository.Add(model);
                    view.Message = "ArtistGenre added sucessfully";
                }
                view.IsSuccessful = true;
                LoadAllArtistList();
                CleanviewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void CleanviewFields()
        {
            view.IDGenero = "1";
            view.IDCancion = "1";
        }

        private void DeleteSelectedArtist(object sender, EventArgs e)
        {
            try
            {
                var table = (CCancionGenero)ArtistsBindingSource.Current;
                repository.Delete(table.IDCancionGenero);
                view.IsSuccessful = true;
                view.Message = "ArtistGenre deleted successfully";
                LoadAllArtistList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An error ocurred, could not delete ArtistGenre";
            }
        }
        private void LoadSelectedArtistToEdit(object sender, EventArgs e)
        {
            var table = (CCancionGenero)ArtistsBindingSource.Current;
            view.IDCancionGenero = table.IDCancionGenero.ToString();
            view.IDGenero = table.IDGenero.ToString();
            view.IDCancion = table.IDCancion.ToString();
            view.IsEdit = true;
        }
        private void AddNewArtist(object sender, EventArgs e)
        {
            view.IsEdit = false;
        }

    }
    class PListaCancion
    {
        //Fields
        private IVListaCancion view;
        private IListaCancion repository;
        private BindingSource ArtistsBindingSource;
        private IEnumerable<CListaCancion> ArtistList;
        private List<int> foraignArtist, foraignGenre;

        //Constructor
        public PListaCancion(IVListaCancion view, IListaCancion repository)
        {
            this.view = view;
            this.repository = repository;
            this.ArtistsBindingSource = new BindingSource();
            //Subscribe event handler methods to view events
            this.view.SearchEvent += SearchArtist;
            this.view.AddNewEvent += AddNewArtist;
            this.view.EditEvent += LoadSelectedArtistToEdit;
            this.view.DeleteEvent += DeleteSelectedArtist;
            this.view.SaveEvent += SaveArtist;
            this.view.CancelEvent += CancelAction;
            this.view.ForaignEvent += Foraign;
            //Set tables bindind source
            this.view.SetArtistGenreListBindingSource(ArtistsBindingSource);
            //Load table list view
            LoadAllArtistList();
            //Show view
            this.view.Show();
        }

        //Methods
        private void LoadAllArtistList()
        {
            ArtistList = repository.GetAll();
            ArtistsBindingSource.DataSource = ArtistList;//Set data source.
        }

        private void Foraign(object sender, EventArgs e)
        {
            (foraignArtist, foraignGenre) = repository.GetAllIDs();
            ComboBox control = sender as ComboBox;
            control.Items.Clear();
            if (control.Name == "cboIDLista")
            {
                for (int i = 0; i < foraignArtist.Count; i++)
                    control.Items.Add(foraignArtist[i]);
            }
            else if (control.Name == "cboIDCancion")
            {
                for (int i = 0; i < foraignGenre.Count; i++)
                    control.Items.Add(foraignGenre[i]);
            }
        }

        private void SearchArtist(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
                ArtistList = repository.GetByValue(this.view.SearchValue);
            else ArtistList = repository.GetAll();
            ArtistsBindingSource.DataSource = ArtistList;
        }
        private void CancelAction(object sender, EventArgs e)
        {
            CleanviewFields();
        }
        private void SaveArtist(object sender, EventArgs e)
        {
            var model = new CListaCancion();
            model.IDListaCancion = Convert.ToInt32(view.IDListaCancion);
            model.IDLista = Convert.ToInt32(view.IDLista);
            model.IDCancion = Convert.ToInt32(view.IDCancion);
            //
            try
            {
                new Common.ModelDataValidation().Validate(model);
                if (view.IsEdit)//Edit model
                {
                    repository.Edit(model);
                    view.Message = "Artistgenre edited successfuly";
                }
                else //Add new model
                {
                    repository.Add(model);
                    view.Message = "ArtistGenre added sucessfully";
                }
                view.IsSuccessful = true;
                LoadAllArtistList();
                CleanviewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void CleanviewFields()
        {
            view.IDLista = "1";
            view.IDCancion = "1";
        }

        private void DeleteSelectedArtist(object sender, EventArgs e)
        {
            try
            {
                var table = (CListaCancion)ArtistsBindingSource.Current;
                repository.Delete(table.IDListaCancion);
                view.IsSuccessful = true;
                view.Message = "ArtistGenre deleted successfully";
                LoadAllArtistList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An error ocurred, could not delete ArtistGenre";
            }
        }
        private void LoadSelectedArtistToEdit(object sender, EventArgs e)
        {
            var table = (CListaCancion)ArtistsBindingSource.Current;
            view.IDListaCancion = table.IDListaCancion.ToString();
            view.IDLista = table.IDLista.ToString();
            view.IDCancion = table.IDCancion.ToString();
            view.IsEdit = true;
        }
        private void AddNewArtist(object sender, EventArgs e)
        {
            view.IsEdit = false;
        }

    }
    class PAlbumCancion
    {
        //Fields
        private IVAlbumCancion view;
        private IAlbumCancion repository;
        private BindingSource ArtistsBindingSource;
        private IEnumerable<CAlbumCancion> ArtistList;
        private List<int> foraignArtist, foraignGenre;

        //Constructor
        public PAlbumCancion(IVAlbumCancion view, IAlbumCancion repository)
        {
            this.view = view;
            this.repository = repository;
            this.ArtistsBindingSource = new BindingSource();
            //Subscribe event handler methods to view events
            this.view.SearchEvent += SearchArtist;
            this.view.AddNewEvent += AddNewArtist;
            this.view.EditEvent += LoadSelectedArtistToEdit;
            this.view.DeleteEvent += DeleteSelectedArtist;
            this.view.SaveEvent += SaveArtist;
            this.view.CancelEvent += CancelAction;
            this.view.ForaignEvent += Foraign;
            //Set tables bindind source
            this.view.SetArtistGenreListBindingSource(ArtistsBindingSource);
            //Load table list view
            LoadAllArtistList();
            //Show view
            this.view.Show();
        }

        //Methods
        private void LoadAllArtistList()
        {
            ArtistList = repository.GetAll();
            ArtistsBindingSource.DataSource = ArtistList;//Set data source.
        }

        private void Foraign(object sender, EventArgs e)
        {
            (foraignArtist, foraignGenre) = repository.GetAllIDs();
            ComboBox control = sender as ComboBox;
            control.Items.Clear();
            if (control.Name == "cboIDAlbum")
            {
                for (int i = 0; i < foraignArtist.Count; i++)
                    control.Items.Add(foraignArtist[i]);
            }
            else if (control.Name == "cboIDCancion")
            {
                for (int i = 0; i < foraignGenre.Count; i++)
                    control.Items.Add(foraignGenre[i]);
            }
        }

        private void SearchArtist(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
                ArtistList = repository.GetByValue(this.view.SearchValue);
            else ArtistList = repository.GetAll();
            ArtistsBindingSource.DataSource = ArtistList;
        }
        private void CancelAction(object sender, EventArgs e)
        {
            CleanviewFields();
        }
        private void SaveArtist(object sender, EventArgs e)
        {
            var model = new CAlbumCancion();
            model.IDAlbumCancion = Convert.ToInt32(view.IDAlbumCancion);
            model.IDAlbum = Convert.ToInt32(view.IDAlbum);
            model.IDCancion = Convert.ToInt32(view.IDCancion);
            //
            try
            {
                new Common.ModelDataValidation().Validate(model);
                if (view.IsEdit)//Edit model
                {
                    repository.Edit(model);
                    view.Message = "Artistgenre edited successfuly";
                }
                else //Add new model
                {
                    repository.Add(model);
                    view.Message = "ArtistGenre added sucessfully";
                }
                view.IsSuccessful = true;
                LoadAllArtistList();
                CleanviewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void CleanviewFields()
        {
            view.IDAlbum = "1";
            view.IDCancion = "1";
        }

        private void DeleteSelectedArtist(object sender, EventArgs e)
        {
            try
            {
                var table = (CAlbumCancion)ArtistsBindingSource.Current;
                repository.Delete(table.IDAlbumCancion);
                view.IsSuccessful = true;
                view.Message = "ArtistGenre deleted successfully";
                LoadAllArtistList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An error ocurred, could not delete ArtistGenre";
            }
        }
        private void LoadSelectedArtistToEdit(object sender, EventArgs e)
        {
            var table = (CAlbumCancion)ArtistsBindingSource.Current;
            view.IDAlbumCancion = table.IDAlbumCancion.ToString();
            view.IDAlbum = table.IDAlbum.ToString();
            view.IDCancion = table.IDCancion.ToString();
            view.IsEdit = true;
        }
        private void AddNewArtist(object sender, EventArgs e)
        {
            view.IsEdit = false;
        }
    }
    class PListas
    {
        //Fields
        private IVListas view;
        private IListas repository;
        private BindingSource usersBindingSource;
        private IEnumerable<CListas> userList;
        private List<int> foraignList;

        //Constructor
        public PListas(IVListas view, IListas repository)
        {
            this.view = view;
            this.repository = repository;
            this.usersBindingSource = new BindingSource();
            this.foraignList = new List<int>();
            //Subscribe event handler methods to view events
            this.view.SearchEvent += SearchUser;
            this.view.AddNewEvent += AddNewUser;
            this.view.EditEvent += LoadSelectedUserToEdit;
            this.view.DeleteEvent += DeleteSelectedUser;
            this.view.SaveEvent += SaveUser;
            this.view.CancelEvent += CancelAction;
            this.view.ForaignEvent += Foraign;
            //Set users bindind source
            this.view.SetUserListBindingSource(usersBindingSource);
            //Load user list view
            LoadAllUserList();
            //Show view
            this.view.Show();
            //this.view.LoadAllProfileList();
        }

        //Methods
        private void LoadAllUserList()
        {
            userList = repository.GetAll();
            usersBindingSource.DataSource = userList;//Set data source.
        }

        private void Foraign(object sender, EventArgs e)
        {
            foraignList = repository.GetAllIDs();
            ComboBox control = sender as ComboBox;
            control.Items.Clear();
            if (control.Name == "cboEstado")
            {
                control.Items.Add(0); control.Items.Add(1);
            }
            else
            {
                for (int i = 0; i < foraignList.Count; i++)
                    control.Items.Add(foraignList[i]);
            }
        }

        private void SearchUser(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
                userList = repository.GetByValue(this.view.SearchValue);
            else userList = repository.GetAll();
            usersBindingSource.DataSource = userList;
            //System.Windows.MessageBox.Show(usersBindingSource.ToString());
        }
        private void CancelAction(object sender, EventArgs e)
        {
            CleanviewFields();
        }
        private void SaveUser(object sender, EventArgs e)
        {
            var model = new CListas();
            model.IDUsuario = Convert.ToInt32(view.IDUsuario);
            model.IDLista = Convert.ToInt32(view.IDLista);
            model.Titulo = view.Titulo;
            model.Descripcion = view.Descripcion;
            model.Estado = Convert.ToInt32(view.Estado);
            //
            try
            {
                new Common.ModelDataValidation().Validate(model);
                if (view.IsEdit)//Edit model
                {
                    repository.Edit(model);
                    view.Message = "User edited successfuly";
                }
                else //Add new model
                {
                    repository.Add(model);
                    view.Message = "User added sucessfully";
                }
                view.IsSuccessful = true;
                LoadAllUserList();
                CleanviewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void CleanviewFields()
        {
            view.IDUsuario = "1";
            view.IDLista = "ID Lista";
            view.Titulo = "Titulo";
            view.Descripcion = "Descripción";
        }

        private void DeleteSelectedUser(object sender, EventArgs e)
        {
            try
            {
                var user = (CListas)usersBindingSource.Current;
                repository.Delete(user.IDLista);
                view.IsSuccessful = true;
                view.Message = "User deleted successfully";
                LoadAllUserList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An error ocurred, could not delete pet";
            }
        }
        private void LoadSelectedUserToEdit(object sender, EventArgs e)
        {
            var user = (CListas)usersBindingSource.Current;
            view.IDUsuario = user.IDUsuario.ToString();
            view.IDLista = user.IDLista.ToString();
            view.Titulo = user.Titulo;
            view.Descripcion = user.Descripcion;
            view.Estado = user.Estado.ToString();
            view.IsEdit = true;
        }
        private void AddNewUser(object sender, EventArgs e)
        {
            view.IsEdit = false;
        }
    }
}
