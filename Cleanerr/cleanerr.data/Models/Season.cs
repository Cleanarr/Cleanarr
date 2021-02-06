using System.Collections.Generic;

namespace cleanerr.Data.Models
{
    public class Season
    {
        public int    SeasonId { get; set; }
        public int    Number   { get; set; }
        public int    SeriesId { get; set; }
        public string AddedAt  { get; set; }

        public Series                 Series     { get; set; }
        public ICollection<MediaItem> MediaItems { get; set; }
    }
}
