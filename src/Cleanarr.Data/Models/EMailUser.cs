using System.Collections.Generic;

namespace Cleanarr.Data.Models
{
    public class EMailUser
    {
        public int EMailUserId { get; set; }
        public int EMailId     { get; set; }
        public int UserId      { get; set; }

        public EMail                     EMail         { get; set; }
        public User                      User          { get; set; }
        public ICollection<EMailRespond> EMailResponds { get; set; }
    }
}
