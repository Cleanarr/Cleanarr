using System.Collections.Generic;

namespace cleanerr.data.Models
{
    public class User
    {
        public int    UserId          { get; set; }
        public string Name            { get; set; }
        public int    MediaProviderId { get; set; }

        public MediaProvider                   MediaProvider       { get; set; }
        public ICollection<WatchHistory>       WatchHistories      { get; set; }
        public ICollection<Request>            Requests            { get; set; }
        public ICollection<RemovalSettingUser> RemovalSettingUsers { get; set; }
        public ICollection<EMailUser>          EMailUsers          { get; set; }
    }
}
