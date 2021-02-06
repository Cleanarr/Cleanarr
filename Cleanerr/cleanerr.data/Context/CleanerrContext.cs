using cleanerr.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace cleanerr.Data.Context
{
    public class CleanerrContext : DbContext
    {
        public CleanerrContext(DbContextOptions<CleanerrContext> options)
            : base(options)
        {
        }

        public DbSet<EMail>              EMails              { get; set; }
        public DbSet<EMailMediaItem>     EMailMediaItems     { get; set; }
        public DbSet<EMailRespond>       EMailResponds       { get; set; }
        public DbSet<EMailUser>          EMailUsers          { get; set; }
        public DbSet<HistoryProvider>    HistoryProviders    { get; set; }
        public DbSet<MediaItem>          MediaItems          { get; set; }
        public DbSet<MediaProvider>      MediaProviders      { get; set; }
        public DbSet<RemovalSetting>     RemovalSettings     { get; set; }
        public DbSet<RemovalSettingUser> RemovalSettingUsers { get; set; }
        public DbSet<Request>            Requests            { get; set; }
        public DbSet<RequestProvider>    RequestProviders    { get; set; }
        public DbSet<Season>             Seasons             { get; set; }
        public DbSet<Series>             Series              { get; set; }
        public DbSet<User>               Users               { get; set; }
        public DbSet<WatchHistory>       WatchHistories      { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
               .UseSqlite(@"Data Source=Cleanerr.db;");
        }
    }
}
