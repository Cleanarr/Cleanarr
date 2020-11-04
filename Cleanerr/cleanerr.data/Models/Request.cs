namespace cleanerr.data.Models
{
    public class Request
    {
        public int    RequestId         { get; set; }
        public int    RequestProviderId { get; set; }
        public int    UserId            { get; set; }
        public int    MediaItemId       { get; set; }
        public string RequestedAt       { get; set; }

        public RequestProvider RequestProvider { get; set; }
        public User            User            { get; set; }
        public MediaItem       MediaItem       { get; set; }
    }
}
