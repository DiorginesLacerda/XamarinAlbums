using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinAlbums.Models;

namespace XamarinAlbums.ViewModels
{
    public class PhotoViewModel
    {

        public Photo Photo { get; private set; }


        public PhotoViewModel(Photo photo)
        {
            this.Photo = photo;
        }

        

        public string Image { get => Photo.url; private set { } }

        public string Title { get => String.Format("Photo {0}", Photo.id); private set { } }

        public string Content { get => Photo.title; private set { } }

    }
}
