namespace GW2Wrapper.Models.Account
{
    public class Account
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int World { get; set; }
        public string[] Guilds { get; set; }
        public string GuildLeader { get; set; }
        public string Created { get; set; }
        public string[] Access { get; set; }
        public bool Commander { get; set; }
        public int FractalLever { get; set; }
        public int DailyAp { get; set; }
        public int MonthlyAp { get; set; }
        public int WvWRank { get; set; }
    }
}