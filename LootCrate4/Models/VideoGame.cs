namespace LootCrate4.Models
{
    public class VideoGame : CrateItem
    {
        public new int ID { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string superHeroName { get; set; }
    }
}