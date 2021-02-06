namespace Cleanarr.Data.Models
{
    public class EMailRespond
    {
        public int    EMailRespondId   { get; set; }
        public int    EMailId          { get; set; }
        public int    EMailUserId      { get; set; }
        public int    EMailMediaItemId { get; set; }
        public string RespondedAt      { get; set; }
        public bool   KeepFile         { get; set; }

        public EMail          EMail          { get; set; }
        public EMailUser      EMailUser      { get; set; }
        public EMailMediaItem EMailMediaItem { get; set; }
    }
}
