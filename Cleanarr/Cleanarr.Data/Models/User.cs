using System.Collections.Generic;

namespace Cleanarr.Data.Models
{
    public class User
    {
        public int    UserId          { get; set; }
        public string Name            { get; set; }
        public string EMailAddress     { get; set; }
        public int    MediaProviderId { get; set; }

        public MediaProvider                   MediaProvider       { get; set; }
        public ICollection<WatchHistory>       WatchHistories      { get; set; }
        public ICollection<Request>            Requests            { get; set; }
        public ICollection<RemovalSettingUser> RemovalSettingUsers { get; set; }
        public ICollection<EMailUser>          EMailUsers          { get; set; }
    }
}
