using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinAlbums.Models;
using XamarinAlbums.ViewModels;

namespace XamarinAlbums.Views
{
    
    public partial class ListAlbumView : ContentPage
    {
        public ListAlbumViewModel ViewModel { get; set; }
        public ListAlbumView()
        {
            InitializeComponent();
            this.ViewModel = new ListAlbumViewModel();
            this.BindingContext = this.ViewModel;
            this.Title = "Albuns";
            this.listViewAlbum.ItemsSource = this.ViewModel.ListAlbums;
        }

        
        protected async override void OnAppearing()
        {
            base.OnAppearing();
          /*  MessagingCenter.Subscribe<List<Photo>>(this, "SelectedAlbum",
                (msg) =>
                {
                    Navigation.PushAsync(new AlbumView());
                });*/
            await this.ViewModel.GetAlbums();
        }
        
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            MessagingCenter.Unsubscribe<List<Photo>>(this, "SelectedAlbum");
        }
    }
}