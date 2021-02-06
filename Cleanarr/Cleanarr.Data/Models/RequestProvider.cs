using System.Collections.Generic;

namespace Cleanarr.Data.Models
{
    public class RequestProvider
    {
        public int    RequestProviderId { get; set; }
        public string Name              { get; set; }
        public string PluginFile        { get; set; }

        public ICollection<Request> Requests { get; set; }
    }
}
