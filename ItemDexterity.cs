using System;

namespace GildedRose
{
    public class ItemDexterity : Item
    {
        public ItemDexterity(int sellIn, int quality) : base(sellIn, quality)
        {
            Name = "+5 Dexterity Vest";
        }
        internal override void UpdateQuality()
        {
            Quality.Quality_Minus();

            if (SellIn < 0)
                Quality.Quality_Minus();
        }
    }
}
