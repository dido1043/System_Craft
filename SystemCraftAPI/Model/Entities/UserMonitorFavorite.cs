namespace SystemCraftAPI.Model.Entities
{
    public class UserMonitorFavorite
    {
        public int UserId { get; set; }
        public User User { get; set; } = null!;

        public int MonitorId { get; set; }
        public Monitor Monitor { get; set; } = null!;
    }
}
