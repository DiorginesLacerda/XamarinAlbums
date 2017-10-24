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
            this.BindingContext = this.ViewModel;
            this.Title = String.Format("Album {0}",ViewModel.Photos.First().albumId);
            this.listViewPhoto.ItemsSource = this.ViewModel.Photos;

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            MessagingCenter.Subscribe<Photo>(this, "SelectedPhoto",
                (msg)=>
                {
                    Navigation.PushAsync(new PhotoView(msg));
                });
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            MessagingCenter.Unsubscribe<Photo>(this, "SelectedPhoto");
        }
    }
}