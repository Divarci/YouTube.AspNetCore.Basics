namespace ApiConsumer.Models
{
    public class GuildWarsItems
    {
        public int id { get; set; }
        public string chat_link { get; set; }
        public string name { get; set; }
        public string? icon { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public string rarity { get; set; }
        public int level { get; set; }
        public int vendor_value { get; set; }
        public int? default_skin { get; set; }
        public string[] flags { get; set; }
        public string[] game_types { get; set; }
        public string[] restrictions { get; set; }
        public UpgradeIntro[]? upgrades_into { get; set; }
        public UpgradeFrom[]? upgrades_from { get; set; }
        public object? details { get; set; }

    }


    public class UpgradeIntro: UpgradeInfo
    {
      
    }

    public class UpgradeFrom : UpgradeInfo
    {
       
    }

    public class UpgradeInfo
    {
        public string upgrade { get; set; }
        public int item_id { get; set; }
    }
}
