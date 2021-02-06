namespace cleanerr.Data.Models
{
    public class WatchHistory
    {
        public int    WatchHistoryId    { get; set; }
        public int    UserId            { get; set; }
        public int    MediaItemId       { get; set; }
        public int    HistoryProviderId { get; set; }
        public string WatchedAt         { get; set; }

        public User            User            { get; set; }
        public MediaItem       MediaItem       { get; set; }
        public HistoryProvider HistoryProvider { get; set; }
    }
}
