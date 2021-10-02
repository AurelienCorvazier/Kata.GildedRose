namespace GildedRose
{
    public class ItemConjuredManaCake : Item
    {
        public ItemConjuredManaCake(int sellIn, int quality) : base(sellIn, quality)
        {
            Name = "Conjured Mana Cake";
        } 

        internal override void UpdateQuality()
        {
            Quality.Quality_Minus();

            if (SellIn < 0)
                Quality.Quality_Minus();
        }
    }
}