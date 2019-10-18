using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicCollection.Models
{
    public class Album
    {
        public int AlbumId { get; set; }
        public string UPC { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Description { get; set; }
        public string Media { get; set; }
        public string Image { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Label { get; set; }
    }
}
