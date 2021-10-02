namespace GildedRose
{
    public class ItemAgedBrie : Item
    {
        public ItemAgedBrie(int sellIn, int quality) : base(sellIn, quality)
        {
            Name = "Aged Brie";
        }

        internal override void UpdateQuality()
        {
            Quality.Quality_Plus();
                  
            if (SellIn < 0)
                Quality.Quality_Plus();
        }
    }
}