using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xeon.Views;

namespace Xeon.Models
{
    interface IUsuarios
    {
        void Add(CUsuarios usuariosModel);
        void Edit(CUsuarios usuariosModel);
        void Delete(int id);
        IEnumerable<CUsuarios> GetAll();
        List<int> GetAllIDs();//ComboBox
        IEnumerable<CUsuarios> GetByValue(string value);//Searchs
    }
    interface IUsuariosB
    {
        void Add(CUsuariosB usuariosModel);
    }
    interface IListasB
    {
        void Add(CListasB listasModel);
        void Edit(CListasB listasModel);
        void Delete(int id);
        IEnumerable<CListasB> GetAll();
        List<CListasB> GetLists();//ComboBox
        //IEnumerable<CListasB> GetByValue(string value);//Searchs
    }
    interface IReproducir
    {
        //void Add(CListasB listasModel);
        //void Edit(CListasB listasModel);
        //void Delete(int id);
        //IEnumerable<CReproducir> GetAll();
        List<CListasB> GetLists();//ComboBox
        //IEnumerable<CListasB> GetByValue(string value);//Searchs
    }

    interface IPerfiles
    {
        void Add(CPerfiles perfilesModel);
        void Edit(CPerfiles perfilesModel);
        void Delete(int id);
        IEnumerable<CPerfiles> GetAll();
        IEnumerable<CPerfiles> GetByValue(string value);//Searchs
    }

    interface IGeneros
    {
        void Add(CGeneros GenerosModel);
        void Edit(CGeneros GenerosModel);
        void Delete(int id);
        IEnumerable<CGeneros> GetAll();
        IEnumerable<CGeneros> GetByValue(string value);//Searchs
    }

    interface IArtistas
    {
        void Add(CArtistas ArtistasModel);
        void Edit(CArtistas ArtistasModel);
        void Delete(int id);
        IEnumerable<CArtistas> GetAll();
        IEnumerable<CArtistas> GetByValue(string value);//Searchs
    }
    interface IArtistaGenero
    {
        void Add(CArtistaGenero ArtistaGeneroModel);
        void Edit(CArtistaGenero ArtistaGeneroModel);
        void Delete(int id);
        IEnumerable<CArtistaGenero> GetAll();
        (List<int> foraignArtist, List<int> foraignGenre) GetAllIDs();
        IEnumerable<CArtistaGenero> GetByValue(string value);//Searchs
    }
    interface IAlbum
    {
        void Add(CAlbumes AlbumesModel);
        void Edit(CAlbumes AlbumesModel);
        void Delete(int id);
        IEnumerable<CAlbumes> GetAll();
        //(List<int> foraignArtist, List<int> foraignGenre) GetAllIDs();
        IEnumerable<CAlbumes> GetByValue(string value);//Searchs
    }
    interface IAlbumArtista
    {
        void Add(CAlbumArtista AlbumArtistaModel);
        void Edit(CAlbumArtista AlbumArtistaModel);
        void Delete(int id);
        IEnumerable<CAlbumArtista> GetAll();
        (List<int> foraignArtist, List<int> foraignGenre) GetAllIDs();
        IEnumerable<CAlbumArtista> GetByValue(string value);//Searchs
    }

    interface IAlbumGenero
    {
        void Add(CAlbumGenero AlbumGeneroModel);
        void Edit(CAlbumGenero AlbumGeneroModel);
        void Delete(int id);
        IEnumerable<CAlbumGenero> GetAll();
        (List<int> foraignArtist, List<int> foraignGenre) GetAllIDs();
        IEnumerable<CAlbumGenero> GetByValue(string value);//Searchs
    }

    interface ICancionGenero
    {
        void Add(CCancionGenero CancionGeneroModel);
        void Edit(CCancionGenero CancionGeneroModel);
        void Delete(int id);
        IEnumerable<CCancionGenero> GetAll();
        (List<int> foraignArtist, List<int> foraignGenre) GetAllIDs();
        IEnumerable<CCancionGenero> GetByValue(string value);//Searchs
    }


    interface IInicio
    {
        IEnumerable<UCInicio> GetAllUserControl();
        IEnumerable<UCInicio> GetAlbumInfo();

        //void Add(CAlbumes AlbumesModel);
        //void Edit(CAlbumes AlbumesModel);
        //void Delete(int id);
        //IEnumerable<CAlbumes> GetAll();
        //(List<int> foraignArtist, List<int> foraignGenre) GetAllIDs();
        //IEnumerable<CAlbumes> GetByValue(string value);//Searchs
    }
    interface ICanciones
    {
        void Add(CCanciones usuariosModel);
        void Edit(CCanciones usuariosModel);
        void Delete(int id);
        IEnumerable<CCanciones> GetAll();
        List<int> GetAllIDs();//ComboBox
        IEnumerable<CCanciones> GetByValue(string value);//Searchs
    }
    interface IListaCancion
    {
        void Add(CListaCancion ListaCancionModel);
        void Edit(CListaCancion ListaCancionModel);
        void Delete(int id);
        IEnumerable<CListaCancion> GetAll();
        (List<int> foraignArtist, List<int> foraignGenre) GetAllIDs();
        IEnumerable<CListaCancion> GetByValue(string value);//Searchs
    }
    interface IAlbumCancion
    {
        void Add(CAlbumCancion AlbumCancionModel);
        void Edit(CAlbumCancion AlbumCancionModel);
        void Delete(int id);
        IEnumerable<CAlbumCancion> GetAll();
        (List<int> foraignArtist, List<int> foraignGenre) GetAllIDs();
        IEnumerable<CAlbumCancion> GetByValue(string value);//Searchs
    }

    interface IListas
    {
        void Add(CListas usuariosModel);
        void Edit(CListas usuariosModel);
        void Delete(int id);
        IEnumerable<CListas> GetAll();
        List<int> GetAllIDs();//ComboBox
        IEnumerable<CListas> GetByValue(string value);//Searchs
    }

}
