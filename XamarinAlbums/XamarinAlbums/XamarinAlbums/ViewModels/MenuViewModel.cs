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
    public class MenuViewModel:BaseViewModel
    {
        public ObservableCollection<ItemMenu> Items { get; set; }

        private ItemMenu selectedItem;

        public ItemMenu SelectedItem
        {
            get { return selectedItem; }
            set
            {
                selectedItem = value;
                if (value != null)
                {
                    
                }
                    
            }
        }

        public MenuViewModel()
        {
            this.Items = new ObservableCollection<ItemMenu>(new[]
            {    
                new ItemMenu{ Id = 1, Title = "Item 1" },
                new ItemMenu{ Id = 1, Title = "Item 2" },
                new ItemMenu{ Id = 1, Title = "Item 3" },
                new ItemMenu{ Id = 1, Title = "Item 4" },
                new ItemMenu{ Id = 1, Title = "Item 5" },
                new ItemMenu{ Id = 1, Title = "Item 6" },
                new ItemMenu{ Id = 1, Title = "Item 7" },
                new ItemMenu{ Id = 1, Title = "Item 8" }
            }); 
        }

    }
}
