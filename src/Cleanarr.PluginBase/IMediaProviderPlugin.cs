using Cleanarr.PluginBase.Models.MediaProvider;
using System.Collections.Generic;

namespace Cleanarr.PluginBase
{
    public interface IMediaProviderPlugin : IPlugin
    {
        public User GetUser(string UserId);
        public Movie GetMovie(string MovieId);
        public Series GetSerie(string SerieId);
        public Season GetSeason(string SeasonId);
        public Episode GetEpisode(string EpisodeId);

        public List<User> GetUsers();
        public List<Movie> GetMovies();
        public List<Series> GetSeries();
        public List<Season> GetSeasons(string SeriesId);
        public List<Episode> GetEpisodesBySeries(string SeriesId);
        public List<Episode> GetEpisodesBySeason(string SeasonId);
    }
}
