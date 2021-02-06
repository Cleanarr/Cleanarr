using System.Collections.Generic;

namespace Cleanarr.Data.Models
{
    public class RemovalSetting
    {
        public int  RemovalSettingId              { get; set; }
        public int  MediaItemId                   { get; set; }
        public bool AllUsersWatched               { get; set; }
        public int  AllUserWatchedTimeOut         { get; set; }
        public bool AllRequesterWatched           { get; set; }
        public int  AllRequesterWatchedTimeOut    { get; set; }
        public bool AllUsersPartialWatched        { get; set; }
        public int  AllUsersPartialWatchedTimeOut { get; set; }
        public bool SendEmail                     { get; set; }
        public int  EmailTimeOut                  { get; set; }
        public int  EmailTimeToAdd                { get; set; }

        public MediaItem                       MediaItem           { get; set; }
        public ICollection<RemovalSettingUser> RemovalSettingUsers { get; set; }
    }
}
