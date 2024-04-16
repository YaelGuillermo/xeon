using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xeon.Views
{
    public interface IVMain
    {
        event EventHandler ShowUserView;
        event EventHandler ShowUserBView;
        event EventHandler ShowListasBView;
        event EventHandler ShowListasView;
        event EventHandler ShowListaCancionView;
        event EventHandler ShowAlbumCancionView;
        event EventHandler ShowReproducirView;
        event EventHandler ShowOwnerView;
        event EventHandler ShowVetsView;

        event EventHandler ShowProfileView;
        event EventHandler ShowGenreView;
        event EventHandler ShowArtistView;
        event EventHandler ShowArtistGenreView;
        event EventHandler ShowAlbumView;
        event EventHandler ShowAlbumArtistView;
        event EventHandler ShowAlbumGenreView;
        //event EventHandler ShowAlbumSongView;

        event EventHandler ShowSongView;
        //event EventHandler ShowSongArtistView;
        //event EventHandler ShowSongGenreView;

        //event EventHandler ShowListView;
        //event EventHandler ShowListSongView;


        event EventHandler ShowBeginningView;
    }
}
