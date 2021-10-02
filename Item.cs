using System;

namespace GildedRose
{
    public class Item
    {
        public string Name { get; set; }
        public int SellIn { get; set; }
        public Quality Quality { get; set; }

        public Item(int sellIn, int quality)
        {
            SellIn = sellIn;
            Quality = new Quality(quality);
        }

        public override string ToString()
        {
            return this.Name + ", " + this.SellIn + ", " + this.Quality;
        }

        internal virtual void UpdateSellIn()
        {
            SellIn -= 1;
        }

        internal virtual void UpdateQuality()
        {
              
        }
    }
}
