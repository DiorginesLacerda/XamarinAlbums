using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinAlbums.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinAlbums.Views
{
	
	public partial class MenuView : ContentPage
	{
        private MenuViewModel ViewModel;
        public MenuView ()
		{
			InitializeComponent ();
            ViewModel = new MenuViewModel();
            this.BindingContext = this.ViewModel;
            this.Title = "Menu";
            this.MenuItemsListView.ItemsSource = this.ViewModel.Items;

        }
	}
}