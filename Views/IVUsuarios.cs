using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Xeon.Views
{
    interface IVUsuarios
    {
        //Properties - Fields
        string IDUsuario { get; set; }
        string IDPerfil { get; set; }
        string apellidoPaterno { get; set; }
        string apellidoMaterno { get; set; }
        string Nombre { get; set; }
        string Apodo { get; set; }
        string correoElectronico { get; set; }
        string Contraseña { get; set; }
        string Nacimiento { get; set; }
        string fechaRegistro { get; set; }
        string Estado { get; set; }
        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }
        
        //Events
        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;
        event EventHandler ForaignEvent;

        //Methods
        void SetUserListBindingSource(BindingSource usuariosList);
        void Show();

    }

    interface IVUsuariosB
    {
        //Properties - Fields
        //string IDUsuario { get; set; }
        //string IDPerfil { get; set; }
        string apellidoPaterno { get; set; }
        string apellidoMaterno { get; set; }
        string Nombre { get; set; }
        string Apodo { get; set; }
        string correoElectronico { get; set; }
        string Contraseña { get; set; }
        string Nacimiento { get; set; }
        string fechaRegistro { get; set; }
        //string Estado { get; set; }
        //string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        //Events
        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;
        event EventHandler ForaignEvent;

        //Methods
        //void SetUserListBindingSource(BindingSource usuariosList);
        void Show();
    }

    interface IVListasB
    {
        //Properties - Fields
        //string IDLista { get; set; }
        //string IDUsuario { get; set; }
        string Titulo { get; set; }
        string Descripcion { get; set; }
        string fechaRegistro { get; set; }
        //string Estado { get; set; }
        //string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        //Events
        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;
        event EventHandler ForaignEvent;

        //Methods
        //void SetUserListBindingSource(BindingSource usuariosList);
        
        void Show();

    }

    interface IVReproducir
    {
        //Properties - Fields
        //string IDLista { get; set; }
        //string IDUsuario { get; set; }
        //string Titulo { get; set; }
        //string Descripcion { get; set; }
        //string fechaRegistro { get; set; }
        ////string Estado { get; set; }
        ////string SearchValue { get; set; }
        //bool IsEdit { get; set; }
        //bool IsSuccessful { get; set; }
        //string Message { get; set; }

        //Events
        event EventHandler FlowEvent;
        event EventHandler CancelEvent;

        //Methods
        //void SetUserListBindingSource(BindingSource usuariosList);

        void Show();

    }

    interface IVPerfiles
    {
        //Properties - Fields
        string IDPerfil { get; set; }
        string Nombre { get; set; }
        string Descripcion { get; set; }
        string Estado { get; set; }
        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        //Events
        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;
        //Methods
        void SetProfileListBindingSource(BindingSource perfilesList);
        void Show();
    }

    interface IVGeneros
    {
        //Properties - Fields
        string IDGenero { get; set; }
        string Nombre { get; set; }
        string Descripcion { get; set; }
        string Estado { get; set; }
        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        //Events
        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;
        
        //Methods
        void SetGenreListBindingSource(BindingSource GenerosList);
        void Show();
    }

    interface IVArtistas
    {
        //Properties - Fields
        string IDArtista { get; set; }
        string apellidoPaterno { get; set; }
        string apellidoMaterno { get; set; }
        string Nombre { get; set; }
        string Apodo { get; set; }
        string Nacimiento { get; set; }
        string Nacionalidad { get; set; }
        byte[] Imagen { get; set; }
        string Estado { get; set; }


        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        //Events
        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        event EventHandler ImageEvent;

        //Methods
        void SetArtistListBindingSource(BindingSource ArtistasList);
        void Show();
    }
    interface IVArtistaGenero
    {
        //Properties - Fields
        string IDArtistaGenero { get; set; }
        string IDArtista { get; set; }
        string IDGenero { get; set; }
        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        //Events
        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;
        event EventHandler ForaignEvent;

        //Methods
        void SetArtistGenreListBindingSource(BindingSource ArtistaGeneroList);
        void Show();
    }
    interface IVAlbum
    {
        //Properties - Fields
        string IDAlbum { get; set; }
        string Titulo { get; set; }
        string fechaLanzamiento { get; set; }
        byte[] Imagen { get; set; }
        string Estado { get; set; }

        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        //Events
        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;
        event EventHandler ImageEvent;

        //Methods
        void SetAlbumListBindingSource(BindingSource AlbumesList);
        void Show();
    }
    interface IVAlbumArtist
    {
        //Properties - Fields
        string IDAlbumArtista { get; set; }
        string IDArtista { get; set; }
        string IDAlbum { get; set; }
        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        //Events
        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;
        event EventHandler ForaignEvent;

        //Methods
        void SetArtistGenreListBindingSource(BindingSource AlbumArtistaList);
        void Show();
    }

    interface IVAlbumGenre
    {
        //Properties - Fields
        string IDAlbumGenero { get; set; }
        string IDGenero { get; set; }
        string IDAlbum { get; set; }
        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        //Events
        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;
        event EventHandler ForaignEvent;

        //Methods
        void SetArtistGenreListBindingSource(BindingSource AlbumGeneroList);
        void Show();
    }

    interface IVCancionGenero
    {
        //Properties - Fields
        string IDCancionGenero { get; set; }
        string IDGenero { get; set; }
        string IDCancion { get; set; }
        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        //Events
        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;
        event EventHandler ForaignEvent;

        //Methods
        void SetArtistGenreListBindingSource(BindingSource CancionGeneroList);
        void Show();
    }

    interface IVInicio
    {
        //Properties - Fields
        //string IDAlbum { get; set; }
        string Titulo { get; set; }

        event EventHandler FlowEvent;
        event EventHandler SkillEvent;
        //void 
        void Show();
        //string fechaLanzamiento { get; set; }
        //byte[] Imagen { get; set; }
        //string Estado { get; set; }

        //string SearchValue { get; set; }
        //bool IsEdit { get; set; }
        //bool IsSuccessful { get; set; }
        //string Message { get; set; }

        //Events
        //event EventHandler SearchEvent;
        //event EventHandler AddNewEvent;
        //event EventHandler EditEvent;
        //event EventHandler DeleteEvent;
        //event EventHandler SaveEvent;
        //event EventHandler CancelEvent;
        //event EventHandler ImageEvent;

        ////Methods
        //void SetAlbumListBindingSource(BindingSource AlbumesList);
        //void Show();
    }
    interface IVCanciones
    {
        //Properties - Fields
        string IDCancion { get; set; }
        string IDAlbum { get; set; }
        string Titulo { get; set; }
        string Duracion { get; set; }
        string Ruta { get; set; }
        string Estado { get; set; }
        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        //Events
        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;
        event EventHandler ForaignEvent;

        //Methods
        void SetUserListBindingSource(BindingSource usuariosList);
        void Show();

    }
    interface IVListaCancion
    {
        //Properties - Fields
        string IDListaCancion { get; set; }
        string IDLista { get; set; }
        string IDCancion { get; set; }
        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        //Events
        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;
        event EventHandler ForaignEvent;

        //Methods
        void SetArtistGenreListBindingSource(BindingSource ListaCancionList);
        void Show();
    }
    interface IVAlbumCancion
    {
        //Properties - Fields
        string IDAlbumCancion { get; set; }
        string IDAlbum { get; set; }
        string IDCancion { get; set; }
        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        //Events
        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;
        event EventHandler ForaignEvent;

        //Methods
        void SetArtistGenreListBindingSource(BindingSource AlbumCancionList);
        void Show();
    }

    interface IVListas
    {
        //Properties - Fields
        string IDUsuario { get; set; }
        string IDLista { get; set; }
        string Titulo { get; set; }
        string Descripcion { get; set; }
        string fechaRegistro { get; set; }
        string Estado { get; set; }
        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        //Events
        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;
        event EventHandler ForaignEvent;

        //Methods
        void SetUserListBindingSource(BindingSource usuariosList);
        void Show();

    }
}
