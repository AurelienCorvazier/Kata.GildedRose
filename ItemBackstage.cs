using System;

namespace GildedRose
{
    public class ItemBackstage : Item
    {
        public ItemBackstage(int sellIn, int quality) : base(sellIn, quality)
        {
            Name = "Backstage passes to a TAFKAL80ETC concert";
        }
        internal override void UpdateQuality()
        {
            Quality.Quality_Plus();
             
            if (SellIn < 10)
                Quality.Quality_Plus();

            if (SellIn < 5)
                Quality.Quality_Plus();

            if (SellIn < 0)
                Quality.Zero();
        }
    }
}
