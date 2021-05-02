
namespace Cleanarr.PluginBase.Models.RequestProvider
{
    public sealed class Request
    {
        public int RequestId { get; set; }
        public int UserId { get; set; }
        public int MediaItemId { get; set; }
        public string RequestedAt { get; set; }
    }
}
