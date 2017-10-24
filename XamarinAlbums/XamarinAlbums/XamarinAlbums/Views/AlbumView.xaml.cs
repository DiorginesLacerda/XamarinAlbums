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


                var frame = new Frame
                {
                    Padding = 0,
                    Content = new StackLayout
                    {
                        Margin = 0,
                        VerticalOptions = LayoutOptions.FillAndExpand,
                        HorizontalOptions = LayoutOptions.Center,
                        
                        Children =
                        {
                            new Image { Source = photo.thumbnailUrl,  },
                            new Label
                            {
                                Text = photo.title,
                                WidthRequest =  90,
                                HeightRequest = 20,
                                HorizontalOptions = LayoutOptions.Center
                            }
                        }
                    },
            };
                this.wrapLayout.Children.Add(frame);
            }
        }
    }
}