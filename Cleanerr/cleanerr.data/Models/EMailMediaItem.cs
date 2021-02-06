using System.Collections.Generic;

namespace cleanerr.Data.Models
{
    public class EMailMediaItem
    {
        public int EMailMediaItemId { get; set; }
        public int EMailId          { get; set; }
        public int MediaItemId      { get; set; }

        public EMail                     EMail         { get; set; }
        public MediaItem                 MediaItem     { get; set; }
        public ICollection<EMailRespond> EMailResponds { get; set; }
    }
}
