using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinAlbums.Models;

namespace XamarinAlbums.ViewModels
{
    public class AlbumViewModel
    {
        public ObservableCollection<Photo> Photos { get; set; }
        public AlbumViewModel(ObservableCollection<Photo> album)
        {
            this.Photos = album;
        }
    }
}
