using System.Collections.Generic;

namespace Cleanarr.Data.Models
{
    public class EMail
    {
        public int    EMailId { get; set; }
        public string SendAt  { get; set; }

        public ICollection<EMailMediaItem> EMailMediaItems { get; set; }
        public ICollection<EMailUser>      EMailUsers      { get; set; }
        public ICollection<EMailRespond>   EMailResponds   { get; set; }
    }
}
