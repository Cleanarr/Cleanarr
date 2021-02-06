using System.Collections.Generic;

namespace Cleanarr.Data.Models
{
    public class MediaItem
    {
        public int    MediaItemId         { get; set; }
        public int    MediaProviderId     { get; set; }
        public string MediaProviderItemId { get; set; }
        public string MediaType           { get; set; }
        public string Title               { get; set; }
        public string Year                { get; set; }
        public string AddedAt             { get; set; }
        public string File                { get; set; }
        public bool   AutoDelete          { get; set; }
        public int    RemovalSettingId    { get; set; }
        public int?   SeriesId            { get; set; }
        public int?   SeasonId            { get; set; }

        public MediaProvider               MediaProvider   { get; set; }
        public ICollection<WatchHistory>   WatchHistories  { get; set; }
        public ICollection<Request>        Requests        { get; set; }
        public RemovalSetting              RemovalSetting  { get; set; }
        public Series                     Series          { get; set; }
        public Season                     Season          { get; set; }
        public ICollection<EMailMediaItem> EMailMediaItems { get; set; }
    }
}
