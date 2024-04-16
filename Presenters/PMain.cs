using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xeon.Models;
using Xeon.Views;
using Xeon.Repositories;
using System.Windows.Forms;

namespace Xeon.Presenters
{
    public class PMain
    {
        private IVMain mainView;
        private readonly string sqlConnectionString;

        public PMain(IVMain mainView, string sqlConnectionString)
        {
            this.mainView = mainView;
            this.sqlConnectionString = sqlConnectionString;
            this.mainView.ShowUserView += ShowUserViews;
            this.mainView.ShowUserBView += ShowUserBViews;
            this.mainView.ShowListasBView += ShowListasBViews;
            this.mainView.ShowListasView += ShowListasViews;
            this.mainView.ShowListaCancionView += ShowListaCancionViews;
            this.mainView.ShowAlbumCancionView += ShowAlbumCancionViews;
            this.mainView.ShowReproducirView += ShowReproducirViews;
            this.mainView.ShowProfileView += ShowProfileViews;
            this.mainView.ShowGenreView += ShowGenreViews;
            this.mainView.ShowArtistView += ShowArtistViews;
            this.mainView.ShowArtistGenreView += ShowArtistGenreViews;
            this.mainView.ShowAlbumView += ShowAlbumViews;
            this.mainView.ShowAlbumArtistView += ShowAlbumArtistViews;
            this.mainView.ShowAlbumGenreView += ShowAlbumGenreViews;
            this.mainView.ShowSongView += ShowSongViews;
            this.mainView.ShowBeginningView += ShowBeginningViews;
        }

        private void ShowUserViews(object sender, EventArgs e)
        {
            IVUsuarios view = Usuarios.GetInstance((FormPrincipal)mainView);
            IUsuarios repository = new UserRepository(sqlConnectionString);
            new PUsuario(view, repository);
        }
        private void ShowUserBViews(object sender, EventArgs e)
        {
            IVUsuariosB view = UsuariosB.GetInstance((FormPrincipal)mainView);
            IUsuariosB repository = new UserBRepository(sqlConnectionString);
            new PUsuarioB(view, repository);
        }
        private void ShowListasBViews(object sender, EventArgs e)
        {
            IVListasB view = ListasB.GetInstance((FormPrincipal)mainView);
            IListasB repository = new ListasBRepository(sqlConnectionString);
            new PListasB(view, repository);
        }
        private void ShowReproducirViews(object sender, EventArgs e)
        {
            IVReproducir view = Reproducir.GetInstance((FormPrincipal)mainView);
            IReproducir repository = new ReproducirRepository(sqlConnectionString);
            new PReproducir(view, repository);
        }
        private void ShowProfileViews(object sender, EventArgs e)
        {
            IVPerfiles view = Perfiles.GetInstance((FormPrincipal)mainView);
            IPerfiles repository = new ProfileRepository(sqlConnectionString);
            new PPerfiles(view, repository);
        }

        private void ShowGenreViews(object sender, EventArgs e)
        {
            IVGeneros view = Generos.GetInstance((FormPrincipal)mainView);
            IGeneros repository = new GenreRepository(sqlConnectionString);
            new PGeneros(view, repository);
        }
        private void ShowArtistViews(object sender, EventArgs e)
        {
            IVArtistas view = Artistas.GetInstance((FormPrincipal)mainView);
            IArtistas repository = new ArtistRepository(sqlConnectionString);
            new PArtistas(view, repository);
        }
        private void ShowArtistGenreViews(object sender, EventArgs e)
        {
            IVArtistaGenero view = ArtistaGenero.GetInstance((FormPrincipal)mainView);
            IArtistaGenero repository = new ArtistGenreRepository(sqlConnectionString);
            new PArtistaGenero(view, repository);
        }

        private void ShowAlbumViews(object sender, EventArgs e)
        {
            IVAlbum view = Albumes.GetInstance((FormPrincipal)mainView);
            IAlbum repository = new AlbumRepository(sqlConnectionString);
            new PAlbum(view, repository);
        }
        private void ShowAlbumArtistViews(object sender, EventArgs e)
        {
            IVAlbumArtist view = AlbumArtista.GetInstance((FormPrincipal)mainView);
            IAlbumArtista repository = new AlbumArtistRepository(sqlConnectionString);
            new PAlbumArtista(view, repository);
        }
        private void ShowAlbumGenreViews(object sender, EventArgs e)
        {
            IVAlbumGenre view = AlbumGenero.GetInstance((FormPrincipal)mainView);
            IAlbumGenero repository = new AlbumGenreRepository(sqlConnectionString);
            new PAlbumGenero(view, repository);
        }
        private void ShowSongViews(object sender, EventArgs e)
        {
            IVCanciones view = Canciones.GetInstance((FormPrincipal)mainView);
            ICanciones repository = new CancionesRepository(sqlConnectionString);
            new PCancion(view, repository);
        }
        private void ShowBeginningViews(object sender, EventArgs e)
        {
            IVInicio view = Inicio.GetInstance((FormPrincipal)mainView);
            IInicio repository = new InicioRepository(sqlConnectionString);
            new PInicio(view, repository);
        }

        private void ShowListaCancionViews(object sender, EventArgs e)
        {
            IVListaCancion view = ListaCancion.GetInstance((FormPrincipal)mainView);
            IListaCancion repository = new ListaCancionRepository(sqlConnectionString);
            new PListaCancion(view, repository);
        }

        private void ShowAlbumCancionViews(object sender, EventArgs e)
        {
            IVAlbumCancion view = AlbumCancion.GetInstance((FormPrincipal)mainView);
            IAlbumCancion repository = new AlbumCancionRepository(sqlConnectionString);
            new PAlbumCancion(view, repository);
        }

        private void ShowListasViews(object sender, EventArgs e)
        {
            IVListas view = Listas.GetInstance((FormPrincipal)mainView);
            IListas repository = new ListasRepository(sqlConnectionString);
            new PListas(view, repository);
        }
    }
}
