using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinAlbums.Models;
using XamarinAlbums.Services;

namespace XamarinAlbums.ViewModels
{
    public class ListAlbumViewModel : BaseViewModel
    {
        private Dictionary<long, ObservableCollection<Photo>> Albums;
        public ObservableCollection<Photo> ListAlbums { get; set; }

        public Command GetPhotosCommand { get; set; }

        private bool busy;

        public bool IsBusy
        {
            get { return busy; }
            set
            {
                busy = value;
                OnPropertyChanged();
                GetPhotosCommand.ChangeCanExecute();

            }
        }

        public ListAlbumViewModel()
        {
            ListAlbums = new ObservableCollection<Photo>();
            Albums = new Dictionary<long, ObservableCollection<Photo>>();
            GetPhotosCommand = new Command(async () => await GetAlbums(), () => !IsBusy);
        }

        public async Task GetAlbums()
        {
            if (!IsBusy)
            {
                Exception Error = null;
                try
                {
                    IsBusy = true;
                    var Repository = new PhotoRepository();
                    var Items = await Repository.GetPhotos();
                    SetDataAlbums(Items);
                    SetDataListAlbums();

                }
                catch (Exception ex)
                {
                    Error = ex;
                }
                finally
                {
                    IsBusy = false;
                }
                if (Error != null)
                {
                    await Xamarin.Forms.Application.Current.MainPage.DisplayAlert("Error", Error.Message, "Ok");
                }
            }
            return;
        }

        private void SetDataListAlbums()
        {
            ListAlbums.Clear();
            foreach (long albumId in Albums.Keys)
            {
                ListAlbums.Add(Albums[albumId].First());
            }
        }

        private void SetDataAlbums(List<Photo> Items)
        {
            Albums.Clear();
            foreach (var photo in Items)
            {
                if (Albums.Keys.Contains(photo.albumId))
                {
                    Albums[photo.albumId].Add(photo);
                }
                else
                {
                    Albums.Add(photo.albumId, new ObservableCollection<Photo> { photo });
                }
            }
        }
    }
}
