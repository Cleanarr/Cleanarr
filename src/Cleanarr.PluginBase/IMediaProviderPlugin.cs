using Cleanarr.PluginBase.Models.MediaProvider;
using System.Collections.Generic;

namespace Cleanarr.PluginBase
{
    public interface IMediaProviderPlugin : IPlugin
    {
        public List<User> GetUsers();
        public List<Movie> GetMovies();
        public List<Series> GetSeries();
        public List<Season> GetSeasons(string SeriesId);
        public List<Episode> GetEpisodesBySeries(string SeriesId);
        public List<Episode> GetEpisodesBySeason(string SeasonId);
    }
}
