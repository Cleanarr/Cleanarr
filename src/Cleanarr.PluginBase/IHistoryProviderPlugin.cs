using Cleanarr.PluginBase.Models.HistoryProvider;
using System;
using System.Collections.Generic;

namespace Cleanarr.PluginBase
{
    public interface IHistoryProviderPlugin : IPlugin
    {
        public List<WatchHistory> GetWatchHistories();
        public List<WatchHistory> GetWatchHistories(DateTime StartDate, DateTime EndDate);
    }
}
