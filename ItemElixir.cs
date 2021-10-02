namespace GildedRose
{
    public class ItemElixir : Item
    {
        public ItemElixir(int sellIn, int quality) : base(sellIn, quality)
        {
            Name = "Elixir of the Mongoose";
        }
        internal override void UpdateQuality()
        {
            Quality.Quality_Minus();

            if (SellIn < 0)
                Quality.Quality_Minus();
        }
    } 
    
}