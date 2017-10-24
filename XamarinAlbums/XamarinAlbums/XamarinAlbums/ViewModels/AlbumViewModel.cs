using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
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

        private Photo selectedPhoto;

        public Photo SelectedPhoto
        {
            get { return selectedPhoto; }
            set {
                selectedPhoto = value;
                if (value != null)
                    MessagingCenter.Send<Photo>(selectedPhoto, "SelectedPhoto");
            }
        }

    }
}
