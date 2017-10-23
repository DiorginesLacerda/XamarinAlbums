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
    public partial class AlbumView : ContentPage
    {
        public AlbumView()
        {
            InitializeComponent();
        }
    }
}