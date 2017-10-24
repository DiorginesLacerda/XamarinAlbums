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
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PhotoView : ContentPage
	{
        private PhotoViewModel ViewModel;
		public PhotoView (Photo photo)
		{
			InitializeComponent ();
            this.ViewModel = new PhotoViewModel(photo);
            this.BindingContext = this.ViewModel;
            this.Title = this.ViewModel.Title;
        }
	}
}