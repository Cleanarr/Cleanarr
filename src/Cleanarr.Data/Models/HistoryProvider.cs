using System.Collections.Generic;

namespace Cleanarr.Data.Models
{
    public class HistoryProvider
    {
        public int    HistoryProviderId { get; set; }
        public string Name              { get; set; }
        public string PluginFile        { get; set; }

        public ICollection<WatchHistory> WatchHistories { get; set; }
    }
}
