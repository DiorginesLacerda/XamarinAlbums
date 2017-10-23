using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinAlbums.Models;
using XamarinAlbums.ViewModels;

namespace XamarinAlbums.Views
{
    
    public partial class AlbumView : ContentPage
    {
        public AlbumViewModel ViewModel;
        public AlbumView(ObservableCollection<Photo> album)
        {
            InitializeComponent();
            this.ViewModel = new AlbumViewModel(album);
            this.Title = String.Format("Album {0}",ViewModel.Photos.First().albumId);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            foreach (var photo in this.ViewModel.Photos)
            {
                var image = new Image();
                image.Source = photo.thumbnailUrl;
                this.wrapLayout.Children.Add(image);
            }
        }
    }
}