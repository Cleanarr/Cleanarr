namespace Cleanarr.Data.Models
{
    public class RemovalSettingUser
    {
        public int RemovalSettingUserId { get; set; }
        public int UserId               { get; set; }
        public int RemovalSettingId     { get; set; }

        public RemovalSetting RemovalSetting { get; set; }
        public User           User           { get; set; }
    }
}
