using System.Collections.Generic;

namespace Cleanarr.Data.Models
{
    public class Series
    {
        public int    SeriesId        { get; set; }
        public int    MediaProviderId { get; set; }
        public string Title           { get; set; }
        public string Year            { get; set; }
        public string AddedAt         { get; set; }

        public MediaProvider          MediaProvider { get; set; }
        public ICollection<Season>    Seasons       { get; set; }
        public ICollection<MediaItem> MediaItems    { get; set; }
    }
}
