using System;

namespace GildedRose
{
    public class ItemSulfuras : Item
    {
        public ItemSulfuras(int sellIn, int quality) : base(sellIn, quality)
        {
            Name = "Sulfuras, Hand of Ragnaros";
        }

        internal override void UpdateSellIn()
        {
          
        }

        internal override void UpdateQuality()
        {
            Quality.Quality_Plus();
        }
    }
}
