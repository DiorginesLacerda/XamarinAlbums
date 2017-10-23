using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using XamarinAlbums.Models;

namespace XamarinAlbums.Services
{
    public class PhotoRepository
    {
        const string URL_GET_IMAGES = "https://jsonplaceholder.typicode.com/photos/";

        public async Task<List<Photo>> GetPhotos()
        {
            var client = new HttpClient();

            var json = await client.GetStringAsync(URL_GET_IMAGES);

            var Images = JsonConvert.DeserializeObject<List<Photo>>(json);

            return Images;
        }
    }
}
