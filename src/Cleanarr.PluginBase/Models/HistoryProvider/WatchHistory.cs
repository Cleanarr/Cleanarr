
namespace Cleanarr.PluginBase.Models.HistoryProvider
{
    public sealed class WatchHistory
    {
        public string UserId { get; set; }
        public string MediaItemId { get; set; }
        public string WatchedAt { get; set; }
        public string Watched_Position { get; set; }
        public string Watched_Percent { get; set; }
    }
}
