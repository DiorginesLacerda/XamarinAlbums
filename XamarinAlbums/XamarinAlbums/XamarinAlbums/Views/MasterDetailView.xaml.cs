using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinAlbums.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MasterDetailView : MasterDetailPage
    {
		public MasterDetailView ()
		{
			InitializeComponent ();
            this.Master = new MenuView();
            this.Detail = new NavigationPage(new ListAlbumView());
		}
	}
}